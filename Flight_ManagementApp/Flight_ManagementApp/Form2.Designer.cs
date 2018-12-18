namespace Flight_ManagementApp
{
    partial class FormBooking1
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
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAirline = new System.Windows.Forms.Label();
            this.Destinationcombo = new System.Windows.Forms.ComboBox();
            this.Datecombo = new System.Windows.Forms.ComboBox();
            this.Airlinecombo = new System.Windows.Forms.ComboBox();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnHome.Location = new System.Drawing.Point(15, 458);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // lblAirline
            // 
            this.lblAirline.AutoSize = true;
            this.lblAirline.Location = new System.Drawing.Point(17, 91);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(35, 13);
            this.lblAirline.TabIndex = 5;
            this.lblAirline.Text = "Airline";
            // 
            // Destinationcombo
            // 
            this.Destinationcombo.FormattingEnabled = true;
            this.Destinationcombo.Location = new System.Drawing.Point(109, 24);
            this.Destinationcombo.Name = "Destinationcombo";
            this.Destinationcombo.Size = new System.Drawing.Size(151, 21);
            this.Destinationcombo.TabIndex = 8;
            this.Destinationcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Datecombo
            // 
            this.Datecombo.FormattingEnabled = true;
            this.Datecombo.Location = new System.Drawing.Point(109, 54);
            this.Datecombo.Name = "Datecombo";
            this.Datecombo.Size = new System.Drawing.Size(151, 21);
            this.Datecombo.TabIndex = 9;
            this.Datecombo.SelectedIndexChanged += new System.EventHandler(this.Datecombo_SelectedIndexChanged);
            // 
            // Airlinecombo
            // 
            this.Airlinecombo.FormattingEnabled = true;
            this.Airlinecombo.Location = new System.Drawing.Point(109, 88);
            this.Airlinecombo.Name = "Airlinecombo";
            this.Airlinecombo.Size = new System.Drawing.Size(151, 21);
            this.Airlinecombo.TabIndex = 10;
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome1.Location = new System.Drawing.Point(12, 363);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(101, 31);
            this.btnHome1.TabIndex = 11;
            this.btnHome1.Text = "Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Airlinecombo);
            this.groupBox1.Controls.Add(this.lblAirline);
            this.groupBox1.Controls.Add(this.Datecombo);
            this.groupBox1.Controls.Add(this.Destinationcombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 82);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.Location = new System.Drawing.Point(519, 363);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(101, 31);
            this.btnNext1.TabIndex = 14;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // FormBooking1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 406);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.btnHome);
            this.Name = "FormBooking1";
            this.Text = "Booking1";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.ComboBox Destinationcombo;
        private System.Windows.Forms.ComboBox Datecombo;
        private System.Windows.Forms.ComboBox Airlinecombo;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNext1;
    }
}