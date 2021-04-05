using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DXApplication1
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=BARIS;Initial Catalog=StokOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
