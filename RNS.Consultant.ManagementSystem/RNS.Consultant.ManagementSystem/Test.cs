using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using RNS.Consultant.ManagementSystem.Models;
using RNS.Consultant.ManagementSystem.UI_Forms;
using RNS.Consultant.ManagementSystem.DataLayer;


namespace RNS.Consultant.ManagementSystem
{
    public partial class Test : Form
    {

        private SqlConnection _sqlconnection;
        private SqlCommand _sqlcommand;
        private SqlDataAdapter _sqldataadapter;
        private DataTable _datatable;
        //private EmployeeDetails _employeedetails;
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionstring"].ConnectionString);
            //SaveEmployeepersonalDetails(ref _sqlconnection);
            //saveWorkexperinceDetails(ref _sqlconnection);
            //PersonalDetailsData personaldetails = new PersonalDetailsData();
            //dataGridView1.DataSource = personaldetails.GetPersonalDetails();
            Login login = new Login();
            login.Show();

        }

        private void SaveEmployeepersonalDetails(ref SqlConnection sqlocnnetion )
        {
            sqlocnnetion.Open();
            SqlCommand _sqlcommand = new SqlCommand(@"Insert into  PersonalDetails(FirstName,LastName,DateOfBirth,Address) 
                        values(@FirstName,@LastName,@DateOfBirth,@Address);" + "SELECT CAST(scope_identity() AS int)", _sqlconnection);
            _sqlcommand.CommandType = CommandType.Text;
            _sqlcommand.Parameters.AddWithValue("@FirstName", "sandeep");
            _sqlcommand.Parameters.AddWithValue("@LastName", "chintalapally");
            _sqlcommand.Parameters.AddWithValue("@DateOfBirth", DateTime.Now);
            _sqlcommand.Parameters.AddWithValue("@Address", "address");
            var employeeid = _sqlcommand.ExecuteScalar();
            MessageBox.Show("Data Saved Successfully");
            sqlocnnetion.Close();

        }

        private void saveWorkexperinceDetails(ref SqlConnection _sqlconnection)
        {
            var _employeedetails = new EmployeeDetails();
            _employeedetails.WorkExperience = new Models.WorkExperience
            {
                FirstCompanyName = "Bally",
                From = "2010",
                To = "2012",
                Skillset = ".Net"
            };
            _sqlconnection.Open();
            SqlCommand _sqlcommandworkexperience = new SqlCommand("Insert into  WorkExperience(CompanyName,[From],[To],Skillset,EmployeeId) values(@CompanyName,@From,@To,@Skillset,@EmployeeId)", _sqlconnection);
            _sqlcommandworkexperience.Parameters.AddWithValue("@CompanyName", _employeedetails.WorkExperience.FirstCompanyName);
            _sqlcommandworkexperience.Parameters.AddWithValue("@From", Convert.ToInt16(_employeedetails.WorkExperience.From));
            _sqlcommandworkexperience.Parameters.AddWithValue("@To", Convert.ToInt16(_employeedetails.WorkExperience.To));
            _sqlcommandworkexperience.Parameters.AddWithValue("@Skillset", _employeedetails.WorkExperience.Skillset);
            _sqlcommandworkexperience.Parameters.AddWithValue("@EmployeeId", 1);
            var _workexpereinceResult = _sqlcommandworkexperience.ExecuteNonQuery();
            DisplayProfile displayprofile = new DisplayProfile();
            displayprofile.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
