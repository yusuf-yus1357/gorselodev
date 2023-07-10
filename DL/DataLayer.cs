using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OBUZ_ILETISIM.DL
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LCGJ1EN;Initial Catalog=OBUZ_ILETISIM;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
