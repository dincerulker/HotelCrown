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
    public partial class Features : Form
    {
        private readonly HotelCrownContext db;
        Feature feature;
        public Features(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadFeatures();
        }

        private void LoadFeatures()
        {
            dgvFeatures.DataSource = db.Features.ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedFeature();
            gboNewFeature.Enabled = true;
            btnAdd.Visible = false;
            btnSave.Visible = true;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            txtFeature.Text = feature.FeatureName;
        }
        


        private void SelectedFeature()
        {
            int selectedFeautre = (int)dgvFeatures.SelectedRows[0].Cells[0].Value;
            feature = db.Features.FirstOrDefault(r => r.Id == selectedFeautre);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedFeature();
            db.Features.Remove(feature);
            if (dgvFeatures.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the room to be edited!");
                return;
            }
            else
            {
                Feature newFeature = new Feature()
                {
                    FeatureName = txtFeature.Text
                };
                db.Features.Add(newFeature);
            }
            db.SaveChanges();
            ResetGroupBox();
            LoadFeatures();
        }

        private void ResetGroupBox()
        {
            gboNewFeature.Enabled = false;
            btnAdd.Visible = true;
            btnSave.Visible = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            txtFeature.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFeatures.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the feature to be deleted!");
                return;
            }
            else
            {
                SelectedFeature();
                DialogResult dr = MessageBox.Show
                    (
                        $"Selected feature will be deleted permenantly.Do you want to continue?",
                        "Room Deleting",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    db.Features.Remove(feature);
                }
                db.SaveChanges();
                LoadFeatures();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetGroupBox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gboNewFeature.Enabled = true;
            btnAdd.Visible = true;
            btnSave.Visible = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedFeature();
            
            if (txtFeature.Text == "")
            {
                MessageBox.Show("Please enter a new feature.");
                return;
            }
            else
            {
                db.Features.Add(new Feature()
                {
                    FeatureName = txtFeature.Text,
                });

                db.SaveChanges();
                ResetGroupBox();
                LoadFeatures();
            }
        }
    }
}
