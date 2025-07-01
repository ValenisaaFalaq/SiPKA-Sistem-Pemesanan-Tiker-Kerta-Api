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
    public partial class user: Form
    {
        user_cls User = new user_cls();
        private object row;
        public user()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrWhiteSpace(id_txt.Text) ||
        string.IsNullOrWhiteSpace(nama_txt.Text) ||
        string.IsNullOrWhiteSpace(email_txt.Text) ||
        string.IsNullOrWhiteSpace(username_txt.Text) ||
        string.IsNullOrWhiteSpace(password_txt.Text))
            {
                MessageBox.Show("Data belum lengkap. Harap isi semua kolom.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!User.cekID(id_txt.Text))
            {
                User.ID_User = User.buatKode();
                User.ID_User = id_txt.Text;
                User.Email_User = email_txt.Text;
                User.Password_User = password_txt.Text;
                User.Nama_User = nama_txt.Text;
                User.Username_User = username_txt.Text;
                
                
                if (User.create() == true)
                {
                    MessageBox.Show("Data berhasil disimpan.", "SIMPAN DATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //bersihkan();
                    //nik_txt.Focus();
                    tampilGrid(); // method data grid view agar saat menyimpan data baru tetap tampil
                    id_txt.Text = User.buatKode();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.", "SIMPAN DATA",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id_txt.Focus();
                }
            }
            else
            {
                MessageBox.Show("ID sudah terdaftar.", "SIMPAN DATA",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void tampilGrid()
        {
            //jurusan_dgv.DataSource = jurusan.tampilsemua();
            //belangBelang(jurusan_dgv);
            if (cariuser_txt.Text.Length == 0)
            {
                cariuser_dgv.DataSource = User.tampilSemua();
                MessageBox.Show("Baris: " + ((DataTable)cariuser_dgv.DataSource).Rows.Count.ToString());

            }
            else
            {
                cariuser_dgv.DataSource = User.tampilPencarian(cariuser_txt.Text);
            }
            //belangBelang(caridata_dgv);
        }

        private void id_btn_Click(object sender, EventArgs e)
        {
            if (User.cekID(id_txt.Text))
            {
                MessageBox.Show("ID Sudah ada");
            }
            else
            {
                MessageBox.Show("ID Tidak tersedia.");
            }
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            if (id_txt.Text.Length == 2)
            {
                nama_txt.Text = User.ambilNamaUser(id_txt.Text);
            }
            else
            {
                nama_txt.Clear();

            }
        }

        private void cariuser_txt_TextChanged(object sender, EventArgs e)
        {
            {
                cariuser_dgv.DataSource = User.tampilPencarian(cariuser_txt.Text);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            {
                if (User.cekID(id_txt.Text))
                {
                    if (MessageBox.Show("Apakah anda yakin data akan dihapus?", "HAPUS DATA",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //jurusan.Nama_Jurusan = nama_txt.Text;
                        if (User.delete(id_txt.Text) == true)
                        {
                            MessageBox.Show("Data berhasil dihapus.", "HAPUS DATA",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //bersihkan();
                            //id_txt.Focus();
                            tampilGrid();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal dihapus.", "HAPUS DATA",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            id_txt.Focus();
                        }
                    }
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
                if (User.cekID(id_txt.Text))
                {
                    User.Nama_User = nama_txt.Text.ToString();
                    User.Email_User = email_txt.Text.ToString();
                    User.Username_User = username_txt.Text.ToString();
                    User.Password_User = password_txt.Text.ToString();

                if (User.update(id_txt.Text))
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

        private void cariuser_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {
            tampilGrid();
            id_txt.Text = User.buatKode();
            id_txt.ReadOnly = true;       // Tidak bisa diketik
            id_txt.TabStop = false;       // Lewat saat tekan Tab
            id_txt.Enabled = false;       // Tidak bisa diklik sama sekali (opsional)

        }

        private void cariuser_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < cariuser_dgv.Rows.Count)
            {
                DataGridViewRow row = cariuser_dgv.Rows[e.RowIndex];

                // Pastikan kolom sesuai dengan data di DataGridView
                id_txt.Text = row.Cells[0].Value.ToString();
                email_txt.Text = row.Cells[1].Value.ToString();
                password_txt.Text = row.Cells[2].Value.ToString();
                nama_txt.Text = row.Cells[3].Value.ToString();
                username_txt.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void cariuser_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            {
                // Kosongkan semua input (kecuali id, karena kita isi otomatis)
                nama_txt.Clear();
                email_txt.Clear();
                username_txt.Clear();
                password_txt.Clear();

                // Buat ID baru dan tampilkan di id_txt
                id_txt.Text = User.buatKode();

                // Fokuskan ke input pertama (nama)
                nama_txt.Focus();
            }
        }
    }
}
