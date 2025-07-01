using SIPKA.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SIPKA.view
{
    using model;
    public partial class penumpang : Form
    {
        penumpang_cls Penumpang = new penumpang_cls();

        public penumpang()
        {
            InitializeComponent();
            this.Load += new EventHandler(penumpang_Load);

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            // Validasi: pastikan semua kolom sudah diisi
            if (string.IsNullOrWhiteSpace(nik_txt.Text) ||
                string.IsNullOrWhiteSpace(nama_txt.Text) ||
                string.IsNullOrWhiteSpace(email_txt.Text) ||
                string.IsNullOrWhiteSpace(notelp_txt.Text) ||
                string.IsNullOrWhiteSpace(alamat_txt.Text) ||
                (!laki_rbn.Checked && !perempuan_rbn.Checked))
            {
                MessageBox.Show("Data belum lengkap. Harap isi semua kolom.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Penumpang.cekID(nik_txt.Text))
            {
                Penumpang.ID_Penumpang = nik_txt.Text;
                Penumpang.Nama_Penumpang = nama_txt.Text;
                Penumpang.NoTelepon_Penumpang = notelp_txt.Text;
                Penumpang.Email_Penumpang = email_txt.Text;
                Penumpang.Tanggallahir_Penumpang = tanggal_dtp.Value.ToString("yyyy-MM-dd");

                // Radiobutton cek jenis kelamin
                Penumpang.Jeniskelamin_Penumpang = laki_rbn.Checked ? "L" : "P";

                Penumpang.Alamat_Penumpang = alamat_txt.Text;

                if (Penumpang.create())
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

        private void penumpang_Load(object sender, EventArgs e)
        {
            caridata_dgv.DataSource = Penumpang.tampilSemua();

            //Penumpang.tampilSemua();
            nik_txt.Text = Penumpang.buatKode();
            nik_txt.ReadOnly = true;
            nik_txt.TabStop = false;
            nik_txt.Enabled = false;
        }

        void tampilGrid()
        {
            if (carinama_txt.Text.Length == 0)
            {
                caridata_dgv.DataSource = Penumpang.tampilSemua();
            }
           
              caridata_dgv.DataSource = Penumpang.tampilPencarian(carinama_txt.Text);
         
        }

        private void btnViewPenumpang_Click(object sender, EventArgs e)
        {
            //penumpang form = new penumpang();
            //form.ShowDialog();
        }

        private void nik_txt_TextChanged(object sender, EventArgs e)
        {
            if (nik_txt.Text.Length == 2)
            {
                nama_txt.Text = Penumpang.ambilNamaPenumpang(nik_txt.Text);
            }
            else
            {
                nama_txt.Clear();
            }
        }

        private void caridata_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.caridata_dgv.Rows[e.RowIndex];

                nik_txt.Text = row.Cells["id_penumpang"].Value.ToString();
                nama_txt.Text = row.Cells["nama"].Value.ToString();
                email_txt.Text = row.Cells["email"].Value.ToString();
                notelp_txt.Text = row.Cells["no_telepon"].Value.ToString();
                alamat_txt.Text = row.Cells["alamat"].Value.ToString();
                tanggal_dtp.Value = Convert.ToDateTime(row.Cells["tanggal_lahir"].Value);
                string jk = row.Cells["jenis_kelamin"].Value.ToString();
                if (jk == "L") laki_rbn.Checked = true;
                else if (jk == "P") perempuan_rbn.Checked = true;
            }
        }

        private void carinama_txt_TextChanged(object sender, EventArgs e)
        {
            caridata_dgv.DataSource = Penumpang.tampilPencarian(carinama_txt.Text);
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (Penumpang.cekID(nik_txt.Text))
            {
                if (MessageBox.Show("Apakah anda yakin data akan dihapus?", "HAPUS DATA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Penumpang.delete(nik_txt.Text))
                    {
                        MessageBox.Show("Data berhasil dihapus.", "HAPUS DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus.", "HAPUS DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nik_txt.Focus();
                    }
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (Penumpang.cekID(nik_txt.Text))
            {
                Penumpang.Nama_Penumpang = nama_txt.Text;
                Penumpang.NoTelepon_Penumpang = notelp_txt.Text;
                Penumpang.Email_Penumpang = email_txt.Text;
                Penumpang.Tanggallahir_Penumpang = tanggal_dtp.Value.ToString("yyyy-MM-dd");
                Penumpang.Jeniskelamin_Penumpang = laki_rbn.Checked ? "L" : "P";
                Penumpang.Alamat_Penumpang = alamat_txt.Text;

                if (Penumpang.update(nik_txt.Text))
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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            nama_txt.Clear();
            notelp_txt.Clear();
            email_txt.Clear();
            alamat_txt.Clear();
            tanggal_dtp.Value = DateTime.Now;
            nik_txt.Text = Penumpang.buatKode();
            nama_txt.Focus();
        }

        private void caridata_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
