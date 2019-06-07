using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connection
    {
        private MySqlConnection connection;

        public Connection()
        {
            this.connection = new MySqlConnection(Properties.Settings.Default.connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
