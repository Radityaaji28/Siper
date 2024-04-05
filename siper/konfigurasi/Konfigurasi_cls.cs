using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siper.konfigurasi
{
    abstract class Konfigurasi_cls
    {
        //untuk menangani intruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiBukanQuery(string query);

        //untuk menangani intruksi SELECT
        public abstract DataTable eksekusiQuery(string query);
    }
}
