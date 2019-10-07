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
    public partial class frmInverse : Form
    {
        public frmInverse()
        {
            InitializeComponent();
        }

        private void tbInverse_TextChanged(object sender, EventArgs e)
        {
            if((tbInverse.Text == "") || (tbInverse.Text == "-"))
            {
                hscInverse.Value = 0;
                tbInverse.Text = "0";
            }
            else if((Convert.ToInt16(tbInverse.Text) <= 255) && 
                (Convert.ToInt16(tbInverse.Text) >= -255))
            {
                hscInverse.Value = Convert.ToInt16(tbInverse.Text);
            }
            else
            {
                MessageBox.Show("Input nilai Error");
                tbInverse.Text = "0";
            }
        }

        private void frmInverse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInverse_Load(object sender, EventArgs e)
        {
            tbInverse.Text = hscInverse.Value.ToString();
        }

        private void hscInverse_ValueChanged(object sender, EventArgs e)
        {
            tbInverse.Text = hscInverse.Value.ToString();
        }
    }
}
