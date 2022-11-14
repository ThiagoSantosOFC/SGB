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
                            levantamento = imput.Created 
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
            throw new NotImplementedException();
        }
    }
}