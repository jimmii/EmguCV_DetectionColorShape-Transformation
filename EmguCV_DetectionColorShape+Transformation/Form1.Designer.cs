namespace EmguCV_DetectionColorShape_Transformation
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModifiedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToYCrCbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToHSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToLUVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToHLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(805, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(700, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.grayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveModifiedFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveModifiedFileToolStripMenuItem
            // 
            this.saveModifiedFileToolStripMenuItem.Name = "saveModifiedFileToolStripMenuItem";
            this.saveModifiedFileToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.saveModifiedFileToolStripMenuItem.Text = "Save Modified File";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToGrayToolStripMenuItem,
            this.bGRToYCrCbToolStripMenuItem,
            this.bGRToHSVToolStripMenuItem,
            this.bGRToLUVToolStripMenuItem,
            this.bGRToLabToolStripMenuItem,
            this.bGRToHLSToolStripMenuItem});
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.grayToolStripMenuItem.Text = "Color Tranformation";
            // 
            // convertToGrayToolStripMenuItem
            // 
            this.convertToGrayToolStripMenuItem.Name = "convertToGrayToolStripMenuItem";
            this.convertToGrayToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.convertToGrayToolStripMenuItem.Text = "BGR_To_Gray";
            this.convertToGrayToolStripMenuItem.Click += new System.EventHandler(this.convertToGrayToolStripMenuItem_Click_1);
            // 
            // bGRToYCrCbToolStripMenuItem
            // 
            this.bGRToYCrCbToolStripMenuItem.Name = "bGRToYCrCbToolStripMenuItem";
            this.bGRToYCrCbToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bGRToYCrCbToolStripMenuItem.Text = "BGR_To_YCrCb";
            this.bGRToYCrCbToolStripMenuItem.Click += new System.EventHandler(this.bGRToYCrCbToolStripMenuItem_Click);
            // 
            // bGRToHSVToolStripMenuItem
            // 
            this.bGRToHSVToolStripMenuItem.Name = "bGRToHSVToolStripMenuItem";
            this.bGRToHSVToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bGRToHSVToolStripMenuItem.Text = "BGR_To_HSV";
            this.bGRToHSVToolStripMenuItem.Click += new System.EventHandler(this.bGRToHSVToolStripMenuItem_Click);
            // 
            // bGRToLUVToolStripMenuItem
            // 
            this.bGRToLUVToolStripMenuItem.Name = "bGRToLUVToolStripMenuItem";
            this.bGRToLUVToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bGRToLUVToolStripMenuItem.Text = "BGR_To_LUV";
            this.bGRToLUVToolStripMenuItem.Click += new System.EventHandler(this.bGRToLUVToolStripMenuItem_Click);
            // 
            // bGRToLabToolStripMenuItem
            // 
            this.bGRToLabToolStripMenuItem.Name = "bGRToLabToolStripMenuItem";
            this.bGRToLabToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bGRToLabToolStripMenuItem.Text = "BGR_To_Lab";
            this.bGRToLabToolStripMenuItem.Click += new System.EventHandler(this.bGRToLabToolStripMenuItem_Click);
            // 
            // bGRToHLSToolStripMenuItem
            // 
            this.bGRToHLSToolStripMenuItem.Name = "bGRToHLSToolStripMenuItem";
            this.bGRToHLSToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bGRToHLSToolStripMenuItem.Text = "BGR_To_HLS";
            this.bGRToHLSToolStripMenuItem.Click += new System.EventHandler(this.bGRToHLSToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveModifiedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRToYCrCbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRToHSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRToLUVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRToLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRToHLSToolStripMenuItem;
    }
}

