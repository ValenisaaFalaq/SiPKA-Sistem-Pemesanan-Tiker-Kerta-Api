using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIPKA.view;
using System.Windows.Forms;
using SIPKA.model;

namespace SIPKA.view
{
    public partial class formstasiun : Form
    {
        stasiun_cls stasiun = new stasiun_cls(); 

        public formstasiun()
        {
            InitializeComponent();
            this.Load += new EventHandler(stasiun_load);
            stasiunview_grid.CellContentClick += stasiunview_grid_CellContentClick;
            stasiunview_grid.CellClick += stasiunview_grid_CellClick;

        }

        private void stasiun_load(object sender, EventArgs e)
        {
            tampilGrid();
            tampilkanData();
            txtIdStasiun.Text = stasiun.buatKode();
        }

        private void stasiunview_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = stasiunview_grid.Rows[e.RowIndex];
                txtIdStasiun.Text = stasiunview_grid.Rows[e.RowIndex].Cells["id_stasiun"].Value.ToString();
                txtNamaStasiun.Text = stasiunview_grid.Rows[e.RowIndex].Cells["nama_stasiun"].Value.ToString();
                txtKota.Text = stasiunview_grid.Rows[e.RowIndex].Cells["kota"].Value.ToString();
                txtkode.Text = stasiunview_grid.Rows[e.RowIndex].Cells["kode_stasiun"].Value.ToString();
                stasiunview_grid.DataSource = stasiun.tampilSemua();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdStasiun_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaStasiun_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            stasiunview_grid.DataSource = stasiun.tampilPencarian(txtCari.Text);
        }

        private void cari_btn_Click(object sender, EventArgs e)
        {

        }

        private void cekid_Click(object sender, EventArgs e)
        {
            if (stasiun.cekID(txtIdStasiun.Text))
            {
                MessageBox.Show("ID sudah terdaftar.", "CEK ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID tersedia.", "CEK ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (!stasiun.cekID(txtIdStasiun.Text))
            {
                stasiun.IdStasiun = stasiun.buatKode();
                //stasiun.IdStasiun = txtIdStasiun.Text;
                stasiun.NamaStasiun = txtNamaStasiun.Text;
                stasiun.Kota = txtKota.Text;
                stasiun.KodeStasiun = txtkode.Text;

                if (stasiun.simpan())
                {
                    MessageBox.Show("Data berhasil disimpan.", "SIMPAN DATA",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampilGrid();
                    txtIdStasiun.Text = stasiun.buatKode();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.", "SIMPAN DATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID sudah terdaftar.", "SIMPAN DATA",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (stasiun.cekID(txtIdStasiun.Text))
            {
                if (MessageBox.Show("Apakah anda yakin data akan diubah?", "UBAH DATA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    stasiun.NamaStasiun = txtNamaStasiun.Text;
                    stasiun.Kota = txtKota.Text;
                    stasiun.KodeStasiun = txtkode.Text;

                    if (stasiun.ubah(txtIdStasiun.Text))
                    {
                        MessageBox.Show("Data berhasil diubah.", "UBAH DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah.", "UBAH DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            int idStasiun;
            if (int.TryParse(txtIdStasiun.Text, out idStasiun))
            {
                if (MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (stasiun.hapus(idStasiun))
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

        private void tampilGrid()
        {
            if (txtCari.Text.Length == 0)
            {
                tampilkanData();       
            }
            else
            {
                stasiunview_grid.DataSource = stasiun.tampilPencarian(txtCari.Text);
            }
           
        }

        private void bersihkan_btn_Click(object sender, EventArgs e)
        {
            kosongkan();
        }
        private void tampilkanData()
        {
            stasiunview_grid.DataSource = stasiun.tampilSemua();
        }

        private void kosongkan()
        {
            txtIdStasiun.Clear();
            txtNamaStasiun.Clear();
            txtKota.Clear();
            txtkode.Clear();
        }

        private void stasiunview_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = stasiunview_grid.Rows[e.RowIndex];
                txtIdStasiun.Text = row.Cells[0].Value.ToString();
                txtNamaStasiun.Text = row.Cells[1].Value.ToString();
                txtKota.Text = row.Cells[2].Value.ToString();
                txtkode.Text = row.Cells[3].Value.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
