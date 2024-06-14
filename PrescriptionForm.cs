using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Курсач
{
    public partial class PrescriptionForm : Form
    {
        private fMain mainForm;
        private List<MedicineStock> medicines;

        public PrescriptionForm(fMain form)
        {
            InitializeComponent();
            mainForm = form;
            LoadDiagnosis();
            LoadMedicines();
        }

        private void LoadDiagnosis()
        {
            comboBoxDiagnosis.Items.Clear();
            foreach (var disease in mainForm.GetDiseases())
            {
                comboBoxDiagnosis.Items.Add(disease.Name);
            }

            // Додаємо обробник події вибору елементу
            comboBoxDiagnosis.SelectedIndexChanged += comboBoxDiagnosis_SelectedIndexChanged;
        }
        private void comboBoxDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMedicines.Items.Clear();
            var selectedDisease = mainForm.GetDiseaseByName(comboBoxDiagnosis.SelectedItem.ToString());
            if (selectedDisease != null)
            {
                var medicines = selectedDisease.RecommendedMedicines.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var medicine in medicines)
                {
                    comboBoxMedicines.Items.Add(medicine);
                }
            }
        }
        private void LoadMedicines()
        {
            medicines = new List<MedicineStock>();
            // Завантаження даних медикаментів з файлу AutoSaveMed
            var lines = File.ReadAllLines("AutoSaveMed.txt");
            foreach (var line in lines)
            {
                var parts = line.Split('\t');
                if (parts.Length >= 2)
                {
                    medicines.Add(new MedicineStock { Name = parts[0], Quantity = int.Parse(parts[1]) });
                }
            }
        }

        private void btnSaveP_Click(object sender, EventArgs e)
        {
            // Перевірка на наявність вибраних елементів у комбо-боксах
            if (string.IsNullOrWhiteSpace(textBoxPatientName.Text) || comboBoxDiagnosis.SelectedItem == null || comboBoxMedicines.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть пацієнта, діагноз та ліки перед збереженням.");
                return;
            }
            // Збереження даних у текстовий файл
            string patientName = textBoxPatientName.Text;
            string diagnosis = comboBoxDiagnosis.SelectedItem?.ToString(); // Додано "?" для перевірки на null
            string medicine = comboBoxMedicines.SelectedItem?.ToString(); // Використовуємо змінну, яка вже перевірена на null

            string prescription = $"Пацієнт: {patientName}\nДіагноз: {diagnosis}\nЛіки: {medicine}\n";

            try
            {
                File.WriteAllText("prescription.txt", prescription);
                MessageBox.Show("Рецепт збережено!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при збереженні: {ex.Message}");
            }
        }

        private void btnCheckMedicine_Click(object sender, EventArgs e)
        {
            var medicineName = textBoxMedicineName.Text;
            if (string.IsNullOrWhiteSpace(medicineName))
            {
                MessageBox.Show("Будь ласка, введіть назву медикаменту.");
                return;
            }

            var medicine = medicines.FirstOrDefault(m => m.Name.Equals(medicineName, StringComparison.OrdinalIgnoreCase));
            if (medicine == null || medicine.Quantity <= 0)
            {
                MessageBox.Show("Обраного медикаменту немає в наявності або його кількість = 0");
            }
            else
            {
                MessageBox.Show($"Медикамент {medicineName} є в наявності. Кількість: {medicine.Quantity}");
            }
        }
    }
}
