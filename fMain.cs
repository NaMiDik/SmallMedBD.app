using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            gvDiseasess.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Symptoms";
            column.Name = "Cимптоми";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Procedures";
            column.Name = "Процедури";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RecommendedMedicines";
            column.Name = "Рекомендовані медикаменти";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "Кількість";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Dot";
            column.Name = "Тривалість лікування(дні)";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SeverityLevel";
            column.Name = "Рівень тяжкості(1-10)";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MortalityRate";
            column.Name = "Cмертність(у відсотках)";
            gvDiseasess.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "IsContagious";
            column.Name = "Чи є заразним";
            column.Width = 60;
            gvDiseasess.Columns.Add(column);


            bindSrcDiseasess.Add(new Diseases("Грип", "Кашель", "Сосаніє члена", "Сперма", 15, 7, 4, 5, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Diseases diseases = new Diseases();

            fAddDiseases ad = new fAddDiseases(diseases);
            if (ad.ShowDialog() == DialogResult.OK) 
            {
                bindSrcDiseasess.Add(diseases);
            }
        }
    }
}
