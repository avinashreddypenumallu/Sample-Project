using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using RNS.Consultant.ManagementSystem.Models;

namespace RNS.Consultant.ManagementSystem
{
    public partial class EducationalDetails : Form
    {

        private SqlConnection _sqlconnection;
        private SqlCommand _sqlcommand;
        private SqlDataAdapter _sqldataadapter;
        private EmployeeDetails _employeedetails;
       
        
        public EducationalDetails()
        {

            InitializeComponent();
                   
        }
        public EducationalDetails(EmployeeDetails emp)
        {
            InitializeComponent();

            _employeedetails = emp;


        }



        private int ValidateTheUserInputs()
        {
            int flag = 0;
            if (string.IsNullOrEmpty(txteducationlevel1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the education level");
                return flag;
            }
            if (string.IsNullOrEmpty(txtspecialization1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the specialization");
                return flag;
            }
            if (string.IsNullOrEmpty(txtinstitutionname1.Text))
            {
                flag = 1;
                MessageBox.Show("Enter the institution name");
                return flag;
            }
            if ((string.IsNullOrEmpty(txtyearofpassing1.Text)))
            {
                flag = 1;
                MessageBox.Show("Enter the correct year of passing");
                return flag;
            }
            if((Convert.ToInt32(txtyearofpassing1.Text) <= 0)){
                flag = 1;
                MessageBox.Show("Enter the correct year of passing");
                return flag;
            }
            return flag;
        }

        private void txteducationlevel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblspecialization_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (ValidateTheUserInputs() == 0)
            {
                //try
                //{

                //    _sqlconnection = new SqlConnection("Data Source = LENOVO-PC; Initial Catalog = EmployeeDetails; User ID = sa; Password = abc@123");
                //    _sqlconnection.Open();
                //    SqlCommand _sqlcommand = new SqlCommand("Insert into  EducationDetails(Degree,Specialization) values(@Degree,@Specialization)", _sqlconnection);
                //    _sqlcommand.CommandType = CommandType.Text;
                //    _sqlcommand.Parameters.AddWithValue("@Degree", (txteducationlevel1.Text));
                //    _sqlcommand.Parameters.AddWithValue("@Specialization", (txteducationlevel2.Text));


                //    int _result = _sqlcommand.ExecuteNonQuery();

                //    if (_result > 0)
                //    {
                //        MessageBox.Show("Record saved successfully");

                //        WorkExperience we = new WorkExperience();
                //        we.Show();
                //    }
                //    else
                //        MessageBox.Show("Record not saved  successfully");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("exception occured  in while saving the data", ex.Message);
                //    throw;
                //}
                Education employeeeducation = new Education();
                employeeeducation.EducationLevel = txteducationlevel1.Text;
                employeeeducation.Specialization = txtspecialization1.Text;
                employeeeducation.InstitutionName = txtinstitutionname1.Text;
                employeeeducation.StartYear = Convert.ToInt32(txtyearofpassing1.Text);
                _employeedetails.Education = employeeeducation;
               
                WorkExperienceDetails we = new WorkExperienceDetails(_employeedetails);
                       we.Show();

            }


        }

        private void lbleducationlevel_Click(object sender, EventArgs e)
        {

        }

        private void txteducationlevel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblinstitutionname_Click(object sender, EventArgs e)
        {

        }

        private void lblyearofpassing_Click(object sender, EventArgs e)
        {

        }

        private void txtspecialization1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinstitutionname1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyearofpassing1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtspecialization2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinstitutionname2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyearofpassing2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
