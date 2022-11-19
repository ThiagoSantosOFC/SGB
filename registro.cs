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
            User user = new();

            user.Name = username_txb.Text;
            user.Email = email_txb.Text;
            user.Password = password_txb.Text;

            MessageBox.Show(user.Name + " " + user.Email + " " + user.Password);

            string valid = user.UserIsValid();

            if (password_txb.Text != confirmarPassword_txb.Text)
            {
                MessageBox.Show("As passwords não são iguais");
            }
            else if (username_txb.Text == "")
            {
                MessageBox.Show("O username não pode estar vazio");
            }
            else if (email_txb.Text == "")
            {
                MessageBox.Show("O email não pode estar vazio");
            }
            else if (password_txb.Text == "")
            {
                MessageBox.Show("A password não pode estar vazia");
            }
            else if (confirmarPassword_txb.Text == "")
            {
                MessageBox.Show("A confirmação da password não pode estar vazia");
            }
            else if (valid != "")
            {
                MessageBox.Show(valid);
            }
            else
            {
                User validateUser = new();
                IData data = new UserDB();
                Connection connection = new();
                
                connection.setDatabase("biblioteca");
                connection.setServer("localhost");
                connection.setPassword("123456789");
                connection.setPort("3306");
                connection.setUser("root");

                data.SetConnection(connection.getConnection());

                validateUser = data.Get(user);

                if (validateUser.Name != null)
                {
                    MessageBox.Show("Já existe um utilizador com esse email ou nome");
                }
                else
                {
                    user.Password = Criptography.sha256_hash(user.Password);
                    data.Insert(user);
                    MessageBox.Show("Registado com sucesso");
                    
                    //Trash all the instances
                    user = null;
                    validateUser = null;
                    data = null;
                    connection = null;

                    this.Hide();
                    login log = new login();
                    log.Show();
                }
            }
        }
    }
}
