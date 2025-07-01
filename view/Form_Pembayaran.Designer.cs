namespace SIPKA.view
{
    partial class Form_Pembayaran
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bayar_btn = new System.Windows.Forms.Button();
            this.bayarNanti_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bayar_cmb = new System.Windows.Forms.ComboBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.namaPenumpang_lbl = new System.Windows.Forms.Label();
            this.namaKereta_lbl = new System.Windows.Forms.Label();
            this.tanggal_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.keberangkatan_lbl = new System.Windows.Forms.Label();
            this.tujuan_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.jamKeeberangkatan_lbl = new System.Windows.Forms.Label();
            this.totalHarga_lbl = new System.Windows.Forms.Label();
            this.jumlah_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pesanan_dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesanan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kereta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Penumpang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hari. Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah Tiket";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Harga";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bayar_btn
            // 
            this.bayar_btn.Location = new System.Drawing.Point(72, 354);
            this.bayar_btn.Name = "bayar_btn";
            this.bayar_btn.Size = new System.Drawing.Size(100, 40);
            this.bayar_btn.TabIndex = 7;
            this.bayar_btn.Text = "Lakukan Pembayaran";
            this.bayar_btn.UseVisualStyleBackColor = true;
            this.bayar_btn.Click += new System.EventHandler(this.bayar_btn_Click);
            // 
            // bayarNanti_btn
            // 
            this.bayarNanti_btn.Location = new System.Drawing.Point(196, 354);
            this.bayarNanti_btn.Name = "bayarNanti_btn";
            this.bayarNanti_btn.Size = new System.Drawing.Size(100, 40);
            this.bayarNanti_btn.TabIndex = 8;
            this.bayarNanti_btn.Text = "Bayar Nanti";
            this.bayarNanti_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Metode Pembayaran";
            // 
            // bayar_cmb
            // 
            this.bayar_cmb.FormattingEnabled = true;
            this.bayar_cmb.Location = new System.Drawing.Point(207, 293);
            this.bayar_cmb.Name = "bayar_cmb";
            this.bayar_cmb.Size = new System.Drawing.Size(202, 21);
            this.bayar_cmb.TabIndex = 10;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(319, 354);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(100, 40);
            this.print_btn.TabIndex = 11;
            this.print_btn.Text = "Print Tiket";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // namaPenumpang_lbl
            // 
            this.namaPenumpang_lbl.AutoSize = true;
            this.namaPenumpang_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.namaPenumpang_lbl.Location = new System.Drawing.Point(204, 68);
            this.namaPenumpang_lbl.Name = "namaPenumpang_lbl";
            this.namaPenumpang_lbl.Size = new System.Drawing.Size(0, 13);
            this.namaPenumpang_lbl.TabIndex = 12;
            // 
            // namaKereta_lbl
            // 
            this.namaKereta_lbl.AutoSize = true;
            this.namaKereta_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.namaKereta_lbl.Location = new System.Drawing.Point(204, 98);
            this.namaKereta_lbl.Name = "namaKereta_lbl";
            this.namaKereta_lbl.Size = new System.Drawing.Size(0, 13);
            this.namaKereta_lbl.TabIndex = 13;
            // 
            // tanggal_lbl
            // 
            this.tanggal_lbl.AutoSize = true;
            this.tanggal_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tanggal_lbl.Location = new System.Drawing.Point(204, 126);
            this.tanggal_lbl.Name = "tanggal_lbl";
            this.tanggal_lbl.Size = new System.Drawing.Size(0, 13);
            this.tanggal_lbl.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Keberangkatan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tujuan";
            // 
            // keberangkatan_lbl
            // 
            this.keberangkatan_lbl.AutoSize = true;
            this.keberangkatan_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.keberangkatan_lbl.Location = new System.Drawing.Point(204, 156);
            this.keberangkatan_lbl.Name = "keberangkatan_lbl";
            this.keberangkatan_lbl.Size = new System.Drawing.Size(0, 13);
            this.keberangkatan_lbl.TabIndex = 17;
            // 
            // tujuan_lbl
            // 
            this.tujuan_lbl.AutoSize = true;
            this.tujuan_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tujuan_lbl.Location = new System.Drawing.Point(204, 183);
            this.tujuan_lbl.Name = "tujuan_lbl";
            this.tujuan_lbl.Size = new System.Drawing.Size(0, 13);
            this.tujuan_lbl.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Jam Keberangkatan";
            // 
            // jamKeeberangkatan_lbl
            // 
            this.jamKeeberangkatan_lbl.AutoSize = true;
            this.jamKeeberangkatan_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jamKeeberangkatan_lbl.Location = new System.Drawing.Point(204, 209);
            this.jamKeeberangkatan_lbl.Name = "jamKeeberangkatan_lbl";
            this.jamKeeberangkatan_lbl.Size = new System.Drawing.Size(0, 13);
            this.jamKeeberangkatan_lbl.TabIndex = 21;
            // 
            // totalHarga_lbl
            // 
            this.totalHarga_lbl.AutoSize = true;
            this.totalHarga_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalHarga_lbl.Location = new System.Drawing.Point(204, 235);
            this.totalHarga_lbl.Name = "totalHarga_lbl";
            this.totalHarga_lbl.Size = new System.Drawing.Size(0, 13);
            this.totalHarga_lbl.TabIndex = 23;
            // 
            // jumlah_lbl
            // 
            this.jumlah_lbl.AutoSize = true;
            this.jumlah_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jumlah_lbl.Location = new System.Drawing.Point(204, 259);
            this.jumlah_lbl.Name = "jumlah_lbl";
            this.jumlah_lbl.Size = new System.Drawing.Size(0, 13);
            this.jumlah_lbl.TabIndex = 24;
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
            this.panel1.Size = new System.Drawing.Size(753, 36);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PEMBAYARAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pesanan_dgv
            // 
            this.pesanan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesanan_dgv.Location = new System.Drawing.Point(442, 68);
            this.pesanan_dgv.Name = "pesanan_dgv";
            this.pesanan_dgv.Size = new System.Drawing.Size(299, 180);
            this.pesanan_dgv.TabIndex = 25;
            this.pesanan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pesanan_dgv_CellClick);
            // 
            // Form_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.pesanan_dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jumlah_lbl);
            this.Controls.Add(this.totalHarga_lbl);
            this.Controls.Add(this.jamKeeberangkatan_lbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tujuan_lbl);
            this.Controls.Add(this.keberangkatan_lbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tanggal_lbl);
            this.Controls.Add(this.namaKereta_lbl);
            this.Controls.Add(this.namaPenumpang_lbl);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.bayar_cmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bayarNanti_btn);
            this.Controls.Add(this.bayar_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Pembayaran";
            this.Load += new System.EventHandler(this.Form_Pembayaran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesanan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bayar_btn;
        private System.Windows.Forms.Button bayarNanti_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox bayar_cmb;
        private System.Windows.Forms.Button print_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label namaPenumpang_lbl;
        private System.Windows.Forms.Label namaKereta_lbl;
        private System.Windows.Forms.Label tanggal_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label keberangkatan_lbl;
        private System.Windows.Forms.Label tujuan_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label jamKeeberangkatan_lbl;
        private System.Windows.Forms.Label totalHarga_lbl;
        private System.Windows.Forms.Label jumlah_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pesanan_dgv;
    }
}