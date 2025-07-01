namespace SIPKA.view
{
    partial class Form_Pemesanan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pemesanan));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesan_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tglBrgkt_date = new System.Windows.Forms.DateTimePicker();
            this.dataJadwal_grd = new System.Windows.Forms.DataGridView();
            this.id_jadwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stasiun_asal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stasiun_tujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kereta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_berangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_berangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_tiba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tujuan_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NIK_txt = new System.Windows.Forms.TextBox();
            this.namaP_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jumlah_num = new System.Windows.Forms.Label();
            this.numericJumlah = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daftar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataJadwal_grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kota Asal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kota Tujuan";
            // 
            // pesan_btn
            // 
            this.pesan_btn.Location = new System.Drawing.Point(601, 261);
            this.pesan_btn.Name = "pesan_btn";
            this.pesan_btn.Size = new System.Drawing.Size(75, 23);
            this.pesan_btn.TabIndex = 3;
            this.pesan_btn.Text = "Pesan TIket";
            this.pesan_btn.UseVisualStyleBackColor = true;
            this.pesan_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal Keberangkatan";
            // 
            // tglBrgkt_date
            // 
            this.tglBrgkt_date.Location = new System.Drawing.Point(342, 224);
            this.tglBrgkt_date.Name = "tglBrgkt_date";
            this.tglBrgkt_date.Size = new System.Drawing.Size(187, 20);
            this.tglBrgkt_date.TabIndex = 7;
            this.tglBrgkt_date.ValueChanged += new System.EventHandler(this.tglBrgkt_date_ValueChanged);
            // 
            // dataJadwal_grd
            // 
            this.dataJadwal_grd.AllowUserToAddRows = false;
            this.dataJadwal_grd.AllowUserToDeleteRows = false;
            this.dataJadwal_grd.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataJadwal_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataJadwal_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJadwal_grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_jadwal,
            this.stasiun_asal,
            this.stasiun_tujuan,
            this.nama_kereta,
            this.tanggal_berangkat,
            this.waktu_berangkat,
            this.waktu_tiba});
            this.dataJadwal_grd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataJadwal_grd.Location = new System.Drawing.Point(0, 306);
            this.dataJadwal_grd.Margin = new System.Windows.Forms.Padding(2);
            this.dataJadwal_grd.Name = "dataJadwal_grd";
            this.dataJadwal_grd.ReadOnly = true;
            this.dataJadwal_grd.Size = new System.Drawing.Size(747, 166);
            this.dataJadwal_grd.TabIndex = 8;
            this.dataJadwal_grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJadwal_grd_CellClick);
            // 
            // id_jadwal
            // 
            this.id_jadwal.DataPropertyName = "id_jadwal";
            this.id_jadwal.HeaderText = "No.";
            this.id_jadwal.Name = "id_jadwal";
            this.id_jadwal.ReadOnly = true;
            // 
            // stasiun_asal
            // 
            this.stasiun_asal.DataPropertyName = "asal";
            this.stasiun_asal.HeaderText = "Stasiun Keberangkatan";
            this.stasiun_asal.Name = "stasiun_asal";
            this.stasiun_asal.ReadOnly = true;
            // 
            // stasiun_tujuan
            // 
            this.stasiun_tujuan.DataPropertyName = "tujuan";
            this.stasiun_tujuan.HeaderText = "Stasiun Tujuan";
            this.stasiun_tujuan.Name = "stasiun_tujuan";
            this.stasiun_tujuan.ReadOnly = true;
            // 
            // nama_kereta
            // 
            this.nama_kereta.DataPropertyName = "nama_kereta";
            this.nama_kereta.HeaderText = "Nama Kereta";
            this.nama_kereta.Name = "nama_kereta";
            this.nama_kereta.ReadOnly = true;
            // 
            // tanggal_berangkat
            // 
            this.tanggal_berangkat.DataPropertyName = "tanggal";
            this.tanggal_berangkat.HeaderText = "Tanggal";
            this.tanggal_berangkat.Name = "tanggal_berangkat";
            this.tanggal_berangkat.ReadOnly = true;
            // 
            // waktu_berangkat
            // 
            this.waktu_berangkat.DataPropertyName = "waktu_berangkat";
            this.waktu_berangkat.HeaderText = "Waktu Berangkat";
            this.waktu_berangkat.Name = "waktu_berangkat";
            this.waktu_berangkat.ReadOnly = true;
            // 
            // waktu_tiba
            // 
            this.waktu_tiba.DataPropertyName = "waktu_tiba";
            this.waktu_tiba.HeaderText = "Waktu Tiba";
            this.waktu_tiba.Name = "waktu_tiba";
            this.waktu_tiba.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tujuan_cmb
            // 
            this.tujuan_cmb.FormattingEnabled = true;
            this.tujuan_cmb.Location = new System.Drawing.Point(342, 187);
            this.tujuan_cmb.Name = "tujuan_cmb";
            this.tujuan_cmb.Size = new System.Drawing.Size(187, 21);
            this.tujuan_cmb.TabIndex = 11;
            this.tujuan_cmb.SelectedIndexChanged += new System.EventHandler(this.tujuan_cmb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NIK_txt);
            this.groupBox1.Controls.Add(this.namaP_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(203, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Penumpang";
            // 
            // NIK_txt
            // 
            this.NIK_txt.Location = new System.Drawing.Point(96, 53);
            this.NIK_txt.Name = "NIK_txt";
            this.NIK_txt.Size = new System.Drawing.Size(224, 20);
            this.NIK_txt.TabIndex = 4;
            this.NIK_txt.TextChanged += new System.EventHandler(this.NIK_txt_TextChanged);
            // 
            // namaP_txt
            // 
            this.namaP_txt.Location = new System.Drawing.Point(96, 27);
            this.namaP_txt.Name = "namaP_txt";
            this.namaP_txt.Size = new System.Drawing.Size(224, 20);
            this.namaP_txt.TabIndex = 3;
            this.namaP_txt.TextChanged += new System.EventHandler(this.namaP_txt_TextChanged);
            this.namaP_txt.Leave += new System.EventHandler(this.namaP_txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NIK/ No. KTP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // jumlah_num
            // 
            this.jumlah_num.AutoSize = true;
            this.jumlah_num.Location = new System.Drawing.Point(201, 261);
            this.jumlah_num.Name = "jumlah_num";
            this.jumlah_num.Size = new System.Drawing.Size(67, 13);
            this.jumlah_num.TabIndex = 13;
            this.jumlah_num.Text = "Jumlah Tiket";
            // 
            // numericJumlah
            // 
            this.numericJumlah.Location = new System.Drawing.Point(342, 261);
            this.numericJumlah.Name = "numericJumlah";
            this.numericJumlah.Size = new System.Drawing.Size(188, 20);
            this.numericJumlah.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 36);
            this.panel1.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(0, -1);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(77, 36);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "<";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(186, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "FORM PEMESANAN TIKET KERETA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // daftar_btn
            // 
            this.daftar_btn.Location = new System.Drawing.Point(601, 225);
            this.daftar_btn.Name = "daftar_btn";
            this.daftar_btn.Size = new System.Drawing.Size(134, 23);
            this.daftar_btn.TabIndex = 47;
            this.daftar_btn.Text = "Daftarkan Penumpang";
            this.daftar_btn.UseVisualStyleBackColor = true;
            this.daftar_btn.Visible = false;
            this.daftar_btn.Click += new System.EventHandler(this.daftar_btn_Click);
            // 
            // Form_Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(747, 472);
            this.Controls.Add(this.daftar_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericJumlah);
            this.Controls.Add(this.jumlah_num);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tujuan_cmb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataJadwal_grd);
            this.Controls.Add(this.tglBrgkt_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pesan_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pemesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Pemesanan";
            this.Load += new System.EventHandler(this.Form_Pemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataJadwal_grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pesan_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tglBrgkt_date;
        private System.Windows.Forms.DataGridView dataJadwal_grd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox tujuan_cmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namaP_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NIK_txt;
        private System.Windows.Forms.Label jumlah_num;
        private System.Windows.Forms.NumericUpDown numericJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jadwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn stasiun_asal;
        private System.Windows.Forms.DataGridViewTextBoxColumn stasiun_tujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kereta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_berangkat;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_berangkat;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_tiba;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button daftar_btn;
    }
}