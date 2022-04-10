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
    public partial class Services : Form
    {
        private readonly HotelCrownContext db;
        Service service;
        public Services(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadServices();
        }

        private void LoadServices()
        {
            dgvServices.DataSource = db.Services.ToList();
        }
        private void SelectedService()
        {
            int selectedService = (int)dgvServices.SelectedRows[0].Cells[0].Value;
            service = db.Services.FirstOrDefault(s => s.Id == selectedService);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedService();
            gboNewService.Enabled = true;
            btnAdd.Visible = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
            btnNew.Enabled = false;
            txtService.Text = service.ServiceName;
            nudUnitPrice.Value = service.UnitPrice;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedService();
            db.Services.Remove(service);
            if (dgvServices.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the service to be edited!");
                return;
            }
            else
            {
                Service newService = new Service()
                {
                    ServiceName = txtService.Text,
                    UnitPrice = nudUnitPrice.Value,
                };
                db.Services.Add(newService);
            }
            db.SaveChanges();
            ResetGroupBox();
            LoadServices();
        }

        private void ResetGroupBox()
        {
            gboNewService.Enabled = false;
            btnAdd.Visible = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            txtService.Text = "";
            nudUnitPrice.Value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the service to be deleted!");
                return;
            }
            else
            {
                SelectedService();
                DialogResult dr = MessageBox.Show
                    (
                        $"Selected service will be deleted permenantly.Do you want to continue?",
                        "Room Deleting",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    db.Services.Remove(service);
                }
                db.SaveChanges();
                LoadServices();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetGroupBox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gboNewService.Enabled = true;
            btnAdd.Visible = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Visible = false;
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedService();
            if (txtService.Text == "")
            {
                MessageBox.Show("Please enter a new feature.");
                return;
            }            
            else
            {
                db.Services.Add(new Service()
                {
                    ServiceName = txtService.Text,
                    UnitPrice = nudUnitPrice.Value,
                });

                db.SaveChanges();
                ResetGroupBox();
                LoadServices();
            }
        }
    }
}
