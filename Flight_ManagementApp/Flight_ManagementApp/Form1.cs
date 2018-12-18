using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flight_ManagementApp
{
    public partial class FormFMS : Form
    {
         public MySqlConnection xCon; // For Sql connection 
         public DataTable xGrid = new DataTable();  //xGrid for fetching data from database 
         
        public FormFMS()
        {
        xCon = new MySqlConnection("SERVER=localhost; DATABASE=project; UID=root; PASSWORD=root;"); 
        InitializeComponent();
        }

        private void FormFMS_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FormBooking1 FormBookingOpen = new FormBooking1();
            FormBookingOpen.Show();
            Visible = false;
            
        }

        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormFMS_Load_1(object sender, EventArgs e)
        {

        }

        private void LblHeading_Click_1(object sender, EventArgs e)
        {

        }

        private void LblHeading_Click_2(object sender, EventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {

        }





    }
}



