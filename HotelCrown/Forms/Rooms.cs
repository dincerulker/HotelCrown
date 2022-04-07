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
    public partial class Rooms : Form
    {
        private readonly HotelCrownContext db;
        Room room;
        List<Feature> features = new List<Feature>();
        public Rooms(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            OdalarıGetir();
            OzellikleriYukle();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            gboNewRoom.Enabled = true;
        }

        private void OzellikleriYukle()
        {
            lstRoomFeatures.DataSource = db.Features.ToList();
        }

        private void OdalarıGetir()
        {
            dgvRooms.DataSource = db.Rooms.Select(x => new
            {
                Id = x.Id,
                RoomName = x.RoomName,
                Capacity = x.Capacity,
                Price = x.Price,

            }).ToList();
        }
    }
}
