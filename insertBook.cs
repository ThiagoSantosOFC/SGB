using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using biblioteca.database;
using biblioteca.interfaces;
using biblioteca.models;
using biblioteca.tools;

namespace SGB
{
    public partial class insertBook : Form
    {
        public insertBook()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Book book = new();

            book.Title = titleTxb.Text;
            book.Author = authorTxb.Text;
            book.ISBN = isbnTxb.Text;
            book.Publisher = publisherTxb.Text;
            book.Year = yearTxb.Text;
            book.Category = categoryTxb.Text;

            BookDB bookDB = new();
            Connection connection = new();
            bookDB.SetConnection(connection.getConnection());

            bookDB.Insert(book);

            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
