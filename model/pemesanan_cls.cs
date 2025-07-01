using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks; 
using SIPKA.view;
using System.Data.SqlClient;



namespace SIPKA.model
{
    using config;
    using MySql.Data.MySqlClient;

    class pemesanan_cls
    {
        public string id_pemesanan { get; set; }
        public string id_penumpang { get; set; }
        public string id_user { get; set; }
        public string id_jadwal { get; set; }
        public string tanggal { get; set; }
        public int jumlah { get; set; }
        public decimal total { get; set; }
        public string status { get; set; }
        public string asal { get; set; }
        public string tujuan { get; set; }
        public decimal harga_tiket { get; set; }
        ConnectDB_cls server;
        string Query;
        AutoCompleteStringCollection autoNama = new AutoCompleteStringCollection();


        public pemesanan_cls()
        {
            server = new ConnectDB_cls();
            Query = "";
        }

        //Menampilkan Jadwal kereta
        public DataTable TampilkanJadwal(string asal, string tujuan, string tanggal)
        {
            string query = "SELECT j.id_jadwal, " +
                           "sa.nama_stasiun AS asal, " +
                           "st.nama_stasiun AS tujuan, " +
                           "k.nama_kereta, " +
                           "j.tanggal_berangkat AS tanggal, " +
                           "j.waktu_berangkat, " +
                           "j.waktu_tiba " +
                           "FROM jadwal j " +
                           "JOIN kereta k ON j.id_kereta = k.id_kereta " +
                           "JOIN stasiun sa ON j.id_stasiun_asal = sa.id_stasiun " +
                           "JOIN stasiun st ON j.id_stasiun_tujuan = st.id_stasiun " +
                           "WHERE sa.nama_stasiun = '" + asal + "' " +
                           "AND st.nama_stasiun = '" + tujuan + "' " +
                           "AND j.tanggal_berangkat = '" + tanggal + "'";

            return server.eksekusiQuery(query);
        }

        // Cek apakah id_pemesanan sudah ada di database
        public bool cekID(string id)
        {
            bool cek = false;
            Query = "SELECT * FROM pemesanan WHERE id_pemesanan = '" + id + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }



        // Hapus data pemesanan jika statusnya gagal
        public bool BatalPemesanan()
        {
            bool cek = false;

            Query = "DELETE FROM pemesanan WHERE id_pemesanan = '" + id_pemesanan + "' AND status_pembayaran = 'Gagal'";

            try
            {
                int result = server.eksekusiNonQuery(Query);
                cek = result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return cek;
        }

        //Hitung Total Tiket
        public void HitungTotal()
        {
            try
            {
                
                string query = "SELECT harga_tiket FROM jadwal WHERE id_jadwal = '" + id_jadwal + "'";
                DataTable dt = server.eksekusiQuery(query);

                if (dt.Rows.Count > 0)
                {
                    harga_tiket = Convert.ToDecimal(dt.Rows[0]["harga_tiket"]);
                    total = harga_tiket * jumlah;
                }
                else
                {
                    MessageBox.Show("Jadwal tidak ditemukan. Gagal menghitung total.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghitung total: " + ex.Message);
            }
        }


        //Ngambil Harga dari Pemesanan
        public decimal Harga(string idJadwal)
        {
            decimal harga = 0;
            string query = "SELECT harga_tiket FROM jadwal WHERE id_jadwal = '" + idJadwal + "'";
            DataTable dt = server.eksekusiQuery(query); 

            if (dt.Rows.Count > 0)
            {
                harga = Convert.ToDecimal(dt.Rows[0]["harga_tiket"]); 
            }

            return harga;
        }


        //Menampilkan data untuk di data grid view pemesanan
        public DataTable tampilSemuaPemesanan()
        {
            Query = "SELECT p.id_pemesanan, pn.nama, s1.nama_stasiun AS asal, s2.nama_stasiun AS tujuan, " +
                          "k.nama_kereta, j.tanggal_berangkat AS tanggal, j.waktu_berangkat, j.waktu_tiba, p.id_penumpang " +
                          "FROM pemesanan p " +
                          "JOIN penumpang pn ON p.id_penumpang = pn.id_penumpang " +
                          "JOIN jadwal j ON p.id_jadwal = j.id_jadwal " +
                          "JOIN stasiun s1 ON j.id_stasiun_asal = s1.id_stasiun " +
                          "JOIN stasiun s2 ON j.id_stasiun_tujuan = s2.id_stasiun " +
                          "JOIN kereta k ON j.id_kereta = k.id_kereta";
            
            return server.eksekusiQuery(Query);
        }



        //Cari   
        public DataTable cariPemesanan(string keyword)
        {
            Query = "SELECT p.id_pemesanan, pn.nama, s1.nama_stasiun AS asal, s2.nama_stasiun AS tujuan, " +
                           "k.nama_kereta, j.tanggal_berangkat AS tanggal, j.waktu_berangkat, j.waktu_tiba, p.id_penumpang " +
                           "FROM pemesanan p " +
                           "JOIN penumpang pn ON p.id_penumpang = pn.id_penumpang " +
                           "JOIN jadwal j ON p.id_jadwal = j.id_jadwal " +
                           "JOIN stasiun s1 ON j.id_stasiun_asal = s1.id_stasiun " +
                           "JOIN stasiun s2 ON j.id_stasiun_tujuan = s2.id_stasiun " +
                           "JOIN kereta k ON j.id_kereta = k.id_kereta " +
                           "WHERE pn.nama LIKE '%" + keyword + "%'";
            return server.eksekusiQuery(Query);
        }

  
        //Simpan Pemesanan
        public int SimpanPemesanan(string id_penumpang, string id_user, string id_jadwal, string tanggal, int jumlah, decimal total, string status)
        {
            int lastId = 0;

            // gabungkan query INSERT dan SELECT
            string insertQuery = "INSERT INTO pemesanan (id_penumpang, id_user, id_jadwal, tanggal_pemesanan, jumlah_tiket, total_harga, status_pembayaran) " +
                                 "VALUES ('" + id_penumpang + "', '" + id_user + "', '" + id_jadwal + "', '" + tanggal + "', '" + jumlah + "', '" + total + "', '" + status + "');";

            string selectIdQuery = "SELECT LAST_INSERT_ID();";

            try
            {
                // jalankan insert
                if (server.eksekusiNonQuery(insertQuery) > 0)
                {
                    // jalankan select
                    DataTable dt = server.eksekusiQuery(selectIdQuery);
                    if (dt.Rows.Count > 0)
                    {
                        lastId = Convert.ToInt32(dt.Rows[0][0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat insert ambil ID: " + ex.Message);
            }

            return lastId;
        }

        //update pemesanan
        public bool UpdatePemesanan(string idPemesanan, string idJadwal, string tanggal, int jumlah, decimal total)
        {
            Query = "UPDATE pemesanan SET " +
                           "id_jadwal = '" + idJadwal + "', " +
                           "tanggal_pemesanan = '" + tanggal + "', " +
                           "jumlah_tiket = " + jumlah + ", " +
                           "total_harga = " + total + " " +
                           "WHERE id_pemesanan = '" + idPemesanan + "' " +
                           "AND status_pembayaran = 'Gagal'";
            return server.eksekusiNonQuery(Query) > 0;
        }

    }
}