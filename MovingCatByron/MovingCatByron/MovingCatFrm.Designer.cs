namespace MovingCatByron
{
    partial class frmMovingCat
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
            this.MnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDenzelCurry = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDenzelCurry1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDenzelCurry2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PicCat = new System.Windows.Forms.PictureBox();
            this.MnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCat)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuFile
            // 
            this.MnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat,
            this.mniDenzelCurry});
            this.MnuFile.Location = new System.Drawing.Point(0, 0);
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(800, 24);
            this.MnuFile.TabIndex = 0;
            this.MnuFile.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(93, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(104, 22);
            this.mniCat1.Text = "Cat 1 ";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(104, 22);
            this.mniCat2.Text = "Cat 2 ";
            this.mniCat2.Click += new System.EventHandler(this.MniCat2_Click);
            // 
            // mniDenzelCurry
            // 
            this.mniDenzelCurry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDenzelCurry1,
            this.mniDenzelCurry2});
            this.mniDenzelCurry.Name = "mniDenzelCurry";
            this.mniDenzelCurry.Size = new System.Drawing.Size(86, 20);
            this.mniDenzelCurry.Text = "Denzel Curry";
            // 
            // mniDenzelCurry1
            // 
            this.mniDenzelCurry1.Name = "mniDenzelCurry1";
            this.mniDenzelCurry1.Size = new System.Drawing.Size(180, 22);
            this.mniDenzelCurry1.Text = "Denzel Curry 1";
            this.mniDenzelCurry1.Click += new System.EventHandler(this.MniDenzelCurry1_Click);
            // 
            // mniDenzelCurry2
            // 
            this.mniDenzelCurry2.Name = "mniDenzelCurry2";
            this.mniDenzelCurry2.Size = new System.Drawing.Size(180, 22);
            this.mniDenzelCurry2.Text = "Denzel Curry 2 ";
            this.mniDenzelCurry2.Click += new System.EventHandler(this.MniDenzelCurry2_Click);
            // 
            // PicCat
            // 
            this.PicCat.Image = global::MovingCatByron.Properties.Resources.cat1;
            this.PicCat.Location = new System.Drawing.Point(144, 142);
            this.PicCat.Name = "PicCat";
            this.PicCat.Size = new System.Drawing.Size(338, 250);
            this.PicCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCat.TabIndex = 1;
            this.PicCat.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicCat);
            this.Controls.Add(this.MnuFile);
            this.MainMenuStrip = this.MnuFile;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat By Byron";
            this.MnuFile.ResumeLayout(false);
            this.MnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox PicCat;
        private System.Windows.Forms.ToolStripMenuItem mniDenzelCurry;
        private System.Windows.Forms.ToolStripMenuItem mniDenzelCurry1;
        private System.Windows.Forms.ToolStripMenuItem mniDenzelCurry2;
    }
}

