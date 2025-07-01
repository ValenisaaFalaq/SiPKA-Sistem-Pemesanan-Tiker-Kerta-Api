namespace SIPKA.view
{
    partial class Kereta_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kereta_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kereta_dgv = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJmlhKursi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.cekid_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jumlah_txt = new System.Windows.Forms.TextBox();
            this.kelas_cmb = new System.Windows.Forms.ComboBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kereta_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM KERETA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(77, 36);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "<";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nama Kereta: ";
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(256, 209);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cari_txt.MaxLength = 50;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(167, 20);
            this.cari_txt.TabIndex = 22;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pencarian Data";
            // 
            // kereta_dgv
            // 
            this.kereta_dgv.AllowUserToAddRows = false;
            this.kereta_dgv.AllowUserToDeleteRows = false;
            this.kereta_dgv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kereta_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kereta_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kereta_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNama,
            this.cKelas,
            this.cJmlhKursi});
            this.kereta_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kereta_dgv.Location = new System.Drawing.Point(0, 239);
            this.kereta_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kereta_dgv.Name = "kereta_dgv";
            this.kereta_dgv.ReadOnly = true;
            this.kereta_dgv.RowHeadersWidth = 62;
            this.kereta_dgv.RowTemplate.Height = 28;
            this.kereta_dgv.Size = new System.Drawing.Size(747, 196);
            this.kereta_dgv.TabIndex = 20;
            this.kereta_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kereta_dgv_CellClick);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "id_kereta";
            this.cId.HeaderText = "ID KERETA";
            this.cId.MinimumWidth = 8;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 170;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_kereta";
            this.cNama.HeaderText = "NAMA KERETA";
            this.cNama.MinimumWidth = 8;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 170;
            // 
            // cKelas
            // 
            this.cKelas.DataPropertyName = "kelas_keretta";
            this.cKelas.HeaderText = "KELAS KERETA";
            this.cKelas.MinimumWidth = 8;
            this.cKelas.Name = "cKelas";
            this.cKelas.ReadOnly = true;
            this.cKelas.Width = 170;
            // 
            // cJmlhKursi
            // 
            this.cJmlhKursi.DataPropertyName = "jumlah_kursi";
            this.cJmlhKursi.HeaderText = "JUMLAH KURSI";
            this.cJmlhKursi.MinimumWidth = 8;
            this.cJmlhKursi.Name = "cJmlhKursi";
            this.cJmlhKursi.ReadOnly = true;
            this.cJmlhKursi.Width = 170;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Red;
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hapus_btn.Location = new System.Drawing.Point(595, 115);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(77, 29);
            this.hapus_btn.TabIndex = 19;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.Yellow;
            this.ubah_btn.Location = new System.Drawing.Point(595, 60);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(77, 32);
            this.ubah_btn.TabIndex = 18;
            this.ubah_btn.Text = "Edit";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.simpan_btn.Location = new System.Drawing.Point(499, 115);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(68, 29);
            this.simpan_btn.TabIndex = 17;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Kereta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID Kereta:";
            // 
            // nama_txt
            // 
            this.nama_txt.Location = new System.Drawing.Point(256, 96);
            this.nama_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nama_txt.MaxLength = 50;
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(167, 20);
            this.nama_txt.TabIndex = 14;
            // 
            // cekid_btn
            // 
            this.cekid_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cekid_btn.Location = new System.Drawing.Point(499, 63);
            this.cekid_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cekid_btn.Name = "cekid_btn";
            this.cekid_btn.Size = new System.Drawing.Size(68, 32);
            this.cekid_btn.TabIndex = 13;
            this.cekid_btn.Text = "Cek ID";
            this.cekid_btn.UseVisualStyleBackColor = false;
            this.cekid_btn.Click += new System.EventHandler(this.cekid_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(256, 59);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_txt.MaxLength = 2;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(167, 20);
            this.id_txt.TabIndex = 12;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kelas Kereta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Jumlah Kursi";
            // 
            // jumlah_txt
            // 
            this.jumlah_txt.Location = new System.Drawing.Point(256, 162);
            this.jumlah_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jumlah_txt.MaxLength = 50;
            this.jumlah_txt.Name = "jumlah_txt";
            this.jumlah_txt.Size = new System.Drawing.Size(167, 20);
            this.jumlah_txt.TabIndex = 27;
            // 
            // kelas_cmb
            // 
            this.kelas_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelas_cmb.FormattingEnabled = true;
            this.kelas_cmb.Location = new System.Drawing.Point(257, 129);
            this.kelas_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kelas_cmb.Name = "kelas_cmb";
            this.kelas_cmb.Size = new System.Drawing.Size(167, 21);
            this.kelas_cmb.TabIndex = 43;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_btn.Location = new System.Drawing.Point(552, 162);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(68, 32);
            this.clear_btn.TabIndex = 44;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Kereta_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(747, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.kelas_cmb);
            this.Controls.Add(this.jumlah_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kereta_dgv);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.cekid_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Kereta_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kereta_frm";
            this.Load += new System.EventHandler(this.Kereta_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kereta_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView kereta_dgv;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Button cekid_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox jumlah_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJmlhKursi;
        private System.Windows.Forms.ComboBox kelas_cmb;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}