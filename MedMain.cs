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
using System.Linq.Expressions;
    
namespace Курсач
{
    public partial class MedMain : Form
    {
        private List<MedicineStock> stockMedicineStocksList;
        public List<MedicineStock> medicinestocksList = new List<MedicineStock>();
        public MedMain()
        {
            InitializeComponent();
        }
        private void CancelAll()
        {
            if (bindSrcMed.List != null && stockMedicineStocksList != null)
            {
                bindSrcMed.Clear();
                foreach (MedicineStock med in stockMedicineStocksList)
                {
                    bindSrcMed.Add(med);
                }
                AutoSaveData();
            }
        }
        private void AutoSaveData()
        {
            StreamWriter sw = new StreamWriter("AutoSaveMed.txt", false, Encoding.UTF8);
            try
            {
                if (bindSrcMed.List != null && medicinestocksList != null)
                {
                    foreach (MedicineStock med in bindSrcMed.List)
                    {
                        sw.Write(med.Name + "\t" + med.Quantity + "\t" + med.IsSubstitutable + "\t" + med.Price +"\t\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            finally
            {
                sw.Close();
            }
        }
        private void MedMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void MedMain_Load(object sender, EventArgs e)
        {
            gvMed.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            column.Width = 130;
            gvMed.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "Кількість";
            gvMed.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна (грн)";
            column.Width = 100;
            gvMed.Columns.Add(column);


            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "IsSubstitutable";
            column.Name = "Взаємозамінна";
            column.Width = 120;
            gvMed.Columns.Add(column);

            bindSrcMed.Clear();
            gvMed.DataSource = bindSrcMed;
            stockMedicineStocksList = new List<MedicineStock>();

            FileStream fs = new FileStream("AutoSaveMed.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string text;
            try
            {
                while ((text = sr.ReadLine()) != null)
                {
                    string[] split = text.Split('\t');
                    MedicineStock med = new MedicineStock(split[0],
                    int.Parse(split[1]), bool.Parse(split[2]), double.Parse(split[3]));
                    bindSrcMed.Add(med);
                    stockMedicineStocksList.Add(med);
                }
                medicinestocksList = stockMedicineStocksList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Сталась помилка: \n{0}", ex.Message), "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedicineStock med = new MedicineStock();

             AddMed ad = new AddMed(med);
            if (ad.ShowDialog() == DialogResult.OK)
            {
                bindSrcMed.Add(med);
            }
            AutoSaveData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MedicineStock med = (MedicineStock)bindSrcMed.List[bindSrcMed.Position];

            AddMed fs = new AddMed(med);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcMed.List[bindSrcMed.Position] = med;
            }
            AutoSaveData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcMed.RemoveCurrent();
            }
            AutoSaveData() ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі данні будуть втрачені", "Очищеня данних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcMed.Clear();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            AutoSaveData();
        }
        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (MedicineStock med in bindSrcMed.List)
                    {
                        sw.Write(med.Name + "\t" + med.Quantity + "\t" +
                        med.Price + "\t" + med.IsSubstitutable + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
                AutoSaveData();
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.med)|*.med|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (MedicineStock med in bindSrcMed.List)
                    {
                        bw.Write(med.Name);
                        bw.Write(med.Quantity);
                        bw.Write(med.Price);
                        bw.Write(med.IsSubstitutable);
                    }
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                { 
                    bw.Close(); 
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            stockMedicineStocksList = new List<MedicineStock>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматi";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcMed.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        MedicineStock med = new MedicineStock(split[0], int.Parse(split[1]), bool.Parse(split[3]), double.Parse(split[2]));
                        bindSrcMed.Add(med);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(": \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { sr.Close(); }
            }
            AutoSaveData();
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            stockMedicineStocksList = new List<MedicineStock>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.med)|*.med|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcMed.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    MedicineStock med; while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        med = new MedicineStock();
                        for (int i = 1; i <= 8; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    med.Name = br.ReadString();
                                    break;
                                case 2:
                                    med.Quantity = br.ReadInt32();
                                    break;
                                case 3:
                                    med.Price = br.ReadDouble();
                                    break;
                                case 4:
                                    med.IsSubstitutable = br.ReadBoolean();
                                    break;
                            }
                        }
                        bindSrcMed.Add(med);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(": \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { br.Close(); }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchKey = cb_Search.SelectedIndex;
            string text = tbSearch.Text.Trim();
            MIActions_Table MedMainAct = new Med_Actions();
            medicinestocksList.Clear();
            foreach (MedicineStock med in bindSrcMed.List)
            {
                medicinestocksList.Add(med);
            }
            medicinestocksList = MedMainAct.Search(medicinestocksList, cb_Search.SelectedIndex, tbSearch.Text.Trim());
            bindSrcMed.Clear();
            foreach (MedicineStock med in medicinestocksList)
            {
                bindSrcMed.Add(med);
            }
            if (medicinestocksList.Count == 0)
            {
                MessageBox.Show("Збігів не знайдено.", "Пошукові результати", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            AutoSaveData();
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            CancelAll();
            tbSearch.Clear();
            cb_Search.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MIActions_Table MedMainAct = new Med_Actions();
            medicinestocksList.Clear();
            foreach (MedicineStock med in bindSrcMed.List)
            {
                medicinestocksList.Add(med);
            }
            medicinestocksList = MedMainAct.Sort(medicinestocksList, cbSort.SelectedIndex);
            bindSrcMed.Clear();
            foreach (MedicineStock med in medicinestocksList)
            {
                bindSrcMed.Add(med);
            }
            if (medicinestocksList.Count == 0)
            {
                MessageBox.Show("Сортування неможливе.", "Результат сортування", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            AutoSaveData();
        }

        private void btnCanselSort_Click(object sender, EventArgs e)
        {
            CancelAll();
            cbSort.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MIActions_Table fMainAct = new Med_Actions();
            medicinestocksList.Clear();
            foreach (MedicineStock med in bindSrcMed.List)
            {
                medicinestocksList.Add(med);
            }
            medicinestocksList = fMainAct.Filter(medicinestocksList, cbFilter.SelectedIndex, int.Parse(tbFilter.Text));
            bindSrcMed.Clear();
            foreach (MedicineStock med in medicinestocksList)
            {
                bindSrcMed.Add(med);
            }
            if (medicinestocksList.Count == 0)
            {
                MessageBox.Show("Дані відсутні.", "Результат фільтрування", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            AutoSaveData();
        }

        private void btnCanselFilter_Click(object sender, EventArgs e)
        {
            CancelAll();
            tbFilter.Clear();
            cbFilter.Text = "";
        }

        private void tbGoDiseaseBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain fmain = new fMain();
            fmain.Show();
            AutoSaveData();
        }
    }
}
