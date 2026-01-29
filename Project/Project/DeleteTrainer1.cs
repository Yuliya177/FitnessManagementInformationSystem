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
    public partial class DeleteTrainer1 : Form
    {
        public DeleteTrainer1()
        {
            InitializeComponent();
            LoadTrainerId();
        }

        private void LoadTrainerId()
        {
            comboBox1.Items.Clear();
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Trainers", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add($"{reader[0]} - {reader[1]} - {reader[2]}");
                }
                reader.Close( );
            }
        }
        

        private void DeleteTrainer_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem==null)
            {
                MessageBox.Show("Моля, изберете ученик!","Грешка!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string trainerId = comboBox1.SelectedItem.ToString().Split('-')[0];
            DialogResult confirm = MessageBox.Show($"Сигурни ли сте, че искате да изтриете ученика?","Потвърждаване",MessageBoxButtons.YesNo);
            string connectiostring = @"Server=LAPTOP-6OQJVU0J;Database=FitnessManagement;Integrated Security=True";
            if (confirm==DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectiostring))
                {
                    con.Open();
                    string delsql = $"DELETE FROM Trainers WHERE TrainerId ={trainerId}"; 
                    SqlCommand cmd = new SqlCommand(delsql, con);   
                    int affectedrows= cmd.ExecuteNonQuery();
                    if (affectedrows>0)
                    {
                        MessageBox.Show("Треньорът беше успешно изтрит!");
                        comboBox1.Text = string.Empty;
                        LoadTrainerId();
                    }
                }
            }
            else
            {
                MessageBox.Show("Грешка при изтриване!","Грешка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteTrainer1_Load(object sender, EventArgs e)
        {

        }
    }
}
