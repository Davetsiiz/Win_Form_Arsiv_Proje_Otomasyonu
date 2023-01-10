using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsiv_proje
{
    internal class Dataconn

    {
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RCC06P7;Initial Catalog=Arsiv_proje;Integrated Security=True");

    }
}
