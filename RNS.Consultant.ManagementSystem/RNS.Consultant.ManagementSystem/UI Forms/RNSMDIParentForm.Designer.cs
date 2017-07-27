namespace RNS.Consultant.ManagementSystem.UI_Forms
{
    partial class RNSMDIParentForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultantSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruterSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultantSystemToolStripMenuItem,
            this.managementSystemToolStripMenuItem,
            this.recruterSystemToolStripMenuItem,
            this.notificationSystemToolStripMenuItem,
            this.viewReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultantSystemToolStripMenuItem
            // 
            this.consultantSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegistrationToolStripMenuItem,
            this.emploToolStripMenuItem});
            this.consultantSystemToolStripMenuItem.Name = "consultantSystemToolStripMenuItem";
            this.consultantSystemToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.consultantSystemToolStripMenuItem.Text = "Employee Management";
            // 
            // managementSystemToolStripMenuItem
            // 
            this.managementSystemToolStripMenuItem.Name = "managementSystemToolStripMenuItem";
            this.managementSystemToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.managementSystemToolStripMenuItem.Text = "Management System";
            // 
            // recruterSystemToolStripMenuItem
            // 
            this.recruterSystemToolStripMenuItem.Name = "recruterSystemToolStripMenuItem";
            this.recruterSystemToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.recruterSystemToolStripMenuItem.Text = "Recruiter System";
            // 
            // notificationSystemToolStripMenuItem
            // 
            this.notificationSystemToolStripMenuItem.Name = "notificationSystemToolStripMenuItem";
            this.notificationSystemToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.notificationSystemToolStripMenuItem.Text = "Notification System";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            // 
            // employeeRegistrationToolStripMenuItem
            // 
            this.employeeRegistrationToolStripMenuItem.Name = "employeeRegistrationToolStripMenuItem";
            this.employeeRegistrationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeRegistrationToolStripMenuItem.Text = "Employee Registration";
            this.employeeRegistrationToolStripMenuItem.Click += new System.EventHandler(this.employeeRegistrationToolStripMenuItem_Click);
            // 
            // emploToolStripMenuItem
            // 
            this.emploToolStripMenuItem.Name = "emploToolStripMenuItem";
            this.emploToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.emploToolStripMenuItem.Text = "Employee Details";
            this.emploToolStripMenuItem.Click += new System.EventHandler(this.emploToolStripMenuItem_Click);
            // 
            // RNSMDIParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RNSMDIParentForm";
            this.Text = "fic";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultantSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruterSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emploToolStripMenuItem;
    }
}



