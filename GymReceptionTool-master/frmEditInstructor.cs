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
    public partial class frmEditInstructor : Form
    {
        List<Instructor> Instructors = new List<Instructor>();
        Instructor activedit = new Instructor();
        public frmEditInstructor()
        {
            InitializeComponent();
        }

        private void frmEditInstructor_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Instructors = db.GetInstructors();
            listBox1.DataSource = Instructors;
            listBox1.DisplayMember = "lbInfo";
        }
        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Instructor instr = new Instructor();
            instr.ID = activedit.ID;
            instr.Name = txtName.Text;
            instr.Surname = txtSurname.Text;
            instr.email = txtemail.Text;
            instr.UserRegistered = activedit.UserRegistered;
            instr.Tel = txtTelNo.Text;
            instr.Address = txtAddress.Text;
            db.InsertInstr(instr);

            MessageBox.Show("Instructor Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void rdbTel_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            populate(listBox1.SelectedIndex);   
        }
        public void populate(int index)
        {
            txtName.Text = Instructors[index].Name;
            txtSurname.Text = Instructors[index].Surname;
            txtAddress.Text = Instructors[index].Address;
            txtTelNo.Text = Instructors[index].Tel;
            txtemail.Text = Instructors[index].email;
            activedit.UserRegistered = Instructors[index].UserRegistered;
                    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Instructor instr = new Instructor();
            instr.ID = activedit.ID;
            db.DeleteInstructor(instr);
            MessageBox.Show("Instructor Succesfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
