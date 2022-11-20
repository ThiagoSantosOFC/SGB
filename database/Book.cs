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
                            bookTitle = imput.Title
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
                        new { bookTitle = imput.Title },
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
            /*
            	in bookTitle varchar(255),
                in bookAuthor varchar(255),
                in bookIsbn varchar(255), 
                in bookPublisher varchar(255),
                in bookYear varchar(45),
                in bookCategory varchar(45)
            */
            string procedure = "insertbook";
            
            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            bookTitle = imput.Title,
                            bookAuthor = imput.Author,
                            bookIsbn = imput.ISBN,
                            bookPublisher = imput.Publisher,
                            bookYear = imput.Year,
                            bookCategory = imput.Category
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

        public bool Update(dynamic imput)
        {
            string procedure = "updatebook";

            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            bookTitle = imput.Title,
                            bookAuthor = imput.Author,
                            bookIsbn = imput.ISBN,
                            bookPublisher = imput.Publisher,
                            bookYear = imput.Year,
                            bookCategory = imput.Category
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

        public List<Book> GetBooks()
        {
            string query = "SELECT * FROM book";

            try
            {
                using (Connection)
                {
                    List<Book> result = Connection.Query<Book>(query).ToList();
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Book>();
            }
        }
    }
}