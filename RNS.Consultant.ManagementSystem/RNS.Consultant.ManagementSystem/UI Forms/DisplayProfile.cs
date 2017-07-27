using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNS.Consultant.ManagementSystem.UI_Forms
{
    public partial class DisplayProfile : Form
    {
        private SqlConnection _sqlconnection;
        private SqlDataAdapter _sqldataadapterpersonal;
        private DataTable _dataTablepersonal;
        private SqlDataAdapter _sqldataadaptereducation;
        private DataTable _dataTableeducation;
        private SqlDataAdapter _sqldataadapterworkexperience;
        private DataTable _dataTableworkexperience;

        public DisplayProfile()
        {
            InitializeComponent();
            _sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionstring"].ConnectionString);

        }


        private void DisplayProfile_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _sqldataadapterpersonal = new SqlDataAdapter("Select * from PersonalDetails ", _sqlconnection);

            _dataTablepersonal = new DataTable();
            _sqldataadapterpersonal.Fill(_dataTablepersonal);
            dataGridView1.DataSource = _dataTablepersonal;
            _sqldataadaptereducation = new SqlDataAdapter("Select * from EducationDetails", _sqlconnection);
            _dataTableeducation = new DataTable();
            _sqldataadaptereducation.Fill(_dataTableeducation);
            dataGridView2.DataSource = _dataTableeducation;
            _sqldataadapterworkexperience = new SqlDataAdapter("Select * from WorkExperience", _sqlconnection);
            _dataTableworkexperience = new DataTable();
            _sqldataadapterworkexperience.Fill(_dataTableworkexperience);
            dataGridView3.DataSource = _dataTableworkexperience;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
