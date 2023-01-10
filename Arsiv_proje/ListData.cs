using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsiv_proje
{
    internal class ListData

    {
        public static DataTable Conne(string data)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(data, Dataconn.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            
            da.Fill(dt);
            return dt;
        }
    }
    
}

