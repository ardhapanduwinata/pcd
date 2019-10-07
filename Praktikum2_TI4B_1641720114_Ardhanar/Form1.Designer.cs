namespace Praktikum2_TI4B_1641720114_Ardhanar
{
    partial class Form1
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
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanSebagaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.averageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorDiffusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbInput
            // 
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(12, 49);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(500, 350);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput.TabIndex = 0;
            this.pbInput.TabStop = false;
            // 
            // pbOutput
            // 
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(548, 49);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 350);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            this.pbOutput.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaToolStripMenuItem,
            this.simpanSebagaiToolStripMenuItem,
            this.keluarAplikasiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bukaToolStripMenuItem
            // 
            this.bukaToolStripMenuItem.Name = "bukaToolStripMenuItem";
            this.bukaToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.bukaToolStripMenuItem.Text = "Buka";
            this.bukaToolStripMenuItem.Click += new System.EventHandler(this.bukaToolStripMenuItem_Click);
            // 
            // simpanSebagaiToolStripMenuItem
            // 
            this.simpanSebagaiToolStripMenuItem.Name = "simpanSebagaiToolStripMenuItem";
            this.simpanSebagaiToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.simpanSebagaiToolStripMenuItem.Text = "Simpan Sebagai...";
            this.simpanSebagaiToolStripMenuItem.Click += new System.EventHandler(this.simpanSebagaiToolStripMenuItem_Click);
            // 
            // keluarAplikasiToolStripMenuItem
            // 
            this.keluarAplikasiToolStripMenuItem.Name = "keluarAplikasiToolStripMenuItem";
            this.keluarAplikasiToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.keluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi";
            this.keluarAplikasiToolStripMenuItem.Click += new System.EventHandler(this.keluarAplikasiToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.brightnessContrastToolStripMenuItem,
            this.inverseToolStripMenuItem,
            this.logContrastToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.rGBToGrayscaleToolStripMenuItem,
            this.depthToolStripMenuItem,
            this.averageToolStripMenuItem1,
            this.nearestToolStripMenuItem,
            this.errorDiffusionToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.averageToolStripMenuItem.Text = "Average";
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.lightnessToolStripMenuItem.Text = "Lightness";
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.luminanceToolStripMenuItem.Text = "Luminance";
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness - Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // logContrastToolStripMenuItem
            // 
            this.logContrastToolStripMenuItem.Name = "logContrastToolStripMenuItem";
            this.logContrastToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.logContrastToolStripMenuItem.Text = "Log Contrast";
            this.logContrastToolStripMenuItem.Click += new System.EventHandler(this.logContrastToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.gammaToolStripMenuItem.Text = "Gamma ";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // rGBToGrayscaleToolStripMenuItem
            // 
            this.rGBToGrayscaleToolStripMenuItem.Name = "rGBToGrayscaleToolStripMenuItem";
            this.rGBToGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.rGBToGrayscaleToolStripMenuItem.Text = "Grayscale Operation";
            this.rGBToGrayscaleToolStripMenuItem.Click += new System.EventHandler(this.rGBToGrayscaleToolStripMenuItem_Click);
            // 
            // depthToolStripMenuItem
            // 
            this.depthToolStripMenuItem.Name = "depthToolStripMenuItem";
            this.depthToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.depthToolStripMenuItem.Text = "Bit Depth";
            this.depthToolStripMenuItem.Click += new System.EventHandler(this.depthToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLocation,
            this.fileSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1078, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileLocation
            // 
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(110, 25);
            this.fileLocation.Text = "File Location";
            // 
            // fileSize
            // 
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(74, 25);
            this.fileSize.Text = "File Size";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(779, 417);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(269, 23);
            this.ProgressBar1.TabIndex = 4;
            // 
            // averageToolStripMenuItem1
            // 
            this.averageToolStripMenuItem1.Name = "averageToolStripMenuItem1";
            this.averageToolStripMenuItem1.Size = new System.Drawing.Size(262, 30);
            this.averageToolStripMenuItem1.Text = "Average Denoising";
            this.averageToolStripMenuItem1.Click += new System.EventHandler(this.averageToolStripMenuItem1_Click);
            // 
            // nearestToolStripMenuItem
            // 
            this.nearestToolStripMenuItem.Name = "nearestToolStripMenuItem";
            this.nearestToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.nearestToolStripMenuItem.Text = "Nearest 8 Color";
            this.nearestToolStripMenuItem.Click += new System.EventHandler(this.nearestToolStripMenuItem_Click);
            // 
            // errorDiffusionToolStripMenuItem
            // 
            this.errorDiffusionToolStripMenuItem.Name = "errorDiffusionToolStripMenuItem";
            this.errorDiffusionToolStripMenuItem.Size = new System.Drawing.Size(262, 30);
            this.errorDiffusionToolStripMenuItem.Text = "Error Diffusion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 444);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Editor Ardhanarisvari";
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanSebagaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileLocation;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel fileSize;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToGrayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nearestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorDiffusionToolStripMenuItem;
    }
}

