namespace SIPKA.view
{
    partial class formjadwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formjadwal));
            this.cari_btn = new System.Windows.Forms.Button();
            this.bersihkan_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.cekid = new System.Windows.Forms.Button();
            this.stasiunTujuan_lbl = new System.Windows.Forms.Label();
            this.stasiunAsal_lbl = new System.Windows.Forms.Label();
            this.tglBrngkt_lbl = new System.Windows.Forms.Label();
            this.idJadwal_lbl = new System.Windows.Forms.Label();
            this.idKereta_lbl = new System.Windows.Forms.Label();
            this.dtp_tglBrngkt_txt = new System.Windows.Forms.DateTimePicker();
            this.waktuBrngkt_lbl = new System.Windows.Forms.Label();
            this.waktuBrngkt_txt = new System.Windows.Forms.DateTimePicker();
            this.waktuTiba_lbl = new System.Windows.Forms.Label();
            this.waktuTiba_txt = new System.Windows.Forms.DateTimePicker();
            this.jadwal_dgv = new System.Windows.Forms.DataGridView();
            this.id_stasiun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kereta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_berangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_berangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_tiba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stasiun_asal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stasiun_tujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJadwal_txt = new System.Windows.Forms.TextBox();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.kereta_cmb = new System.Windows.Forms.ComboBox();
            this.stasiunAsal_cmb = new System.Windows.Forms.ComboBox();
            this.stasiunTujuan_cmb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jadwal_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cari_btn
            // 
            this.cari_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_btn.Location = new System.Drawing.Point(1077, 167);
            this.cari_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Size = new System.Drawing.Size(88, 28);
            this.cari_btn.TabIndex = 32;
            this.cari_btn.Text = "Cari";
            this.cari_btn.UseVisualStyleBackColor = true;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // bersihkan_btn
            // 
            this.bersihkan_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bersihkan_btn.Location = new System.Drawing.Point(450, 343);
            this.bersihkan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.bersihkan_btn.Name = "bersihkan_btn";
            this.bersihkan_btn.Size = new System.Drawing.Size(88, 28);
            this.bersihkan_btn.TabIndex = 30;
            this.bersihkan_btn.Text = "Bersihkan";
            this.bersihkan_btn.UseVisualStyleBackColor = true;
            this.bersihkan_btn.Click += new System.EventHandler(this.bersihkan_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(355, 343);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(4);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(88, 28);
            this.hapus_btn.TabIndex = 29;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.Location = new System.Drawing.Point(261, 343);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(88, 28);
            this.ubah_btn.TabIndex = 28;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            this.ubah_btn.Move += new System.EventHandler(this.ubah_btn_Move);
            // 
            // tambah_btn
            // 
            this.tambah_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.Location = new System.Drawing.Point(166, 343);
            this.tambah_btn.Margin = new System.Windows.Forms.Padding(4);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(88, 28);
            this.tambah_btn.TabIndex = 27;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = true;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // cekid
            // 
            this.cekid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekid.Location = new System.Drawing.Point(429, 59);
            this.cekid.Margin = new System.Windows.Forms.Padding(4);
            this.cekid.Name = "cekid";
            this.cekid.Size = new System.Drawing.Size(88, 28);
            this.cekid.TabIndex = 26;
            this.cekid.Text = "Cek ID";
            this.cekid.UseVisualStyleBackColor = true;
            this.cekid.Click += new System.EventHandler(this.cekid_Click);
            // 
            // stasiunTujuan_lbl
            // 
            this.stasiunTujuan_lbl.AutoSize = true;
            this.stasiunTujuan_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stasiunTujuan_lbl.Location = new System.Drawing.Point(165, 292);
            this.stasiunTujuan_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stasiunTujuan_lbl.Name = "stasiunTujuan_lbl";
            this.stasiunTujuan_lbl.Size = new System.Drawing.Size(104, 19);
            this.stasiunTujuan_lbl.TabIndex = 24;
            this.stasiunTujuan_lbl.Text = "Stasiun Tujuan";
            // 
            // stasiunAsal_lbl
            // 
            this.stasiunAsal_lbl.AutoSize = true;
            this.stasiunAsal_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stasiunAsal_lbl.Location = new System.Drawing.Point(165, 247);
            this.stasiunAsal_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stasiunAsal_lbl.Name = "stasiunAsal_lbl";
            this.stasiunAsal_lbl.Size = new System.Drawing.Size(88, 19);
            this.stasiunAsal_lbl.TabIndex = 22;
            this.stasiunAsal_lbl.Text = "Stasiun Asal";
            // 
            // tglBrngkt_lbl
            // 
            this.tglBrngkt_lbl.AutoSize = true;
            this.tglBrngkt_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglBrngkt_lbl.Location = new System.Drawing.Point(165, 130);
            this.tglBrngkt_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tglBrngkt_lbl.Name = "tglBrngkt_lbl";
            this.tglBrngkt_lbl.Size = new System.Drawing.Size(136, 19);
            this.tglBrngkt_lbl.TabIndex = 20;
            this.tglBrngkt_lbl.Text = "Tanggal Berangkat";
            // 
            // idJadwal_lbl
            // 
            this.idJadwal_lbl.AutoSize = true;
            this.idJadwal_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idJadwal_lbl.Location = new System.Drawing.Point(165, 68);
            this.idJadwal_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idJadwal_lbl.Name = "idJadwal_lbl";
            this.idJadwal_lbl.Size = new System.Drawing.Size(73, 19);
            this.idJadwal_lbl.TabIndex = 19;
            this.idJadwal_lbl.Text = "ID Jadwal";
            // 
            // idKereta_lbl
            // 
            this.idKereta_lbl.AutoSize = true;
            this.idKereta_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idKereta_lbl.Location = new System.Drawing.Point(165, 97);
            this.idKereta_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idKereta_lbl.Name = "idKereta_lbl";
            this.idKereta_lbl.Size = new System.Drawing.Size(71, 19);
            this.idKereta_lbl.TabIndex = 33;
            this.idKereta_lbl.Text = "ID Kereta";
            // 
            // dtp_tglBrngkt_txt
            // 
            this.dtp_tglBrngkt_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tglBrngkt_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tglBrngkt_txt.Location = new System.Drawing.Point(334, 129);
            this.dtp_tglBrngkt_txt.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_tglBrngkt_txt.Name = "dtp_tglBrngkt_txt";
            this.dtp_tglBrngkt_txt.Size = new System.Drawing.Size(103, 24);
            this.dtp_tglBrngkt_txt.TabIndex = 35;
            this.dtp_tglBrngkt_txt.Value = new System.DateTime(2025, 5, 21, 15, 42, 0, 0);
            this.dtp_tglBrngkt_txt.ValueChanged += new System.EventHandler(this.dtp_tglBrngkt_txt_ValueChanged);
            // 
            // waktuBrngkt_lbl
            // 
            this.waktuBrngkt_lbl.AutoSize = true;
            this.waktuBrngkt_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktuBrngkt_lbl.Location = new System.Drawing.Point(165, 167);
            this.waktuBrngkt_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waktuBrngkt_lbl.Name = "waktuBrngkt_lbl";
            this.waktuBrngkt_lbl.Size = new System.Drawing.Size(125, 19);
            this.waktuBrngkt_lbl.TabIndex = 36;
            this.waktuBrngkt_lbl.Text = "Waktu Berangkat";
            // 
            // waktuBrngkt_txt
            // 
            this.waktuBrngkt_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktuBrngkt_txt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.waktuBrngkt_txt.Location = new System.Drawing.Point(334, 167);
            this.waktuBrngkt_txt.Margin = new System.Windows.Forms.Padding(4);
            this.waktuBrngkt_txt.Name = "waktuBrngkt_txt";
            this.waktuBrngkt_txt.ShowUpDown = true;
            this.waktuBrngkt_txt.Size = new System.Drawing.Size(103, 24);
            this.waktuBrngkt_txt.TabIndex = 37;
            this.waktuBrngkt_txt.Value = new System.DateTime(2025, 5, 21, 15, 42, 0, 0);
            this.waktuBrngkt_txt.ValueChanged += new System.EventHandler(this.waktuBrngkt_txt_ValueChanged);
            // 
            // waktuTiba_lbl
            // 
            this.waktuTiba_lbl.AutoSize = true;
            this.waktuTiba_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktuTiba_lbl.Location = new System.Drawing.Point(165, 203);
            this.waktuTiba_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waktuTiba_lbl.Name = "waktuTiba_lbl";
            this.waktuTiba_lbl.Size = new System.Drawing.Size(85, 19);
            this.waktuTiba_lbl.TabIndex = 38;
            this.waktuTiba_lbl.Text = "Waktu Tiba";
            this.waktuTiba_lbl.Click += new System.EventHandler(this.waktuTiba_lbl_Click);
            // 
            // waktuTiba_txt
            // 
            this.waktuTiba_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktuTiba_txt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.waktuTiba_txt.Location = new System.Drawing.Point(334, 203);
            this.waktuTiba_txt.Margin = new System.Windows.Forms.Padding(4);
            this.waktuTiba_txt.Name = "waktuTiba_txt";
            this.waktuTiba_txt.ShowUpDown = true;
            this.waktuTiba_txt.Size = new System.Drawing.Size(103, 24);
            this.waktuTiba_txt.TabIndex = 39;
            this.waktuTiba_txt.Value = new System.DateTime(2025, 5, 21, 15, 42, 0, 0);
            this.waktuTiba_txt.ValueChanged += new System.EventHandler(this.waktuTiba_txt_ValueChanged);
            // 
            // jadwal_dgv
            // 
            this.jadwal_dgv.AllowUserToOrderColumns = true;
            this.jadwal_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.jadwal_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.jadwal_dgv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.jadwal_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jadwal_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_stasiun,
            this.id_kereta,
            this.tanggal_berangkat,
            this.waktu_berangkat,
            this.waktu_tiba,
            this.stasiun_asal,
            this.stasiun_tujuan});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jadwal_dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.jadwal_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jadwal_dgv.GridColor = System.Drawing.Color.Black;
            this.jadwal_dgv.Location = new System.Drawing.Point(0, 420);
            this.jadwal_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.jadwal_dgv.Name = "jadwal_dgv";
            this.jadwal_dgv.RowHeadersWidth = 62;
            this.jadwal_dgv.Size = new System.Drawing.Size(717, 198);
            this.jadwal_dgv.TabIndex = 40;
            this.jadwal_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jadwal_dgv_CellClick);
            this.jadwal_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jadwal_dgv_CellContentClick);
            // 
            // id_stasiun
            // 
            this.id_stasiun.DataPropertyName = "id_jadwal";
            this.id_stasiun.HeaderText = "ID Jadwal";
            this.id_stasiun.MinimumWidth = 8;
            this.id_stasiun.Name = "id_stasiun";
            this.id_stasiun.Width = 76;
            // 
            // id_kereta
            // 
            this.id_kereta.DataPropertyName = "id_kereta";
            this.id_kereta.HeaderText = "ID Kereta";
            this.id_kereta.MinimumWidth = 8;
            this.id_kereta.Name = "id_kereta";
            this.id_kereta.Width = 74;
            // 
            // tanggal_berangkat
            // 
            this.tanggal_berangkat.DataPropertyName = "tanggal_berangkat";
            this.tanggal_berangkat.HeaderText = "Tanggal Berangkat";
            this.tanggal_berangkat.MinimumWidth = 8;
            this.tanggal_berangkat.Name = "tanggal_berangkat";
            this.tanggal_berangkat.Width = 120;
            // 
            // waktu_berangkat
            // 
            this.waktu_berangkat.DataPropertyName = "waktu_berangkat";
            this.waktu_berangkat.HeaderText = "Waktu Berangkat";
            this.waktu_berangkat.MinimumWidth = 8;
            this.waktu_berangkat.Name = "waktu_berangkat";
            this.waktu_berangkat.Width = 113;
            // 
            // waktu_tiba
            // 
            this.waktu_tiba.DataPropertyName = "waktu_tiba";
            this.waktu_tiba.HeaderText = "Waktu Tiba";
            this.waktu_tiba.MinimumWidth = 8;
            this.waktu_tiba.Name = "waktu_tiba";
            this.waktu_tiba.Width = 85;
            // 
            // stasiun_asal
            // 
            this.stasiun_asal.DataPropertyName = "stasiun_asal";
            this.stasiun_asal.HeaderText = "Stasiun Asal";
            this.stasiun_asal.MinimumWidth = 8;
            this.stasiun_asal.Name = "stasiun_asal";
            this.stasiun_asal.Width = 88;
            // 
            // stasiun_tujuan
            // 
            this.stasiun_tujuan.DataPropertyName = "stasiun_tujuan";
            this.stasiun_tujuan.HeaderText = "Stasiun Tujuan";
            this.stasiun_tujuan.MinimumWidth = 8;
            this.stasiun_tujuan.Name = "stasiun_tujuan";
            this.stasiun_tujuan.Width = 101;
            // 
            // idJadwal_txt
            // 
            this.idJadwal_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.idJadwal_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idJadwal_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.idJadwal_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idJadwal_txt.ForeColor = System.Drawing.Color.Black;
            this.idJadwal_txt.Location = new System.Drawing.Point(334, 63);
            this.idJadwal_txt.Margin = new System.Windows.Forms.Padding(4);
            this.idJadwal_txt.Name = "idJadwal_txt";
            this.idJadwal_txt.ReadOnly = true;
            this.idJadwal_txt.Size = new System.Drawing.Size(78, 17);
            this.idJadwal_txt.TabIndex = 42;
            this.idJadwal_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idJadwal_txt.TextChanged += new System.EventHandler(this.idJadwal_txt_TextChanged);
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(146, 391);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(405, 21);
            this.cari_txt.TabIndex = 43;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // kereta_cmb
            // 
            this.kereta_cmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kereta_cmb.FormattingEnabled = true;
            this.kereta_cmb.Location = new System.Drawing.Point(334, 97);
            this.kereta_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.kereta_cmb.Name = "kereta_cmb";
            this.kereta_cmb.Size = new System.Drawing.Size(103, 27);
            this.kereta_cmb.TabIndex = 44;
            this.kereta_cmb.SelectedIndexChanged += new System.EventHandler(this.kereta_cmb_SelectedIndexChanged);
            // 
            // stasiunAsal_cmb
            // 
            this.stasiunAsal_cmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stasiunAsal_cmb.FormattingEnabled = true;
            this.stasiunAsal_cmb.Location = new System.Drawing.Point(334, 247);
            this.stasiunAsal_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.stasiunAsal_cmb.Name = "stasiunAsal_cmb";
            this.stasiunAsal_cmb.Size = new System.Drawing.Size(103, 27);
            this.stasiunAsal_cmb.TabIndex = 45;
            this.stasiunAsal_cmb.SelectedIndexChanged += new System.EventHandler(this.stasiunAsal_cmb_SelectedIndexChanged);
            // 
            // stasiunTujuan_cmb
            // 
            this.stasiunTujuan_cmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stasiunTujuan_cmb.FormattingEnabled = true;
            this.stasiunTujuan_cmb.Location = new System.Drawing.Point(334, 292);
            this.stasiunTujuan_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.stasiunTujuan_cmb.Name = "stasiunTujuan_cmb";
            this.stasiunTujuan_cmb.Size = new System.Drawing.Size(103, 27);
            this.stasiunTujuan_cmb.TabIndex = 46;
            this.stasiunTujuan_cmb.SelectedIndexChanged += new System.EventHandler(this.stasiunTujuan_cmb_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 36);
            this.panel1.TabIndex = 47;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM JADWAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // formjadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(717, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stasiunTujuan_cmb);
            this.Controls.Add(this.stasiunAsal_cmb);
            this.Controls.Add(this.kereta_cmb);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.idJadwal_txt);
            this.Controls.Add(this.jadwal_dgv);
            this.Controls.Add(this.waktuTiba_txt);
            this.Controls.Add(this.waktuTiba_lbl);
            this.Controls.Add(this.waktuBrngkt_txt);
            this.Controls.Add(this.waktuBrngkt_lbl);
            this.Controls.Add(this.dtp_tglBrngkt_txt);
            this.Controls.Add(this.idKereta_lbl);
            this.Controls.Add(this.cari_btn);
            this.Controls.Add(this.bersihkan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.tambah_btn);
            this.Controls.Add(this.cekid);
            this.Controls.Add(this.stasiunTujuan_lbl);
            this.Controls.Add(this.stasiunAsal_lbl);
            this.Controls.Add(this.tglBrngkt_lbl);
            this.Controls.Add(this.idJadwal_lbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formjadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formjadwal";
            this.Load += new System.EventHandler(this.formjadwal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.jadwal_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cari_btn;
        private System.Windows.Forms.Button bersihkan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.Button cekid;
        private System.Windows.Forms.Label stasiunTujuan_lbl;
        private System.Windows.Forms.Label stasiunAsal_lbl;
        private System.Windows.Forms.Label tglBrngkt_lbl;
        private System.Windows.Forms.Label idJadwal_lbl;
        private System.Windows.Forms.Label idKereta_lbl;
        private System.Windows.Forms.DateTimePicker dtp_tglBrngkt_txt;
        private System.Windows.Forms.Label waktuBrngkt_lbl;
        private System.Windows.Forms.DateTimePicker waktuBrngkt_txt;
        private System.Windows.Forms.Label waktuTiba_lbl;
        private System.Windows.Forms.DateTimePicker waktuTiba_txt;
        private System.Windows.Forms.DataGridView jadwal_dgv;
        private System.Windows.Forms.TextBox idJadwal_txt;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.ComboBox kereta_cmb;
        private System.Windows.Forms.ComboBox stasiunAsal_cmb;
        private System.Windows.Forms.ComboBox stasiunTujuan_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stasiun;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kereta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_berangkat;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_berangkat;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_tiba;
        private System.Windows.Forms.DataGridViewTextBoxColumn stasiun_asal;
        private System.Windows.Forms.DataGridViewTextBoxColumn stasiun_tujuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}