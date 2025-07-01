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
    public partial class formjadwal: Form
    {
        jadwal_cls jadwal = new jadwal_cls();
        ConnectDB_cls db = new ConnectDB_cls(); 


        public formjadwal()
        {
            InitializeComponent();
            this.Load += new EventHandler(formjadwal_Load);
            jadwal_dgv.CellContentClick += jadwal_dgv_CellContentClick;
            jadwal_dgv.CellClick += jadwal_dgv_CellClick;
        }

        private void formjadwal_Load(object sender, EventArgs e)
        {
            tampilGrid();
            idJadwal_txt.Text = jadwal.buatKode();
            kereta_cmb.DataSource = db.eksekusiQuery("SELECT DISTINCT id_kereta, nama_kereta FROM kereta");
            kereta_cmb.DisplayMember = "nama_kereta";
            kereta_cmb.ValueMember = "id_kereta";

            stasiunAsal_cmb.DataSource = db.eksekusiQuery("SELECT id_stasiun, nama_stasiun FROM stasiun");
            stasiunAsal_cmb.DisplayMember = "nama_stasiun";
            stasiunAsal_cmb.ValueMember = "id_stasiun";

            stasiunTujuan_cmb.DataSource = db.eksekusiQuery("SELECT id_stasiun, nama_stasiun FROM stasiun");
            stasiunTujuan_cmb.DisplayMember = "nama_stasiun";
            stasiunTujuan_cmb.ValueMember = "id_stasiun";

         

            //idJadwal_txt.Enabled = false;
            idJadwal_txt.ReadOnly = true;

        }

        private void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
                jadwal_dgv.DataSource = jadwal.tampilSemua();
            else
                jadwal_dgv.DataSource = jadwal.tampilPencarian(cari_txt.Text);
        }

        private void waktuTiba_lbl_Click(object sender, EventArgs e)
        {

        }

        private void jadwal_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > - 1)
            {
                DataGridViewRow row = jadwal_dgv.Rows[e.RowIndex];

                idJadwal_txt.Text = row.Cells[0].Value.ToString();
         
                kereta_cmb.SelectedValue = Convert.ToInt32(row.Cells["id_kereta"].Value);
                dtp_tglBrngkt_txt.Value = Convert.ToDateTime(row.Cells["tanggal_berangkat"].Value);

                
                waktuBrngkt_txt.Value = DateTime.Today.Add((TimeSpan)row.Cells["waktu_berangkat"].Value);
                waktuTiba_txt.Value = DateTime.Today.Add((TimeSpan)row.Cells["waktu_tiba"].Value);

                stasiunAsal_cmb.SelectedValue = Convert.ToInt32(row.Cells["id_stasiun_asal"].Value);
                stasiunTujuan_cmb.SelectedValue = Convert.ToInt32(row.Cells["id_stasiun_tujuan"].Value);
            }
        }
         
        private void jadwal_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtp_tglBrngkt_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void waktuBrngkt_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void waktuTiba_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stasiunAsal_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void stasiunTujuan_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            int idJadwal;
            if (int.TryParse(idJadwal_txt.Text, out idJadwal))
            {
                jadwal.IdJadwal = Convert.ToInt32(idJadwal_txt.Text);
                jadwal.IdKereta = Convert.ToInt32(kereta_cmb.SelectedValue);
                jadwal.TanggalBerangkat = dtp_tglBrngkt_txt.Value;
                jadwal.WaktuBerangkat = waktuBrngkt_txt.Value.TimeOfDay;
                jadwal.WaktuTiba = waktuTiba_txt.Value.TimeOfDay;
                jadwal.StasiunAsal = Convert.ToInt32(stasiunAsal_cmb.SelectedValue);
                jadwal.StasiunTujuan = Convert.ToInt32(stasiunTujuan_cmb.SelectedValue);

                if (jadwal.simpan())
                {
                    MessageBox.Show("Data berhasil disimpan.");
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.");
                }
            }
            else
            {
                MessageBox.Show("ID sudah terdaftar.");
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            int idJadwal;
            if (int.TryParse(idJadwal_txt.Text, out idJadwal))
            {
                jadwal.IdKereta = Convert.ToInt32(kereta_cmb.SelectedValue);
                jadwal.TanggalBerangkat = dtp_tglBrngkt_txt.Value;
                jadwal.WaktuBerangkat = waktuBrngkt_txt.Value.TimeOfDay;
                jadwal.WaktuTiba = waktuTiba_txt.Value.TimeOfDay;
                jadwal.StasiunAsal = Convert.ToInt32(stasiunAsal_cmb.SelectedValue);
                jadwal.StasiunTujuan = Convert.ToInt32(stasiunTujuan_cmb.SelectedValue);

                if (jadwal.ubah(idJadwal))
                {
                    MessageBox.Show("Data berhasil diubah.");
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Gagal mengubah data.");
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            int idJadwal;

            if (int.TryParse(idJadwal_txt.Text, out idJadwal))
            {
                if (MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (jadwal.hapus(idJadwal))
                    {
                        MessageBox.Show("Data berhasil dihapus.");
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.");
                    }
                }
            }
        }

        private void bersih()
        {
            idJadwal_txt.Clear();
            kereta_cmb.SelectedIndex = -1;
            stasiunAsal_cmb.SelectedIndex = -1;
            stasiunTujuan_cmb.SelectedIndex = -1;
            dtp_tglBrngkt_txt.Value = DateTime.Now;
            waktuBrngkt_txt.Value = DateTime.Now;
            waktuTiba_txt.Value = DateTime.Now;
        }
        private void bersihkan_btn_Click(object sender, EventArgs e)
        {
            bersih();
            idJadwal_txt.Text = jadwal.buatKode();
        }

        private void cari_btn_Click(object sender, EventArgs e)
        {

        }

        private void idKereta_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idJadwal_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void cekid_Click(object sender, EventArgs e)
        {
            int idJadwal;

            if (int.TryParse(idJadwal_txt.Text, out idJadwal))
            {
                MessageBox.Show("ID sudah terdaftar.", "CEK ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID tersedia.", "CEK ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kereta_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
            
            //kereta_cmb.DataSource = db.eksekusiQuery("SELECT id_kereta, nama_kereta FROM kereta");

            
            //kereta_cmb.DisplayMember = "id_kereta";

           
            //kereta_cmb.ValueMember = "id_kereta";
        

        }
        private void isiIdOtomatis()
        {
            int idBaru = jadwal.ambilIdTerakhir() + 1;
            idJadwal_txt.Text = idBaru.ToString();
        }

        private void stasiunAsal_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stasiunTujuan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formjadwal_Load_1(object sender, EventArgs e)
        {

        }

        private void ubah_btn_Move(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
