namespace RNS.Consultant.ManagementSystem
{
    partial class PersonalDetails
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.datetimedateofbirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblfirstname.Location = new System.Drawing.Point(222, 31);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(80, 17);
            this.lblfirstname.TabIndex = 1;
            this.lblfirstname.Text = "First Name:";
            this.lblfirstname.Click += new System.EventHandler(this.lblfirstname_Click);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbllastname.Location = new System.Drawing.Point(222, 91);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(80, 17);
            this.lbllastname.TabIndex = 2;
            this.lbllastname.Text = "Last Name:";
            this.lbllastname.Click += new System.EventHandler(this.lbllastname_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(222, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Of Birth:";
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbladress.Location = new System.Drawing.Point(222, 211);
            this.lbladress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(64, 17);
            this.lbladress.TabIndex = 4;
            this.lbladress.Text = "Address:";
            this.lbladress.Click += new System.EventHandler(this.lbladress_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(408, 25);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(344, 26);
            this.txtfirstname.TabIndex = 5;
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(408, 86);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(344, 26);
            this.txtlastname.TabIndex = 6;
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(408, 209);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(148, 26);
            this.txtaddress.TabIndex = 8;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(328, 353);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 38);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // datetimedateofbirth
            // 
            this.datetimedateofbirth.CustomFormat = "";
            this.datetimedateofbirth.Location = new System.Drawing.Point(408, 143);
            this.datetimedateofbirth.Name = "datetimedateofbirth";
            this.datetimedateofbirth.Size = new System.Drawing.Size(344, 26);
            this.datetimedateofbirth.TabIndex = 10;
            this.datetimedateofbirth.ValueChanged += new System.EventHandler(this.datetimedateofbirth_ValueChanged);
            // 
            // PersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 663);
            this.Controls.Add(this.datetimedateofbirth);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lbladress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonalDetails";
            this.Text = "Personal Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker datetimedateofbirth;
    }
}

