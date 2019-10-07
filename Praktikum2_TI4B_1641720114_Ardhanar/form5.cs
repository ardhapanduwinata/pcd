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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void hscGamma_ValueChanged(object sender, EventArgs e)
        {
            tbGamma.Text = Convert.ToString(hscGamma.Value);
        }

        private void tbGamma_TextChanged(object sender, EventArgs e)
        {
            if ((tbGamma.Text == "") || (tbGamma.Text == "-"))
            {
                hscGamma.Value = 0;
                tbGamma.Text = "0";
            }
            else if (Convert.ToInt16(tbGamma.Text) <= 800 && (Convert.ToInt16(tbGamma.Text) >= 0))
            {
                hscGamma.Value = Convert.ToInt16(tbGamma.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error"); tbGamma.Text = "0";
            }
        }

        private void tbOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGamma_Load(object sender, EventArgs e)
        {
            tbGamma.Text = hscGamma.Value.ToString();
        }
    }
}
