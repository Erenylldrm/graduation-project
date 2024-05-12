using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPYAZİLİM
{
    class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
