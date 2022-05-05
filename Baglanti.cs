using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace english_learn
{
    class Baglanti
    {
        public OleDbConnection baglanti()
        {
            OleDbConnection bgl = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DataBase\dbSozluk.mdb;Persist Security Info=True");
            bgl.Open();
            return bgl;
        }
    }
}
