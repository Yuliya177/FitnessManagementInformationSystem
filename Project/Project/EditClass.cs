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
    public partial class EditClass : Form
    {
        public EditClass()
        {
            InitializeComponent();
            
        }
        private void LoadClasses()
        {
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                string query = "SELECT ClassesId FROM Classes";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ClassesId.Items.Clear();
                while (reader.Read())
                {
                    ClassesId.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
        }
        private void EditClass_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (ClassesId.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете ID от списъка!");
                return;
            }
            else
            {
                int classId = int.Parse(ClassesId.SelectedItem.ToString());
                string type = ClassType.Text;
                string price = ClassPrice.Text;
                string date = ClassDate.Text;
                string trId = TrainerId.Text;
                string connectiostring = @"Server=LAPTOP-6OQJVU0J;Database=FitnessManagement;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectiostring))
                {
                    con.Open();
                    string query = $"UPDATE Classes SET ClassesType='{type}', Price='{price}', Date = '{date}', TrainerId = '{trId}' WHERE ClassesId = {classId}";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int affectedrows = cmd.ExecuteNonQuery();
                    if (affectedrows > 0)
                    {
                        MessageBox.Show("Данните бяха успешно записани!");
                        ClassType.Clear();
                        ClassPrice.Clear();
                        ClassDate.Clear();
                        TrainerId.Clear();
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
