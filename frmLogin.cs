using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GymReceptionTool
{
    public partial class frmLogin : Form
    {
        public static int user;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = chkbox_ShowPassword.Checked ? '\0' : '*';
        }

        private void txtpassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != "" && txtUsername.Text != "")
                {
                List<User> Users = new List<User>();
                DataAccess db = new DataAccess();
                Users = db.GetUser(txtUsername.Text);
                if (Users.Count!=0)
                if (Users[0].Password == txtpassword.Text)
                {
                    user = Users[0].ID;
                    frmMain myNewForm = new frmMain();
                    myNewForm.Visible = true;
                    this.Hide();
                }
                else
                    MessageBox.Show("Authentication failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Username and password are required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            frmAddUser myNewForm = new frmAddUser();
            myNewForm.Visible = true;
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditUser myNewForm = new frmEditUser();
            myNewForm.Visible = true;
            this.Hide();
        }
    }
}
