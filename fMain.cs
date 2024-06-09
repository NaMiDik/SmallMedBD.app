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
    public partial class fMain : Form
    {
        private List<Disease> stockDiseasesList;
        public List<Disease> diseasesList = new List<Disease>();
        public fMain()
        {
            InitializeComponent();
        }
        private void CancelAll()
        {
            if (bindSrcDiseases.List != null && stockDiseasesList != null)
            {
                bindSrcDiseases.Clear();
                foreach (Disease book in stockDiseasesList)
                {
                    bindSrcDiseases.Add(book);
                }
                AutoSaveData();
            }
        }
        private void AutoSaveData()
        {
            StreamWriter sw = new StreamWriter("AutoSave.txt", false, Encoding.UTF8);
            try
            {
                if (bindSrcDiseases.List != null && diseasesList != null)
                {
                    foreach (Disease disease in bindSrcDiseases.List)
                    {
                        sw.Write(disease.Name + "\t" + disease.Symptoms + "\t" +disease.Procedures + "\t" + disease.RecommendedMedicines +
                        "\t" + disease.Dot + "\t" + disease.SeverityLevel + "\t" + disease.MortalityRate + "\t" + disease.IsContagious +"\t\n");
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
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvDisease.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Symptoms";
            column.Name = "Симптоми";
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Procedures";
            column.Name = "Процедури";
            column.Width = 150;
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RecommendedMedicines";
            column.Name = "Рекомендовані ліки, к-сть";
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Dot";
            column.Name = "Тривалість лікування (дн)";
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SeverityLevel";
            column.Name = "Рівень тяжкості (1-10)";
            column.Width = 100;
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SeverityIndex";
            column.Name = "Індекс тяжкості";
            column.Width = 100;
            gvDisease.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MortalityRate";
            column.Name = "Смертність %";
            column.Width = 80;
            gvDisease.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "IsContagious";
            column.Name = "Заразна";
            column.Width = 80;
            gvDisease.Columns.Add(column);

            bindSrcDiseases.Clear();
            gvDisease.DataSource = bindSrcDiseases;
            stockDiseasesList = new List<Disease>();

            FileStream fs = new FileStream("AutoSave.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string text;
            try
            {
                while ((text = sr.ReadLine()) != null)
                {
                    string[] split = text.Split('\t');
                    Disease disease = new Disease(split[0], split[1], split[2],
                    split[3], int.Parse(split[4]), int.Parse(split[5]),
                    double.Parse(split[6]), bool.Parse(split[7]));
                    bindSrcDiseases.Add(disease);
                    stockDiseasesList.Add(disease);
                }
                diseasesList = stockDiseasesList;
            }
            catch(Exception ex)
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
            Disease disease = new Disease();

             AddDisease ad = new AddDisease(disease);
            if (ad.ShowDialog() == DialogResult.OK)
            {
                bindSrcDiseases.Add(disease);
            }
            AutoSaveData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Disease disease = (Disease)bindSrcDiseases.List[bindSrcDiseases.Position];

            AddDisease fs = new AddDisease(disease);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcDiseases.List[bindSrcDiseases.Position] = disease;
            }
            AutoSaveData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcDiseases.RemoveCurrent();
            }
            AutoSaveData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі данні будуть втрачені", "Очищеня данних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcDiseases.Clear();
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
                    foreach (Disease disease in bindSrcDiseases.List)
                    {
                        sw.Write(disease.Name + "\t" + disease.Symptoms + "\t" +
                        disease.Procedures + "\t" + disease.RecommendedMedicines + "\t" + disease.Dot +
                        "\t" + disease.SeverityLevel + "\t" + disease.MortalityRate + "\t" +
                        disease.IsContagious + "\t\n");
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
            saveFileDialog.Filter = "Файли даних (*.diseases)|*.diseases|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (Disease disease in bindSrcDiseases.List)
                    {
                        bw.Write(disease.Name);
                        bw.Write(disease.Symptoms);
                        bw.Write(disease.Procedures);
                        bw.Write(disease.RecommendedMedicines);
                        bw.Write(disease.Dot);
                        bw.Write(disease.SeverityLevel);
                        bw.Write(disease.MortalityRate);
                        bw.Write(disease.IsContagious);
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
            stockDiseasesList = new List<Disease>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматi";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcDiseases.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Disease disease = new Disease(split[0], split[1], split[2],
                        split[3], int.Parse(split[4]), int.Parse(split[5]),
                        double.Parse(split[6]), bool.Parse(split[7]));
                        bindSrcDiseases.Add(disease);
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
            stockDiseasesList = new List<Disease>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.diseases)|*.diseases|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcDiseases.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    Disease disease; while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        disease = new Disease();
                        for (int i = 1; i <= 8; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    disease.Name = br.ReadString();
                                    break;
                                case 2:
                                    disease.Symptoms = br.ReadString();
                                    break;
                                case 3:
                                    disease.Procedures = br.ReadString();
                                    break;
                                case 4:
                                    disease.RecommendedMedicines = br.ReadString();
                                    break;
                                case 5:
                                    disease.Dot = br.ReadInt32();
                                    break;
                                case 6:
                                    disease.SeverityLevel = br.ReadInt32();
                                    break;
                                case 7:
                                    disease.MortalityRate = br.ReadDouble();
                                    break;
                                case 8:
                                    disease.IsContagious = br.ReadBoolean();
                                    break;

                            }
                        }
                        bindSrcDiseases.Add(disease);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchKey = cb_Search.SelectedIndex;
            string text = tbSearch.Text.Trim();
            IActions_Table fMainAct = new Disease_Actions();
            diseasesList.Clear();
            foreach (Disease disease in bindSrcDiseases.List)
            {
                diseasesList.Add(disease);
            }
            diseasesList = fMainAct.Search(diseasesList, cb_Search.SelectedIndex, tbSearch.Text.Trim());
            bindSrcDiseases.Clear();
            foreach (Disease disease in diseasesList)
            {
                bindSrcDiseases.Add(disease);
            }
            if (diseasesList.Count == 0)
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
            IActions_Table fMainAct = new Disease_Actions();
            diseasesList.Clear();
            foreach (Disease disease in bindSrcDiseases.List)
            {
                diseasesList.Add(disease);
            }
            diseasesList = fMainAct.Sort(diseasesList, cbSort.SelectedIndex);
            bindSrcDiseases.Clear();
            foreach (Disease disease in diseasesList)
            {
                bindSrcDiseases.Add(disease);
            }
            if (diseasesList.Count == 0)
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
            IActions_Table fMainAct = new Disease_Actions();
            diseasesList.Clear();
            foreach (Disease disease in bindSrcDiseases.List)
            {
                diseasesList.Add(disease);
            }
            diseasesList = fMainAct.Filter(diseasesList, cbFilter.SelectedIndex, int.Parse(tbFilter.Text));
            bindSrcDiseases.Clear();
            foreach (Disease disease in diseasesList)
            {
                bindSrcDiseases.Add(disease);
            }
            if (diseasesList.Count == 0)
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

        private void tbGoMedBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedMain medmain = new MedMain();
            medmain.Show();
            AutoSaveData();
        }
    }
}
