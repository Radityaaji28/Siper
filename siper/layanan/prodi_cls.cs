using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siper.layanan
{
    using konfigurasi;
    class prodi_cls
    {
        private string _id;
        private string _nama;
        private string _jurusan;

        KoneksiDB_cls server;
        DataTable data;
        string Query;

        public prodi_cls()
        {
            _id = "";
            _nama = "";
            _jurusan = "";

            server = new KoneksiDB_cls();
            data = new DataTable();
            Query = "";
        }

        public string Id_Prodi
        {
            set { _id = value; }
            //get { return _id; }
        }

        public string Nama_Prodi
        {
            set { _nama = value; }
        }
        public string Id_Jurusan
        {
            set { _jurusan = value; }
        }
        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = $"select * from prodi where id_prodi = '{id}'";
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
            Query = $"insert into prodi (id_prodi,nama_prodi,id_jurusan) values('{_id}','{_nama}','{_jurusan}')";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal disimpan.");
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika diperlukan
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public int ubahData(string id)
        {
            int result = -1;
            Query = $"update prodi set nama_prodi = '{_nama}',id_jurusan = '{_jurusan}' where id_prodi = '{id}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal diubah.");
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika diperlukan
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public int hapusData(string id)
        {
            int result = -1;
            Query = $"delete from prodi where id_prodi = '{id}'";
            try
            {
                result = server.eksekusiBukanQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal dihapus.");
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public DataTable tampilkanData()
        {
            Query = $"SELECT p.id_prodi, p.nama_prodi, j.nama_jurusan AS jurusan FROM prodi p JOIN jurusan j ON p.id_jurusan = j.id_jurusan";
            return server.eksekusiQuery(Query);
        }

        public DataTable getComboJurusan()
        {
            Query = "select id_jurusan as id_jurusan,nama_jurusan as nama_jurusan from jurusan";
            return server.eksekusiQuery(Query);
        }

        public DataTable tampilkanDgnama(string nama)
        {
            Query = $"select * from prodi where nama_prodi like '%{nama}%'";
            return server.eksekusiQuery(Query);
        }
    }
}
