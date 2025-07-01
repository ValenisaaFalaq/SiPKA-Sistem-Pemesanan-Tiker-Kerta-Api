using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKA.model
{
    using config;
    using System.Data;
    using System.Windows.Forms;

    class jadwal_cls
    {
        private int _id_jadwal;
        private int _id_kereta;
        private int _id_stasiun_asal;
        private int _id_stasiun_tujuan;
        private DateTime _tanggal_berangkat;
        private TimeSpan _waktu_berangkat;
        private TimeSpan _waktu_tiba;

        ConnectDB_cls server;
        string Query;

        public jadwal_cls()
        {
            _id_jadwal = 0;
            _id_kereta = 0;
            _id_stasiun_asal = 0;
            _id_stasiun_tujuan = 0;
            _tanggal_berangkat = DateTime.Now;
            _waktu_berangkat = TimeSpan.Zero;
            _waktu_tiba = TimeSpan.Zero;

            server = new ConnectDB_cls();
            Query = "";
        }

        // Properties
        public int IdJadwal
        {
            get { return _id_jadwal; }
            set { _id_jadwal = value; }
        }

        public int IdKereta
        {
            get { return _id_kereta; }
            set { _id_kereta = value; }
        }

        public int StasiunAsal
        {
            get { return _id_stasiun_asal; }
            set { _id_stasiun_asal = value; }
        }

        public int StasiunTujuan
        {
            get { return _id_stasiun_tujuan; }
            set { _id_stasiun_tujuan = value; }
        }

        public DateTime TanggalBerangkat
        {
            get { return _tanggal_berangkat; }
            set { _tanggal_berangkat = value; }
        }

        public TimeSpan WaktuBerangkat
        {
            get { return _waktu_berangkat; }
            set { _waktu_berangkat = value; }
        }

        public TimeSpan WaktuTiba
        {
            get { return _waktu_tiba; }
            set { _waktu_tiba = value; }
        }

        // CRUD Methods
        public bool cekid(int id)
        {
            bool cek = false;
            Query = "SELECT * FROM jadwal WHERE id_jadwal='" + id + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public bool simpan()
        {
            bool cek = true;
            Query = "INSERT INTO jadwal VALUES('" + _id_jadwal + "', '" +
                _id_kereta + "', '" + _id_stasiun_asal + "', '" + _id_stasiun_tujuan + "', '" +
                _tanggal_berangkat.ToString("yyyy-MM-dd") + "', '" + _waktu_berangkat + "', '" + _waktu_tiba + "')";
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        public bool ubah(int id)
        {
            bool cek = true;
            Query = "UPDATE jadwal SET " +
            "id_kereta=" + _id_kereta + ", " +
            "id_stasiun_asal=" + _id_stasiun_asal + ", " +
            "id_stasiun_tujuan=" + _id_stasiun_tujuan + ", " +
            "tanggal_berangkat='" + _tanggal_berangkat.ToString("yyyy-MM-dd") + "', " +
            "waktu_berangkat='" + _waktu_berangkat.ToString(@"hh\:mm\:ss") + "', " +
            "waktu_tiba='" + _waktu_tiba.ToString(@"hh\:mm\:ss") + "' " +
            "WHERE id_jadwal=" + id;

            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        public bool hapus(int id)
        {
            bool cek = true;
            Query = "DELETE FROM jadwal WHERE id_jadwal='" + id + "'";
            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                cek = false;
            }
            return cek;
        }

        public DataTable cari(int id)
        {
            Query = "SELECT * FROM jadwal WHERE id_jadwal='" + id + "'";
            return server.eksekusiQuery(Query);
        }

        public int ambilIdTerakhir()
        {
            int idTerakhir = 0;
            Query = "SELECT MAX(id_jadwal) FROM jadwal";
            DataTable data = server.eksekusiQuery(Query);

            if (data.Rows.Count > 0 && data.Rows[0][0] != DBNull.Value)
            {
                idTerakhir = Convert.ToInt32(data.Rows[0][0]);
            }

            return idTerakhir;
        }

        // Method tambahan untuk combobox
        public DataTable ambilDataKereta()
        {
            Query = "SELECT id_kereta, nama_kereta FROM kereta";
            return server.eksekusiQuery(Query);
        }

        public DataTable ambilDataStasiun()
        {
            Query = "SELECT id_stasiun, nama_stasiun FROM stasiun";
            return server.eksekusiQuery(Query);
        }

        public string ambilNamaKereta(int id)
        {
            string nama = "";
            Query = "SELECT nama_kereta FROM kereta WHERE id_kereta='" + id + "'";
            DataTable data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                nama = data.Rows[0][0].ToString();
            }
            return nama;
        }

        public string ambilNamaStasiun(int id)
        {
            string nama = "";
            Query = "SELECT nama_stasiun FROM stasiun WHERE id_stasiun='" + id + "'";
            DataTable data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                nama = data.Rows[0][0].ToString();
            }
            return nama;
        }

        public string ambilIdKereta(string nama)
        {
            string id = "";
            Query = "SELECT id_kereta FROM kereta WHERE nama_kereta='" + nama + "'";
            DataTable data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                id = data.Rows[0][0].ToString();
            }
            return id;
        }

        public string ambilIdStasiun(string nama)
        {
            string id = "";
            Query = "SELECT id_stasiun FROM stasiun WHERE nama_stasiun='" + nama + "'";
            DataTable data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                id = data.Rows[0][0].ToString();
            }
            return id;
        }

        public DataTable tampilSemua()
        {
            Query = "SELECT " +
        "j.id_jadwal, " +
        "j.id_kereta, " +
        "j.tanggal_berangkat, " +
        "j.waktu_berangkat, " +
        "j.waktu_tiba, " +
        "j.id_stasiun_asal, " +
        "sa.nama_stasiun AS stasiun_asal, " +
        "j.id_stasiun_tujuan, " +
        "st.nama_stasiun AS stasiun_tujuan " +
        "FROM jadwal j " +
        "JOIN stasiun sa ON j.id_stasiun_asal = sa.id_stasiun " +
        "JOIN stasiun st ON j.id_stasiun_tujuan = st.id_stasiun";
            //join nya dua ke tabel yang sama tapi namanya beda
            return server.eksekusiQuery(Query);
        }


        public string buatKode()
        {
            string kode = "";
            int data = -1;

            Query = "select ifnull(max(id_jadwal),0) + 1 as id_jadwal from jadwal";
            DataTable dataTable = server.eksekusiQuery(Query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    data = Convert.ToInt32(row["id_jadwal"]);
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

        public DataTable tampilPencarian(string keyword)
        {
            Query = "SELECT " +
        "j.id_jadwal, " +
        "j.id_kereta, " +
        "j.tanggal_berangkat, " +
        "j.waktu_berangkat, " +
        "j.waktu_tiba, " +
        "j.id_stasiun_asal, " +
        "sa.nama_stasiun AS stasiun_asal, " +
        "j.id_stasiun_tujuan, " +
        "st.nama_stasiun AS stasiun_tujuan " +
        "FROM jadwal j " +
        "JOIN stasiun sa ON j.id_stasiun_asal = sa.id_stasiun " +
        "JOIN stasiun st ON j.id_stasiun_tujuan = st.id_stasiun " +
        "WHERE j.id_jadwal LIKE '%" + keyword + "%' " +
        "OR sa.nama_stasiun LIKE '%" + keyword + "%' " +
        "OR st.nama_stasiun LIKE '%" + keyword + "%'";

            return server.eksekusiQuery(Query);
        }
    }
}
