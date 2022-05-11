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
    public partial class frmCreateMembership : Form
    {
        public frmCreateMembership()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if (!IsNumeric(txtAmount.Text))

                {
                    MessageBox.Show("Invalid value in Amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Select();
                }

                DataAccess db = new DataAccess();
                Membership ms = new Membership();
                ms.Name = txtName.Text;
                ms.MembershipAmount = int.Parse(txtAmount.Text);
                ms.UserCreated = frmLogin.user;
                ms.MembershipPeriod = int.Parse(txtDuration.Text);
                db.InsertMembership(ms);
                MessageBox.Show("Membership Succesfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void frmCreateMembership_Load(object sender, EventArgs e)
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