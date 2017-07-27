using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNS.Consultant.ManagementSystem.UI_Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionstring = "Data Source = localhost; Initial Catalog = EmployeeDetails; Integrated Security=True;";

            try
            {
                SqlConnection _connection = new SqlConnection();
                _connection.ConnectionString = connectionstring;
                _connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
