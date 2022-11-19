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
            SectionTools sectionTools = new();
            sectionTools.LoadSectionFile();
            User user = new();
            user.Name = sectionTools.GetSection("username");
            user.Password = sectionTools.GetSection("password");
            user.Email = sectionTools.GetSection("email");
            user.Id = Convert.ToInt32(sectionTools.GetSection("id"));

            username_txb.Text = user.Name;
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

            MessageBox.Show(user.Password);

            UserDB userDB = new();
            Connection connection = new();
            SectionTools sectionTools = new();

            connection.setDatabase("biblioteca");
            connection.setServer("localhost");
            connection.setPort("3306");
            connection.setUser("root");
            connection.setPassword("123456789");

            userDB.SetConnection(connection.getConnection());

            User validate = userDB.Get(user);

            MessageBox.Show(validate.Name + " " + validate.Password);

            if (validate.Name == null || validate.Password == null)
            {
                MessageBox.Show("Username ou password errados");
                return;
            }
            else if (validate.Password == user.Password)
            {
                MessageBox.Show("Login efetuado com sucesso");
                
                sectionTools.AddSection("username", user.Name, true, false);
                sectionTools.AddSection("password", user.Password, true, false);
                sectionTools.AddSection("email", user.Email, true, false);
                sectionTools.AddSection("id", user.Id.ToString(), true, false);
                sectionTools.SaveSectionFile();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
                return;
            }
        }
    }
}
