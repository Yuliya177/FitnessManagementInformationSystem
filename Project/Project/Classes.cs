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


namespace Project
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                string query = "SELECT * FROM Classes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;

            }
        }

        public static EditClass editcl; 
        private void EditClass_Click(object sender, EventArgs e)
        {
            if (editcl != null)
            {
                editcl.BringToFront();
            }
            else
            {
                editcl = new EditClass();
                editcl.Show();
                editcl.FormClosed += delegate
                {
                    editcl = null;
                };
            }
        }

        private void Classes_Load(object sender, EventArgs e)
        {

        }

        public static DeleteClass delclass; 
        private void DeleteClass_Click(object sender, EventArgs e)
        {
            if (delclass != null)
            {
                delclass.BringToFront();
            }
            else
            {
                delclass = new DeleteClass();
                delclass.Show();
                delclass.FormClosed += delegate
                {
                    delclass = null;
                };
            }
        }
    }
}
