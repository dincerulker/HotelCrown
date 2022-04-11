using HotelCrown.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.Forms
{
    public partial class Customers : Form
    {
        private readonly HotelCrownContext db;
        Gender gender;
        Customer customer;
        public Customers(HotelCrownContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            btnSave.Visible = false;
            dgvCustomers.DataSource = db.Customers.Select(x => new
            {
                FullName = x.FullName,
                ID = x.IdentityNumber,
                PhoneNumber = x.PhoneNumber,
                BirthDate = DbFunctions.TruncateTime(x.BirthDate),
                Gender = x.Gender,
                AdditionalInfo = x.Description
            }).ToList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            gboNewCustomer.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelation();
            ResetGroupBox();
        }

        private void Cancelation()
        {
            gboNewCustomer.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Visible = false;
            btnAdd.Visible = true;
            chbMan.Checked = false;
            chbWomen.Checked = false;
        }

        private void ResetGroupBox()
        {
            txtName.Text = "";
            txtIdNumber.Text = "";
            txtPhone.Text = "";
            txtAdditionalInfo.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            //chbMan.Checked = false;
            //chbWomen.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadGenders();
            
            if (txtName.Text == "" && txtIdNumber.Text == "" && txtPhone.Text == "")
            {
                MessageBox.Show("Please add customer's information");
                return;
            }
            // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtIdNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in the ID field.");
                txtIdNumber.Text = txtIdNumber.Text.Remove(txtIdNumber.Text.Length - 1);
                return;
            }
            else if ((chbMan.Checked) && (chbWomen.Checked))
            {
                MessageBox.Show("Please choose one gender!");
                return ;
            }
            else
            {
                Customer customer = new Customer()
                {
                    FullName = txtName.Text,
                    IdentityNumber = txtIdNumber.Text,
                    PhoneNumber = txtPhone.Text,
                    BirthDate = dtpBirthDate.Value,
                    Gender = gender,
                    Description = txtAdditionalInfo.Text
                };
                if (chbMan.Checked)
                {
                    chbWomen.Checked = false;
                }
                db.Customers.Add(customer);
                db.SaveChanges();
                ResetGroupBox();
                LoadCustomers();
            }
        }

        private void LoadGenders()
        {
            if (chbMan.Checked)
            {
                gender = Gender.Erkek;
                
            }
            else
            {
                gender = Gender.Kadın;
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                SelectedCustomer();
                DialogResult dr = MessageBox.Show
                    (
                        $"Selected customer will be deleted permenantly.Do you want to continue?",
                        "Customer Deleting",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    db.Customers.Remove(customer);
                }
                db.SaveChanges();
                LoadCustomers();
                
            }

        }

        private void SelectedCustomer()
        {
            string selectedCustomer = dgvCustomers.SelectedRows[0].Cells[0].Value.ToString();
            customer = db.Customers.FirstOrDefault(c => c.FullName == selectedCustomer);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedCustomer();
            gboNewCustomer.Enabled = true;
            btnSave.Visible = true;
            btnAdd.Visible = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            chbWomen.Checked = false;
            chbMan.Checked = false;
            txtName.Text = customer.FullName;
            txtIdNumber.Text = customer.IdentityNumber;
            txtPhone.Text = customer.PhoneNumber;
            dtpBirthDate.Value = customer.BirthDate;
            txtAdditionalInfo.Text = customer.Description;
            if (chbMan.Checked)
            {
                gender = customer.Gender;
            }
            else
            {
                gender = customer.Gender;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedCustomer();
            LoadGenders();
            db.Customers.Remove(customer);
            if (dgvCustomers.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please select the customer to be edited!");
                return;
            }

            else if ((chbMan.Checked) && (chbWomen.Checked))
            {
                MessageBox.Show("Please choose one gender!");
                return;
            }
            else
            {
                Customer customer = new Customer()
                {
                    IdentityNumber = txtIdNumber.Text,
                    FullName = txtName.Text,
                    PhoneNumber = txtPhone.Text,
                    BirthDate = dtpBirthDate.Value,
                    Description = txtAdditionalInfo.Text,
                    Gender = gender,
                };

                db.Customers.Add(customer);
            }
            db.SaveChanges();
            LoadCustomers();
            ResetGroupBox();
            Cancelation();
        }
    }
}
