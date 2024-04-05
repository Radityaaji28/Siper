using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siper.layanan
{
    using konfigurasi;
    class pengguna_cls
    {
        KoneksiDB_cls server;
        string Query;

        public pengguna_cls()
        {
            server = new KoneksiDB_cls();
            Query = "";
        }

        public bool apakahAdaUser(string uid,string pwd)
        {
            bool cek = false;
            Query = $"select * from pengguna where user_name = '{uid}' and password ='{pwd}'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
    }
}
