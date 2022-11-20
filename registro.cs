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
using biblioteca.models;
using biblioteca.tools;
using biblioteca.interfaces;
using Dapper;
using MySql.Data.MySqlClient;
namespace SGB
{
    public partial class registro : Form
    {

        public registro()
        {
            InitializeComponent();
        }

        private void voltarlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open form login
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //verifica se as password são iguais, verifica se o email é válido
            
            // password_txb.Text == ""
            //     || confirmarPassword_txb.Text == ""
            //     || email_txb.Text == ""
            //     || username_txb.Text == ""
            UserFactory userFactory = new();
            User user = userFactory
            .setEmail(email_txb.Text)
            .setName(username_txb.Text)
            .setPassword(Criptography.sha256_hash(password_txb.Text))
            .build();
            if (email_txb.Text == "" || username_txb.Text == "" || password_txb.Text == "" || confirmarPassword_txb.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (user.Password != Criptography.sha256_hash(confirmarPassword_txb.Text))
            {
                MessageBox.Show("As passwords não são iguais");
                return;
            }
            else if (userFactory.EmailIsValid == false)
            {
                MessageBox.Show("Email inválido");
                return;
            }
            else
            {
                UserDB userDB = new();
                Connection connection = new();

                userDB.SetConnection(connection.getConnection());

                User verifyUser = userDB.Get(user);

                if ((verifyUser.Name != null) && (verifyUser.Email != null))
                {
                    MessageBox.Show("Utilizador já existe");
                }
                else
                {
                    if(userDB.Insert(user) == true)
                    {
                        MessageBox.Show("Registado com sucesso");
                        this.Hide();
                        login log = new login();
                        log.Show();
                    }
                }
            }
        }
    }
}
