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
    public partial class frmAddPayment : Form
    {
        Member mb = new Member();
        List<Member> lbcontents = new List<Member>();
        public frmAddPayment()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if (!IsNumeric(txtAmount.Text))

                {
                    MessageBox.Show("Invalid value in Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Select();
                }

                DataAccess db = new DataAccess();
                Payment pay = new Payment();
                pay.Amount = int.Parse(txtAmount.Text);
                pay.MemberID = mb.ID;
                pay.Note = txtNote.Text;
                pay.PDate = DateTime.Today;
                pay.PTime = DateTime.Now;
                pay.UserID = frmLogin.user;
                db.AddPaymentMember(pay,mb);
                MessageBox.Show("Payment Succesfully Added to Member!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
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

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                rdbTel.Checked = false;
                txtSearchbyID.Enabled = true;
                txtSearchbyTel.Enabled = false;
            }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mb = lbcontents[listBox2.SelectedIndex];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
