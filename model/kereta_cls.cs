using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SIPKA.model
{
    using config;
    using System.Data;
    using System.Windows.Forms;

    class kereta_cls
    {
        private int _id_kereta;
        private string _nama_kereta;
        private string _kelas_keretta;
        private int _jumlah_kursi;

        ConnectDB_cls server;
        string Query;

        public kereta_cls()
        {
            _id_kereta = 0;
            _nama_kereta = "";
            _kelas_keretta = "";
            _jumlah_kursi = 0;

            server = new ConnectDB_cls();
            Query = "";
        }

        public int id_kereta
        {
            get { return _id_kereta; } //aksesor method
            set { _id_kereta = value; }
        }

        public string nama_kereta
        {
            get { return _nama_kereta; } //aksesor method
            set { _nama_kereta = value; }
        }

        public string kelas_keretta
        {
            get { return _kelas_keretta; } //aksesor method
            set { _kelas_keretta = value; }
        }

        public int jumlah_kursi
        {
            get { return _jumlah_kursi; } //aksesor method
            set { _jumlah_kursi = value; }
        }

        public bool cekid(int id)
        {
            bool cek = false;
            Query = "select * from kereta where id_kereta='" + id + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public bool simpan()
        {
            bool cek = true;
            Query = "insert into kereta values('" + _id_kereta + "','" +
                _nama_kereta + "','" + _kelas_keretta + "','" + _jumlah_kursi + "')";
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                //throw new Exception("Gagal menyimpan data nih");
                cek = false;
            }
            return cek;
        }

        public bool ubah(int id)
        {
            bool cek = true;
            Query = "UPDATE kereta SET nama_kereta = '" + _nama_kereta + "', " +
                    "kelas_keretta = '" + _kelas_keretta + "', " +
                    "jumlah_kursi = " + _jumlah_kursi + " " +
                    "WHERE id_kereta = " + id;

            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        public bool hapus(int id)
        {
            bool cek = true;
            Query = "DELETE FROM kereta WHERE id_kereta = " + id;
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        public string ambiljumlahKursi(int id)
        {
            string kursi = "";
            DataTable data = new DataTable();

            Query = "SELECT jumlah_kursi FROM kereta WHERE id_kereta = " + id;
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    kursi = dt[0].ToString();
                }
            }

            return kursi;
        }

        public string ambilKelasKereta(int id)
        {
            string kelas = "";
            DataTable data = new DataTable();

            Query = "select kelas_keretta from kereta where id_kereta=  '" + id + "'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    kelas = dt[0].ToString();
                }
            }

            return kelas;
        }

        public string ambilNamaKereta(int id)
        {
            string nama = "";
            DataTable data = new DataTable();

            Query = "select nama_kereta from kereta where id_kereta=  '" + id + "'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    nama = dt[0].ToString();
                }
            }

            return nama;
        }

        public string ambilIdKereta(string nama)
        {
            string kode = "";
            DataTable data = new DataTable();

            Query = "select id_kereta from kereta where nama_kereta=  '" + nama + "'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    kode = dt[0].ToString();
                }
            }

            return kode;
        }
        public DataTable ambilDataKelas()
        {
            Query = "SELECT DISTINCT TRIM(kelas_keretta) as kelas_keretta FROM kereta";
            return server.eksekusiQuery(Query);
        }

        public string ambilKereta(int id)
        {
            string nama = "";
            DataTable data = new DataTable();

            Query = "select * from kereta where id_kereta=  '" + id + "'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    nama = dt[0].ToString();
                }
            }

            return nama;
        }

        public DataTable tampilSemua()
        {
            Query = "select * from kereta";

            return server.eksekusiQuery(Query);
        }

        public DataTable cari(string nama)
        {
            Query = "select * from kereta where nama_kereta like '" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        public int ambilIdTerakhir()
        {
            int idTerakhir = 0;
            Query = "SELECT MAX(id_kereta) FROM kereta";
            DataTable data = server.eksekusiQuery(Query);

            if (data.Rows.Count > 0 && data.Rows[0][0] != DBNull.Value)
            {
                idTerakhir = Convert.ToInt32(data.Rows[0][0]);
            }

            return idTerakhir;
        }

    }
}
