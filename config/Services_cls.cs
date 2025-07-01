using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKA.config
{
   abstract class Services_cls
    {
        //Deklar abstract methdo(fungsi), digunakan untuk menangani INSERT, UPDATE dan DELETE.
        public abstract int eksekusiNonQuery(string query);
        //Deklar abstract methdo(fungsi), digunakan untuk menangani SELECT.
        public abstract DataTable eksekusiQuery(string query);
    }
}
