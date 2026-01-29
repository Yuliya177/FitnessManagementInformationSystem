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

namespace Project
{
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();
            LoadClientId();
        }
        private void LoadClientId()
        {
            comboBox1.Items.Clear();
            string connectiostring = @"Server=LAPTOP-6OQJVU0J;Database=FitnessManagement;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Clients", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add($"{reader[0]} - {reader[1]} - {reader[2]}-{reader[3]}-{reader[4]}-{reader[5]}");
                }
                reader.Close();
            }
        }
        private void DeleteClient_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете трньор!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string clientId = comboBox1.SelectedItem.ToString().Split('-')[0];
            DialogResult confirm = MessageBox.Show($"Сигурни ли сте, че искате да изтриете клиента?", "Потвърждаване", MessageBoxButtons.YesNo);
            string connectiostring = @"Server=LAPTOP-6OQJVU0J;Database=FitnessManagement;Integrated Security=True";
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectiostring))
                {
                    con.Open();
                    string delsql = $"DELETE FROM Clients WHERE ClientId ={clientId}";
                    SqlCommand cmd = new SqlCommand(delsql, con);
                    int affectedrows = cmd.ExecuteNonQuery();
                    if (affectedrows > 0)
                    {
                        MessageBox.Show("Клиентът беше успешно изтрит!");
                        comboBox1.Text = string.Empty;
                        LoadClientId();
                    }
                }
            }
            else
            {
                MessageBox.Show("Грешка при изтриване!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
