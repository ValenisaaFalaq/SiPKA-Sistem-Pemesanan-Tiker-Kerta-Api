using System;
using System.Data;
using SIPKA.view;

namespace SIPKA.model
{
    using config;

    class stasiun_cls
    {
        private string _idStasiun;
        private string _namaStasiun;
        private string _kota;
        private string _kodeStasiun;

        ConnectDB_cls server;
        string query;

        public stasiun_cls()
        {
            _idStasiun = "";
            _namaStasiun = "";
            _kota = "";
            _kodeStasiun = "";
            server = new ConnectDB_cls();
            query = "";
        }

        // Property (Setter)
        public string IdStasiun
        {
            get { return _idStasiun; }
            set { _idStasiun = value; }
        }

        public string NamaStasiun
        {
            get { return _namaStasiun; }
            set { _namaStasiun = value; }
        }


        public string Kota
        {
            get { return _kota; }
            set { _kota = value; }
        }

        public string KodeStasiun
        {
            get { return _kodeStasiun; }
            set { _kodeStasiun = value; }
        }

        // Cek apakah ID stasiun sudah ada
        public bool cekID(string id)
        {
            bool cek = false;
            query = "SELECT * FROM stasiun WHERE id_stasiun = '" + id + "'";
            if (server.eksekusiQuery(query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        // Simpan data baru
        public bool simpan()
        {
            bool cek = true;
            query = "INSERT INTO stasiun (id_stasiun, nama_stasiun, kota, kode_stasiun) VALUES('" +
                    _idStasiun + "', '" + _namaStasiun + "', '" + _kota + "', '" + _kodeStasiun + "')";

            if (!(server.eksekusiNonQuery(query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        // Ubah data stasiun berdasarkan ID
        public bool ubah(string id)
        {
            bool cek = true;
            query = "UPDATE stasiun SET nama_stasiun = '" + _namaStasiun +
                    "', kota = '" + _kota +
                    "', kode_stasiun = '" + _kodeStasiun +
                    "' WHERE id_stasiun = '" + id + "'";

            if (!(server.eksekusiNonQuery(query) > 0))
            {
                cek = false;
            }
            return cek;
        }


        // Hapus data stasiun berdasarkan ID
        public bool hapus(int id)
        {
            bool cek = true;
            query = "DELETE FROM stasiun WHERE id_stasiun ='" + id + "'";
            if (!(server.eksekusiNonQuery(query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        // Ambil nama stasiun berdasarkan ID
        public string ambilNamaStasiun(string id)
        {
            string nama_stasiun = "";
            DataTable data = server.eksekusiQuery("SELECT nama_stasiun FROM stasiun WHERE id_stasiun = '{id}'");

            if (data.Rows.Count > 0)
            {
                nama_stasiun = data.Rows[0]["nama_stasiun"].ToString();
            }

            return nama_stasiun;
        }

        // Tampilkan semua data stasiun
        public DataTable tampilSemua()
        {
            query = "SELECT * FROM stasiun";
            return server.eksekusiQuery(query);
        }

        // Tampilkan data berdasarkan nama stasiun (pencarian)
        public DataTable tampilPencarian(string keyword)
        {
            query = "SELECT * FROM stasiun WHERE " +
                    "nama_stasiun LIKE '%" + keyword + "%' OR " +
                    "kota LIKE '%" + keyword + "%' OR " +
                    "kode_stasiun LIKE '%" + keyword + "%'";

            return server.eksekusiQuery(query);
        }

        // Ambil ID stasiun berdasarkan nama
        public string ambilIdStasiun(string nama)
        {
            string id = "";
            DataTable data = server.eksekusiQuery("SELECT id_stasiun FROM stasiun WHERE nama_stasiun = '{nama}'");

            if (data.Rows.Count > 0)
            {
                id = data.Rows[0]["id_stasiun"].ToString();
            }

            return id;
        }

        public string buatKode()
        {
            string kode = "";
            int data = -1;

            query = "select ifnull(max(id_stasiun),0) + 1 as id_stasiun from stasiun";
            DataTable dataTable = server.eksekusiQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    data = Convert.ToInt32(row["id_stasiun"]);
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
