using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKA.model
{
    using config;
    using System.Windows.Forms;

    class register_cls
    {
        private string _id_user;
        private string _email;
        private string _password;
        private string _nama;
        private string _username;
        //private string _role;

        ConnectDB_cls server;
        string Query;

        public register_cls()
        {
            _id_user = "";
            _email = "";
            _password = "";
            _nama = "";
            _username = "";
            //_role = "user";

            server = new ConnectDB_cls();
            Query = "";
        }

        public string id_user
        {
            get { return _id_user; } //aksesor method
            set { _id_user = value; } //metator method
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
            set { _username = value; }
        }

        //public string role
        //{
        //    get { return _role; }
        //    set { _role = value; }
        //}

        public bool daftar()
        {
            bool cek = true;
            Query = "INSERT INTO user (email, password, nama, username) " +
                    "VALUES ('" + _email + "','" + _password + "','" + _nama + "','" + _username + "')";

            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                cek = false;
            }
            return cek;
        }
    }
}
