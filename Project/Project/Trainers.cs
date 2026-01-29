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
    public partial class Trainers : Form
    {
        public Trainers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                dataGridView1.DataSource= datatable;

            }
        }

        public static AddTrainer addtrainer; 
        private void AddTrainer_Click(object sender, EventArgs e)
        {
            if (addtrainer!=null)
            {
                addtrainer.BringToFront();
            }
            else
            {
                addtrainer = new AddTrainer();
                addtrainer.FormClosed += delegate
                {
                    addtrainer=null;
                };
                addtrainer.Show();
            }
        }
        public static EditTrainer1 editTrainer; 
        private void EditData_Click(object sender, EventArgs e)
        {
            if (editTrainer != null)
            {
                editTrainer.BringToFront();
            }
            else
            {
                editTrainer = new EditTrainer1();
                editTrainer.FormClosed += delegate
                {
                    editTrainer = null;
                };
                editTrainer.Show();
            }
        }

        public static DeleteTrainer1 deleteTrainer; 
        private void DeleteTrainer_Click(object sender, EventArgs e)
        {
            if (deleteTrainer != null)
            {
                deleteTrainer.BringToFront();
            }
            else
            {
                deleteTrainer = new DeleteTrainer1();
                deleteTrainer.FormClosed += delegate
                {
                    deleteTrainer= null;
                };
                deleteTrainer.Show();
            }
        }

        private void Trainers_Load(object sender, EventArgs e)
        {

        }
    }
}
