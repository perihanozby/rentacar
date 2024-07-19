using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace rentacar
{
     class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-8E0ATBG9;Initial Catalog=rentacar;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}

