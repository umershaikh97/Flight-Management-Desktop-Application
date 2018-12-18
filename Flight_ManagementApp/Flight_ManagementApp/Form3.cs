using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
//using System.Data.SqlClient;

namespace Flight_ManagementApp
{
    public partial class Booking2 : Form
    {

        public MySqlConnection xCon; // For Sql connection 
        public DataTable xGrid = new DataTable();  //xGrid for fetching data from database 

        public Booking2()
        {
            xCon = new MySqlConnection("SERVER=localhost; DATABASE=project; UID=root; PASSWORD=root;"); 
            InitializeComponent();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            FormFMS FormHomeOpen = new FormFMS();
            FormHomeOpen.Show();
            Visible = false;
        }

        private void btnNext1_Click(object sender, EventArgs e) // It will store passenger info into database
        {
            xCon.Open();
            xGrid.Clear();
           xGrid.Reset();
           string query = "Insert into passenger_info values ( NOW()+0 ,'"+FnametextBox.Text+"','"+LnametextBox.Text+"','"+AddresstextBox.Text+"','"+PhoneNumtextBox.Text+"','"+EmailtextBox.Text+"','"+CNICtextBox.Text+"');";
         //  string query2 = "Insert into ticket_info values ( NOW()+0 ,'" + FnametextBox.Text + "','" + LnametextBox.Text + "','" + AddresstextBox.Text + "','" + PhoneNumtextBox.Text + "','" + EmailtextBox.Text + "','" + CNICtextBox.Text + "');";
            MySqlCommand cmd = new MySqlCommand(query, xCon);
            cmd.ExecuteNonQuery();
            xCon.Close();



            Ticket FormOpen = new Ticket                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ();
            FormOpen.Show();
            Visible = false;

        }

        private void Booking2_Load(object sender, EventArgs e)
        {

        }

        private void FnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

    

      

    }
}
