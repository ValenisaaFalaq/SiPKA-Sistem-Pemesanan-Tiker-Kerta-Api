using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKA.model
{
    using config;
    using MySql.Data.MySqlClient;
    using System.Data;
    using System.Data.SqlClient;
    using System.Runtime.ConstrainedExecution;
    using System.Windows.Forms;
    class user_cls
    {
        private string _id_user;
        private string _nama_user;
        private string _email_user;
        private string _username_user;
        private string _password_user;

        ConnectDB_cls server;
        string query;

        public user_cls()
        {
            _id_user = "";
            _nama_user = "";
            _email_user = "";
            _username_user = "";
            _password_user = "";
            server = new ConnectDB_cls();
            query = "";
        }

        public string ID_User
        {
            get { return _id_user; } //aksesor method
            set { _id_user = value; } //mutator method
        }
        public string Nama_User
        {
            get { return _nama_user; } //aksesor method
            set { _nama_user = value; } //mutator method
        }
        public string Email_User
        {
            get { return _email_user; } //aksesor method
            set { _email_user = value; } //mutator method
        }
        public string Username_User
        {
            get { return _username_user; } //aksesor method
            set { _username_user = value; } //mutator method
        }
        public string Password_User
        {
            get { return _password_user; } //aksesor method
            set { _password_user = value; } //mutator method
        }

        public string connStr { get; private set; }

        public string ambilNamaUser(string id_user)
        {
            string nama = "";
            DataTable data = new DataTable();

            query = "SELECT * FROM user WHERE id_user='" + id_user + "'";
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
        public bool cekID(string id_user)
        {
            bool exists = false;
            string connStr = "server=localhost;user=root;database=sipka;password=;"; // ganti sesuai koneksimu

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM user WHERE id_user = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id_user);
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
            query = "insert into user values('" + _id_user + "','" + _email_user + "', '" + _password_user + "','" + _nama_user + "','" + _username_user + "')";
            if (!(server.eksekusiNonQuery(query) > 0))
            {
                //throw new Exception("Gagal menyimpan data");
                cek = false;
            }
            return cek;
        }
        public DataTable tampilPencarian(string nama)
        {
            query = "SELECT * FROM user WHERE nama LIKE'" + nama + "%'";
            return server.eksekusiQuery(query);
        }
        internal bool delete(string id_user)
        {
            {
                bool cek = true;
                query = "delete from user where id_user='" + id_user + "'";
                if (!(server.eksekusiNonQuery(query) > 0))
                {
                    cek = false;
                }
                return cek;
            }
        }
        public bool update(string id)
        {
            string query = "UPDATE user SET Nama_User = @Nama, Email_User = @Email, Username_User = @Username, Password_User = @Password WHERE ID_User = @ID";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nama", this.Nama_User);
                cmd.Parameters.AddWithValue("@Email", this.Email_User);
                cmd.Parameters.AddWithValue("@Username", this.Username_User);
                cmd.Parameters.AddWithValue("@Password", this.Password_User);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public DataTable tampilSemua()
        {
            DataTable dt = new DataTable();
            string connStr = "server=localhost;user=root;database=sipka;password=;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
                //{
                //    try
                //    {
                //        conn.Open();
                //        string query = "SELECT * FROM user";
                //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                //        adapter.Fill(dt);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Gagal menampilkan data: " + ex.Message);
                //    }
                //}

                return dt;
        }

        public string buatKode()
        {
            string kode = "";
            int data = -1;

            query = "select ifnull(max(id_user),0) + 1 as id_user from user";
            DataTable dataTable = server.eksekusiQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    data = Convert.ToInt32(row["id_user"]);
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
    }
}
