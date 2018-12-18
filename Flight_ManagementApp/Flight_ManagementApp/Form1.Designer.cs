namespace Flight_ManagementApp
{
    partial class FormFMS
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
            this.PnlHome = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.PnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHome
            // 
            this.PnlHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlHome.BackgroundImage = global::Flight_ManagementApp.Properties.Resources.aeroplane_11;
            this.PnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlHome.Controls.Add(this.btnExit);
            this.PnlHome.Controls.Add(this.btnView);
            this.PnlHome.Controls.Add(this.btnUpdate);
            this.PnlHome.Controls.Add(this.btnBooking);
            this.PnlHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlHome.Location = new System.Drawing.Point(12, 12);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(818, 465);
            this.PnlHome.TabIndex = 1;
            this.PnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHome_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(593, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnView.Location = new System.Drawing.Point(405, 409);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(127, 31);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnUpdate.Location = new System.Drawing.Point(234, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.Control;
            this.btnBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnBooking.Location = new System.Drawing.Point(68, 409);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(127, 31);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Book Tickets";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // FormFMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 514);
            this.Controls.Add(this.PnlHome);
            this.Name = "FormFMS";
            this.Text = "Flight Management System";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FormFMS_Load_1);
            this.PnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBooking;


    }
}

