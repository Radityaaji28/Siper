using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siper.layanan
{
    using konfigurasi;
    class Jurusan_cls
    {
        private string _id;
        private string _nama;

        KoneksiDB_cls server;
        DataTable data;
        string Query;

        public Jurusan_cls()
        {
            _id = "";
            _nama = "";

            server = new KoneksiDB_cls();
            data = new DataTable();
            Query = "";
        }

        public string Id_Jurusan
        {
            set { _id = value; }
            //get { return _id; }
        }

        public string Nama_Jurusan
        {
            set { _nama = value; }
        }

        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = $"select * from jurusan where id_jurusan = '{id}'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public int simpanData()
        {
            int result = -1;
            Query = $"insert into jurusan values('{_id}','{_nama}')";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal disimpan.");
                }
            }catch (Exception ex) { }

            return result;
        }

        public int ubahData(string id)
        {
            int result = -1;
            Query = $"update jurusan set nama_jurusan = '{_nama}' where id_jurusan = '{id}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal diubah.");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        public int hapusData(string id)
        {
            int result = -1;
            Query = $"delete from jurusan where id_jurusan = '{id}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal dihapus.");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        public DataTable tampilkanData()
        {
            Query = "select * from jurusan";

            return server.eksekusiQuery(Query);
        }

        public DataTable tampilkanDgnama(string nama)
        {
            Query = $"select * from jurusan where nama_jurusan like '%{nama}%'";

            return server.eksekusiQuery(Query);
        }

        public string ambilkodeDgnama(string nama)
        {
            string kode = "";
            DataTable dt = new DataTable();
            Query = $"select id_jurusan from jurusan where nama_jurusan = '{nama}'";
            if(server.eksekusiQuery(Query).Rows.Count > 0)
            {
                foreach(DataRow data in dt.Rows)
                {
                    kode = data[0].ToString();
                }
            }
            return kode;
        }
    }
}
