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
            Section username = new();
            Section password = new();

            password = sectionTools.GetSection("password");
            username = sectionTools.GetSection("username");

            if (password.permanent == true)
            {
                username_txb.Text = username.value;
                password_txb.Text = password.value;
                remenberme_chb.Checked = true;
            }
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
            user.Password = password_txb.Text;

            MessageBox.Show(user.Password);

            UserDB userDB = new();
            Connection connection = new();
            SectionTools sectionTools = new();

            userDB.SetConnection(connection.getConnection());

            User validate = userDB.Get(user);

            MessageBox.Show(validate.Name + " " + validate.Password);

            if (validate == null)
            {
                MessageBox.Show("Username ou password errados");
                return;
            }
            else if (validate.Password == Criptography.sha256_hash(user.Password))
            {
                MessageBox.Show("Login efetuado com sucesso");
                
                if(remenberme_chb.Checked == true)
                {
                    sectionTools.AddSection("username", user.Name, false, true);
                    sectionTools.AddSection("password", user.Password, false, true);
                    sectionTools.AddSection("email", user.Email, true, true);
                    sectionTools.AddSection("id", user.Id.ToString(), false, true);
                    sectionTools.SaveSectionFile();
                    this.Hide();
                }
                else
                {
                    sectionTools.AddSection("username", user.Name, false, false);
                    sectionTools.AddSection("password", user.Password, false, false);
                    sectionTools.AddSection("email", user.Email, false, false);
                    sectionTools.AddSection("id", user.Id.ToString(), false, false);
                    sectionTools.SaveSectionFile();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
                return;
            }
        }
    }
}
