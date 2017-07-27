using RNS.Consultancy.Models;
using System.Data.Entity;
namespace RNS.Consultancy.DataAccessLayer.DataModels
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
            //this.Database.Connection.ConnectionString = @"Data Source = localhost; Initial Catalog = EmployeeManagementSystem; Integrated Security=True;";
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<EducationDetail> EducationDetails { get; set; }
        public DbSet<Company> CompanieDetails { get; set; }

    }
}
