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
                Id = x.Id,
                RoomId = x.RoomId,
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,

            }).ToList();
        }

        private void tsmRooms_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(db);
            rooms.ShowDialog();
        }
    }
}
