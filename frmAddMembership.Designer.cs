
namespace GymReceptionTool
{
    partial class frmAddMembership
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbTel = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.txtSearchbyTel = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtSearchbyID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 225);
            this.listBox1.TabIndex = 45;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdbTel);
            this.groupBox1.Controls.Add(this.rdbID);
            this.groupBox1.Controls.Add(this.txtSearchbyTel);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.txtSearchbyID);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 160);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Member";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(78, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbTel
            // 
            this.rdbTel.AutoSize = true;
            this.rdbTel.Location = new System.Drawing.Point(15, 52);
            this.rdbTel.Name = "rdbTel";
            this.rdbTel.Size = new System.Drawing.Size(64, 19);
            this.rdbTel.TabIndex = 59;
            this.rdbTel.TabStop = true;
            this.rdbTel.Text = "Tel.No";
            this.rdbTel.UseVisualStyleBackColor = true;
            this.rdbTel.CheckedChanged += new System.EventHandler(this.rdbTel_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Location = new System.Drawing.Point(15, 24);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(40, 19);
            this.rdbID.TabIndex = 58;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // txtSearchbyTel
            // 
            this.txtSearchbyTel.Enabled = false;
            this.txtSearchbyTel.Location = new System.Drawing.Point(78, 48);
            this.txtSearchbyTel.MaxLength = 20;
            this.txtSearchbyTel.Name = "txtSearchbyTel";
            this.txtSearchbyTel.Size = new System.Drawing.Size(100, 20);
            this.txtSearchbyTel.TabIndex = 57;
            this.txtSearchbyTel.TextChanged += new System.EventHandler(this.txtSearchbyTel_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(222, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 69);
            this.listBox2.TabIndex = 56;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // txtSearchbyID
            // 
            this.txtSearchbyID.Enabled = false;
            this.txtSearchbyID.Location = new System.Drawing.Point(78, 19);
            this.txtSearchbyID.MaxLength = 20;
            this.txtSearchbyID.Name = "txtSearchbyID";
            this.txtSearchbyID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchbyID.TabIndex = 55;
            this.txtSearchbyID.TextChanged += new System.EventHandler(this.txtSearchbyID_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(294, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add Membership";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 555);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmAddMembership";
            this.Text = "Add Membership to Member";
            this.Load += new System.EventHandler(this.frmAddMembership_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdbTel;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.TextBox txtSearchbyTel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtSearchbyID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}