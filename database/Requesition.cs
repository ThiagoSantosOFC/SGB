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
    class RequisitionDB : IData
    {
        private IDbConnection? Connection;

        /*
        Requisições tem apenas os metodos de inserção e deleção visto que são registros de empréstimos e pressisam estar gravados 
        e não podem ser apagados apenas inseridos e alterados.
        */
        public void SetConnection(IDbConnection connection)
        {
            Connection = connection;
        }

        public bool Delete(dynamic imput)
        {
            throw new NotImplementedException();
        }

        public dynamic Get(dynamic imput)
        {
            string procedure = "getrequisicao";

            try
            {
                using (Connection)
                {
                    dynamic result = Connection.QueryFirst<Requesition>(
                        procedure,
                        new { requisicaoId = imput.Id },
                        commandType: CommandType.StoredProcedure
                        );
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new Requesition();
            }

            throw new NotImplementedException();
        }

        public bool Insert(dynamic imput)
        {
            /*
            in userid INT,
            in bookid INT,
            in levantamento varchar(255) <- Time now in string format (yyyy-MM-dd HH:mm:ss)
            */

            string procedure = "insertrequisicao";

            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            userid = imput.UserId,
                            bookid = imput.BookId,
                            levantamento = imput.levantamento 
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
            /*
            in entrega varchar(45),
            in userid INT,
            in bookid INT
            */

            string procedure = "updaterequisicao";

            try
            {
                using (Connection)
                {
                    Connection.Execute(
                        procedure,
                        new
                        {
                            entrega = imput.Delivered,
                            userid = imput.UserId,
                            bookid = imput.BookId
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
    
        public List<Requesition> GetRequisitions()
        {
            string query = "SELECT * FROM requisicao";

            try
            {
                using (Connection)
                {
                    List<Requesition> result = Connection.Query<Requesition>(query).ToList();
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Requesition>();
            }
        }

        public dynamic GetUserRequisition(int userId)
        {
            //Inner join para substituir o id do livro pelo nome do livro e o id do utilizador pelo nome do utilizador
            string query = "SELECT requisicoes.id, requisicoes.levantamento, requisicoes.entrega, requisicoes.book_id, requisicoes.user_id, book.title, user.username FROM requisicoes INNER JOIN book ON requisicoes.book_id = book.book_id INNER JOIN user ON requisicoes.user_id = user.id WHERE requisicoes.user_id = @user_id";

            try
            {
                using (Connection)
                {
                    dynamic result = Connection.QueryFirst<Requesition>(
                        query,
                        new { user_id = userId }
                        );
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new Requesition();
            }
        }
    }
}