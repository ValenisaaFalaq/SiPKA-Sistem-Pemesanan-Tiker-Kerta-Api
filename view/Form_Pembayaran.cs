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
    public partial class Form_Pembayaran : Form
    {
        private int idUser;
        private int idPemesanan = -1;
        ConnectDB_cls db = new ConnectDB_cls();
        pembayaran_cls bayar = new pembayaran_cls();

        public Form_Pembayaran(int id_user)
        {
            InitializeComponent();
            idUser = id_user;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontJudul = new Font("Arial", 14, FontStyle.Bold);
            Font fontBiasa = new Font("Arial", 10);
            int marginLeft = 10;
            int posisiY = 20;

            e.Graphics.DrawString("STRUK PEMESANAN TIKET KERETA", fontJudul, Brushes.Black, marginLeft, posisiY);
            posisiY += 30;
            e.Graphics.DrawString("======================================", fontBiasa, Brushes.Black, marginLeft, posisiY);
            posisiY += 20;

            e.Graphics.DrawString("Nama Penumpang : " + namaPenumpang_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Nama Kereta    : " + namaKereta_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Asal           : " + keberangkatan_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Tujuan         : " + tujuan_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Tanggal Brgkt  : " + tanggal_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Jam Berangkat  : " + jamKeeberangkatan_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Jumlah Tiket   : " + jumlah_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 20;
            e.Graphics.DrawString("Total Harga    : Rp " + totalHarga_lbl.Text, fontBiasa, Brushes.Black, marginLeft, posisiY); posisiY += 30;

            e.Graphics.DrawString("Terima kasih telah memesan!", fontBiasa, Brushes.Black, marginLeft, posisiY);

        }

        private void Form_Pembayaran_Load(object sender, EventArgs e)
        {
            TampilDataGridPesanan();

            // Isi metode pembayaran
            DataTable dtMetode = db.eksekusiQuery("SELECT DISTINCT metode_pembayaran FROM pembayaran");
            bayar_cmb.Items.Clear();
            foreach (DataRow r in dtMetode.Rows)
            {
                bayar_cmb.Items.Add(r[0].ToString());
            }
            if (bayar_cmb.Items.Count > 0) bayar_cmb.SelectedIndex = 0;
        }

        private void bayar_btn_Click(object sender, EventArgs e)
        {
            if (idPemesanan == -1)
            {
                MessageBox.Show("Pilih salah satu pesanan dulu dari tabel.");
                return;
            }

            if (bayar_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih metode pembayaran dulu!");
                return;
            }

            string metode = bayar_cmb.Text;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string jumlah = totalHarga_lbl.Text.Replace("Rp", "").Replace(".", "").Trim();

            string q1 = "INSERT INTO pembayaran (id_pemesanan, metode_pembayaran, tanggal_pembayaran, jumlah_dibayar, status_pembayaran) " +
                        "VALUES ('" + idPemesanan + "', '" + metode + "', '" + today + "', '" + jumlah + "', 'Berhasil')";

            string q2 = "UPDATE pemesanan SET status_pembayaran = 'Berhasil' WHERE id_pemesanan = '" + idPemesanan + "'";

            try
            {
                if (db.eksekusiNonQuery(q1) > 0 && db.eksekusiNonQuery(q2) > 0)
                {
                    MessageBox.Show("Pembayaran sukses!");
                    LoadDataGridPesanan(); // Refresh tabel
                    printDocument1.Print(); // auto cetak struk
                }
                else
                {
                    MessageBox.Show("Pembayaran gagal disimpan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error bayar: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TampilDataGridPesanan()
        {
            DataTable dtPesanan = bayar.GetDataPesananDetailByUser(idUser);
            pesanan_dgv.DataSource = dtPesanan;

            pesanan_dgv.Columns["id_pemesanan"].HeaderText = "ID";
            pesanan_dgv.Columns["nama_penumpang"].HeaderText = "Penumpang";
            pesanan_dgv.Columns["nama_kereta"].HeaderText = "Kereta";
            pesanan_dgv.Columns["tanggal_berangkat"].HeaderText = "Tanggal";
            pesanan_dgv.Columns["total_harga"].HeaderText = "Total";

            pesanan_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pesanan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPemesanan = Convert.ToInt32(pesanan_dgv.Rows[e.RowIndex].Cells["id_pemesanan"].Value);
                DataTable dt = bayar.GetDataPembayaran(idPemesanan);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    namaPenumpang_lbl.Text = row["nama_penumpang"].ToString();
                    namaKereta_lbl.Text = row["nama_kereta"].ToString();
                    keberangkatan_lbl.Text = row["stasiun_asal"].ToString();
                    tujuan_lbl.Text = row["stasiun_tujuan"].ToString();
                    tanggal_lbl.Text = Convert.ToDateTime(row["tanggal_berangkat"]).ToString("dd MMM yyyy");
                    jamKeeberangkatan_lbl.Text = row["waktu_berangkat"].ToString();
                    jumlah_lbl.Text = row["jumlah_tiket"].ToString();
                    totalHarga_lbl.Text = Convert.ToDecimal(row["total_harga"]).ToString("C0");
                }
            }
        }
    }
}
