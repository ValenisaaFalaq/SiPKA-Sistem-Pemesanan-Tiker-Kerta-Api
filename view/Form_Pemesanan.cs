using MySqlX.XDevAPI;
using SIPKA.config;
using SIPKA.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIPKA.view
{
    using model;

    public partial class Form_Pemesanan: Form
    {
        AutoCompleteStringCollection autoNama = new AutoCompleteStringCollection();
        ConnectDB_cls db = new ConnectDB_cls();
        pemesanan_cls ps = new pemesanan_cls();
       
        DataTable dtPenumpang;
        string selectedIdJadwal = "";

        Dashboard_frm dashboard;

        public Form_Pemesanan(Dashboard_frm dashboardForm)
        {
            InitializeComponent();
            this.dashboard = dashboardForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NIK_txt.Text) || string.IsNullOrWhiteSpace(namaP_txt.Text))
            {
                MessageBox.Show("NIK dan Nama harus diisi!");
                return;
            }

            if (string.IsNullOrEmpty(selectedIdJadwal))
            {
                MessageBox.Show("Silakan pilih jadwal keberangkatan pada DataGridView.");
                return;
            }

            string id_penumpang = NIK_txt.Text;
            string id_user = "1"; // misalnya default user dulu
            string id_jadwal = selectedIdJadwal;
            string tanggal = tglBrgkt_date.Value.ToString("yyyy-MM-dd");
            int jumlah = (int)numericJumlah.Value;
            string status = "Gagal";

            decimal harga = ps.Harga(selectedIdJadwal); // method kamu sendiri
            decimal total = harga * jumlah;

       
            int idBaru = ps.SimpanPemesanan(id_penumpang, id_user, id_jadwal, tanggal, jumlah, total, status);

            if (idBaru > 0)
            {
                MessageBox.Show("Berhasil pesan tiket!");

                // Buka Form Pembayaran dan kirim id_pemesanan
                Form_Pembayaran frm = new Form_Pembayaran(idBaru.ToString());
                frm.ShowDialog(); // bisa Show() juga kalau mau paralel

                BersihkanForm();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan pemesanan.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanJadwal();
        }

        private void Form_Pemesanan_Load(object sender, EventArgs e)
        {
            // Bersihkan isi combo box saat form pertama kali dibuka
            comboBox1.SelectedIndex = -1;
            tujuan_cmb.SelectedIndex = -1;

            dtPenumpang = db.eksekusiQuery("SELECT id_penumpang, nama FROM penumpang");


            foreach (DataRow row in dtPenumpang.Rows)
            {
                autoNama.Add(row["nama"].ToString());
            }

            namaP_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            namaP_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            namaP_txt.AutoCompleteCustomSource = autoNama;

            comboBox1.DataSource = db.eksekusiQuery("SELECT DISTINCT nama_stasiun FROM stasiun");
            comboBox1.DisplayMember = "nama_stasiun";

            tujuan_cmb.DataSource = db.eksekusiQuery("SELECT DISTINCT nama_stasiun FROM stasiun");
            tujuan_cmb.DisplayMember = "nama_stasiun";

            dataJadwal_grd.CellClick += dataJadwal_grd_CellClick;
        }

        private void TampilkanJadwal()
        {
            if (comboBox1.Text == "" || tujuan_cmb.Text == "")
                return;

            string asal = comboBox1.Text;
            string tujuan = tujuan_cmb.Text;
            string tanggal = tglBrgkt_date.Value.ToString("yyyy-MM-dd");

            
            dataJadwal_grd.DataSource = ps.TampilkanJadwal(asal, tujuan, tanggal);
        }

        private void tujuan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanJadwal();
        }

        private void tglBrgkt_date_ValueChanged(object sender, EventArgs e)
        {
            
           TampilkanJadwal();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NIK_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void namaP_txt_Leave(object sender, EventArgs e)
        {
            string nama = namaP_txt.Text.Trim();
            if (string.IsNullOrEmpty(nama)) return;

            DataRow[] found = dtPenumpang.Select("nama = '" + nama.Replace("'", "''") + "'");
            if (found.Length > 0)
            {
                NIK_txt.Text = found[0]["id_penumpang"].ToString();
            }
            else
            {
                NIK_txt.Text = "";

                DialogResult result = MessageBox.Show(
                    "Nama tidak terdaftar sebagai penumpang. Ingin daftarkan sekarang?",
                    "Penumpang tidak ditemukan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    dashboard.MainPanel.Controls.Clear();
                    penumpang p = new penumpang();
                    p.TopLevel = false;
                    dashboard.MainPanel.Controls.Add(p);
                    p.Show();

                    this.Hide();
                }
            }
        }

        private void namaP_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataJadwal_grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   
            try
            {
                var dgv = dataJadwal_grd;
                var dataRow = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

                comboBox1.Text = dataRow["asal"].ToString();
                tujuan_cmb.Text = dataRow["tujuan"].ToString();
                tglBrgkt_date.Value = Convert.ToDateTime(dataRow["tanggal"]);


                selectedIdJadwal = dataRow["id_jadwal"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ups… {ex.Message}");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BersihkanForm()
        {
            NIK_txt.Clear();
            namaP_txt.Clear();
            tglBrgkt_date.Value = DateTime.Today;
            numericJumlah.Value = 0;
            selectedIdJadwal = null;
            comboBox1.SelectedIndex = -1;
            tujuan_cmb.SelectedIndex = -1;

            // Kalau ada label info jadwal yang ditampilkan, kosongkan juga
            // labelJadwalTerpilih.Text = "";
        }

        private void daftar_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
