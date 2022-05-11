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
    public partial class frmAddInstructor : Form
    {
        public frmAddInstructor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if (!IsNumeric(txtTelNo.Text))

                {
                    MessageBox.Show("Invalid value in Telephone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelNo.Select();
                }

                DataAccess db = new DataAccess();
                Instructor instr = new Instructor();
                instr.Name = txtName.Text;
                instr.Surname = txtSurname.Text;
                instr.email = txtemail.Text;
                instr.UserRegistered = frmLogin.user;
                instr.Tel = txtTelNo.Text;
                instr.Address = txtAddress.Text;
                db.InsertInstr(instr);

                MessageBox.Show("Instructor Succesfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTelNo_TextChanged(object sender, EventArgs e)
        {

        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
