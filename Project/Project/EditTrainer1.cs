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
    public partial class EditTrainer1 : Form
    {
        public EditTrainer1()
        {
            InitializeComponent();
        }

        private void LoadTrainers()
        {
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                string query = "SELECT TrainerId FROM Trainers";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader  = cmd.ExecuteReader();
                ChooseTrId.Items.Clear();
                while (reader.Read())
                {
                    ChooseTrId.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
        }
        
        private void EditTrainer1_Load(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void ChooseTrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trainerId = int.Parse(ChooseTrId.SelectedItem.ToString());
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                string query = $"SELECT FirstName, LastName FROM Trainers WHERE TrainerId = {trainerId}";
                SqlCommand cmd = new SqlCommand(query, con);    
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                EditName.Text= reader[0].ToString();
                EditSurname.Text= reader[1].ToString();
                reader.Close(); 
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (ChooseTrId.SelectedItem==null)
            {
                MessageBox.Show("Моля, изберете ID от списъка!");
                return; 
            }
            else
            {
                int trainerId = int.Parse(ChooseTrId.SelectedItem.ToString());
                string name = EditName.Text; 
                string surname=EditSurname.Text;
                string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectiostring))
                {
                    con.Open();
                    string query = $"UPDATE Trainers SET FirstName='{name}', LastName='{surname}' WHERE TrainerId = {trainerId}";
                    SqlCommand cmd = new SqlCommand (query, con);   
                    int affectedrows = cmd.ExecuteNonQuery();
                    if (affectedrows>0)
                    {
                        MessageBox.Show("Данните бяха успешно записани!"); 
                        EditName.Clear();
                        EditSurname.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Неуспешна актуализация!");
                    }
                }
            }
        }
    }
}
