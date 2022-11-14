using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace biblioteca.interfaces
{
    public interface IData
    {
        void SetConnection(IDbConnection connection);
        dynamic Get(dynamic imput);
        Boolean Insert(dynamic imput);
        Boolean Delete(dynamic imput);
        Boolean Update(dynamic imput);
    }
}