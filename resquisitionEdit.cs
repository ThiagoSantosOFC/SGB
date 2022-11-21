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
    public partial class resquisitionEdit : Form
    {
        public resquisitionEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new();

            Temp temp = new();
            temp.ReadFile();
            string id = temp.Get("id");

            Requesition requesition = new();
            requesition.Id = int.TryParse(id, out int result) ? result : 0;

            RequisitionDB requisitionDB = new();
            requisitionDB.SetConnection(connection.getConnection());

            requesition = requisitionDB.Get(requesition);

            requesition.entrega = DateTime.Now.ToString("yyyy-MM-dd");

            requisitionDB.Update(requesition);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
