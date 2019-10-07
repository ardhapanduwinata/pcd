using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Praktikum2_TI4B_1641720114_Ardhanar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            
            if (DialogResult.OK == bukaFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(bukaFile.FileName);
                string path = bukaFile.FileName;
                string name = Path.GetFileName(path);
                fileLocation.Text = "Path : " + bukaFile.FileName;
                fileSize.Text = "Res. Citra : " + pbInput.Image.Height + " x " + pbInput.Image.Width;

            }
        }

        private void simpanSebagaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan disimpan");
            }
            else
            {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan File Citra";
                simpanFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == simpanFile.ShowDialog())
                    this.pbOutput.Image.Save(simpanFile.FileName);
            }

        }

        private void keluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                frmBrightness frm2 = new frmBrightness();
                if(frm2.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    int nilaiBrightness = Convert.ToInt16(frm2.tbBrightness.Text);
                    ProgressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            int ergebeB = (Convert.ToInt16(frm2.tbBrightness.Text));
                            int ergebeC = (Convert.ToInt16(frm2.tbContrast.Text));

                            double rgb = c1.R + c1.G + c1.B;
                            double rgb1 = (259 * (ergebeC + 255)) / (255 * (259 - ergebeC));

                            double red = 0;
                            double green = 0;
                            double blue = 0;

                            if (ergebeC != 0)
                            {
                                red = (rgb1 * (c1.R - 128)) + 128;
                                green = (rgb1 * (c1.G - 128)) + 128;
                                blue = (rgb1 * (c1.B - 128)) + 128;

                            }
                            else
                            {
                                red = 0;
                                green = 0;
                                blue = 0;
                            }

                            int r1 = c1.R + (ergebeB / 3) + (Convert.ToInt16(red));
                            int g1 = c1.G + (ergebeB / 3) + (Convert.ToInt16(green));
                            int b1 = c1.B + (ergebeB / 3) + (Convert.ToInt16(blue));

                            if (r1 > 255)
                            {
                                r1 = 255;
                            }
                            else if (r1 < 0)
                            {
                                r1 = 0;
                            }

                            if (g1 > 255)
                            {
                                g1 = 255;
                            }
                            else if (g1 < 0)
                            {
                                g1 = 0;
                            }

                            if (b1 > 255)
                            {
                                b1 = 255;
                            }
                            else if (b1 < 0)
                            {
                                b1 = 0;
                            }

                            b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                        }
                        ProgressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);

                    }
                    ProgressBar1.Visible = true;
                    this.pbOutput.Image = b;
                }
            }
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                frmInverse frm3 = new frmInverse();
                if (frm3.ShowDialog() == DialogResult.OK)
                {
                    if (pbInput.Image == null)
                    {
                        MessageBox.Show("Tidak Ada citra yang akan diolah");
                    }
                    else
                    {
                        int inverse = (Convert.ToInt16(frm3.tbInverse.Text));
                        Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                        ProgressBar1.Visible = true;
                        for (int i = 0; i < b.Width; i++)
                        {
                            for (int j = 0; j < b.Height; j++)
                            {
                                Color c1 = b.GetPixel(i, j);
                                int xg = (int)((c1.R + c1.G + c1.B) / 3);
                                int xi = 255 - xg;

                                Color new_w = Color.FromArgb(xi, xi, xi);
                                b.SetPixel(i, j, new_w);
                            }
                            ProgressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                        }
                        ProgressBar1.Visible = false;
                        this.pbOutput.Image = b;
                    }
                }
            }
        }

        private void logContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan diolah");
            }
            else
            {
                frmLogContrast frm3 = new frmLogContrast();
                if (frm3.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    double nilaiBrightness = Convert.ToDouble(frm3.tbLogContrast.Text);
                    ProgressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);

                            double r0 = c1.R + c1.G + c1.B;

                            double logBInput = Convert.ToInt16(frm3.tbLogContrast.Text);
                            double c = 0;

                            double r1 = 0;
                            double g1 = 0;
                            double b1 = 0;

                            if (logBInput != 0)
                            {
                                c = 255 / (Math.Log(1 + Math.Abs(logBInput)));

                                r1 = c * Math.Log10(1 + Math.Abs(c1.R));
                                g1 = c * Math.Log10(1 + Math.Abs(c1.G));
                                b1 = c * Math.Log10(1 + Math.Abs(c1.B));

                                if (r1 > 255)
                                {
                                    r1 = 255;
                                }
                                else if (r1 < 0)
                                {
                                    r1 = 0;
                                }

                                if (g1 > 255)
                                {
                                    g1 = 255;
                                }
                                else if (g1 < 0)
                                {
                                    g1 = 0;
                                }

                                if (b1 > 255)
                                {
                                    b1 = 255;
                                }
                                else if (b1 < 0)
                                {
                                    b1 = 0;
                                }

                                b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                            }
                            else
                            {
                                r1 = c1.R;
                                g1 = c1.G;
                                b1 = c1.B;
                            }

                        }
                        ProgressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }
                    ProgressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan diolah");
            }
            else
            {
                frmGamma frm5 = new frmGamma();
                if (frm5.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                    double nilaiGamma = Convert.ToDouble(frm5.tbGamma.Text) * (double)0.01;
                    double gammaCorrection = 1 / nilaiGamma;
                    ProgressBar1.Visible = true;

                    int r1, g1, b1;

                    double merah, hijau, biru;

                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {

                            merah = b.GetPixel(i, j).R;
                            hijau = b.GetPixel(i, j).G;
                            biru = b.GetPixel(i, j).B;

                            r1 = Convert.ToInt32(255 * Math.Pow((double)(merah / (double)255), gammaCorrection));

                            g1 = Convert.ToInt32(255 * Math.Pow((double)(hijau / (double)255), gammaCorrection));

                            b1 = Convert.ToInt32(255 * Math.Pow((double)(biru / (double)255), gammaCorrection));

                            b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                        }
                        ProgressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }
                    ProgressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }
            }
        }

        private void depthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan diolah");
            }
            else
            {
                frmDepth frm6 = new frmDepth();
                if (frm6.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);

                    double bitDepth = Convert.ToDouble(frm6.tbDepth.Text);
                    double level = 255 / (Math.Pow(2, bitDepth) - 1);
                    ProgressBar1.Visible = true;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            double R = Math.Round(c1.R / level) * level;
                            double G = Math.Round(c1.G / level) * level;
                            double B = Math.Round(c1.B / level) * level;
                            int r2 = Convert.ToInt16(R);
                            int g2 = Convert.ToInt16(G);
                            int b2 = Convert.ToInt16(B);
                            b.SetPixel(i, j, Color.FromArgb(r2, g2, b2));
                        }
                        ProgressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                    }
                    ProgressBar1.Visible = false;
                    this.pbOutput.Image = b;
                }

            }
        }
    }
}
