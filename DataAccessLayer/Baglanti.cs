using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class Baglanti
    {
        // MDB uzantılı Access veritabanımızın connection string olan kısım...
        public static OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ..\..\..\HastaneOtomasyonu.mdb");
    }
}
