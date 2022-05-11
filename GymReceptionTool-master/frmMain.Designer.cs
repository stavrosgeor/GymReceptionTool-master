
namespace GymReceptionTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditInstructor = new System.Windows.Forms.Button();
            this.btnAddNewInstructor = new System.Windows.Forms.Button();
            this.lstOnPremises = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBalanceOP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExpDateOP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSurnameOP = new System.Windows.Forms.Label();
            this.lblNameOP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.pbOP = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddtoMember = new System.Windows.Forms.Button();
            this.btnEditMembership = new System.Windows.Forms.Button();
            this.btnCreateMembership = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnViewMemberPayments = new System.Windows.Forms.Button();
            this.btwNewPayment = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddMemberPhoto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOP)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMemberPhoto);
            this.groupBox1.Controls.Add(this.btnViewMember);
            this.groupBox1.Controls.Add(this.btnEditMember);
            this.groupBox1.Controls.Add(this.btnAddNewMember);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members";
            // 
            // btnViewMember
            // 
            this.btnViewMember.Location = new System.Drawing.Point(50, 114);
            this.btnViewMember.Name = "btnViewMember";
            this.btnViewMember.Size = new System.Drawing.Size(169, 26);
            this.btnViewMember.TabIndex = 3;
            this.btnViewMember.Text = "View Member";
            this.btnViewMember.UseVisualStyleBackColor = true;
            this.btnViewMember.Click += new System.EventHandler(this.btnViewMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Location = new System.Drawing.Point(50, 83);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(169, 26);
            this.btnEditMember.TabIndex = 2;
            this.btnEditMember.Text = "Edit/Delete";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.Location = new System.Drawing.Point(50, 15);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(169, 29);
            this.btnAddNewMember.TabIndex = 1;
            this.btnAddNewMember.Text = "Add New";
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditInstructor);
            this.groupBox2.Controls.Add(this.btnAddNewInstructor);
            this.groupBox2.Location = new System.Drawing.Point(23, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructor";
            // 
            // btnEditInstructor
            // 
            this.btnEditInstructor.Location = new System.Drawing.Point(50, 54);
            this.btnEditInstructor.Name = "btnEditInstructor";
            this.btnEditInstructor.Size = new System.Drawing.Size(169, 26);
            this.btnEditInstructor.TabIndex = 2;
            this.btnEditInstructor.Text = "Edit/Delete";
            this.btnEditInstructor.UseVisualStyleBackColor = true;
            this.btnEditInstructor.Click += new System.EventHandler(this.btnEditInstructor_Click);
            // 
            // btnAddNewInstructor
            // 
            this.btnAddNewInstructor.Location = new System.Drawing.Point(50, 19);
            this.btnAddNewInstructor.Name = "btnAddNewInstructor";
            this.btnAddNewInstructor.Size = new System.Drawing.Size(169, 29);
            this.btnAddNewInstructor.TabIndex = 1;
            this.btnAddNewInstructor.Text = "Add New";
            this.btnAddNewInstructor.UseVisualStyleBackColor = true;
            this.btnAddNewInstructor.Click += new System.EventHandler(this.btnAddNewInstructor_Click);
            // 
            // lstOnPremises
            // 
            this.lstOnPremises.FormattingEnabled = true;
            this.lstOnPremises.Location = new System.Drawing.Point(324, 40);
            this.lstOnPremises.Name = "lstOnPremises";
            this.lstOnPremises.Size = new System.Drawing.Size(404, 355);
            this.lstOnPremises.TabIndex = 5;
            this.lstOnPremises.SelectedIndexChanged += new System.EventHandler(this.lstOnPremises_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Currently on premises:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBalanceOP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblExpDateOP);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblSurnameOP);
            this.groupBox3.Controls.Add(this.lblNameOP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.pbOP);
            this.groupBox3.Location = new System.Drawing.Point(755, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 307);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QuickWatch";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblBalanceOP
            // 
            this.lblBalanceOP.AutoSize = true;
            this.lblBalanceOP.Location = new System.Drawing.Point(100, 265);
            this.lblBalanceOP.Name = "lblBalanceOP";
            this.lblBalanceOP.Size = new System.Drawing.Size(33, 13);
            this.lblBalanceOP.TabIndex = 10;
            this.lblBalanceOP.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Balance:";
            // 
            // lblExpDateOP
            // 
            this.lblExpDateOP.AutoSize = true;
            this.lblExpDateOP.Location = new System.Drawing.Point(100, 243);
            this.lblExpDateOP.Name = "lblExpDateOP";
            this.lblExpDateOP.Size = new System.Drawing.Size(33, 13);
            this.lblExpDateOP.TabIndex = 8;
            this.lblExpDateOP.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Exp. Date:";
            // 
            // lblSurnameOP
            // 
            this.lblSurnameOP.AutoSize = true;
            this.lblSurnameOP.Location = new System.Drawing.Point(100, 220);
            this.lblSurnameOP.Name = "lblSurnameOP";
            this.lblSurnameOP.Size = new System.Drawing.Size(33, 13);
            this.lblSurnameOP.TabIndex = 4;
            this.lblSurnameOP.Text = "None";
            // 
            // lblNameOP
            // 
            this.lblNameOP.AutoSize = true;
            this.lblNameOP.Location = new System.Drawing.Point(100, 198);
            this.lblNameOP.Name = "lblNameOP";
            this.lblNameOP.Size = new System.Drawing.Size(33, 13);
            this.lblNameOP.TabIndex = 3;
            this.lblNameOP.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 198);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Name:";
            // 
            // pbOP
            // 
            this.pbOP.Location = new System.Drawing.Point(48, 19);
            this.pbOP.Name = "pbOP";
            this.pbOP.Size = new System.Drawing.Size(248, 165);
            this.pbOP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOP.TabIndex = 0;
            this.pbOP.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddtoMember);
            this.groupBox4.Controls.Add(this.btnEditMembership);
            this.groupBox4.Controls.Add(this.btnCreateMembership);
            this.groupBox4.Location = new System.Drawing.Point(23, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 134);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership";
            // 
            // btnAddtoMember
            // 
            this.btnAddtoMember.Location = new System.Drawing.Point(50, 86);
            this.btnAddtoMember.Name = "btnAddtoMember";
            this.btnAddtoMember.Size = new System.Drawing.Size(169, 29);
            this.btnAddtoMember.TabIndex = 3;
            this.btnAddtoMember.Text = "Add to Member";
            this.btnAddtoMember.UseVisualStyleBackColor = true;
            this.btnAddtoMember.Click += new System.EventHandler(this.btnAddtoMember_Click);
            // 
            // btnEditMembership
            // 
            this.btnEditMembership.Location = new System.Drawing.Point(50, 54);
            this.btnEditMembership.Name = "btnEditMembership";
            this.btnEditMembership.Size = new System.Drawing.Size(169, 26);
            this.btnEditMembership.TabIndex = 2;
            this.btnEditMembership.Text = "Edit/Delete";
            this.btnEditMembership.UseVisualStyleBackColor = true;
            this.btnEditMembership.Click += new System.EventHandler(this.btnEditMembership_Click);
            // 
            // btnCreateMembership
            // 
            this.btnCreateMembership.Location = new System.Drawing.Point(50, 19);
            this.btnCreateMembership.Name = "btnCreateMembership";
            this.btnCreateMembership.Size = new System.Drawing.Size(169, 29);
            this.btnCreateMembership.TabIndex = 1;
            this.btnCreateMembership.Text = "Create Membership";
            this.btnCreateMembership.UseVisualStyleBackColor = true;
            this.btnCreateMembership.Click += new System.EventHandler(this.btnCreateMembership_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnViewMemberPayments);
            this.groupBox5.Controls.Add(this.btwNewPayment);
            this.groupBox5.Location = new System.Drawing.Point(23, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 97);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Member Payment";
            // 
            // btnViewMemberPayments
            // 
            this.btnViewMemberPayments.Location = new System.Drawing.Point(50, 54);
            this.btnViewMemberPayments.Name = "btnViewMemberPayments";
            this.btnViewMemberPayments.Size = new System.Drawing.Size(169, 29);
            this.btnViewMemberPayments.TabIndex = 3;
            this.btnViewMemberPayments.Text = "View Member Payments";
            this.btnViewMemberPayments.UseVisualStyleBackColor = true;
            this.btnViewMemberPayments.Click += new System.EventHandler(this.btnViewMemberPayments_Click);
            // 
            // btwNewPayment
            // 
            this.btwNewPayment.Location = new System.Drawing.Point(50, 19);
            this.btwNewPayment.Name = "btwNewPayment";
            this.btwNewPayment.Size = new System.Drawing.Size(169, 29);
            this.btwNewPayment.TabIndex = 1;
            this.btwNewPayment.Text = "New Payment";
            this.btwNewPayment.UseVisualStyleBackColor = true;
            this.btwNewPayment.Click += new System.EventHandler(this.btwNewPayment_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(460, 418);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(112, 97);
            this.btnEntry.TabIndex = 8;
            this.btnEntry.Text = "Swipe Card";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(858, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddMemberPhoto
            // 
            this.btnAddMemberPhoto.Location = new System.Drawing.Point(51, 49);
            this.btnAddMemberPhoto.Name = "btnAddMemberPhoto";
            this.btnAddMemberPhoto.Size = new System.Drawing.Size(169, 29);
            this.btnAddMemberPhoto.TabIndex = 4;
            this.btnAddMemberPhoto.Text = "Add Member Photo";
            this.btnAddMemberPhoto.UseVisualStyleBackColor = true;
            this.btnAddMemberPhoto.Click += new System.EventHandler(this.btnAddMemberPhoto_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 555);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOnPremises);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Gym Reception Tool v0.01";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditInstructor;
        private System.Windows.Forms.Button btnAddNewInstructor;
        private System.Windows.Forms.ListBox lstOnPremises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExpDateOP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox pbOP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddtoMember;
        private System.Windows.Forms.Button btnEditMembership;
        private System.Windows.Forms.Button btnCreateMembership;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnViewMemberPayments;
        private System.Windows.Forms.Button btwNewPayment;
        private System.Windows.Forms.Label lblBalanceOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSurnameOP;
        private System.Windows.Forms.Label lblNameOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMemberPhoto;
    }
}