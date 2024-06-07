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
    public partial class AddMed : Form
    {
        public MedicineStock TheMed;
        public AddMed(MedicineStock m)
        {
            TheMed = m;
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
            TheMed.Name = tbName.Text.Trim();
            TheMed.Quantity = int.Parse(tbQuantity.Text.Trim());
            TheMed.IsSubstitutable = chbIsSubstitutable.Checked;
            TheMed.Price = double.Parse(tbPrice.Text.Trim());
            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddMed_Load(object sender, EventArgs e)
        {
            if (TheMed != null)
            {
                tbName.Text = TheMed.Name;
                tbQuantity.Text = TheMed.Quantity.ToString();
                chbIsSubstitutable.Checked = TheMed.IsSubstitutable;
                tbPrice.Text = TheMed.Price.ToString("0.00");
            }
        }

        private void tbUniversity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
