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
    public partial class frmEditMember : Form
    {
        List<Member> lbcontents = new List<Member>();
        List<Instructor> Instructors = new List<Instructor>();
        Member activedit = new Member();
        public frmEditMember()
        {
            InitializeComponent();
        }

        private void frmEditMember_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Instructors = db.GetInstructors();
            listBox2.DataSource = Instructors;
            listBox2.DisplayMember = "lbInfo";
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

        private void rdbID_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                rdbTel.Checked = false;
                txtSearchbyID.Enabled = true;
                txtSearchbyTel.Enabled = false;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Member member = new Member();
            member.Name = txtName.Text;
            member.Surname = txtSurname.Text;
            member.JoinDate = activedit.JoinDate;
            member.MembershipExp = activedit.MembershipExp;
            member.Age = int.Parse(txtAge.Text);
            member.Address = txtAddress.Text;
            member.Tel = txtTelNo.Text;
            member.email = txtemail.Text;
            member.Balance = activedit.Balance;
            member.Gender = cmbGender.SelectedItem.ToString();
            member.UserRegistered = activedit.UserRegistered;
            member.Instructor = Instructors[listBox1.SelectedIndex].ID;
            member.MembershipID =activedit.MembershipID;
            db.UpdateMember(member);

            MessageBox.Show("Member Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
        }
    

        private void rdbTel_CheckedChanged_1(object sender, EventArgs e)
        {

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
            groupBox1.Enabled = true;
            populate(listBox1.SelectedIndex);
        }

        public void populate(int index)
        {
            try
            {

                txtName.Text = lbcontents[index].Name;
                txtSurname.Text = lbcontents[index].Surname;
                txtAge.Text = lbcontents[index].Age.ToString();
                txtAddress.Text = lbcontents[index].Address;
                txtTelNo.Text = lbcontents[index].Tel;
                txtemail.Text = lbcontents[index].email;
                cmbGender.SelectedItem = lbcontents[index].Gender;
                int comp = 0;
                for (int i = 0; i < Instructors.Count + 1; i++)
                    if (Instructors[i].ID == lbcontents[index].Instructor)
                        comp = i;
                listBox2.SelectedIndex = comp;
                activedit.ID = lbcontents[index].ID;
                activedit.Balance = lbcontents[index].Balance;
                activedit.JoinDate = lbcontents[index].JoinDate;
                activedit.MembershipExp = lbcontents[index].MembershipExp;
                activedit.MembershipID = lbcontents[index].MembershipID;
                activedit.UserRegistered = lbcontents[index].UserRegistered;
            }
            catch (Exception Ex) { };
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Member member = new Member();
            member.ID = activedit.ID;
            db.DeleteMember(member);
            MessageBox.Show("Member Succesfully Delete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbTel_CheckedChanged_2(object sender, EventArgs e)
        {
            if (rdbTel.Checked)
            {
                rdbID.Checked = false;
                txtSearchbyID.Enabled = false;
                txtSearchbyTel.Enabled = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
