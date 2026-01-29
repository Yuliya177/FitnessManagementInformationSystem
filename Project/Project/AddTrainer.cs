using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Project
{
    public partial class AddTrainer : Form
    {
        public AddTrainer()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();


                string name = TrainerName.Text;
                string surname = TrainerSurname.Text;

                string insertQuery = $"INSERT INTO Trainers VALUES ('{name}','{surname}')";

                SqlCommand insertCommand = new SqlCommand(insertQuery, con);

                int affectedrows = insertCommand.ExecuteNonQuery();
                if (affectedrows > 0)
                {
                    MessageBox.Show("Треньорът беше успешно записан!");
                    TrainerName.Clear();
                    TrainerSurname.Clear();
                }
                else
                {
                    MessageBox.Show("Неуспешно добавяне на запис!");
                }
            }
        }

        private void AddTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
