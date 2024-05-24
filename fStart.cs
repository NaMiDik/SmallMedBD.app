using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class fStart : Form
    {
        public fStart()
        {
            InitializeComponent();
        }
        private void fStart_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain fmain = new fMain();
            fmain.Show();
        }
    }
}
