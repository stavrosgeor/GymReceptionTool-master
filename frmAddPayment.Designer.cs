
namespace GymReceptionTool
{
    partial class frmAddPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbTel = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.txtSearchbyTel = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtSearchbyID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Amount Payed";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(99, 153);
            this.txtAmount.MaxLength = 20;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 48;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(99, 187);
            this.txtNote.MaxLength = 20;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(205, 20);
            this.txtNote.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Note";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(158, 235);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 51;
            this.btnPayment.Text = "Add Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdbTel);
            this.groupBox1.Controls.Add(this.rdbID);
            this.groupBox1.Controls.Add(this.txtSearchbyTel);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.txtSearchbyID);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 123);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Member";
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
            this.rdbTel.Size = new System.Drawing.Size(57, 17);
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
            this.rdbID.Size = new System.Drawing.Size(36, 17);
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
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPayment";
            this.Text = "Add Payment to Member";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdbTel;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.TextBox txtSearchbyTel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtSearchbyID;
    }
}