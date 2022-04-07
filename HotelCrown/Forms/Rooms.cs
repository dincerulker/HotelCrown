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
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gboNewRoom.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Feature item in lstRoomFeatures.SelectedItems)
            {
                features.Add(item);
            }

            if (txtRoomName.Text == "")
            {
                MessageBox.Show("Please enter room name!");
            }
            else if (lstRoomFeatures.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a feature at least!");
            }
            else
            {
                Room newRoom = new Room()
                {
                    Id = (int)nudRoomNo.Value,
                    RoomName = txtRoomName.Text.Trim(),
                    Capacity = (int)nudCapacity.Value,
                    Price = (decimal)nudNightlyRate.Value,
                    Features = features,
                };
                db.Rooms.Add(newRoom);
                db.SaveChanges();
                FormuSifila();
                OdalarıGetir();

            }
        }

        private void FormuSifila()
        {
            nudRoomNo.Value = 1;
            txtRoomName.Text = "Standart";
            nudCapacity.Value = 1;
            nudNightlyRate.Value = 100;
        }
    }
}
