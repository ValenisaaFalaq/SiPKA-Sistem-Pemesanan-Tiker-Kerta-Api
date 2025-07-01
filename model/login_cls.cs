using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIPKA.model
{
    using config;
    class Login_cls
    {
        //atribut
        private string _id_user;
        private string _email;
        private string _password;
        private string _nama;
        private string _username;
        private string _role;

        ConnectDB_cls server;
        string Query;

        public Login_cls()
       {
           _id_user = "";
           _email = "";
           _password = "";
           _nama = "";
           _username = "";
           _role = "";

           server = new ConnectDB_cls();
           Query = "";
        }

    
        // Properties
        public string id_user
        {
            get { return _id_user; }
            set { _id_user = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            set { _password = value; }
        }

        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string role
        {
            get { return _role; }
            set { _role = value; }
        }

        // Method login utama
        public bool cekLogin()
        {
            bool cek = false;

            // Query untuk mengambil semua data user berdasarkan email dan password
            Query = "SELECT * FROM user WHERE email = '" + _email + "' AND password = '" + _password + "'";

            DataTable dt = server.eksekusiQuery(Query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Isi atribut jika login sukses
                _id_user = row["id_user"].ToString();
                _nama = row["nama"].ToString();
                _username = row["username"].ToString();
                _role = row["role"].ToString();

                cek = true;
            }

            return cek;
        }
    }
}
