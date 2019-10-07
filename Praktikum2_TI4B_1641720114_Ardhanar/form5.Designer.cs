namespace Praktikum2_TI4B_1641720114_Ardhanar
{
    partial class Form5
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
            this.hscGamma = new System.Windows.Forms.HScrollBar();
            this.tbOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbGamma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hscGamma
            // 
            this.hscGamma.Location = new System.Drawing.Point(29, 41);
            this.hscGamma.Maximum = 800;
            this.hscGamma.Name = "hscGamma";
            this.hscGamma.Size = new System.Drawing.Size(619, 26);
            this.hscGamma.TabIndex = 0;
            this.hscGamma.ValueChanged += new System.EventHandler(this.hscGamma_ValueChanged);
            // 
            // tbOK
            // 
            this.tbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbOK.Location = new System.Drawing.Point(288, 93);
            this.tbOK.Name = "tbOK";
            this.tbOK.Size = new System.Drawing.Size(75, 30);
            this.tbOK.TabIndex = 1;
            this.tbOK.Text = "OK";
            this.tbOK.UseVisualStyleBackColor = true;
            this.tbOK.Click += new System.EventHandler(this.tbOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(674, 41);
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(100, 26);
            this.tbGamma.TabIndex = 3;
            this.tbGamma.Text = "0";
            this.tbGamma.TextChanged += new System.EventHandler(this.tbGamma_TextChanged);
            // 
            // frmGamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 159);
            this.Controls.Add(this.tbGamma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbOK);
            this.Controls.Add(this.hscGamma);
            this.Name = "frmGamma";
            this.Text = "frmGamma";
            this.Load += new System.EventHandler(this.frmGamma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.HScrollBar hscGamma;
        private System.Windows.Forms.Button tbOK;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox tbGamma;
    }
}