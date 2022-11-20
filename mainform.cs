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
            //select books from database
        }

        private void sairConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //logout from accout, dispose section
            this.Hide();
            login log = new login();
            log.Show();
            
        }

        private void attDados_Click(object sender, EventArgs e)
        {
            //select books from db and put into datagridLivro
            
            
        }
    }
}
