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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheDisease.Name = tbName.Text.Trim();
            TheDisease.Symptoms = tbSymptoms.Text.Trim();
            TheDisease.Procedures = tbProcedures.Text.Trim();
            TheDisease.Age = int.Parse(tbAge.Text.Trim());
            TheDisease.Semester = double.Parse(tbSemester.Text.Trim());
            TheDisease.Scholarship = double.Parse(tbScholarship.Text.Trim());
            TheDisease.HasHostel = chbHasHostel.Checked;
            TheDisease.HasScholarship = chbHasScholarship.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fStudent_Load(object sender, EventArgs e)
        {
            if (TheDisease != null)
            {
                tbName.Text = TheDisease.Name;
                tbSymptoms.Text = TheDisease.Symptoms;
                tbProcedures.Text = TheDisease.Procedures;
                tbAge.Text = TheDisease.Age.ToString();
                tbSemester.Text = TheDisease.Semester.ToString("0.00");
                tbScholarship.Text = TheDisease.Scholarship.ToString("0.000");
                chbHasHostel.Checked = TheDisease.HasHostel;
                chbHasScholarship.Checked = TheDisease.HasScholarship;
            }
        }

        private void tbUniversity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
