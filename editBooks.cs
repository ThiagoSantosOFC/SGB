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
    public partial class editBooks : Form
    {
        public editBooks()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void editBooks_Load(object sender, EventArgs e)
        {
            SectionTools sectionTools = new();
            sectionTools.LoadSectionFile();  

            Section titleSection = sectionTools.GetSection("title");

            Book book = new();
            book.Title = titleSection.value;

            BookDB bookDB = new();
            Connection connection = new();
            bookDB.SetConnection(connection.getConnection());

            book = bookDB.Get(book);

            titleTxb.Text = book.Title;
            authorTxb.Text = book.Author;
            isbnTxb.Text = book.ISBN;
            publisherTxb.Text = book.Publisher;
            yearTxb.Text = book.Year;
            categoryTxb.Text = book.Category;
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

            bookDB.Update(book);

            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
