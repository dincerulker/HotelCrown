namespace HotelCrown.Forms
{
    partial class EditReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReservation));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.dtpCheckedOutTime = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckedInTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCheckIn = new System.Windows.Forms.CheckBox();
            this.cbCheckOut = new System.Windows.Forms.CheckBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.Rooms = new System.Windows.Forms.Label();
            this.cbChange = new System.Windows.Forms.CheckBox();
            this.cbRefresh = new System.Windows.Forms.CheckBox();
            this.nudServiceQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Reservation";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(12, 200);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(287, 29);
            this.dtpCheckInDate.TabIndex = 2;
            this.dtpCheckInDate.ValueChanged += new System.EventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check-In Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Check-Out Date";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(12, 268);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(287, 29);
            this.dtpCheckOutDate.TabIndex = 2;
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // dgvReservation
            // 
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(12, 37);
            this.dgvReservation.MultiSelect = false;
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersVisible = false;
            this.dgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservation.Size = new System.Drawing.Size(1047, 118);
            this.dgvReservation.TabIndex = 3;
            // 
            // dtpCheckedOutTime
            // 
            this.dtpCheckedOutTime.Location = new System.Drawing.Point(751, 268);
            this.dtpCheckedOutTime.Name = "dtpCheckedOutTime";
            this.dtpCheckedOutTime.Size = new System.Drawing.Size(308, 29);
            this.dtpCheckedOutTime.TabIndex = 2;
            // 
            // dtpCheckedInTime
            // 
            this.dtpCheckedInTime.Location = new System.Drawing.Point(751, 200);
            this.dtpCheckedInTime.Name = "dtpCheckedInTime";
            this.dtpCheckedInTime.Size = new System.Drawing.Size(308, 29);
            this.dtpCheckedInTime.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Checked-In Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Checked-Out Time";
            // 
            // cbCheckIn
            // 
            this.cbCheckIn.AutoSize = true;
            this.cbCheckIn.Location = new System.Drawing.Point(940, 172);
            this.cbCheckIn.Name = "cbCheckIn";
            this.cbCheckIn.Size = new System.Drawing.Size(104, 28);
            this.cbCheckIn.TabIndex = 4;
            this.cbCheckIn.Text = "Check-In";
            this.cbCheckIn.UseVisualStyleBackColor = true;
            // 
            // cbCheckOut
            // 
            this.cbCheckOut.AutoSize = true;
            this.cbCheckOut.Location = new System.Drawing.Point(940, 237);
            this.cbCheckOut.Name = "cbCheckOut";
            this.cbCheckOut.Size = new System.Drawing.Size(119, 28);
            this.cbCheckOut.TabIndex = 4;
            this.cbCheckOut.Text = "Check-Out";
            this.cbCheckOut.UseVisualStyleBackColor = true;
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 24;
            this.lstServices.Location = new System.Drawing.Point(341, 197);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(370, 100);
            this.lstServices.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Services";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(341, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboRooms
            // 
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(12, 334);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(287, 32);
            this.cboRooms.TabIndex = 7;
            // 
            // Rooms
            // 
            this.Rooms.AutoSize = true;
            this.Rooms.Location = new System.Drawing.Point(12, 307);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(70, 24);
            this.Rooms.TabIndex = 1;
            this.Rooms.Text = "Rooms";
            // 
            // cbChange
            // 
            this.cbChange.AutoSize = true;
            this.cbChange.Location = new System.Drawing.Point(12, 372);
            this.cbChange.Name = "cbChange";
            this.cbChange.Size = new System.Drawing.Size(213, 28);
            this.cbChange.TabIndex = 4;
            this.cbChange.Text = "Change Rooms Dates";
            this.cbChange.UseVisualStyleBackColor = true;
            // 
            // cbRefresh
            // 
            this.cbRefresh.AutoSize = true;
            this.cbRefresh.Location = new System.Drawing.Point(12, 400);
            this.cbRefresh.Name = "cbRefresh";
            this.cbRefresh.Size = new System.Drawing.Size(233, 28);
            this.cbRefresh.TabIndex = 4;
            this.cbRefresh.Text = "Refresh Reservation Info";
            this.cbRefresh.UseVisualStyleBackColor = true;
            // 
            // nudServiceQuantity
            // 
            this.nudServiceQuantity.Location = new System.Drawing.Point(493, 307);
            this.nudServiceQuantity.Name = "nudServiceQuantity";
            this.nudServiceQuantity.Size = new System.Drawing.Size(218, 29);
            this.nudServiceQuantity.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Service Quantitiy";
            // 
            // EditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 440);
            this.Controls.Add(this.nudServiceQuantity);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.cbCheckOut);
            this.Controls.Add(this.cbRefresh);
            this.Controls.Add(this.cbChange);
            this.Controls.Add(this.cbCheckIn);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.dtpCheckedOutTime);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.dtpCheckedInTime);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditReservation";
            this.Text = "Edit Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DateTimePicker dtpCheckedOutTime;
        private System.Windows.Forms.DateTimePicker dtpCheckedInTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCheckIn;
        private System.Windows.Forms.CheckBox cbCheckOut;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.Label Rooms;
        private System.Windows.Forms.CheckBox cbChange;
        private System.Windows.Forms.CheckBox cbRefresh;
        private System.Windows.Forms.NumericUpDown nudServiceQuantity;
        private System.Windows.Forms.Label label7;
    }
}