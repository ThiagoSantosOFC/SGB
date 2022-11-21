using biblioteca.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using biblioteca.models;
using biblioteca.tools;
using biblioteca.database;

namespace SGB
{
    public partial class insertRequisicao : Form
    {
        public insertRequisicao()
        {
            InitializeComponent();
        }

        private void bootTitleTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = bootTitleTxb.Text;

            BookDB bookDB = new BookDB();
            Connection connection = new Connection();
            bookDB.SetConnection(connection.getConnection());

            book = bookDB.Get(book);

            Requesition requesition = new Requesition();
            requesition.BookId = book.Id;

            SectionTools sectionTools = new SectionTools();
            sectionTools.LoadSectionFile();
            Section username = sectionTools.GetSection("username");

            User user = new User();
            user.Name = username.value;

            UserDB userDB = new UserDB();   
            userDB.SetConnection(connection.getConnection());

            user = userDB.Get(user);

            requesition.UserId = user.Id;
            requesition.levantamento = DateTime.Now.ToString("dd/MM/yyyy");

            RequisitionDB reqDB = new RequisitionDB();
            reqDB.SetConnection(connection.getConnection());

            reqDB.Insert(requesition);

            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
