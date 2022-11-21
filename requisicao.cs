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
    public partial class requisicao : Form
    {
        public requisicao()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string? userid = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Temp temp = new();
            temp.Add("id", userid ?? "null");
            temp.WriteFile();

            resquisitionEdit resquisitionEdit = new();
            resquisitionEdit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertRequisicao insertRequisicao = new();
            insertRequisicao.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void requisicao_Load(object sender, EventArgs e)
        {
            SectionTools sectionTools = new();
            sectionTools.LoadSectionFile();

            Section username = new();

            username = sectionTools.GetSection("username");

            User user = new();
            user.Name = username.value;

            UserDB userDB = new();
            Connection connection = new();

            userDB.SetConnection(connection.getConnection());

            user = userDB.Get(user);

            Requesition req = new();
            req.UserId = user.Id;

            RequisitionDB reqDB = new();
            reqDB.SetConnection(connection.getConnection());

            List<Requesition> reqList = new();

            reqList = reqDB.GetRequisitions(user);

            foreach (Requesition r in reqList)
            {
                dataGridView1.Rows.Add(r.Id, r.levantamento, r.entrega, r.BookId);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            SectionTools sectionTools = new();
            sectionTools.LoadSectionFile();

            Section username = new();

            username = sectionTools.GetSection("username");

            User user = new();
            user.Name = username.value;

            UserDB userDB = new();
            Connection connection = new();

            userDB.SetConnection(connection.getConnection());

            user = userDB.Get(user);

            Requesition req = new();
            req.UserId = user.Id;

            RequisitionDB reqDB = new();
            reqDB.SetConnection(connection.getConnection());

            List<Requesition> reqList = new();

            reqList = reqDB.GetRequisitions(user);

            foreach (Requesition r in reqList)
            {
                dataGridView1.Rows.Add(r.Id, r.levantamento, r.entrega, r.BookId);
            }
        }
    }
}
