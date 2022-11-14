using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using biblioteca.interfaces;
using biblioteca.models;

namespace biblioteca.database
{
    class UserDB : IData
    {
        private IDbConnection? Connection;
        public void SetConnection(IDbConnection connection)
        {
            Connection = connection;
        }
        public dynamic Get(dynamic imput)
        {
            string procedure = "getuser";
            try
            {
                using (Connection)
                {
                    dynamic result = Connection.QueryFirst<User>(
                        procedure,
                        new { userId = imput.Id },
                        commandType: CommandType.StoredProcedure
                        );
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new User();
            }
        }
        public Boolean Insert(dynamic imput)
        {
            /*
            Stored Procedure: insertUser
            Parameters:
            in userUsername varchar(255),
            in userEmail varchar(255),
            in userPassword
            Object: User
            Dapper
            */
            string procedure = "insertuser";
            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            userUsername = imput.Name,
                            userEmail = imput.Email,
                            userPassword = imput.Password
                        },
                        commandType: CommandType.StoredProcedure
                        );
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public Boolean Delete(dynamic imput)
        {
            string procedure = "deleteuser";

            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new { userId = imput.Id },
                        commandType: CommandType.StoredProcedure
                        );
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public Boolean Update(dynamic imput)
        {
            string procedure = "updateuser";

            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            userId = imput.Id,
                            userEmail = imput.Email,
                            userPassword = imput.Password
                        },
                        commandType: CommandType.StoredProcedure
                        );
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            throw new NotImplementedException();
        }
    }
}