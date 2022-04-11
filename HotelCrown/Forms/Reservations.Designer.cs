﻿namespace HotelCrown.Forms
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnUnMatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(391, 504);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(297, 29);
            this.dtpCheckInDate.TabIndex = 1;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(391, 539);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(297, 29);
            this.dtpCheckOutDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check-In Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check-Out Date";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(468, 574);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(220, 40);
            this.btnAddReservation.TabIndex = 3;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 24;
            this.lstCustomers.Location = new System.Drawing.Point(9, 36);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(262, 364);
            this.lstCustomers.TabIndex = 4;
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 24;
            this.lstRooms.Location = new System.Drawing.Point(281, 36);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(262, 364);
            this.lstRooms.TabIndex = 4;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(156, 430);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(262, 42);
            this.btnMatch.TabIndex = 5;
            this.btnMatch.Text = "Match Room/Customer";
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // btnUnMatch
            // 
            this.btnUnMatch.Location = new System.Drawing.Point(428, 430);
            this.btnUnMatch.Name = "btnUnMatch";
            this.btnUnMatch.Size = new System.Drawing.Size(262, 42);
            this.btnUnMatch.TabIndex = 5;
            this.btnUnMatch.Text = "Un-Match Room/Customer";
            this.btnUnMatch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Match a customer and a room by choosing.";
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 24;
            this.lstServices.Location = new System.Drawing.Point(555, 36);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(262, 364);
            this.lstServices.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Services";
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 622);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUnMatch);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.dtpCheckInDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 573);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnUnMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.Label label6;
    }
}