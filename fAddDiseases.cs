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
    public partial class fAddDiseases : Form
    {
        public Diseases TheDiseases;
        public fAddDiseases(Diseases d)
        {
            TheDiseases = d;
            InitializeComponent();
        }

        private void btnCansle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCansle_MouseEnter(object sender, EventArgs e)
        {
            btnCansle.BackColor = Color.SteelBlue;
        }

        private void btnCansle_MouseLeave(object sender, EventArgs e)
        {
            btnCansle.BackColor= Color.Cyan;
        }
        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.Cyan;
        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.SteelBlue;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            TheDiseases.Name = tbName.Text.Trim();
            TheDiseases.Symptoms = tbSymptoms.Text.Trim();
            TheDiseases.Procedures = tbProcedures.Text.Trim();
            TheDiseases.RecommendedMedicines = tbRecommendedMedicines.Text.Trim();
            TheDiseases.Quantity = int.Parse(tbQuantity.Text.Trim());
            TheDiseases.Dot = int.Parse(tbDot.Text.Trim());
            TheDiseases.SeverityLevel = int.Parse(tbSeverityLevel.Text.Trim());
            TheDiseases.MortalityRate = double.Parse(tbMortalityRate.Text.Trim());
            TheDiseases.IsContagious = chbIsContagious.Checked;

            DialogResult = DialogResult.OK;
        }
        private void fAddDiseases_Load(object sender, EventArgs e)
        {
            if (TheDiseases != null)
            {
                tbName.Text = TheDiseases.Name;
                tbSymptoms.Text = TheDiseases.Symptoms;
                tbProcedures.Text = TheDiseases.Procedures;
                tbRecommendedMedicines.Text = TheDiseases.RecommendedMedicines;
                tbQuantity.Text = TheDiseases.Quantity.ToString();
                tbDot.Text = TheDiseases.Dot.ToString("0.0");
                tbSeverityLevel.Text = TheDiseases.SeverityLevel.ToString("0.00");
                tbMortalityRate.Text = TheDiseases.MortalityRate.ToString();
                chbIsContagious.Checked = TheDiseases.IsContagious;
            }
        }
    }
}
