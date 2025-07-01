namespace SIPKA.view
{
    partial class Dashboard_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pengguna_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.penumpang_btn = new System.Windows.Forms.Button();
            this.pembayaran_btn = new System.Windows.Forms.Button();
            this.pemesanan_btn = new System.Windows.Forms.Button();
            this.jadwal_btn = new System.Windows.Forms.Button();
            this.stasiun_btn = new System.Windows.Forms.Button();
            this.kereta_btn = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem Informasi Pemesanan Tiket Kereta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 98);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.pengguna_btn);
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.penumpang_btn);
            this.panel3.Controls.Add(this.pembayaran_btn);
            this.panel3.Controls.Add(this.pemesanan_btn);
            this.panel3.Controls.Add(this.jadwal_btn);
            this.panel3.Controls.Add(this.stasiun_btn);
            this.panel3.Controls.Add(this.kereta_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 355);
            this.panel3.TabIndex = 1;
            // 
            // pengguna_btn
            // 
            this.pengguna_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pengguna_btn.Location = new System.Drawing.Point(0, 192);
            this.pengguna_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pengguna_btn.Name = "pengguna_btn";
            this.pengguna_btn.Size = new System.Drawing.Size(133, 32);
            this.pengguna_btn.TabIndex = 7;
            this.pengguna_btn.Text = "Pengguna";
            this.pengguna_btn.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.Location = new System.Drawing.Point(0, 323);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(133, 32);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // penumpang_btn
            // 
            this.penumpang_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.penumpang_btn.Location = new System.Drawing.Point(0, 160);
            this.penumpang_btn.Margin = new System.Windows.Forms.Padding(2);
            this.penumpang_btn.Name = "penumpang_btn";
            this.penumpang_btn.Size = new System.Drawing.Size(133, 32);
            this.penumpang_btn.TabIndex = 5;
            this.penumpang_btn.Text = "Penumpang";
            this.penumpang_btn.UseVisualStyleBackColor = true;
            this.penumpang_btn.Click += new System.EventHandler(this.penumpang_btn_Click);
            // 
            // pembayaran_btn
            // 
            this.pembayaran_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pembayaran_btn.Location = new System.Drawing.Point(0, 128);
            this.pembayaran_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pembayaran_btn.Name = "pembayaran_btn";
            this.pembayaran_btn.Size = new System.Drawing.Size(133, 32);
            this.pembayaran_btn.TabIndex = 4;
            this.pembayaran_btn.Text = "Pembayaran";
            this.pembayaran_btn.UseVisualStyleBackColor = true;
            this.pembayaran_btn.Click += new System.EventHandler(this.pembayaran_btn_Click);
            // 
            // pemesanan_btn
            // 
            this.pemesanan_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pemesanan_btn.Location = new System.Drawing.Point(0, 96);
            this.pemesanan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pemesanan_btn.Name = "pemesanan_btn";
            this.pemesanan_btn.Size = new System.Drawing.Size(133, 32);
            this.pemesanan_btn.TabIndex = 3;
            this.pemesanan_btn.Text = "Pemesanan";
            this.pemesanan_btn.UseVisualStyleBackColor = true;
            this.pemesanan_btn.Click += new System.EventHandler(this.pemesanan_btn_Click);
            // 
            // jadwal_btn
            // 
            this.jadwal_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.jadwal_btn.Location = new System.Drawing.Point(0, 64);
            this.jadwal_btn.Margin = new System.Windows.Forms.Padding(2);
            this.jadwal_btn.Name = "jadwal_btn";
            this.jadwal_btn.Size = new System.Drawing.Size(133, 32);
            this.jadwal_btn.TabIndex = 2;
            this.jadwal_btn.Text = "Jadwal";
            this.jadwal_btn.UseVisualStyleBackColor = true;
            this.jadwal_btn.Click += new System.EventHandler(this.jadwal_btn_Click);
            // 
            // stasiun_btn
            // 
            this.stasiun_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stasiun_btn.Location = new System.Drawing.Point(0, 32);
            this.stasiun_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stasiun_btn.Name = "stasiun_btn";
            this.stasiun_btn.Size = new System.Drawing.Size(133, 32);
            this.stasiun_btn.TabIndex = 1;
            this.stasiun_btn.Text = "Stasiun";
            this.stasiun_btn.UseVisualStyleBackColor = true;
            this.stasiun_btn.Click += new System.EventHandler(this.stasiun_btn_Click);
            // 
            // kereta_btn
            // 
            this.kereta_btn.BackColor = System.Drawing.Color.Transparent;
            this.kereta_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kereta_btn.FlatAppearance.BorderSize = 0;
            this.kereta_btn.Location = new System.Drawing.Point(0, 0);
            this.kereta_btn.Margin = new System.Windows.Forms.Padding(2);
            this.kereta_btn.Name = "kereta_btn";
            this.kereta_btn.Size = new System.Drawing.Size(133, 32);
            this.kereta_btn.TabIndex = 0;
            this.kereta_btn.Text = "Kereta";
            this.kereta_btn.UseVisualStyleBackColor = false;
            this.kereta_btn.Click += new System.EventHandler(this.kereta_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.PowderBlue;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(133, 100);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(735, 355);
            this.main_panel.TabIndex = 2;
            // 
            // Dashboard_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 455);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard_frm";
            this.Text = "Dashboard_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button penumpang_btn;
        private System.Windows.Forms.Button pembayaran_btn;
        private System.Windows.Forms.Button pemesanan_btn;
        private System.Windows.Forms.Button jadwal_btn;
        private System.Windows.Forms.Button stasiun_btn;
        private System.Windows.Forms.Button kereta_btn;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button pengguna_btn;
    }
}