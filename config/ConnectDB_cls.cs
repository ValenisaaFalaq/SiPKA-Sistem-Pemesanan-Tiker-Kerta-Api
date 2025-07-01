using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SIPKA.config
{
    class ConnectDB_cls : Services_cls
    {

        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter adapter;

        string strCon = "server=localhost;port=3306;database=sipka;uid=root;pwd=";

        //constructor
        public ConnectDB_cls()
        {
            conn = new MySqlConnection(strCon); // untuk connector
            comm = new MySqlCommand(); //untuk eksekusi INSERT UPDATE DELETE
            adapter = new MySqlDataAdapter(); // untuk menampung 
        }

        void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e) { }
        }

        void tutupKoneksi()
        {
            conn.Close();
        }

        public override int eksekusiNonQuery(string query)
        {
            int kembali = -1;


            try
            {
                bukaKoneksi();
                comm.Connection = conn;
                comm.CommandText = query;
                kembali = comm.ExecuteNonQuery();
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }

            return kembali;


        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable kembali = new DataTable();

            try
            {
                bukaKoneksi();
                comm.Connection = conn;
                comm.CommandText = query;
                adapter.SelectCommand = comm;
                adapter.Fill(kembali);
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }

            return kembali;
        }

    }
}
