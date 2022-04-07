﻿namespace HotelCrown.Forms
{
    partial class Rooms
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
            this.gboNewRoom = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRoomNo = new System.Windows.Forms.NumericUpDown();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudNightlyRate = new System.Windows.Forms.NumericUpDown();
            this.lstRoomFeatures = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gboNewRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRooms);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rooms";
            // 
            // gboNewRoom
            // 
            this.gboNewRoom.Controls.Add(this.label5);
            this.gboNewRoom.Controls.Add(this.lstRoomFeatures);
            this.gboNewRoom.Controls.Add(this.txtRoomName);
            this.gboNewRoom.Controls.Add(this.nudNightlyRate);
            this.gboNewRoom.Controls.Add(this.nudCapacity);
            this.gboNewRoom.Controls.Add(this.nudRoomNo);
            this.gboNewRoom.Controls.Add(this.label4);
            this.gboNewRoom.Controls.Add(this.label3);
            this.gboNewRoom.Controls.Add(this.label2);
            this.gboNewRoom.Controls.Add(this.label1);
            this.gboNewRoom.Enabled = false;
            this.gboNewRoom.Location = new System.Drawing.Point(630, 13);
            this.gboNewRoom.Name = "gboNewRoom";
            this.gboNewRoom.Size = new System.Drawing.Size(305, 484);
            this.gboNewRoom.TabIndex = 1;
            this.gboNewRoom.TabStop = false;
            this.gboNewRoom.Text = "New Room";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 503);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 503);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(820, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 41);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(6, 26);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.Size = new System.Drawing.Size(598, 452);
            this.dgvRooms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No#";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(699, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nightly Rate";
            // 
            // nudRoomNo
            // 
            this.nudRoomNo.Location = new System.Drawing.Point(147, 21);
            this.nudRoomNo.Margin = new System.Windows.Forms.Padding(10);
            this.nudRoomNo.Name = "nudRoomNo";
            this.nudRoomNo.Size = new System.Drawing.Size(145, 27);
            this.nudRoomNo.TabIndex = 1;
            this.nudRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRoomNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(147, 61);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(145, 27);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.Text = "Standart";
            this.txtRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(147, 100);
            this.nudCapacity.Margin = new System.Windows.Forms.Padding(10);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(145, 27);
            this.nudCapacity.TabIndex = 1;
            this.nudCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNightlyRate
            // 
            this.nudNightlyRate.Location = new System.Drawing.Point(147, 138);
            this.nudNightlyRate.Margin = new System.Windows.Forms.Padding(10);
            this.nudNightlyRate.Name = "nudNightlyRate";
            this.nudNightlyRate.Size = new System.Drawing.Size(145, 27);
            this.nudNightlyRate.TabIndex = 1;
            this.nudNightlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNightlyRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lstRoomFeatures
            // 
            this.lstRoomFeatures.FormattingEnabled = true;
            this.lstRoomFeatures.ItemHeight = 18;
            this.lstRoomFeatures.Location = new System.Drawing.Point(17, 222);
            this.lstRoomFeatures.Name = "lstRoomFeatures";
            this.lstRoomFeatures.Size = new System.Drawing.Size(275, 238);
            this.lstRoomFeatures.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Features";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(255, 503);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(115, 41);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 556);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gboNewRoom);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.groupBox1.ResumeLayout(false);
            this.gboNewRoom.ResumeLayout(false);
            this.gboNewRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightlyRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gboNewRoom;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRoomFeatures;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.NumericUpDown nudNightlyRate;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.NumericUpDown nudRoomNo;
        private System.Windows.Forms.Button btnAddRoom;
    }
}