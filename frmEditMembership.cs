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
    
    public partial class frmEditMembership : Form
    {
        List<Membership> lbcontents = new List<Membership>();
        Membership activedit = new Membership();
        public frmEditMembership()
        {
            InitializeComponent();
        }

        private void frmEditMembership_Load(object sender, EventArgs e)
        {
            List<Membership> ms = new List<Membership>();
            DataAccess db = new DataAccess();

            ms = db.GetMemberships();
            lbcontents = ms;
            listBox1.DataSource = ms;
            listBox1.DisplayMember = "FullInfo";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            populate(listBox1.SelectedIndex);

        }
        public void populate(int index)
        {
            txtName.Text = lbcontents[index].Name;
            txtDuration.Text = lbcontents[index].MembershipAmount.ToString();
            DataAccess db = new DataAccess();
            txtCreatedby.Text = db.GetUserName(lbcontents[index].UserCreated.ToString());
            txtCreatedby.Enabled = false;
            txtAmount.Text = lbcontents[index].MembershipAmount.ToString();
            activedit.ID = lbcontents[index].ID;
            activedit.UserCreated = lbcontents[index].UserCreated;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Membership ms = new Membership();
            ms.Name = txtName.Text;
            ms.ID = activedit.ID;
            ms.MembershipAmount = int.Parse(txtAmount.Text);
            ms.MembershipPeriod = int.Parse(txtDuration.Text);
            ms.UserCreated = activedit.UserCreated;

            db.UpdateMembership(ms);

            MessageBox.Show("Membership Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Membership ms = new Membership();
            ms.ID = activedit.ID;
            db.DeleteMembership(ms);
            MessageBox.Show("Membership Succesfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
    }

