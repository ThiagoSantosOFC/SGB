using biblioteca.database;
using biblioteca.interfaces;
using biblioteca.models;
using biblioteca.tools;

namespace Testing
{
    class DbTests
    {
        // User tests
        public void TestGetUser()
        {
            try
            {
                User user = new User();
                user.Id = 1;
                IData data = new UserDB();


                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                User result = data.Get(user);

                throw new Exception($"User: {result.Id} {result.Name} {result.Email} {result.Password}");
            }
            catch   (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void TestInsertUser()
        {
            try
            {
                User user = new User();
                user.Name = "test2";
                user.Email = "test2@demo.com";
                user.Password = "123456789";

                IData data = new UserDB();
                
                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());
                
                bool result = data.Insert(user);

                if (result == true)
                {
                    throw new Exception("User inserted");
                }
                else
                {
                    throw new Exception("User not inserted");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void TestDeleteUser()
        {
            try
            {
                User user = new User();
                user.Id = 6;
                IData data = new UserDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                bool result = data.Delete(user);

                if (result == true)
                {
                    throw new Exception("User deleted");
                }
                else
                {
                    throw new Exception("User not deleted");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void TestUpdateUser()
        {
            try
            {
                User user = new User();
                user.Id = 1;
                user.Email = "umemailae@gmail.com";
                user.Password = "123456789";
                IData data = new UserDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                bool result = data.Update(user);

                if (result == true)
                {
                    throw new Exception("User updated");
                }
                else
                {
                    throw new Exception("User not updated");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        //Book tests
        public void TestGetBook()
        {
            try
            {
                Book book = new Book();
                book.Title = "The Hobbit";

                IData data = new BookDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                Book result = data.Get(book);

                throw new Exception($"Book: {result.Title} {result.Author} {result.Year}");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void TestInsertBook()
        {
            try
            {
                Book book = new Book();
                book.Title = "A arte da guerra";
                book.Author = "Sun Tzu";
                book.Year = "500 a.C";
                book.Publisher = "Editora";
                book.ISBN = "123456789";
                book.Category = "Guerra";

                IData data = new BookDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                bool result = data.Insert(book);

                if (result == true)
                {
                    throw new Exception("Book inserted");
                }
                else
                {
                    throw new Exception("Book not inserted");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void TestDeleteBook()
        {
            try
            {
                Book book = new Book();
                book.Title = "teste";
                IData data = new BookDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                bool result = data.Delete(book);

                if (result == true)
                {
                    throw new Exception("Book deleted");
                }
                else
                {
                    throw new Exception("Book not deleted");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void TestUpdateBook()
        {
            try
            {
                Book book = new Book();
                book.Title = "test";
                book.Author = "Sun Tzu";
                book.Year = "500 a.C";
                book.Publisher = "Editora";
                book.ISBN = "123";
                book.Category = "Guerra";

                IData data = new BookDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                bool result = data.Update(book);

                if (result == true)
                {
                    throw new Exception("Book updated");
                }
                else
                {
                    throw new Exception("Book not updated");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    
        // Requesition tests
        public void TestInsertRequesition()
        {
            try
            {
                Requesition requesition = new Requesition();
                requesition.Book = "A arte da guerra";
                requesition.User = "test2";
                requesition.Date = "2020-12-12";
                requesition.Status = "Pendente";

                IData data = new RequesitionDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                bool result = data.Insert(requesition);

                if (result == true)
                {
                    throw new Exception("Requesition inserted");
                }
                else
                {
                    throw new Exception("Requesition not inserted");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}