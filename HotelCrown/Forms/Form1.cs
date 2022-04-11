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
            reservations.NewReservation += Reservations_NewReservation;
            reservations.ShowDialog();
        }

        private void Reservations_NewReservation(object sender, EventArgs e)
        {
            dgvReservations.DataSource = db.Reservations.ToList();
        }
    }
}
