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
    public partial class frmAddMember : Form
    {
        List<Instructor> Instructors = new List<Instructor>();
        Membership registration = new Membership();
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Instructors = db.GetInstructors();
            listBox1.DataSource = Instructors;
            listBox1.DisplayMember = "lbInfo";
            registration = db.GetRegMembership();
            lblRFee.Text = registration.MembershipAmount.ToString() + " euro"; 

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DataAccess db = new DataAccess();
                Member member = new Member();
                
                member.Name = txtName.Text;
                member.Surname = txtSurname.Text;
                member.JoinDate = DateTime.Today;
                member.MembershipExp = DateTime.Today;
                member.Age = int.Parse(txtAge.Text);
                member.Address = txtAddress.Text;
                member.Tel = txtTelNo.Text;
                member.email = txtemail.Text;
                member.Balance =-registration.MembershipAmount;
                member.Gender = cmbGender.SelectedItem.ToString();
                member.UserRegistered = frmLogin.user;
                member.Instructor = Instructors[listBox1.SelectedIndex].ID;
                member.MembershipID = 1;
                db.InsertMember(member);

                MessageBox.Show("Member Succesfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
            }
        }

        private void lblRFee_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }


    }
}
