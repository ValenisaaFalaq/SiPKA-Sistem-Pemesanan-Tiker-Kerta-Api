using MySqlX.XDevAPI.Common;
using SIPKA.config;
using SIPKA.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIPKA.view
{
    using config;
    public partial class Form_RUD_Pemesanan: Form
    {
        pemesanan_cls ps = new pemesanan_cls();
        string selectedIdPemesanan = "";
        string selectedIdJadwal = "";
        ConnectDB_cls db = new ConnectDB_cls();
        public Form_RUD_Pemesanan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form_RUD_Pemesanan_Load(object sender, EventArgs e)
        {
            tampilGrid();

            dataPemesanan_grd.CellClick += dataPemesanan_grd_CellClick;
            dataPemesanan_grd.CellClick += dataJadwal_grd_CellClick;

            comboBox1.DataSource = db.eksekusiQuery("SELECT DISTINCT nama_stasiun FROM stasiun");
            comboBox1.DisplayMember = "nama_stasiun";

            tujuan_cmb.DataSource = db.eksekusiQuery("SELECT DISTINCT nama_stasiun FROM stasiun");
            tujuan_cmb.DisplayMember = "nama_stasiun";

        }
 
        public void dataPemesanan_grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            if (e.RowIndex >= 0) 
                try
                {
                    var dgv = dataPemesanan_grd;
                    var dataRow = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

                    namaP_txt.Text = dataRow["nama"].ToString();
                    comboBox1.Text = dataRow["asal"].ToString();
                    tujuan_cmb.Text = dataRow["tujuan"].ToString();
                    tglBrgkt_date.Value = Convert.ToDateTime(dataRow["tanggal"]);
                    NIK_txt.Text = dataRow["id_penumpang"].ToString();

                    selectedIdPemesanan = dataRow["id_pemesanan"].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ups… {Exception.Message}");
                }
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanJadwal();
        }

        private void tujuan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanJadwal();
        }

        private void tglBrgkt_date_ValueChanged(object sender, EventArgs e)
        {

            TampilkanJadwal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedIdPemesanan))
            {
                MessageBox.Show("Pilih data pemesanan dulu ya!");
                return;
            }
            if (dataJadwal_grd.CurrentRow == null)
            {
                MessageBox.Show("Pilih jadwal dulu ya!");
                return;
            }

            selectedIdJadwal = dataJadwal_grd.CurrentRow.Cells["id_jadwal"].Value.ToString();
            string idPemesanan = selectedIdPemesanan;
            string idJadwal = selectedIdJadwal;
            string tanggal = tglBrgkt_date.Value.ToString("yyyy-MM-dd");
            int jumlah = (int)numericJumlah.Value;
            decimal hargaSatuan = ps.Harga(idJadwal);
            decimal total = hargaSatuan * jumlah;

            bool hasil = ps.UpdatePemesanan(idPemesanan, idJadwal, tanggal, jumlah, total);

            if (hasil)
            {
                MessageBox.Show("Data berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampilGrid();
                KosongkanForm();
            }
            else
            {
                MessageBox.Show("Data tidak bisa diubah. Mungkin status pembayarannya sudah 'Berhasil'.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void refreshDataPemesanan()
        {
            try
            {
                ConnectDB_cls db = new ConnectDB_cls(); // pakai koneksi kamu
                string query = "SELECT * FROM pemesanan"; // bisa dari tabel langsung atau VIEW

                DataTable dt = db.eksekusiQuery(query);
                dataPemesanan_grd.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal refresh data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataJadwal_grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataJadwal_grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) return;
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
                MessageBox.Show("Ups… {Exception.Message}");
            }
        }

        public void tampilGrid()
        {
            if (cariP_txt.Text.Length == 0)
            {
                dataPemesanan_grd.DataSource = ps.tampilSemuaPemesanan();
            }
            else
            {
                dataPemesanan_grd.DataSource = ps.cariPemesanan(cariP_txt.Text);
            }
          
        }

       

        private void delete_cmb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedIdPemesanan))
            {
                MessageBox.Show("Pilih data pemesanan terlebih dahulu.");
                return;
            }

            pemesanan_cls ps = new pemesanan_cls();
            ps.id_pemesanan = selectedIdPemesanan;

            bool berhasil = ps.BatalPemesanan();

            if (berhasil)
            {
                MessageBox.Show("Pemesanan berhasil dibatalkan!");
                tampilGrid(); // fungsi refresh DataGridView
                KosongkanForm();
            }
            else
            {
                MessageBox.Show("Pemesanan tidak bisa dibatalkan. Status bukan 'Gagal'?");
            }
        }

        private void KosongkanForm()
        {
            namaP_txt.Text = "";
            NIK_txt.Text = "";
            

            comboBox1.SelectedIndex = -1;
            tujuan_cmb.SelectedIndex = -1;

            tglBrgkt_date.Value = DateTime.Now;

            numericJumlah.Value = 0;

            dataJadwal_grd.ClearSelection();

            dataPemesanan_grd.ClearSelection();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
