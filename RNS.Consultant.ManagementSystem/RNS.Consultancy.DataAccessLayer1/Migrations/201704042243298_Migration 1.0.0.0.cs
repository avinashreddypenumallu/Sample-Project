namespace RNS.Consultancy.DataAccessLayer
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1000 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        SkillSet = c.String(),
                        WorkStartDate = c.DateTime(nullable: false),
                        WorkEndDate = c.DateTime(nullable: false),
                        EmployeeDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeDetails", t => t.EmployeeDetail_Id)
                .Index(t => t.EmployeeDetail_Id);
            
            CreateTable(
                "dbo.EducationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InstituteName = c.String(),
                        PassYear = c.String(),
                        CGP = c.String(),
                        Specialization = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.String(),
                        Gender = c.String(),
                        MailingAddress = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Nationality = c.String(),
                        EmailId = c.String(),
                        MobileNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Educationdetai_Id = c.Int(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EducationDetails", t => t.Educationdetai_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Educationdetai_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeDetails", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeDetails", "Educationdetai_Id", "dbo.EducationDetails");
            DropForeignKey("dbo.Companies", "EmployeeDetail_Id", "dbo.EmployeeDetails");
            DropIndex("dbo.EmployeeDetails", new[] { "Employee_Id" });
            DropIndex("dbo.EmployeeDetails", new[] { "Educationdetai_Id" });
            DropIndex("dbo.Companies", new[] { "EmployeeDetail_Id" });
            DropTable("dbo.EmployeeDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.EducationDetails");
            DropTable("dbo.Companies");
        }
    }
}
