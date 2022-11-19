using biblioteca.models;
using biblioteca.tools;
using biblioteca.database;
using biblioteca.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB
{
    public partial class login : Form
    {
 

        public login()
        {
            InitializeComponent();
         
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void criarcontaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open form resgitro
            this.Hide();
            registro reg = new registro();
            reg.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new();

            user.Name = username_txb.Text;
            user.Password = Criptography.sha256_hash(password_txb.Text);

            UserDB userDB = new();
            Connection connection = new();
        }
    }
}
