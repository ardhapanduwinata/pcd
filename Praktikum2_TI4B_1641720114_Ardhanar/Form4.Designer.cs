namespace Praktikum2_TI4B_1641720114_Ardhanar
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbLogContrast = new System.Windows.Forms.TextBox();
            this.hscLogContrast = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(616, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLogContrast
            // 
            this.tbLogContrast.Location = new System.Drawing.Point(707, 43);
            this.tbLogContrast.Name = "tbLogContrast";
            this.tbLogContrast.Size = new System.Drawing.Size(63, 26);
            this.tbLogContrast.TabIndex = 1;
            this.tbLogContrast.TextChanged += new System.EventHandler(this.tbLogContrast_TextChanged);
            // 
            // hscLogContrast
            // 
            this.hscLogContrast.Location = new System.Drawing.Point(128, 43);
            this.hscLogContrast.Maximum = 255;
            this.hscLogContrast.Minimum = -255;
            this.hscLogContrast.Name = "hscLogContrast";
            this.hscLogContrast.Size = new System.Drawing.Size(563, 26);
            this.hscLogContrast.TabIndex = 2;
            this.hscLogContrast.ValueChanged += new System.EventHandler(this.hscLogContrast_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log Contrast";
            // 
            // frmLogContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hscLogContrast);
            this.Controls.Add(this.tbLogContrast);
            this.Controls.Add(this.button1);
            this.Name = "frmLogContrast";
            this.Text = "frmLogContrast";
            this.Load += new System.EventHandler(this.frmLogContrast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbLogContrast;
        private System.Windows.Forms.HScrollBar hscLogContrast;
        private System.Windows.Forms.Label label1;
    }
}