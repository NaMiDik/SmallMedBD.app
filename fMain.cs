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
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvStudents.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Symptoms";
            column.Name = "Симптоми";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Procedures";
            column.Name = "Процедури";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Вік";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Semester";
            column.Name = "Семестер";
            gvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Scholarship";
            column.Name = "Стипендія";
            column.Width = 100;
            gvStudents.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasHostel";
            column.Name = "Гуртожитoк";
            column.Width = 80;
            gvStudents.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasScholarship";
            column.Name = "Стипендія";
            column.Width = 80;
            gvStudents.Columns.Add(column);

            bindSrcStudents.Add(new Disease("Грип", "Симптоми грипу", "Процедури для грипу", 18, 2, 0, true, false));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Disease disease = new Disease();

             AddDisease ad = new AddDisease(disease);
            if (ad.ShowDialog() == DialogResult.OK)
            {
                bindSrcStudents.Add(disease);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Disease disease = (Disease)bindSrcStudents.List[bindSrcStudents.Position];

            AddDisease fs = new AddDisease(disease);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcStudents.List[bindSrcStudents.Position] = disease;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcStudents.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі данні будуть втрачені", "Очищеня данних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcStudents.Clear();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
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
                    foreach (Disease disease in bindSrcStudents.List)
                    {
                        sw.Write(disease.Name + "\t" + disease.Symptoms + "\t" +
                        disease.Procedures + "\t" + disease.Age + "\t" + disease.Semester +
                        "\t" + disease.Scholarship + "\t" + disease.HasHostel + "\t" +
                        disease.HasScholarship + "\t\n");
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
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.students)|*.students|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (Disease disease in bindSrcStudents.List)
                    {
                        bw.Write(disease.Name);
                        bw.Write(disease.Symptoms);
                        bw.Write(disease.Procedures);
                        bw.Write(disease.Age);
                        bw.Write(disease.Semester);
                        bw.Write(disease.Scholarship);
                        bw.Write(disease.HasHostel);
                        bw.Write(disease.HasScholarship);
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "";
            openFileDialog.Title = "";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcStudents.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Disease disease = new Disease(split[0], split[1], split[2],
                        int.Parse(split[3]), double.Parse(split[4]), double.Parse(split[5]),
                        bool.Parse(split[6]), bool.Parse(split[7]));
                        bindSrcStudents.Add(disease);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(": \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { sr.Close(); }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "";
            openFileDialog.Title = "";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcStudents.Clear();
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
                                    disease.Age = br.ReadInt32();
                                    break;
                                case 5:
                                    disease.Semester = br.ReadDouble();
                                    break;
                                case 6:
                                    disease.Scholarship = br.ReadDouble();
                                    break;
                                case 7:
                                    disease.HasHostel = br.ReadBoolean();
                                    break;
                                case 8:
                                    disease.HasScholarship = br.ReadBoolean();
                                    break;

                            }
                        }
                        bindSrcStudents.Add(disease);
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
    }
}
