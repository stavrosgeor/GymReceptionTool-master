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
    }
}
