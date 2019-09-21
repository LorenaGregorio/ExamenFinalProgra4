using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgra4.Reader
{
    public abstract class ObjetReaderWithConnection <T> : ObjectReaderBase <T>
    {
        public static string ConnectionString = "Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=IpearTelefonosDB;Integrated Security=True";
        protected override IDbConnection GetConecction()
        {
            IDbConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }
    }
}
