using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyApplication
{
    public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        public string MyConnection()
        {
            con = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DBLabProject;Integrated Security=True";
            return con;
        }
    }
}

