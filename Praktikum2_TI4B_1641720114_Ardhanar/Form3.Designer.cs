namespace Praktikum2_TI4B_1641720114_Ardhanar
{
    partial class Form3
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
            this.hscInverse = new System.Windows.Forms.HScrollBar();
            this.tbOK = new System.Windows.Forms.Button();
            this.tbInverse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hscInverse
            // 
            this.hscInverse.Location = new System.Drawing.Point(93, 34);
            this.hscInverse.Maximum = 255;
            this.hscInverse.Minimum = -255;
            this.hscInverse.Name = "hscInverse";
            this.hscInverse.Size = new System.Drawing.Size(593, 26);
            this.hscInverse.TabIndex = 0;
            this.hscInverse.ValueChanged += new System.EventHandler(this.hscInverse_ValueChanged);
            // 
            // tbOK
            // 
            this.tbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbOK.Location = new System.Drawing.Point(611, 78);
            this.tbOK.Name = "tbOK";
            this.tbOK.Size = new System.Drawing.Size(75, 31);
            this.tbOK.TabIndex = 1;
            this.tbOK.Text = "OK";
            this.tbOK.UseVisualStyleBackColor = true;
            // 
            // tbInverse
            // 
            this.tbInverse.Location = new System.Drawing.Point(704, 34);
            this.tbInverse.Name = "tbInverse";
            this.tbInverse.Size = new System.Drawing.Size(66, 26);
            this.tbInverse.TabIndex = 2;
            this.tbInverse.TextChanged += new System.EventHandler(this.tbInverse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inverse";
            // 
            // frmInverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInverse);
            this.Controls.Add(this.tbOK);
            this.Controls.Add(this.hscInverse);
            this.Name = "frmInverse";
            this.Text = "frmInverse";
            this.Load += new System.EventHandler(this.frmInverse_Load);
            this.Click += new System.EventHandler(this.frmInverse_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscInverse;
        private System.Windows.Forms.Button tbOK;
        public System.Windows.Forms.TextBox tbInverse;
        private System.Windows.Forms.Label label1;
    }
}