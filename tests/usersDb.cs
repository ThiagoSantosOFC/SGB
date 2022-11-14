using biblioteca.database;
using biblioteca.interfaces;
using biblioteca.models;
using biblioteca.tools;

namespace Testing
{
    class DbTests
    {
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

        public void TestGetBook()
        {
            try
            {
                Book book = new Book();
                book.Id = 1;
                IData data = new BookDB();

                Connection connection = new Connection();

                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setUser("root");
                connection.setPassword("123456789");
                connection.setPort("3306");

                data.SetConnection(connection.getConnection());

                Book result = data.Get(book);

                throw new Exception($"Book: {result.Id} {result.Title} {result.Author} {result.Publisher} {result.Year} {result.ISBN} {result.Category}");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}