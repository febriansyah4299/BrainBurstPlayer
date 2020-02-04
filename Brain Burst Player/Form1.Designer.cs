namespace Brain_Burst_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TombolTambah = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaBerkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutupAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangBrainBurstPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TombolPlay = new System.Windows.Forms.Button();
            this.TombolPause = new System.Windows.Forms.Button();
            this.TombolStop = new System.Windows.Forms.Button();
            this.TombolSayonara = new System.Windows.Forms.Button();
            this.AjebAjeb = new System.Windows.Forms.TextBox();
            this.BukaDonk = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TombolTambah
            // 
            resources.ApplyResources(this.TombolTambah, "TombolTambah");
            this.TombolTambah.Name = "TombolTambah";
            this.TombolTambah.UseVisualStyleBackColor = true;
            this.TombolTambah.Click += new System.EventHandler(this.TombolTambah_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berkasToolStripMenuItem,
            this.tentangToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // berkasToolStripMenuItem
            // 
            this.berkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaBerkasToolStripMenuItem,
            this.tutupAplikasiToolStripMenuItem});
            this.berkasToolStripMenuItem.Name = "berkasToolStripMenuItem";
            resources.ApplyResources(this.berkasToolStripMenuItem, "berkasToolStripMenuItem");
            // 
            // bukaBerkasToolStripMenuItem
            // 
            this.bukaBerkasToolStripMenuItem.Name = "bukaBerkasToolStripMenuItem";
            resources.ApplyResources(this.bukaBerkasToolStripMenuItem, "bukaBerkasToolStripMenuItem");
            this.bukaBerkasToolStripMenuItem.Click += new System.EventHandler(this.bukaBerkasToolStripMenuItem_Click);
            // 
            // tutupAplikasiToolStripMenuItem
            // 
            this.tutupAplikasiToolStripMenuItem.Name = "tutupAplikasiToolStripMenuItem";
            resources.ApplyResources(this.tutupAplikasiToolStripMenuItem, "tutupAplikasiToolStripMenuItem");
            this.tutupAplikasiToolStripMenuItem.Click += new System.EventHandler(this.tutupAplikasiToolStripMenuItem_Click);
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangBrainBurstPlayerToolStripMenuItem,
            this.lisensiToolStripMenuItem});
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            resources.ApplyResources(this.tentangToolStripMenuItem, "tentangToolStripMenuItem");
            // 
            // tentangBrainBurstPlayerToolStripMenuItem
            // 
            this.tentangBrainBurstPlayerToolStripMenuItem.Name = "tentangBrainBurstPlayerToolStripMenuItem";
            resources.ApplyResources(this.tentangBrainBurstPlayerToolStripMenuItem, "tentangBrainBurstPlayerToolStripMenuItem");
            this.tentangBrainBurstPlayerToolStripMenuItem.Click += new System.EventHandler(this.tentangBrainBurstPlayerToolStripMenuItem_Click);
            // 
            // lisensiToolStripMenuItem
            // 
            this.lisensiToolStripMenuItem.Name = "lisensiToolStripMenuItem";
            resources.ApplyResources(this.lisensiToolStripMenuItem, "lisensiToolStripMenuItem");
            this.lisensiToolStripMenuItem.Click += new System.EventHandler(this.lisensiToolStripMenuItem_Click);
            // 
            // TombolPlay
            // 
            resources.ApplyResources(this.TombolPlay, "TombolPlay");
            this.TombolPlay.Name = "TombolPlay";
            this.TombolPlay.UseVisualStyleBackColor = true;
            this.TombolPlay.Click += new System.EventHandler(this.TombolPlay_Click);
            // 
            // TombolPause
            // 
            resources.ApplyResources(this.TombolPause, "TombolPause");
            this.TombolPause.Name = "TombolPause";
            this.TombolPause.UseVisualStyleBackColor = true;
            this.TombolPause.Click += new System.EventHandler(this.TombolPause_Click);
            // 
            // TombolStop
            // 
            resources.ApplyResources(this.TombolStop, "TombolStop");
            this.TombolStop.Name = "TombolStop";
            this.TombolStop.UseVisualStyleBackColor = true;
            this.TombolStop.Click += new System.EventHandler(this.TombolStop_Click);
            // 
            // TombolSayonara
            // 
            resources.ApplyResources(this.TombolSayonara, "TombolSayonara");
            this.TombolSayonara.Name = "TombolSayonara";
            this.TombolSayonara.UseVisualStyleBackColor = true;
            this.TombolSayonara.Click += new System.EventHandler(this.TombolSayonara_Click);
            // 
            // AjebAjeb
            // 
            this.AjebAjeb.BackColor = System.Drawing.Color.White;
            this.AjebAjeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.AjebAjeb, "AjebAjeb");
            this.AjebAjeb.Name = "AjebAjeb";
            this.AjebAjeb.ReadOnly = true;
            // 
            // BukaDonk
            // 
            resources.ApplyResources(this.BukaDonk, "BukaDonk");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Brain_Burst_Player.Properties.Resources.BBP;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AjebAjeb);
            this.Controls.Add(this.TombolSayonara);
            this.Controls.Add(this.TombolStop);
            this.Controls.Add(this.TombolPause);
            this.Controls.Add(this.TombolPlay);
            this.Controls.Add(this.TombolTambah);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TombolTambah;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem berkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaBerkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutupAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangBrainBurstPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisensiToolStripMenuItem;
        private System.Windows.Forms.Button TombolPlay;
        private System.Windows.Forms.Button TombolPause;
        private System.Windows.Forms.Button TombolStop;
        private System.Windows.Forms.Button TombolSayonara;
        private System.Windows.Forms.TextBox AjebAjeb;
        private System.Windows.Forms.OpenFileDialog BukaDonk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

