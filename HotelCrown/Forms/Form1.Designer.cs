namespace HotelCrown
{
    partial class Form1
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnEditReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmServices = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(291, 87);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(852, 475);
            this.dgvReservations.TabIndex = 0;
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewReservation.Location = new System.Drawing.Point(41, 352);
            this.btnNewReservation.Margin = new System.Windows.Forms.Padding(10);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Padding = new System.Windows.Forms.Padding(10);
            this.btnNewReservation.Size = new System.Drawing.Size(213, 50);
            this.btnNewReservation.TabIndex = 2;
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = true;
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditReservation.Location = new System.Drawing.Point(41, 422);
            this.btnEditReservation.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Padding = new System.Windows.Forms.Padding(10);
            this.btnEditReservation.Size = new System.Drawing.Size(213, 50);
            this.btnEditReservation.TabIndex = 2;
            this.btnEditReservation.Text = "Edit Reservation";
            this.btnEditReservation.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(41, 492);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Padding = new System.Windows.Forms.Padding(10);
            this.btnDeleteReservation.Size = new System.Drawing.Size(213, 50);
            this.btnDeleteReservation.TabIndex = 2;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRooms,
            this.tsmCustomers,
            this.tsmFeatures,
            this.tsmServices});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmRooms
            // 
            this.tsmRooms.Name = "tsmRooms";
            this.tsmRooms.Size = new System.Drawing.Size(75, 22);
            this.tsmRooms.Text = "Rooms";
            this.tsmRooms.Click += new System.EventHandler(this.tsmRooms_Click);
            // 
            // tsmCustomers
            // 
            this.tsmCustomers.Name = "tsmCustomers";
            this.tsmCustomers.Size = new System.Drawing.Size(107, 22);
            this.tsmCustomers.Text = "Customers";
            this.tsmCustomers.Click += new System.EventHandler(this.tsmCustomers_Click);
            // 
            // tsmFeatures
            // 
            this.tsmFeatures.Name = "tsmFeatures";
            this.tsmFeatures.Size = new System.Drawing.Size(91, 22);
            this.tsmFeatures.Text = "Features";
            // 
            // tsmServices
            // 
            this.tsmServices.Name = "tsmServices";
            this.tsmServices.Size = new System.Drawing.Size(87, 22);
            this.tsmServices.Text = "Services";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HotelCrown.Properties.Resources.crown_hotels_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 271);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1153, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnEditReservation);
            this.Controls.Add(this.btnNewReservation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Crown";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnEditReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRooms;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmFeatures;
        private System.Windows.Forms.ToolStripMenuItem tsmServices;
    }
}

