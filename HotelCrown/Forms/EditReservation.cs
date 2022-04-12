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
    public partial class EditReservation : Form
    {
        private readonly HotelCrownContext db;
        Reservation reservation;

        public EditReservation(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadRooms(db);
            cboRooms.DisplayMember = "RoomNumber";
            LoadInfo(db);
            
        }

        private void LoadRooms(HotelCrownContext db)
        {
            cboRooms.DataSource = db.Rooms.Where(x => x.Reservations.All(r => r.CheckOutDate <= dtpCheckInDate.Value || r.CheckInDate >= dtpCheckOutDate.Value)).ToList();            
            cboRooms.SelectedIndex = -1;
        }

        private void LoadInfo(HotelCrownContext db)
        {

            dgvReservation.DataSource = db.Reservations.Select(x => new
            {
                RoomName = x.RoomName,
                RoomId = x.RoomId,
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,
                CheckedInTime = x.CheckedInTime,
                CheckedOutTime = x.CheckedOutTime,

            }).ToList();
            lstServices.DataSource = db.Services.ToList();
            lstServices.DisplayMember = "ServiceName";
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms(db);
            cboRooms.SelectedIndex = -1;
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms(db);
            cboRooms.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var availableRooms = db.Rooms.Where(x => x.Reservations.All(r => r.CheckOutDate <= dtpCheckInDate.Value || r.CheckInDate >= dtpCheckOutDate.Value)).ToList();

            DateTime dateTimeNow = DateTime.Now;

            if (cbChange.Checked == true)
            {
                if (DateTime.Compare(dateTimeNow, dtpCheckInDate.Value) > 0 || DateTime.Compare(dateTimeNow, dtpCheckOutDate.Value) > 0)
                {
                    MessageBox.Show("You cannot make a reservation to a past date");
                    return;
                }
                if (DateTime.Compare(dtpCheckInDate.Value, dtpCheckOutDate.Value) > 0)
                {
                    MessageBox.Show("Check-In Date must be earlier then Check-Out Date");
                    return;
                }
                SelectedReservation();
                reservation.CheckInDate = dtpCheckInDate.Value;
                reservation.CheckOutDate = dtpCheckOutDate.Value;
            }
            if (cbCheckIn.Checked == true)
            {
                if (DateTime.Compare(dateTimeNow, dtpCheckedInTime.Value) > 0)
                {
                    MessageBox.Show("You cannot make a reservation to a past date");
                    return;
                }
                if (cbCheckOut.Checked == true && DateTime.Compare(dtpCheckedInTime.Value, dtpCheckedOutTime.Value) == 0)
                {
                    MessageBox.Show("CheckIn Date and Check Out date cannot be equal");
                    return;
                }
                if (cbCheckOut.Checked == true && DateTime.Compare(dtpCheckedInTime.Value, dtpCheckedOutTime.Value) > 0)
                {
                    MessageBox.Show("Check-In Date must be earlier then Check-Out Date");
                    return;
                }
                SelectedReservation();
                reservation.CheckedInTime = dtpCheckedInTime.Value;
            }
            if (cbCheckOut.Checked == true)
            {
                if (DateTime.Compare(dateTimeNow, dtpCheckedOutTime.Value) > 0)
                {
                    MessageBox.Show("CheckOut Date must be to the future or now");
                    return;
                }
                SelectedReservation();
                reservation.CheckedOutTime = dtpCheckedOutTime.Value;
            }
            db.SaveChanges();
            this.Refresh();
            LoadRooms(db);
            cboRooms.DisplayMember = "RoomNumber";
            LoadInfo(db);
        }

        private void SelectedReservation()
        {
            string selectedReservation = dgvReservation.SelectedRows[0].Cells[0].Value.ToString();
            reservation = db.Reservations.FirstOrDefault(c => c.RoomName == selectedReservation);
        }
    }
}
