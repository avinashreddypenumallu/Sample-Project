using RNS.Consultant.ManagementSystem.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RNS.Consultant.ManagementSystem
{
    public partial class PersonalDetails : Form
    {

        private SqlConnection _sqlconnection;
        private SqlCommand _sqlcommand;
        private SqlDataAdapter _sqldataadapter;
        private DataTable _datatable;

       

        public PersonalDetails()
        {
            InitializeComponent();

        }

         private int ValidateTheUserInputs()
        {
            int flag = 0;
            if (String.IsNullOrEmpty(txtfirstname.Text))
            {
                flag = 1;
                MessageBox.Show("enter the firstname");
                return flag;
                
            }
            if (String.IsNullOrEmpty(txtlastname.Text))
            {
                flag = 1;
                MessageBox.Show("enter the lastname");
                return flag;
            }
            if (String.IsNullOrEmpty(datetimedateofbirth.Text))
            {
                flag = 1;
                MessageBox.Show("enter the date of birth");
                return flag;
            }
            if(datetimedateofbirth.Value.Year> 1998)
            {
                flag = 1;
                MessageBox.Show("plase enter correct year");
            }
            if (String.IsNullOrEmpty(txtaddress.Text))
            {
                flag = 1;
                MessageBox.Show("enter the address");
                return flag;
            }
            return flag;
        }


        private void lbladress_Click(object sender, EventArgs e)
        {

        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void lbllastname_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {


            if(ValidateTheUserInputs()==0) {
                //try
                //{
                //    _sqlconnection = new SqlConnection("Data Source = LENOVO-PC; Initial Catalog = EmployeeDetails; User ID = sa; Password = abc@123");
                //    _sqlconnection.Open();
                //    SqlCommand _sqlcommand = new SqlCommand("Insert into  PersonalDetails(FirstName,LastName,DateOfBirth,Address) values(@FirstName,@LastName,@DateOfBirth,@Address)", _sqlconnection);
                //    _sqlcommand.CommandType = CommandType.Text;
                //    _sqlcommand.Parameters.AddWithValue("@FirstName", (txtfirstname.Text));
                //    _sqlcommand.Parameters.AddWithValue("@LastName", txtlastname.Text);
                //    _sqlcommand.Parameters.AddWithValue("@DateOfBirth", datetimedateofbirth.Value);
                //    _sqlcommand.Parameters.AddWithValue("@Address", txtaddress.Text);
                //    int _result = _sqlcommand.ExecuteNonQuery();

                //    if (_result > 0)
                //    {
                //        MessageBox.Show("Record saved successfully");

                //        EducationalDetails ed = new EducationalDetails();
                //        ed.Show();
                //    }
                //    else
                //        MessageBox.Show("Record not saved  successfully");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("exception occured  in while saving the data", ex.Message);
                //}
                EmployeeDetails employeeDetails = new EmployeeDetails();
                Employee emp = new Employee();
                emp.FirstName = txtfirstname.Text;
                emp.LastName = txtlastname.Text;
                emp.DateOfBirth = datetimedateofbirth.Text;
                //emp.Address = txtaddress.Text;
               
                employeeDetails.Employee = emp;
                EducationalDetails ed = new EducationalDetails(employeeDetails);
                ed.Show();



            }


        }

      

       

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetimedateofbirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }


       
    }
}
