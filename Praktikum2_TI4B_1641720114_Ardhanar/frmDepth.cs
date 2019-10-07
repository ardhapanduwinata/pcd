using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum2_TI4B_1641720114_Ardhanar
{
    public partial class frmDepth : Form
    {
        public frmDepth()
        {
            InitializeComponent();
        }

        private void hscDepth_ValueChanged(object sender, EventArgs e)
        {
            tbDepth.Text = hscDepth.Value.ToString();
        }

        private void tbDepth_TextChanged(object sender, EventArgs e)
        {
            if ((tbDepth.Text == "") || (tbDepth.Text == "-"))
            {
                hscDepth.Value = 0;
                tbDepth.Text = "0";
            }
            else if ((Convert.ToInt16(tbDepth.Text) <= 7) && (Convert.ToInt16(tbDepth.Text) >= 0))
            {
                hscDepth.Value = Convert.ToInt16(tbDepth.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error");
                tbDepth.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepth_Load(object sender, EventArgs e)
        {

        }
    }
}
