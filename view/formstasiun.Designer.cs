namespace SIPKA.view
{
    partial class formstasiun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formstasiun));
            this.stasiunview_grid = new System.Windows.Forms.DataGridView();
            this.id_stasiun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_stasiun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_stasiun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdStasiun = new System.Windows.Forms.TextBox();
            this.id_sts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaStasiun = new System.Windows.Forms.TextBox();
            this.Kotast = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.kode_sts = new System.Windows.Forms.Label();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.cekid = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.bersihkan_btn = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cari_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stasiunview_grid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stasiunview_grid
            // 
            this.stasiunview_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stasiunview_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stasiunview_grid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stasiunview_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stasiunview_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stasiunview_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_stasiun,
            this.nama_stasiun,
            this.kota,
            this.kode_stasiun});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stasiunview_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.stasiunview_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stasiunview_grid.GridColor = System.Drawing.Color.Black;
            this.stasiunview_grid.Location = new System.Drawing.Point(0, 284);
            this.stasiunview_grid.Name = "stasiunview_grid";
            this.stasiunview_grid.Size = new System.Drawing.Size(665, 138);
            this.stasiunview_grid.TabIndex = 1;
            this.stasiunview_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stasiunview_grid_CellClick);
            this.stasiunview_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stasiunview_grid_CellContentClick);
            // 
            // id_stasiun
            // 
            this.id_stasiun.DataPropertyName = "id_stasiun";
            this.id_stasiun.HeaderText = "ID";
            this.id_stasiun.Name = "id_stasiun";
            // 
            // nama_stasiun
            // 
            this.nama_stasiun.DataPropertyName = "nama_stasiun";
            this.nama_stasiun.HeaderText = "Nama Stasiun";
            this.nama_stasiun.Name = "nama_stasiun";
            // 
            // kota
            // 
            this.kota.DataPropertyName = "kota";
            this.kota.HeaderText = "Kota";
            this.kota.Name = "kota";
            // 
            // kode_stasiun
            // 
            this.kode_stasiun.DataPropertyName = "kode_stasiun";
            this.kode_stasiun.HeaderText = "Kode";
            this.kode_stasiun.Name = "kode_stasiun";
            // 
            // txtIdStasiun
            // 
            this.txtIdStasiun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtIdStasiun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdStasiun.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStasiun.Location = new System.Drawing.Point(304, 59);
            this.txtIdStasiun.Name = "txtIdStasiun";
            this.txtIdStasiun.ReadOnly = true;
            this.txtIdStasiun.Size = new System.Drawing.Size(67, 17);
            this.txtIdStasiun.TabIndex = 2;
            this.txtIdStasiun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdStasiun.TextChanged += new System.EventHandler(this.txtIdStasiun_TextChanged);
            // 
            // id_sts
            // 
            this.id_sts.AutoSize = true;
            this.id_sts.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_sts.Location = new System.Drawing.Point(159, 62);
            this.id_sts.Name = "id_sts";
            this.id_sts.Size = new System.Drawing.Size(74, 19);
            this.id_sts.TabIndex = 3;
            this.id_sts.Text = "ID Stasiun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Stasiun";
            // 
            // txtNamaStasiun
            // 
            this.txtNamaStasiun.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaStasiun.Location = new System.Drawing.Point(304, 98);
            this.txtNamaStasiun.Name = "txtNamaStasiun";
            this.txtNamaStasiun.Size = new System.Drawing.Size(179, 24);
            this.txtNamaStasiun.TabIndex = 5;
            this.txtNamaStasiun.TextChanged += new System.EventHandler(this.txtNamaStasiun_TextChanged);
            // 
            // Kotast
            // 
            this.Kotast.AutoSize = true;
            this.Kotast.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kotast.Location = new System.Drawing.Point(159, 138);
            this.Kotast.Name = "Kotast";
            this.Kotast.Size = new System.Drawing.Size(40, 19);
            this.Kotast.TabIndex = 6;
            this.Kotast.Text = "Kota";
            // 
            // txtKota
            // 
            this.txtKota.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKota.Location = new System.Drawing.Point(304, 138);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(179, 24);
            this.txtKota.TabIndex = 7;
            this.txtKota.TextChanged += new System.EventHandler(this.txtKota_TextChanged);
            // 
            // kode_sts
            // 
            this.kode_sts.AutoSize = true;
            this.kode_sts.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_sts.Location = new System.Drawing.Point(159, 173);
            this.kode_sts.Name = "kode_sts";
            this.kode_sts.Size = new System.Drawing.Size(44, 19);
            this.kode_sts.TabIndex = 8;
            this.kode_sts.Text = "Kode";
            // 
            // txtkode
            // 
            this.txtkode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkode.Location = new System.Drawing.Point(304, 173);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(67, 24);
            this.txtkode.TabIndex = 9;
            this.txtkode.TextChanged += new System.EventHandler(this.txtkode_TextChanged);
            // 
            // cekid
            // 
            this.cekid.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekid.Location = new System.Drawing.Point(385, 58);
            this.cekid.Name = "cekid";
            this.cekid.Size = new System.Drawing.Size(75, 23);
            this.cekid.TabIndex = 10;
            this.cekid.Text = "Cek ID";
            this.cekid.UseVisualStyleBackColor = true;
            this.cekid.Click += new System.EventHandler(this.cekid_Click);
            // 
            // tambah_btn
            // 
            this.tambah_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.Location = new System.Drawing.Point(304, 217);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(75, 23);
            this.tambah_btn.TabIndex = 11;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = true;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.Location = new System.Drawing.Point(385, 217);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(75, 23);
            this.ubah_btn.TabIndex = 12;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(466, 217);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(75, 23);
            this.hapus_btn.TabIndex = 13;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // bersihkan_btn
            // 
            this.bersihkan_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bersihkan_btn.Location = new System.Drawing.Point(547, 217);
            this.bersihkan_btn.Name = "bersihkan_btn";
            this.bersihkan_btn.Size = new System.Drawing.Size(82, 23);
            this.bersihkan_btn.TabIndex = 14;
            this.bersihkan_btn.Text = "Bersihkan";
            this.bersihkan_btn.UseVisualStyleBackColor = true;
            this.bersihkan_btn.Click += new System.EventHandler(this.bersihkan_btn_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(163, 258);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(348, 20);
            this.txtCari.TabIndex = 15;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // cari_btn
            // 
            this.cari_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_btn.Location = new System.Drawing.Point(554, 256);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Size = new System.Drawing.Size(75, 23);
            this.cari_btn.TabIndex = 16;
            this.cari_btn.Text = "Cari";
            this.cari_btn.UseVisualStyleBackColor = true;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(2, 2);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(77, 36);
            this.exit_btn.TabIndex = 18;
            this.exit_btn.Text = "<";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "FORM STASIUN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 40);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // formstasiun
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cari_btn);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.bersihkan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.tambah_btn);
            this.Controls.Add(this.cekid);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.kode_sts);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.Kotast);
            this.Controls.Add(this.txtNamaStasiun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_sts);
            this.Controls.Add(this.txtIdStasiun);
            this.Controls.Add(this.stasiunview_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formstasiun";
            ((System.ComponentModel.ISupportInitialize)(this.stasiunview_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView stasiunview_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stasiun;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_stasiun;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_stasiun;
        private System.Windows.Forms.TextBox txtIdStasiun;
        private System.Windows.Forms.Label id_sts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaStasiun;
        private System.Windows.Forms.Label Kotast;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label kode_sts;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.Button cekid;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button bersihkan_btn;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button cari_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}