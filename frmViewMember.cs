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
    public partial class frmViewMember : Form
    {
        List<Member> lbcontents = new List<Member>();
        List<Payment> Payments = new List<Payment>();
        Member activedit = new Member();
        public string pathFolder = Application.StartupPath + @"\ImageCapture\";
        public frmViewMember()
        {
            InitializeComponent();
        }

        private void frmViewMember_Load(object sender, EventArgs e)
        {

        }
        public void populate(int index)
        {
            DataAccess db = new DataAccess();
            txtName.Text = lbcontents[index].Name;
            txtSurname.Text = lbcontents[index].Surname;
            txtAge.Text = lbcontents[index].Age.ToString();
            txtAddress.Text = lbcontents[index].Address;
            txtTelNo.Text = lbcontents[index].Tel;
            txtemail.Text = lbcontents[index].email;
            txtGender.Text = lbcontents[index].Gender;
            txtInstructor.Text = db.GetInstactorName(lbcontents[index].Instructor.ToString());
            txtID.Text = lbcontents[index].ID.ToString();
            txtBalance.Text = lbcontents[index].Balance.ToString();
            txtJoinDate.Text = lbcontents[index].JoinDate.ToString();
            txtMembershipExp.Text = lbcontents[index].MembershipExp.ToString();
            txtMembershipName.Text = db.GetMembershipName(lbcontents[index].MembershipID.ToString());
            txtUserRegistered.Text = db.GetUserName(lbcontents[index].UserRegistered.ToString());
            Payments = db.GetPaymentbyMID(lbcontents[index].ID.ToString());
            listBox2.DataSource = Payments;
            listBox2.DisplayMember = "lbInfo";
            try
            {
                pictureBox1.ImageLocation = pathFolder + @"Member" + lbcontents[index].ID.ToString() + ".bmp";
            }
            catch (Exception Ex) { };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {

                List<Member> Members = new List<Member>();
                DataAccess db = new DataAccess();
                Members = db.GetMemberbyID(txtSearchbyID.Text);
                lbcontents = Members;
                listBox1.DataSource = Members;
                listBox1.DisplayMember = "FullInfo";

            }
            else if (rdbTel.Checked)
            {
                List<Member> Members = new List<Member>();
                DataAccess db = new DataAccess();
                Members = db.GetMemberbyTel(txtSearchbyTel.Text);
                lbcontents = Members;
                listBox1.DataSource = Members;
                listBox1.DisplayMember = "FullInfo";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate(listBox1.SelectedIndex);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                rdbTel.Checked = false;
                txtSearchbyID.Enabled = true;
                txtSearchbyTel.Enabled = false;
            }
        }

        private void rdbTel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTel.Checked)
            {
                rdbID.Checked = false;
                txtSearchbyID.Enabled = false;
                txtSearchbyTel.Enabled = true;
            }
        }
    }
}
