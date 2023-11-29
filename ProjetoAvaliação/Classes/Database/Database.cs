    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliação.Classes.Database
{
    public class Database
    {
        public static string GetConexao()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DB;" +
                "Integrated Security=True";
            
            return connectionString;
        }
    }
}

