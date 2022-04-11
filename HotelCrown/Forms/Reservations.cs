using HotelCrown.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.Forms
{
    public partial class Reservations : Form
    {
        private readonly HotelCrownContext db;

        public Reservations(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadCustomers(db);
            LoadRooms(db);
        }

        private void LoadRooms(HotelCrownContext db)
        {
            lstRooms.DataSource = db.Rooms.Where(r => r.Reservations.All(x => x.CheckOutDate <= dtpCheckInDate.Value || x.CheckInDate >= dtpCheckOutDate.Value)).ToList();
            lstRooms.SelectedIndex = -1;
        }

        private void LoadCustomers(HotelCrownContext db)
        {
            lstCustomers.DataSource = db.Customers.Where(c => c.Reservations == null).ToList();
            lstCustomers.SelectedIndex = -1;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lstCustomers.SelectedItem;
            Room room = (Room)lstRooms.SelectedItem;
            DateTime dateTime = DateTime.Now;
            if (lstRooms.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a room!");
                return;
            }
            else if (lstCustomers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer!");
                return;
            }
            else if (DateTime.Compare(dateTime, dtpCheckInDate.Value) > 0 || DateTime.Compare(dateTime, dtpCheckOutDate.Value) > 0)
            {
                MessageBox.Show("You cannot make a reservation to a past date");
                return;
            }
            else if (DateTime.Compare(dtpCheckInDate.Value,dtpCheckOutDate.Value) > 0)
            {
                MessageBox.Show("Check-In Date must be earlier then Check-Out Date");
                return;
            }

        }
    }
}
