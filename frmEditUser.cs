using System;
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
    public partial class frmEditUser : Form
    {
        List<User> lbcontents = new List<User>();

        User activedit = new User();
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                
                List<User> Users = new List<User>();
                DataAccess db = new DataAccess();
                Users = db.GetUserbyID(txtSID.Text);
                lbcontents = Users;
                listBox1.DataSource = Users;
                listBox1.DisplayMember = "FullInfo";

            }
            else if (rdbTel.Checked)
            {
                List<User> Users = new List<User>();
                DataAccess db = new DataAccess();
                Users = db.GetUserbyTel(txtSPhone.Text);
                lbcontents = Users;
                listBox1.DataSource = Users;
                listBox1.DisplayMember = "FullInfo";
            }

            
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                rdbTel.Checked = false;
                txtSID.Enabled = true;
                txtSPhone.Enabled = false;
            }

        }

        private void rdbTel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTel.Checked)
            {
                rdbID.Checked = false;
                txtSID.Enabled = false;
                txtSPhone.Enabled = true;
            }
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {

        }



        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            User user = new User();
            user.ID = activedit.ID;
            user.Name = txtFullName.Text;
            user.Address = txtAddress.Text;
            user.DateAdded = activedit.DateAdded;
            user.Password = txtPassword.Text;
            user.Tel = txtTelNo.Text;
            user.Username = txtUsername.Text;
            db.UpdateUser(user);
            MessageBox.Show("User Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLogin myNewForm = new frmLogin();
            myNewForm.Visible = true;
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            populate(listBox1.SelectedIndex);
        }

        private void populate(int index) 
        {
            txtAddress.Text = lbcontents[index].Address;
            txtFullName.Text = lbcontents[index].Name;
            txtPassword.PasswordChar = chkbox_ShowPassword.Checked ? '\0' : '*';
            txtConfirmPass.PasswordChar = chkbox_ShowPassword.Checked ? '\0' : '*';
            txtPassword.Text = lbcontents[index].Password;
            txtConfirmPass.Text = lbcontents[index].Password;
            txtTelNo.Text = lbcontents[index].Tel;
            txtUsername.Text = lbcontents[index].Username;
            activedit.ID = lbcontents[index].ID;
            activedit.DateAdded = lbcontents[index].DateAdded;
            
        }

        private void chkbox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkbox_ShowPassword.Checked ? '\0' : '*';
            txtConfirmPass.PasswordChar = chkbox_ShowPassword.Checked ? '\0' : '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin myNewForm = new frmLogin();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            User user = new User();
            user.ID = activedit.ID;
            db.DeleteUser(user);
            MessageBox.Show("User Succesfully Delete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLogin myNewForm = new frmLogin();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
