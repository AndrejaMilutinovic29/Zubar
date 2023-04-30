using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubar
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string CS = ConfigurationManager.ConnectionStrings["ZubarKonekcija"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
