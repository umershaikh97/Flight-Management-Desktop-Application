namespace Flight_ManagementApp
{
    partial class Ticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.airpline_lb = new System.Windows.Forms.Label();
            this.airlineid_lb = new System.Windows.Forms.Label();
            this.AirlineLb = new System.Windows.Forms.Label();
            this.flightid_lb = new System.Windows.Forms.Label();
            this.flightidLb = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.airpline_lb);
            this.groupBox1.Controls.Add(this.airlineid_lb);
            this.groupBox1.Controls.Add(this.AirlineLb);
            this.groupBox1.Controls.Add(this.flightid_lb);
            this.groupBox1.Controls.Add(this.flightidLb);
            this.groupBox1.Controls.Add(this.textBoxTicket);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Reservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // airpline_lb
            // 
            this.airpline_lb.AutoSize = true;
            this.airpline_lb.Location = new System.Drawing.Point(91, 89);
            this.airpline_lb.Name = "airpline_lb";
            this.airpline_lb.Size = new System.Drawing.Size(0, 13);
            this.airpline_lb.TabIndex = 10;
            // 
            // airlineid_lb
            // 
            this.airlineid_lb.AutoSize = true;
            this.airlineid_lb.Location = new System.Drawing.Point(92, 112);
            this.airlineid_lb.Name = "airlineid_lb";
            this.airlineid_lb.Size = new System.Drawing.Size(0, 13);
            this.airlineid_lb.TabIndex = 9;
            this.airlineid_lb.Click += new System.EventHandler(this.airlineid_lb_Click);
            // 
            // AirlineLb
            // 
            this.AirlineLb.AutoSize = true;
            this.AirlineLb.Location = new System.Drawing.Point(92, 89);
            this.AirlineLb.Name = "AirlineLb";
            this.AirlineLb.Size = new System.Drawing.Size(0, 13);
            this.AirlineLb.TabIndex = 8;
            // 
            // flightid_lb
            // 
            this.flightid_lb.AutoSize = true;
            this.flightid_lb.Location = new System.Drawing.Point(92, 65);
            this.flightid_lb.Name = "flightid_lb";
            this.flightid_lb.Size = new System.Drawing.Size(0, 13);
            this.flightid_lb.TabIndex = 7;
            this.flightid_lb.Click += new System.EventHandler(this.flightid_lb_Click);
            // 
            // flightidLb
            // 
            this.flightidLb.AutoSize = true;
            this.flightidLb.Location = new System.Drawing.Point(92, 65);
            this.flightidLb.Name = "flightidLb";
            this.flightidLb.Size = new System.Drawing.Size(0, 13);
            this.flightidLb.TabIndex = 6;
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(95, 37);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(133, 20);
            this.textBoxTicket.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airline Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AirlineID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TicketD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FlightID";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label flightidLb;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.Label flightid_lb;
        private System.Windows.Forms.Label airlineid_lb;
        private System.Windows.Forms.Label AirlineLb;
        private System.Windows.Forms.Label airpline_lb;
    }
}