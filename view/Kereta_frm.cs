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
    public partial class Kereta_frm : Form
    {
        kereta_cls kereta = new kereta_cls();
        public Kereta_frm()
        {
            InitializeComponent();

            id_txt.KeyPress += new KeyPressEventHandler(id_txt_KeyPress);
            jumlah_txt.KeyPress += new KeyPressEventHandler(jumlah_txt_KeyPress);

            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatAppearance.MouseOverBackColor = Color.Transparent; 
            exit_btn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            exit_btn.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            exit_btn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
        }

        private void Kereta_frm_Load(object sender, EventArgs e)
        {
            tampilGrid();
            isiKelasKereta();
            isiIdOtomatis();

            id_txt.ReadOnly = true;

        }

        // Event KeyPress untuk ID Kereta
        private void id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan angka dan tombol backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid
            }
        }

        // Event KeyPress untuk Jumlah Kursi
        private void jumlah_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan angka dan tombol backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid
            }
        }

        private void cekid_btn_Click(object sender, EventArgs e)
        {
            int idKereta;
            if (int.TryParse(id_txt.Text, out idKereta))
            {
                if (kereta.cekid(idKereta))
                {
                    MessageBox.Show("ID sudah ada");
                }
                else
                {
                    MessageBox.Show("ID tidak ada");
                }
            }
            else
            {
                MessageBox.Show("ID harus berupa angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            int idKereta;
            int jumlahKursi;
            if (int.TryParse(id_txt.Text, out idKereta) && int.TryParse(jumlah_txt.Text, out jumlahKursi))
            {
                // Cek apakah ID sudah ada di database
                if (!kereta.cekid(idKereta))
                {
                    kereta.id_kereta = idKereta;
                    kereta.nama_kereta = nama_txt.Text;
                    kereta.kelas_keretta = kelas_cmb.SelectedItem.ToString();
                    kereta.jumlah_kursi = jumlahKursi;

                    if (kereta.simpan())
                    {
                        MessageBox.Show("Data berhasil disimpan", "SIMPAN DATAA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        id_txt.Focus();
                        tampilGrid();
                        isiIdOtomatis();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data", "SIMPAN DATAA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        id_txt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ID sudah ada", "SIMPAN DATAA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Kereta dan Jumlah Kursi harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            // Validasi ID Kereta dan Jumlah Kursi harus berupa angka
            int idKereta;
            int jumlahKursi;
            if (int.TryParse(id_txt.Text, out idKereta) && int.TryParse(jumlah_txt.Text, out jumlahKursi))
            {
                if (MessageBox.Show("Yakin nih diubah?", "UBAH DATAA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kereta.id_kereta = idKereta;
                    kereta.nama_kereta = nama_txt.Text;
                    kereta.kelas_keretta = kelas_cmb.SelectedItem.ToString();
                    kereta.jumlah_kursi = jumlahKursi;

                    if (kereta.cekid(idKereta))
                    {
                        if (kereta.ubah(idKereta))  // Mengirim ID sebagai integer
                        {
                            MessageBox.Show("Data berhasil diubah", "UBAH DATAA",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bersihkan();
                            id_txt.Focus();
                            tampilGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah", "UBAH DATAA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        id_txt.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID Kereta dan Jumlah Kursi harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bersihkan()
        {
            //id_txt.Clear();
            nama_txt.Clear();
            kelas_cmb.SelectedIndex = -1;
            jumlah_txt.Clear();
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            int idKereta;

            if (int.TryParse(id_txt.Text, out idKereta))
            {
                if (MessageBox.Show("Yakin nih HAPUS?", "HAPUS DATAA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kereta.id_kereta = idKereta;

                    if (kereta.hapus(idKereta))  // Mengirim ID sebagai integer
                    {
                        MessageBox.Show("Data berhasil dihapus", "HAPUS DATAA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        id_txt.Focus();
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus", "HAPUS DATAA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        id_txt.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID Kereta harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                kereta_dgv.DataSource = kereta.tampilSemua();
            }
            kereta_dgv.DataSource = kereta.cari(cari_txt.Text);
            belang(kereta_dgv);
        }  

        private void kereta_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.kereta_dgv.Rows[e.RowIndex];
                id_txt.Text = baris.Cells[0].Value.ToString();
            }
        }

        void belang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void isiKelasKereta()
        {
            DataTable data = kereta.ambilDataKelas();
            kelas_cmb.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                kelas_cmb.Items.Add(row["kelas_keretta"].ToString());
            }

            kelas_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(id_txt.Text, out id))
            {
                nama_txt.Text = kereta.ambilNamaKereta(id);
                string kelas = kereta.ambilKelasKereta(id);

                if (!kelas_cmb.Items.Contains(kelas))
                {
                    kelas_cmb.Items.Add(kelas);
                }
                kelas_cmb.SelectedItem = kelas;

                jumlah_txt.Text = kereta.ambiljumlahKursi(id).ToString();
            }
            else
            {
                nama_txt.Clear();
                kelas_cmb.SelectedIndex = -1;
                jumlah_txt.Clear();
            }
        }

        private void isiIdOtomatis()
        {
            int idBaru = kereta.ambilIdTerakhir() + 1;
            id_txt.Text = idBaru.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            isiIdOtomatis();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
