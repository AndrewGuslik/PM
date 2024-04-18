using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PM
{
    internal class Db
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=11111; Database=PM");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) 
            { 
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }
    }

    
}
