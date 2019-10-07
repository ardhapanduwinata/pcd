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
    public partial class frmLogContrast : Form
    {
        public frmLogContrast()
        {
            InitializeComponent();
        }

        private void tbLogContrast_TextChanged(object sender, EventArgs e)
        {
            if ((tbLogContrast.Text == "") || (tbLogContrast.Text == "-"))
            {
                hscLogContrast.Value = 0;
                tbLogContrast.Text = "0";
            }
            else if ((Convert.ToInt16(tbLogContrast.Text) <= 255) &&
                (Convert.ToInt16(tbLogContrast.Text) >= -255))
            {
                hscLogContrast.Value = Convert.ToInt16(tbLogContrast.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error");
                tbLogContrast.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hscLogContrast_ValueChanged(object sender, EventArgs e)
        {
            tbLogContrast.Text = hscLogContrast.Value.ToString();
        }

        private void frmLogContrast_Load(object sender, EventArgs e)
        {
            tbLogContrast.Text = hscLogContrast.Value.ToString();
        }
    }
}
