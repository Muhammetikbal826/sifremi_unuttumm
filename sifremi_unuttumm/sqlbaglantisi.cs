using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace sifremi_unuttumm
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RD4OLNE\\SQLEXPRESS;Initial Catalog=kisiler3;Integrated Security=True");
            baglanti.Open();
            return baglanti;

        }
    }
}