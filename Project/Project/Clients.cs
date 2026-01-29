using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
     
        private void ShowData_Click(object sender, EventArgs e)
        {
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                string query = "SELECT * FROM Trainers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;

            }
        }

        public static AddClients1 addclient; 
        private void ShowClient_Click(object sender, EventArgs e)
        {
            if (addclient != null)
            {
                addclient.BringToFront();
            }
            else
            {
                addclient = new AddClients1();
                addclient.FormClosed += delegate
                {
                    addclient = null;
                };
                addclient.Show();
            }
        }

        public static DeleteClient delclient;
        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (delclient != null)
            {
                delclient.BringToFront();
            }
            else
            {
                delclient = new DeleteClient();
                delclient.FormClosed += delegate
                {
                    delclient = null;
                };
                delclient.Show();
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }
    }
}
