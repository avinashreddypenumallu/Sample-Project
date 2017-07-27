using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using RNS.Consultant.ManagementSystem.Models;
using RNS.Consultant.ManagementSystem.DataLayer;

namespace RNS.Consultant.ManagementSystem
{
    public partial class WorkExperienceDetails : Form
    {
        private SqlConnection _sqlconnection;
        private EmployeeDetails _employeedetails;
        public WorkExperienceDetails()
        {
            InitializeComponent();
        }
        public WorkExperienceDetails(EmployeeDetails employeeeducation)
        {
            InitializeComponent();
            _employeedetails = employeeeducation;
        }

        private int ValidateTheUserInputs()
        {
            int flag = 0;
            if (string.IsNullOrEmpty(txtfrom1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the date of start at" + txtcompany1.Text);
                return flag;
            }
            if (string.IsNullOrEmpty(txtto1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the date of leaving from " + txtcompany1.Text);
                return flag;
            }
            if (string.IsNullOrEmpty(txtcompany1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the company name");
                return flag;
            }
            if (string.IsNullOrEmpty(txtskillset1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the skillset names");
                return flag;
            }
            return flag;
        }



        private void btnsubmit_Click(object sender, EventArgs e)
        {

            if (ValidateTheUserInputs() == 0)
            {
                //try
                //{
                //    var _workexpereinceResult = 0;
                //    var _educationalDetails = 0;
                //    _employeedetails.WorkExperience = new Models.WorkExperience
                //    {
                //        CompanyName = txtcompany1.Text,
                //        From = txtfrom1.Text,
                //        To = txtto1.Text,
                //        Skillset = txtskillset1.Text,
                //    };
                //    _sqlconnection = new SqlConnection(Database.GetDatabaseConnectionstring());
                //    _sqlconnection.Open();
                //    SqlCommand _sqlcommand = new SqlCommand("Insert into  PersonalDetails(FirstName,LastName,DateOfBirth,Address) values(@FirstName,@LastName,@DateOfBirth,@Address)" + "SELECT CAST(scope_identity() AS int)", _sqlconnection);
                //    _sqlcommand.CommandType = CommandType.Text;
                //    _sqlcommand.Parameters.AddWithValue("@FirstName", _employeedetails.Employee.FirstName);
                //    _sqlcommand.Parameters.AddWithValue("@LastName", _employeedetails.Employee.LastName);
                //    _sqlcommand.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(_employeedetails.Employee.DateOfBirth));
                //    _sqlcommand.Parameters.AddWithValue("@Address", _employeedetails.Employee.Address);
                //    int _recentlyInsertedemployeeid = (int)_sqlcommand.ExecuteScalar();
                //    if (_recentlyInsertedemployeeid > 0)
                //    {
                //        SqlCommand _sqlcommandeducation = new SqlCommand("Insert into  EducationDetails(EducationLevel,Specialization,InstitutionName,YearOfPassing,EmployeeId) values(@EducationLevel,@Specialization,@InstitutionName,@YearOfPassing,@EmployeeId)", _sqlconnection);
                //        _sqlcommandeducation.CommandType = CommandType.Text;
                //        _sqlcommandeducation.Parameters.AddWithValue("@EducationalLevel", _employeedetails.Education.EducationLevel);
                //        _sqlcommandeducation.Parameters.AddWithValue("@Specialization", _employeedetails.Education.Specialization);
                //        _sqlcommandeducation.Parameters.AddWithValue("@InstitutionName", _employeedetails.Education.InstitutionName);
                //        _sqlcommandeducation.Parameters.AddWithValue("@YearOfPassing", _employeedetails.Education.YearOfPassing);
                //        _sqlcommandeducation.Parameters.AddWithValue("@EmployeeId", _recentlyInsertedemployeeid);
                //        _educationalDetails = _sqlcommand.ExecuteNonQuery();
                //        SqlCommand _sqlcommandworkexperience = new SqlCommand("Insert into  WorkExperience(CompanyName,[From],[To],Skillset,EmployeeId) values(@CompanyName,@From,@To,@Skillset,@EmployeeId)", _sqlconnection);
                //        _sqlcommandworkexperience.Parameters.AddWithValue("@CompanyName", _employeedetails.WorkExperience.CompanyName);
                //        _sqlcommandworkexperience.Parameters.AddWithValue("@From", Convert.ToInt16(_employeedetails.WorkExperience.From));
                //        _sqlcommandworkexperience.Parameters.AddWithValue("@To", Convert.ToInt16(_employeedetails.WorkExperience.To));
                //        _sqlcommandworkexperience.Parameters.AddWithValue("@Skillset", _employeedetails.WorkExperience.Skillset);
                //        _sqlcommandworkexperience.Parameters.AddWithValue("@EmployeeId", _recentlyInsertedemployeeid);
                //        _workexpereinceResult = _sqlcommandworkexperience.ExecuteNonQuery();
                //        var resultmessage = (_educationalDetails + _workexpereinceResult) > 0 ? "Employee Details saved success fully" :
                //               "Employee Details not saved success fully";
                //        MessageBox.Show(resultmessage);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Employee Personal details not saved successfully");
                //    }

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("exception occured  in while saving the employee details data", ex.Message);
                //}

                WorkExperience workexperience = new WorkExperience();
                workexperience.FirstCompanyName = txtcompany1.Text;
                workexperience.From = txtfrom1.Text;
                workexperience.To = txtto1.Text;
                workexperience.Skillset = txtskillset1.Text;
                _employeedetails.WorkExperience = workexperience;
                InsertData insertdata = new InsertData();
                insertdata.saveuserdetails(_employeedetails);
                this.Close();
            }

        }

        private void txtto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblto_Click(object sender, EventArgs e)
        {

        }

        private void lblfrom_Click(object sender, EventArgs e)
        {

        }

        private void txtskillset1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcompany2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfrom2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtskillset2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcompany1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
