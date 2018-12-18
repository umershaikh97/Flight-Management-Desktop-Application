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
    public partial class FormBooking1 : Form
    {


        string destination;    // User ko kaha jana hai
        string depart_datetime; // depart date
        string AirlineName; // Airline
        public MySqlConnection xCon; // For Sql connection 
        public DataTable xGrid = new DataTable();  //xGrid for fetching data from database 

        public FormBooking1()
        {
            xCon = new MySqlConnection("SERVER=localhost; DATABASE=project; UID=root; PASSWORD=root;"); 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFMS FormFmsOpen = new FormFMS();
            FormFmsOpen.Show();
            Visible = false;
        }


        public void pass(string airline)
        {
            Ticket FormFmsOpen = new Ticket(airline);

        }



        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            destination = Destinationcombo.Text;
            //MessageBox.Show(destination);
           // Datecombo.Focus();

          //  xGrid.Clear();
          // Datecombo.Items.Clear();
          //--- Datecombo.ResetText();
           Datecombo_SelectedIndexChanged(sender,e);


        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            xCon.Open();
            xGrid.Clear();
            xGrid.Reset();
            new MySqlDataAdapter("SELECT Arrival_Location from airplane", xCon).Fill(xGrid);
            xCon.Close();

            for (int i = 0; i < xGrid.Rows.Count; i++)
            {
                if (!Destinationcombo.Items.Contains(xGrid.Rows[i][0].ToString()))
                    Destinationcombo.Items.Add(xGrid.Rows[i][0].ToString());
          
            }

            xGrid.Clear();
            xGrid.Reset();

            //Datecombo.Items.Clear();
         //   Destinationcombo.Focus();
           // Datecombo.Items.Clear(); 
              comboBox1_SelectedIndexChanged(sender,e);
        }

        private void Datecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            xCon.Open();
            xGrid.Reset();
            //Datecombo.Items.Clear();
            //xGrid.Clear();
            new MySqlDataAdapter("select depart_time from flight_details inner join airplane on flight_details.FlightID = airplane.FlightID where Arrival_Location =  '"+destination+"' ;", xCon).Fill(xGrid);
           // MessageBox.Show(xGrid.Rows.Count.ToString());
            xCon.Close();




           // MessageBox.Show(xGrid.Rows[0][0].ToString());
           // MessageBox.Show(xGrid.Rows[0][1].ToString());
            //Datecombo.Items.Clear();
            for (int i = 0; i < xGrid.Rows.Count; i++)
            {
                if (!Datecombo.Items.Contains(xGrid.Rows[i][0].ToString()))
                    Datecombo.Items.Add(xGrid.Rows[i][0].ToString());
                
            }
            xGrid.Clear();
            xGrid.Reset();
            depart_datetime = Datecombo.Text;
            //Airlinecombo.Focus();
            Airlinecombo_SelectedIndexChanged_1(sender, e);

        }


        private void Airlinecombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            xCon.Open();
            xGrid.Reset();
            //Datecombo.Items.Clear();
            //xGrid.Clear();
            new MySqlDataAdapter("select flight.AirlineName from flight inner join airplane on flight.FlightID = airplane.FlightID where airplane.Arrival_Location = '" + destination + "' ;", xCon).Fill(xGrid);
            // MessageBox.Show(xGrid.Rows.Count.ToString());
            xCon.Close();
            for (int i = 0; i < xGrid.Rows.Count; i++)
            {
                if (!Airlinecombo.Items.Contains(xGrid.Rows[i][0].ToString()))
                    Airlinecombo.Items.Add(xGrid.Rows[i][0].ToString());
            }

           // MessageBox.Show(xGrid.Rows.Count.ToString());

            xGrid.Clear();
            xGrid.Reset();
             //Airlinecombo.Focus();
            AirlineName = Airlinecombo.Text;
          //------  Airlinecombo.ResetText();
            //ticketpricecb_SelectedIndexChanged(sender,e);
            
        //  ticketlb_Click(sender,e);
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            FormFMS FormHomeOpen = new FormFMS();
            FormHomeOpen.Show();
            Visible = false;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            Booking2 FormNextOpen = new Booking2();
             FormNextOpen.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




       




       /* private void ticketpricecb_SelectedIndexChanged(object sender, EventArgs e)
        {

            xCon.Open();
            xGrid.Reset();
            //Datecombo.Items.Clear();
            //xGrid.Clear();
           //MessageBox.Show(AirlineName);
            new MySqlDataAdapter("select ticket_price from flight where AirlineName ='"+Airlinecombo.Text+"';", xCon).Fill(xGrid);
            // MessageBox.Show(xGrid.Rows.Count.ToString());
            xCon.Close();
            
            for (int i = 0; i < xGrid.Rows.Count; i++)
            {
                if (!ticketpricecb.Items.Contains(xGrid.Rows[i][0].ToString()))
                    ticketpricecb.Items.Add(xGrid.Rows[i][0].ToString());
            }

           // MessageBox.Show(xGrid.Rows.Count.ToString());

            xGrid.Clear();
            xGrid.Reset();
            //Airlinecombo.Focus();
            //ticketP = ticketpricecb.Text;
           //---- ticketpricecb.ResetText();



        }

   */

 
    }
}
