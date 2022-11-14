using Dapper;
using MySql.Data.MySqlClient;
using biblioteca.interfaces;
using biblioteca.models;
using System.Data;

namespace biblioteca.database
{
    class BookDB : IData
    {
        private IDbConnection? Connection;

        public void SetConnection(IDbConnection connection)
        {
            Connection = connection;
        }

        public bool Delete(dynamic imput)
        {
            string procedure = "deletebook";

            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            bookId = imput.Title
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

        public dynamic Get(dynamic imput)
        {
            string procedure = "getbook";

            try
            {
                using (Connection)
                {
                    dynamic result = Connection.QueryFirst<Book>(
                        procedure,
                        new { bookId = imput.Title },
                        commandType: CommandType.StoredProcedure
                    );
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new Book();
            }
        }

        public bool Insert(dynamic imput)
        {
            throw new NotImplementedException();
        }


        public bool Update(dynamic imput)
        {
            throw new NotImplementedException();
        }
    }
}