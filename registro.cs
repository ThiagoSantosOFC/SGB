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

            if (
                password_txb.Text == ""
                || confirmarPassword_txb.Text == ""
                || email_txb.Text == ""
                || username_txb.Text == ""
            )
            {
                MessageBox.Show(
                    "Preencha todos os campos",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                if (password_txb.Text == confirmarPassword_txb.Text)
                {
                    if (email_txb.Text.Contains("@") && email_txb.Text.Contains("."))
                    {
                        if (username_txb.Text == "")
                        {
                            MessageBox.Show("O nome de utilizador não pode estar vazio!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                else if (password_txb.Text != confirmarPassword_txb.Text)
                {
                    MessageBox.Show("As passwords não são iguais!");
                }
            }
        }
    }
}
