using HotelCrown.Data;
using HotelCrown.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown
{
    public partial class Form1 : Form
    {
        HotelCrownContext db = new HotelCrownContext();
        Reservation reservation;
        public Form1()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            
            dgvReservations.DataSource = db.Reservations.Select(x => new
            {                               
                RoomName = x.RoomName,
                RoomId = x.RoomId,
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,
                CheckedInTime = x.CheckedInTime,
                CheckedOutTime = x.CheckedOutTime,

            }).ToList();
        }

        private void tsmRooms_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(db);
            rooms.ShowDialog();
        }

        private void tsmCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers(db);
            customers.ShowDialog();
        }

        private void tsmFeatures_Click(object sender, EventArgs e)
        {
            Features features = new Features(db);
            features.ShowDialog();
        }

        private void tsmServices_Click(object sender, EventArgs e)
        {
            Services services = new Services(db);
            services.ShowDialog();
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations(db);
            reservations.ReservationChanged += Reservations_ReservationChanged;
            reservations.ShowDialog();
        }

        private void Reservations_ReservationChanged(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            string selectedReservation = dgvReservations.SelectedRows[0].Cells[0].Value.ToString();
            reservation = db.Reservations.FirstOrDefault(c => c.RoomName == selectedReservation);
            db.Reservations.Remove(reservation);
            db.SaveChanges();
            VerileriYukle();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            VerileriYukle();
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            EditReservation editReservation = new EditReservation(db);
            editReservation.ShowDialog();   
        }
    }
}
