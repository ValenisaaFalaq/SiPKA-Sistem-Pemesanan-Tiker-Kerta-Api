namespace SIPKA.view
{
    partial class Form_RUD_Pemesanan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NIK_txt = new System.Windows.Forms.TextBox();
            this.namaP_txt = new System.Windows.Forms.TextBox();
            this.dataPemesanan_grd = new System.Windows.Forms.DataGridView();
            this.id_pemesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_penumpang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_berangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_tiba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tujuan_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tglBrgkt_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_cmb = new System.Windows.Forms.Button();
            this.cariP_txt = new System.Windows.Forms.TextBox();
            this.dataJadwal_grd = new System.Windows.Forms.DataGridView();
            this.id_jadwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stasiun_asal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stasiun_tujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kereta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_berangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericJumlah = new System.Windows.Forms.NumericUpDown();
            this.jumlah_num = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPemesanan_grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataJadwal_grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NIK_txt);
            this.groupBox1.Controls.Add(this.namaP_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(75, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Penumpang";
            // 
            // NIK_txt
            // 
            this.NIK_txt.Location = new System.Drawing.Point(155, 52);
            this.NIK_txt.Name = "NIK_txt";
            this.NIK_txt.Size = new System.Drawing.Size(207, 20);
            this.NIK_txt.TabIndex = 4;
            // 
            // namaP_txt
            // 
            this.namaP_txt.Location = new System.Drawing.Point(155, 26);
            this.namaP_txt.Name = "namaP_txt";
            this.namaP_txt.Size = new System.Drawing.Size(207, 20);
            this.namaP_txt.TabIndex = 3;
            // 
            // dataPemesanan_grd
            // 
            this.dataPemesanan_grd.AllowUserToAddRows = false;
            this.dataPemesanan_grd.AllowUserToDeleteRows = false;
            this.dataPemesanan_grd.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPemesanan_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPemesanan_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPemesanan_grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pemesanan,
            this.id_penumpang,
            this.nama,
            this.keberangkatan,
            this.tujuan,
            this.tanggal,
            this.waktu_berangkat,
            this.waktu_tiba});
            this.dataPemesanan_grd.Location = new System.Drawing.Point(0, 86);
            this.dataPemesanan_grd.Margin = new System.Windows.Forms.Padding(2);
            this.dataPemesanan_grd.Name = "dataPemesanan_grd";
            this.dataPemesanan_grd.Size = new System.Drawing.Size(563, 195);
            this.dataPemesanan_grd.TabIndex = 4;
            this.dataPemesanan_grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPemesanan_grd_CellClick);
            // 
            // id_pemesanan
            // 
            this.id_pemesanan.DataPropertyName = "id_pemesanan";
            this.id_pemesanan.HeaderText = "No.";
            this.id_pemesanan.Name = "id_pemesanan";
            // 
            // id_penumpang
            // 
            this.id_penumpang.DataPropertyName = "id_penumpang";
            this.id_penumpang.HeaderText = "NIK";
            this.id_penumpang.Name = "id_penumpang";
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Penumpang";
            this.nama.Name = "nama";
            // 
            // keberangkatan
            // 
            this.keberangkatan.DataPropertyName = "asal";
            this.keberangkatan.HeaderText = "Keberangkatan";
            this.keberangkatan.Name = "keberangkatan";
            // 
            // tujuan
            // 
            this.tujuan.DataPropertyName = "tujuan";
            this.tujuan.HeaderText = "Tujuan";
            this.tujuan.Name = "tujuan";
            // 
            // tanggal
            // 
            this.tanggal.DataPropertyName = "tanggal";
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.Name = "tanggal";
            // 
            // waktu_berangkat
            // 
            this.waktu_berangkat.DataPropertyName = "waktu_berangkat";
            this.waktu_berangkat.HeaderText = "Waktu Keberangkatan";
            this.waktu_berangkat.Name = "waktu_berangkat";
            // 
            // waktu_tiba
            // 
            this.waktu_tiba.DataPropertyName = "waktu_tiba";
            this.waktu_tiba.HeaderText = "Waktu Tiba";
            this.waktu_tiba.Name = "waktu_tiba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kota Asal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kota Tujuan";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 396);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tujuan_cmb
            // 
            this.tujuan_cmb.FormattingEnabled = true;
            this.tujuan_cmb.Location = new System.Drawing.Point(224, 423);
            this.tujuan_cmb.Name = "tujuan_cmb";
            this.tujuan_cmb.Size = new System.Drawing.Size(206, 21);
            this.tujuan_cmb.TabIndex = 8;
            this.tujuan_cmb.SelectedIndexChanged += new System.EventHandler(this.tujuan_cmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tanggal Keberangkatan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tglBrgkt_date
            // 
            this.tglBrgkt_date.Location = new System.Drawing.Point(223, 450);
            this.tglBrgkt_date.Name = "tglBrgkt_date";
            this.tglBrgkt_date.Size = new System.Drawing.Size(207, 20);
            this.tglBrgkt_date.TabIndex = 10;
            this.tglBrgkt_date.ValueChanged += new System.EventHandler(this.tglBrgkt_date_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_cmb
            // 
            this.delete_cmb.BackColor = System.Drawing.Color.Red;
            this.delete_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_cmb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_cmb.Location = new System.Drawing.Point(355, 648);
            this.delete_cmb.Name = "delete_cmb";
            this.delete_cmb.Size = new System.Drawing.Size(75, 31);
            this.delete_cmb.TabIndex = 12;
            this.delete_cmb.Text = "Delete";
            this.delete_cmb.UseVisualStyleBackColor = false;
            this.delete_cmb.Click += new System.EventHandler(this.delete_cmb_Click);
            // 
            // cariP_txt
            // 
            this.cariP_txt.Location = new System.Drawing.Point(182, 61);
            this.cariP_txt.Name = "cariP_txt";
            this.cariP_txt.Size = new System.Drawing.Size(185, 20);
            this.cariP_txt.TabIndex = 13;
            // 
            // dataJadwal_grd
            // 
            this.dataJadwal_grd.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataJadwal_grd.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataJadwal_grd.Location = new System.Drawing.Point(22, 530);
            this.dataJadwal_grd.Name = "dataJadwal_grd";
            this.dataJadwal_grd.ReadOnly = true;
            this.dataJadwal_grd.Size = new System.Drawing.Size(517, 112);
            this.dataJadwal_grd.TabIndex = 14;
            this.dataJadwal_grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJadwal_grd_CellClick);
            this.dataJadwal_grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJadwal_grd_CellContentClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "waktu_berangkat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Waktu Berangkat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "waktu_tiba";
            this.dataGridViewTextBoxColumn2.HeaderText = "Waktu Tiba";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numericJumlah
            // 
            this.numericJumlah.Location = new System.Drawing.Point(223, 476);
            this.numericJumlah.Name = "numericJumlah";
            this.numericJumlah.Size = new System.Drawing.Size(207, 20);
            this.numericJumlah.TabIndex = 15;
            // 
            // jumlah_num
            // 
            this.jumlah_num.AutoSize = true;
            this.jumlah_num.Location = new System.Drawing.Point(86, 483);
            this.jumlah_num.Name = "jumlah_num";
            this.jumlah_num.Size = new System.Drawing.Size(67, 13);
            this.jumlah_num.TabIndex = 16;
            this.jumlah_num.Text = "Jumlah Tiket";
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
            this.panel1.TabIndex = 17;
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
            this.label7.Location = new System.Drawing.Point(132, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "PENGELOLAAN DATA PEMESANAN";
            // 
            // Form_RUD_Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(564, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jumlah_num);
            this.Controls.Add(this.numericJumlah);
            this.Controls.Add(this.dataJadwal_grd);
            this.Controls.Add(this.cariP_txt);
            this.Controls.Add(this.delete_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tglBrgkt_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tujuan_cmb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataPemesanan_grd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RUD_Pemesanan";
            this.Text = "Form_RUD_Pemesanan";
            this.Load += new System.EventHandler(this.Form_RUD_Pemesanan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPemesanan_grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataJadwal_grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NIK_txt;
        private System.Windows.Forms.TextBox namaP_txt;
        private System.Windows.Forms.DataGridView dataPemesanan_grd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox tujuan_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tglBrgkt_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_cmb;
        private System.Windows.Forms.TextBox cariP_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pemesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_penumpang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn keberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_berangkat;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_tiba;
        private System.Windows.Forms.DataGridView dataJadwal_grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jadwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn stasiun_asal;
        private System.Windows.Forms.DataGridViewTextBoxColumn stasiun_tujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kereta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_berangkat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.NumericUpDown numericJumlah;
        private System.Windows.Forms.Label jumlah_num;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label7;
    }
}