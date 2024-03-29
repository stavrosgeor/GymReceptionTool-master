﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymReceptionTool
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!IsNumeric(txtTelNo.Text))

            {
                MessageBox.Show("Invalid value in Telephone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelNo.Select();
            }

            else if (txtConfirmPass.Text == txtPassword.Text)
            {
                DataAccess db = new DataAccess();
                User user = new User();
                user.Name = txtFullName.Text;
                user.Address = txtAddress.Text;
                user.DateAdded = DateTime.Now.Date;
                user.Password = txtPassword.Text;
                user.Tel = txtTelNo.Text;
                user.Username = txtUsername.Text;

                db.InsertUser(user);

                MessageBox.Show("User Succesfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLogin myNewForm = new frmLogin();
                myNewForm.Visible = true;
                this.Hide();
            }
            
            }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin myNewForm = new frmLogin();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }

}