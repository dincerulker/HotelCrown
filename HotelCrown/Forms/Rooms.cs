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
            btnSave.Visible = false;
            btnAdd.Visible = true;
        }

        private void OzellikleriYukle()
        {
            lstRoomFeatures.DataSource = db.Features.ToList();
        }
        private void SelectedRoom()
        {
            int selectedRoom = (int)dgvRooms.SelectedRows[0].Cells[0].Value;
            room = db.Rooms.FirstOrDefault(r => r.Id == selectedRoom);
        }
        private void OdalarıGetir()
        {
            dgvRooms.DataSource = db.Rooms.Select(x => new
            {
                Id = x.Id,
                RoomNumber = x.RoomNumber,
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
            btnSave.Visible = false;
            btnAdd.Visible = true;
            FormuSifirla();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            foreach (Feature item in lstRoomFeatures.SelectedItems)
            {
                features.Add(item);
            }

            if (txtRoomName.Text == "")
            {
                MessageBox.Show("Please enter room name!");
                return;
            }
            else if (lstRoomFeatures.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a feature at least!");
                return;
            }
            else
            {
                db.Rooms.Add(new Room()
                {
                    RoomNumber = (int)nudRoomNo.Value,
                    RoomName = txtRoomName.Text.Trim(),
                    Capacity = (int)nudCapacity.Value,
                    Price = (decimal)nudNightlyRate.Value,
                    Features = features,
                });
                db.SaveChanges();
                FormuSifirla();
                OdalarıGetir();

            }
        }

        private void FormuSifirla()
        {
            nudRoomNo.Value = 1;
            txtRoomName.Text = "Standart";
            nudCapacity.Value = 1;
            nudNightlyRate.Value = 100;
            lstRoomFeatures.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the room to be deleted!");
            }
            else
            {
                SelectedRoom();
                DialogResult dr = MessageBox.Show
                    (
                        $"Selected room will be deleted permenantly.Do you want to continue?",
                        "Room Deleting",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    db.Rooms.Remove(room);
                }
                db.SaveChanges();
                OdalarıGetir();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRoom();
            gboNewRoom.Enabled = true;
            btnSave.Visible = true;
            btnAdd.Visible = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            nudRoomNo.Value = room.Id;
            nudNightlyRate.Value = room.Price;
            nudCapacity.Value = room.Capacity;
            txtRoomName.Text = room.RoomName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.Rooms.Remove(room);
            SelectedRoom();
            if (dgvRooms.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the room to be edited!");
            }
            else
            {
                Room newRoom = new Room()
                {
                    RoomNumber = (int)nudRoomNo.Value,
                    RoomName = txtRoomName.Text.Trim(),
                    Capacity = (int)nudCapacity.Value,
                    Price = (decimal)nudNightlyRate.Value,
                    Features = features,
                };
                db.Rooms.Add(newRoom);
            }
            db.SaveChanges();
            OdalarıGetir();
        }
    }
}