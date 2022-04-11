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
        List<Room> rooms = new List<Room>();
        List<Customer> customers = new List<Customer>();
        List<Service> services = new List<Service>();
        public event EventHandler NewReservation;

        public Reservations(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadCustomers(db);
            LoadRooms(db);
            LoadServices(db);

        }

        private void LoadServices(HotelCrownContext db)
        {
            lstServices.DataSource = db.Services.ToList();
            lstServices.DisplayMember = "ServiceName";
            lstServices.SelectedIndex = -1;
        }

        private void LoadRooms(HotelCrownContext db)
        {
            lstRooms.DataSource = db.Rooms.Where(r => r.Reservations.All(x => x.CheckOutDate <= dtpCheckInDate.Value || x.CheckInDate >= dtpCheckOutDate.Value)).ToList();
            lstRooms.DisplayMember = "RoomName";
            lstRooms.SelectedIndex = -1;
        }

        private void LoadCustomers(HotelCrownContext db)
        {
            lstCustomers.DataSource = db.Customers.ToList();
            lstCustomers.DisplayMember = "FullName";
            lstCustomers.SelectedIndex = -1;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lstCustomers.SelectedItem;
            Room room = (Room)lstRooms.SelectedItem;
            DateTime dateTime = DateTime.Now;
            var availableRooms = db.Rooms.Where(x => x.Reservations.All(r => r.CheckOutDate <= dtpCheckInDate.Value || r.CheckInDate >= dtpCheckOutDate.Value)).ToList();
            lstRooms.DataSource = availableRooms;
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
            else if (DateTime.Compare(dtpCheckInDate.Value, dtpCheckOutDate.Value) > 0)
            {
                MessageBox.Show("Check-In Date must be earlier then Check-Out Date");
                return;
            }
            //if (room.Capacity < room.Reservations.Count())
            //{
            //    MessageBox.Show("Room capacity is full, please select another room.");
            //    return ;
            //}
            LoadObjects();
            Reservation reservation = new Reservation()
            {
                Customers = customers,
                Rooms = rooms,
                Services = services,
                CheckInDate = dtpCheckInDate.Value,
                CheckOutDate = dtpCheckOutDate.Value,
                RoomName = room.RoomName,
                RoomId = room.RoomNumber,
                
            };
            //reservation.CheckInDate = dtpCheckInDate.Value;
            //reservation.CheckOutDate = dtpCheckOutDate.Value;
            //reservation.RoomName = room.RoomName;
            //room.Reservations.Add(reservation);

            if (availableRooms.Contains(room))
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
            }
        }

        private void LoadObjects()
        {
            foreach (Customer item in lstCustomers.SelectedItems)
            {
                customers.Add(item);
            }
            foreach (Room item in lstRooms.SelectedItems)
            {
                rooms.Add(item);
            }
            foreach (Service item in lstServices.SelectedItems)
            {
                services.Add(item);
            }
        }
    }
}
