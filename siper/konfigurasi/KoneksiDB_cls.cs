using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace siper.konfigurasi
{
    class KoneksiDB_cls:Konfigurasi_cls
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string link = "server=localhost;port=3306;database=siper;uid=root;pwd=";

        public KoneksiDB_cls()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }catch (Exception ex) { }
        }

        void tutupKoneksi()
        {
            conn.Close();
        }
        public override int eksekusiBukanQuery(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
            }catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);

            }
            catch (Exception ex) { }
            finally { tutupKoneksi(); }

            return result;
        }
    }
}
