using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SQLite;

namespace Veritabanı_deneme
{
    public class VeritabanıConnection
    {
        public static SQLiteConnection connect = new SQLiteConnection("Data source =.\\deneme.db;Versiyon=3");
    }
}
