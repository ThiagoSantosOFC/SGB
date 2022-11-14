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
            if (password_txb.Text == confirmarPassword_txb.Text)
            {
                MessageBox.Show("Conta criada com sucesso");
            }
            else
            {
                MessageBox.Show("As senhas não coincidem");
            }
        }
    }
}
