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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            List<Book> books = new();
            Book book = new();
            Connection connection = new();
            BookDB bookDB = new();
            bookDB.SetConnection(connection.getConnection());

            books = bookDB.GetBooks();

            foreach (Book b in books)
            {
                //Ordem de colunas: Id, Titulo, Autor, Editora, Ano, Categoria
                datagridLivros.Rows.Add(b.Id, b.Title, b.Author, b.ISBN, b.Publisher, b.Year, b.Category);
            }
        }

        private void sairConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //logout from accout, dispose section
            SectionTools sectionTools = new();

            sectionTools.PurgeTemporarySections();

            this.Hide();
            login log = new login();
            log.Show();
        }

        private void attDados_Click(object sender, EventArgs e)
        {
            insertBook insertBook = new();
            insertBook.Show();
        }

        private void datagridLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Titulo
            string? title = datagridLivros.CurrentRow.Cells[1].Value.ToString();
            
            Temp temp = new();
            temp.Add("title", title == null ? "" : title);
            temp.WriteFile();

            editBooks edit = new editBooks();
            edit.Show();
        }
        private void openReq_Click(object sender, EventArgs e)
        {
            requisicao req = new requisicao();
            req.Show();
        }

        private void openReq_Click_1(object sender, EventArgs e)
        {
            requisicao req = new requisicao();
            req.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear datagrid
            datagridLivros.Rows.Clear();

            //Reload datagrid
            List<Book> books = new();
            Book book = new();
            Connection connection = new();
            BookDB bookDB = new();
            bookDB.SetConnection(connection.getConnection());

            books = bookDB.GetBooks();

            foreach (Book b in books)
            {
                //Ordem de colunas: Id, Titulo, Autor, Editora, Ano, Categoria
                datagridLivros.Rows.Add(b.Id, b.Title, b.Author, b.ISBN, b.Publisher, b.Year, b.Category);
            }
        }
    }
}
