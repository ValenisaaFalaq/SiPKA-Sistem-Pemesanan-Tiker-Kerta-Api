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
    public partial class Login_frm: Form
    {
        Login_cls login = new Login_cls();

        public Login_frm()
        {
            InitializeComponent();
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
            email_txt.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login.email = email_txt.Text.Trim();
            login.password = password_txt.Text;

            if (login.cekLogin())
            {
                MessageBox.Show("Selamat datang, " + login.nama + "!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard_frm dashboard = new Dashboard_frm(login.nama, login.role, Convert.ToInt32(login.id_user));
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_txt.Clear();
                email_txt.SelectAll();
                email_txt.Focus();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void daftar_btn_Click(object sender, EventArgs e)
        {
            Register_frm regis = new Register_frm();
            regis.Show();
            this.Hide();
        }

        private void daftar_linktxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_frm regis = new Register_frm();
            regis.Show();
            this.Hide();
        }
    }
}