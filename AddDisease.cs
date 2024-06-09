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
    public partial class AddDisease : Form
    {
        public Disease TheDisease;
        public AddDisease(Disease d)
        {
            TheDisease = d;
        InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            TheDisease.Name = tbName.Text.Trim();
            TheDisease.Symptoms = tbSymptoms.Text.Trim();
            TheDisease.Procedures = tbProcedures.Text.Trim();
            TheDisease.RecommendedMedicines = tbRecommendedMedicines.Text.Trim();
            TheDisease.Dot = int.Parse(tbDot.Text.Trim());
            TheDisease.SeverityLevel = int.Parse(tbSeverityLevel.Text.Trim());
            TheDisease.MortalityRate = double.Parse(tbMortalityRate.Text.Trim());
            TheDisease.IsContagious = chbIsContagious.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddDisease_Load(object sender, EventArgs e)
        {
            if (TheDisease != null)
            {
                tbName.Text = TheDisease.Name;
                tbSymptoms.Text = TheDisease.Symptoms;
                tbProcedures.Text = TheDisease.Procedures;
                tbRecommendedMedicines.Text = TheDisease.RecommendedMedicines;
                tbDot.Text = TheDisease.Dot.ToString();
                tbSeverityLevel.Text = TheDisease.SeverityLevel.ToString();
                tbMortalityRate.Text = TheDisease.MortalityRate.ToString();
                chbIsContagious.Checked = TheDisease.IsContagious;
            }
        }
    }
}
