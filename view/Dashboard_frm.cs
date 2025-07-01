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
    

    public partial class Dashboard_frm : Form
    {
       
           private string _role;
           private string _nama;
           private int _id_user;

        public Dashboard_frm(string nama, string role, int id_user)
        {
            InitializeComponent();
            _nama = nama;
            _role = role;
             _id_user = id_user;

            this.Load += Dashboard_frm_Load;
        }

        public Panel MainPanel
        {
            get { return main_panel; }
        }



        private void kereta_btn_Click(object sender, EventArgs e)
        {
            if(!(main_panel.Controls.Count > 0))
            {
                Kereta_frm kereta = new Kereta_frm();
                kereta.TopLevel = false;

                main_panel.Controls.Add(kereta);
                kereta.Show();
            }
        }

        private void stasiun_btn_Click(object sender, EventArgs e)
        {
            if (!(main_panel.Controls.Count > 0))
            {
                formstasiun stasiun = new formstasiun();
                stasiun.TopLevel = false;

                main_panel.Controls.Add(stasiun);
                stasiun.Show();
            }
        }

        private void jadwal_btn_Click(object sender, EventArgs e)
        {
            if (!(main_panel.Controls.Count > 0))
            {
                formjadwal jadwal = new formjadwal();
                jadwal.TopLevel = false;

                main_panel.Controls.Add(jadwal);
                jadwal.Show();
            }
        }

        private void pemesanan_btn_Click(object sender, EventArgs e)
        {
            if (!(main_panel.Controls.Count > 0))
            {
                Form_Pemesanan pemesanan = new Form_Pemesanan(this);
                pemesanan.TopLevel = false;

                main_panel.Controls.Add(pemesanan);
                pemesanan.Show();
            }
        }

        private void pembayaran_btn_Click(object sender, EventArgs e)
        {
            if (!(main_panel.Controls.Count > 0))
            {
                Form_Pembayaran pembayaran = new Form_Pembayaran(_id_user);
                pembayaran.TopLevel = false;

                main_panel.Controls.Add(pembayaran);
                pembayaran.Show();
            }
        }

        private void penumpang_btn_Click(object sender, EventArgs e)
        {
            if (!(main_panel.Controls.Count > 0))
            {
               penumpang penumpang = new penumpang();
               penumpang.TopLevel = false;

               main_panel.Controls.Add(penumpang);
               penumpang.Show();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin akan Logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login_frm login = new Login_frm();
                login.Show();
                this.Close();
            }
        }

        private void Dashboard_frm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat datang, " + _nama + " (" + _role + ")");

            if (_role == "admin")
            {
                kereta_btn.Visible = true;
                stasiun_btn.Visible = true;
                jadwal_btn.Visible = true;
                penumpang_btn.Visible = true;
                pemesanan_btn.Visible = true;
                pembayaran_btn.Visible = true;
            }
            else if (_role == "user")
            {
                kereta_btn.Visible = false;
                stasiun_btn.Visible = false;
                jadwal_btn.Visible = false;

                penumpang_btn.Visible = true;
                pemesanan_btn.Visible = true;
                pembayaran_btn.Visible = true;
            }
        }

     }
 }
 
