using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GymReceptionTool
{
    public partial class frmMain : Form
    {
        public string pathFolder = Application.StartupPath + @"\ImageCapture\";
        public frmMain()
        {
            InitializeComponent();
        }
        BindingList<Member> onpremises = new BindingList<Member>();
        private void button1_Click(object sender, EventArgs e)
        {
            frmEditMember myNewForm = new frmEditMember();
            myNewForm.Visible = true;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstOnPremises.DataSource = onpremises;
            lstOnPremises.DisplayMember = "onPremises";
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddMember myNewForm = new frmAddMember();
            myNewForm.Visible = true;
            
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            frmViewMember myNewForm = new frmViewMember();
            myNewForm.Visible = true;

        }

        private void btnAddNewInstructor_Click(object sender, EventArgs e)
        {
            frmAddInstructor myNewForm = new frmAddInstructor();
            myNewForm.Visible = true;

        }

        private void btnEditInstructor_Click(object sender, EventArgs e)
        {
            frmEditInstructor myNewForm = new frmEditInstructor();
            myNewForm.Visible = true;

        }

        private void btnCreateMembership_Click(object sender, EventArgs e)
        {
            frmCreateMembership myNewForm = new frmCreateMembership();
            myNewForm.Visible = true;

        }

        private void btnEditMembership_Click(object sender, EventArgs e)
        {
            frmEditMembership myNewForm = new frmEditMembership();
            myNewForm.Visible = true;

        }

        private void btwNewPayment_Click(object sender, EventArgs e)
        {
            frmAddPayment myNewForm = new frmAddPayment();
            myNewForm.Visible = true;

        }

        private void btnViewMemberPayments_Click(object sender, EventArgs e)
        {
            frmViewMember myNewForm = new frmViewMember();
            myNewForm.Visible = true;

        }

        private void btnAddtoMember_Click(object sender, EventArgs e)
        {
            
            frmAddMembership myNewForm = new frmAddMembership();
            myNewForm.Visible = true;

        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            List<Member> member = new List<Member>();
            member = db.GetMembers();
            bool isint = false;
            bool exists = true;
            do
            {
                try
                {
                    int input = int.Parse(Interaction.InputBox("Please enter the ID of the Member:", "ID","", -1, -1));
                    isint = true;

                    bool del = false;
                    for (int i = 0; i < onpremises.Count; i++)
                    {
                        if (input == onpremises[i].ID)
                        {
                            onpremises.RemoveAt(lstOnPremises.SelectedIndex);
                            lstOnPremises.DataSource = onpremises;
                            lstOnPremises.DisplayMember = "FullInfo";
                            del = true;
                            exists = true;
                        }

                    }
                    if (!del)
                    {
                        for (int i = 0; i < member.Count; i++)
                        {
                            if (input == member[i].ID)
                            {
                                onpremises.Add(member[i]);

                                lstOnPremises.DataSource = onpremises;
                                lstOnPremises.DisplayMember = "FullInfo";
                                exists = true;
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("You must provide a number", "Error", MessageBoxButtons.OK);
                }
            } while (exists == false);
        }

        private void lstOnPremises_SelectedIndexChanged(object sender, EventArgs e)
        {

            populate(lstOnPremises.SelectedIndex);
        }

        public void populate(int index)
        {
            try
            {
                lblBalanceOP.Text = onpremises[index].Balance.ToString();
                lblExpDateOP.Text = onpremises[index].MembershipExp.ToString();
                lblNameOP.Text = onpremises[index].Name;
                lblSurnameOP.Text = onpremises[index].Surname;
                if (onpremises[index].MembershipExp < DateTime.Today)
                    lblExpDateOP.ForeColor = Color.Red;
                else
                    lblExpDateOP.ForeColor = Color.Green;
                if (onpremises[index].Balance < 0)
                    lblBalanceOP.ForeColor = Color.Red;
                else
                    lblBalanceOP.ForeColor = Color.Green;
            }
            catch (Exception Ex) { };

            try
            {
                pbOP.ImageLocation = pathFolder + @"Member" + onpremises[index].ID.ToString() + ".bmp";
            }
            catch (Exception Ex) { };
            



         }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnAddMemberPhoto_Click(object sender, EventArgs e)
        {
            frmCamCap myNewForm = new frmCamCap();
            myNewForm.Visible = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
