using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FitnessCentre : Form
    {
        public FitnessCentre()
        {
            InitializeComponent();
        }
        public static Trainers trainerForm;
        private void Trainers_Click(object sender, EventArgs e)
        {
            if (trainerForm!=null)
            {
                trainerForm.BringToFront();
            }
            else
            {
                trainerForm = new Trainers();
                trainerForm.FormClosed+=delegate
                { trainerForm = null; };
                trainerForm.Show();
            }
         
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static Clients clientForm;
        private void Clients_Click(object sender, EventArgs e)
        {
            if (clientForm != null)
            {
                clientForm.BringToFront();
            }
            else
            {
                clientForm = new Clients();
                clientForm.Show();
                clientForm.FormClosed += delegate
                {
                    clientForm = null;
                };
            }
                
            
        }


        public static Classes classForm;
        private void Classes_Click(object sender, EventArgs e)
        {
            if (classForm!=null)
            {
                classForm.BringToFront();
            }
            else
            {
                classForm = new Classes();
                classForm.Show();
                classForm.FormClosed += delegate
                {
                    classForm = null;
                };

            }
         
        }

        private void FitnessCentre_Load(object sender, EventArgs e)
        {

        }
    }
}
