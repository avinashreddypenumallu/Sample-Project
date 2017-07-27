using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNS.Consultant.ManagementSystem.UI_Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            PersonalDetails personaldetails = new PersonalDetails();
            personaldetails.Show();
        }
    }
}
