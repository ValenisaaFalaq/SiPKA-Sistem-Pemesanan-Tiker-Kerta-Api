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
    public partial class Register_frm: Form
    {
        register_cls register = new register_cls();
        public Register_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (email_txt.Text == "" || password_txt.Text == "" || nama_txt.Text == "" || username_txt.Text == "")
            {
                MessageBox.Show("Semua kolom wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            register.email = email_txt.Text;
            register.password = password_txt.Text;
            register.nama = nama_txt.Text;
            register.username = username_txt.Text;
            //register.role = "user";

            if (register.daftar())
            {
                MessageBox.Show("Registrasi berhasil. Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_frm login = new Login_frm();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registrasi gagal. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin akan keluar dari aplikasi?",
               "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
