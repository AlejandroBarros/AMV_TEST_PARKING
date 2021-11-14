using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class ConnectionToSql
    {
        private readonly string ConnectionString;

        public ConnectionToSql()
        {
            ConnectionString = "Server=(local);Database=MyCompany;Integrated Security=true";
                //Server=(local),Database=MyCompany;integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}


