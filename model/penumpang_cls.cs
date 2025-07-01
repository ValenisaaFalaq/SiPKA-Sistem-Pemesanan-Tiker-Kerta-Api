using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKA.model
{
    using config;
    using MySql.Data.MySqlClient;
    using System.Data;
    using System.Runtime.ConstrainedExecution;
    using System.Windows.Forms;

    class penumpang_cls
    {
        private string _id_penumpang;
        private string _nama_penumpang;
        private string _email_penumpang;
        private string _notelepon_penumpang;
        private string _tanggallahir_penumpang;
        private string _jeniskelamin_penumpang;
        private string _alamat_penumpang;

        ConnectDB_cls server;
        string query;

        public penumpang_cls()
        {
            _id_penumpang = "";
            _nama_penumpang = "";
            _email_penumpang = "";
            _notelepon_penumpang = "";
            _tanggallahir_penumpang = "";
            _jeniskelamin_penumpang = "";
            _alamat_penumpang = "";
            server = new ConnectDB_cls();
            query = "";
        }

        public string ID_Penumpang
        {
            get { return _id_penumpang; } //aksesor method
            set { _id_penumpang = value; } //mutator method
        }

        public string id_penumpang { get; private set; }

        public string Nama_Penumpang
        {
            get { return _nama_penumpang; } //aksesor method
            set { _nama_penumpang = value; } //mutator method
        }
        public string Email_Penumpang
        {
            get { return _email_penumpang; } //aksesor method
            set { _email_penumpang = value; } //mutator method
        }
        public string NoTelepon_Penumpang
        {
            get { return _notelepon_penumpang; } //aksesor method
            set { _notelepon_penumpang = value; } //mutator method
        }
        public string Tanggallahir_Penumpang
        {
            get { return _tanggallahir_penumpang; } //aksesor method
            set { _tanggallahir_penumpang = value; } //mutator method
        }
        public string Jeniskelamin_Penumpang
        {
            get { return _jeniskelamin_penumpang; } //aksesor method
            set { _jeniskelamin_penumpang = value; } //mutator method
        }
        public string Alamat_Penumpang
        {
            get { return _alamat_penumpang; } //aksesor method
            set { _alamat_penumpang = value; } //mutator method
        }

        public string ambilNamaPenumpang(string id_penumpang)
        {
            string nama = "";
            DataTable data = new DataTable();

            query = "SELECT * FROM penumpang WHERE id_penumpang='" + id_penumpang + "'";
            data = server.eksekusiQuery(query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows) // perulangan tergantung dari banyaknya objek
                {
                    nama = dt[1].ToString(); // [0] maksudnya tergantung dari indeks kolom yang akan diambil, [1] jika querynya menggunakan select * untuk mengambil semua kolom
                }
            }
            return nama;
        }

        public bool cekID(string id_penumpang)
        {

            bool exists = false;
            string connStr = "server=localhost;user=root;database=sipka;password=;"; // ganti sesuai koneksimu

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM penumpang WHERE id_penumpang = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id_penumpang);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        exists = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan: " + ex.Message);
                }
            }

            return exists;
        }

        public bool create()
        {
            bool cek = true;
            query = "insert into penumpang values('" + _id_penumpang + "','" + _nama_penumpang + "','" + _alamat_penumpang + "','" + _notelepon_penumpang + "','" + _email_penumpang + "','" + _jeniskelamin_penumpang + "','" + _tanggallahir_penumpang + "')";
            if (!(server.eksekusiNonQuery(query) > 0))
            {
                //throw new Exception("Gagal menyimpan data");
                cek = false;
            }
            return cek;
        }


        public DataTable tampilPencarian(string nama)
        {
            query = "SELECT * FROM penumpang WHERE nama LIKE '" + nama + "%'";
            return server.eksekusiQuery(query);
        }

        internal bool delete(string id_penumpang)
        {
            {
                bool cek = true;
                query = "delete from penumpang where id_penumpang='" + id_penumpang + "'";
                if (!(server.eksekusiNonQuery(query) > 0))
                {
                    cek = false;
                }
                return cek;
            }
        }


        public DataTable tampilSemua()
        {
            query = "SELECT * FROM penumpang";

            return server.eksekusiQuery(query);
            //DataTable dt = new DataTable();
            //string connStr = "server=localhost;user=root;database=sipka;password=;";

            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    try
            //    {
            //        conn.Open();
            //        string query = "SELECT * FROM penumpang";
            //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            //        adapter.Fill(dt);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            //    }
            //}

            //return dt;
        }


        internal bool update(string id_penumpang)
        {
            bool cek = true;

            query = "UPDATE penumpang SET " +
                    "nama = '" + _nama_penumpang + "', " +
                    "email = '" + _email_penumpang + "', " +
                    "no_telepon = '" + _notelepon_penumpang + "', " +
                    "tanggal_lahir = '" + _tanggallahir_penumpang + "', " +
                    "jenis_kelamin = '" + _jeniskelamin_penumpang + "', " +
                    "alamat = '" + _alamat_penumpang + "' " +
                    "WHERE id_penumpang = '" + id_penumpang + "'";

            if (!(server.eksekusiNonQuery(query) > 0))
            {
                cek = false;
            }

            return cek;
        }

        public string buatKode()
        {
            string kode = "";
            int data = -1;

            query = "select ifnull(max(id_penumpang),0) + 1 as id_penumpang from penumpang";
            DataTable dataTable = server.eksekusiQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    data = Convert.ToInt32(row["id_penumpang"]);
                }

                if (data > 0 && data < 10)
                {
                    kode = "0" + data.ToString();
                }
                else if (data >= 10 && data < 100)
                {
                    kode = data.ToString();
                }

            }

            return kode; // pastikan return selalu terjadi
        }

        //nama belum tedaftar sebagai penumpang
        public bool NamaTerdaftar(string nama)
        {
            query = "SELECT COUNT(*) FROM penumpang WHERE nama = '" + nama + "'";
            DataTable dt = server.eksekusiQuery(query);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

    }
}

