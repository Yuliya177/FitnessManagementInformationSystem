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
    public partial class AddClients1 : Form
    {
        public AddClients1()
        {
            InitializeComponent();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            string connectiostring = ConfigurationManager.ConnectionStrings["FitnessDB"].ConnectionString; 
            using (SqlConnection con = new SqlConnection(connectiostring))
            {
                con.Open();
                string getLastId = "SELECT MAX(ClientId) FROM Clients"; 
                SqlCommand cmd = new SqlCommand(getLastId, con);    
                SqlDataReader reader = cmd.ExecuteReader(); 
                reader.Read();
                 
                int newId = Convert.ToInt32(reader[0])+1;
                reader.Close(); 

                string name = NameCl.Text;
                string surname = SurnameCl.Text;
                string email = EmailCl.Text;
                string phone= ClientPh.Text;
                string date = StartDate.Text;


                string insertQuery = $"INSERT INTO Clients VALUES ({newId},'{name}','{surname}','{email}','{phone}','{date}')";

                SqlCommand insertCommand = new SqlCommand(insertQuery, con);

                int affectedrows = insertCommand.ExecuteNonQuery();
                if (affectedrows > 0)
                {
                    MessageBox.Show("Клиентът беше успешно записан!");
                    NameCl.Clear();
                    SurnameCl.Clear();
                    EmailCl.Clear();    
                    ClientPh.Clear();
                    StartDate.Clear();  
                }
                else
                {
                    MessageBox.Show("Неуспешно добавяне на запис!");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddClients1_Load(object sender, EventArgs e)
        {

        }
    }
}
