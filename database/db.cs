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
        private string? Server = System.Configuration.ConfigurationManager.AppSettings["server"];
        private string? Database = System.Configuration.ConfigurationManager.AppSettings["database"]; 
        private string? User = System.Configuration.ConfigurationManager.AppSettings["user"];
        private string? Password = System.Configuration.ConfigurationManager.AppSettings["password"];
        private string? Port = System.Configuration.ConfigurationManager.AppSettings["port"];

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
