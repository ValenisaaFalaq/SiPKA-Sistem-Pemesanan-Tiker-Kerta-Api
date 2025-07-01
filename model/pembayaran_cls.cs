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
using System.Drawing.Printing;
//using System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SIPKA.model
{
    using config;

    class pembayaran_cls
    {
        ConnectDB_cls server = new ConnectDB_cls();
        string Query;

        public DataTable GetDataPesananDetailByUser(int idUser)
        {
            string query = "SELECT ps.id_pemesanan, p.nama AS nama_penumpang, k.nama_kereta, j.tanggal_berangkat, ps.total_harga " +
                   "FROM pemesanan ps " +
                   "JOIN penumpang p ON ps.id_penumpang = p.id_penumpang " +
                   "JOIN jadwal j ON j.id_jadwal = ps.id_jadwal " +
                   "JOIN kereta k ON k.id_kereta = j.id_kereta " +
                   "WHERE ps.id_user = '" + idUser + "' AND ps.status_pembayaran != 'Berhasil'";
            return server.eksekusiQuery(query);
        }

        public DataTable GetDataPembayaran(int idPemesanan)
        {
            Query = "SELECT " +
                "p.nama AS nama_penumpang, " +
                "k.nama_kereta, " +
                "j.stasiun_asal, " +
                "j.stasiun_tujuan, " +
                "j.tanggal_berangkat, " +
                "j.waktu_berangkat, " +
                "ps.jumlah_tiket, " +
                "j.harga_tiket, " +
                "ps.total_harga " +
                "FROM pemesanan ps " +
                "JOIN penumpang p ON p.id_penumpang = ps.id_penumpang " +
                "JOIN jadwal j ON j.id_jadwal = ps.id_jadwal " +
                "JOIN kereta k ON k.id_kereta = j.id_kereta " +
                "WHERE ps.id_pemesanan = '" + idPemesanan + "'";

            return server.eksekusiQuery(Query);
        }
    }
}