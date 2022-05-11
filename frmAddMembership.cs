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
    public partial class frmAddMembership : Form
    {
        List<Member> lbcontents = new List<Member>();
        List<Membership> lbmscontents = new List<Membership>();

        Member mb = new Member();
        Membership ms = new Membership();
        public frmAddMembership()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {

                List<Member> Members = new List<Member>();
                DataAccess db = new DataAccess();
                Members = db.GetMemberbyID(txtSearchbyID.Text);
                lbcontents = Members;
                listBox2.DataSource = Members;
                listBox2.DisplayMember = "FullInfo";

            }
            else if (rdbTel.Checked)
            {
                List<Member> Members = new List<Member>();
                DataAccess db = new DataAccess();
                Members = db.GetMemberbyTel(txtSearchbyTel.Text);
                lbcontents = Members;
                listBox2.DataSource = Members;
                listBox2.DisplayMember = "FullInfo";
            }
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
        private void txtSearchbyTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mb = lbcontents[listBox2.SelectedIndex];
        }

        private void txtSearchbyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddMembership_Load(object sender, EventArgs e)
        {
            List<Membership> ms = new List<Membership>();
            DataAccess db = new DataAccess();
            ms = db.GetMemberships();
            lbmscontents = ms;
            listBox1.DataSource = ms;
            listBox1.DisplayMember = "FullInfo";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DataAccess db = new DataAccess();
               
                db.AddMembershipMember(ms,mb);
                MessageBox.Show("Membership Succesfully Added to Member!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ms = lbmscontents[listBox1.SelectedIndex];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
