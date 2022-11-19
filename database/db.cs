using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace biblioteca.database
{
    public class Connection
    {
        private string Server = "localhost";
        private string Database = "db";
        private string User = "root";
        private string Password = "root";
        private string Port = "3306";

        public Connection setServer(string server)
        {
            Server = server;
            return this;
        }

        public Connection setDatabase(string database)
        {
            Database = database;
            return this;
        }

        public Connection setUser(string user)
        {
            User = user;
            return this;
        }

        public Connection setPassword(string password)
        {
            Password = password;
            return this;
        }

        public Connection setPort(string port)
        {
            Port = port;
            return this;
        }

        public MySqlConnection getConnection()
        {
            MySqlConnection connection;
            try
            {
                connection = new MySqlConnection($"Server={Server};Database={Database};Uid={User};Pwd={Password};Port={Port};");
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
