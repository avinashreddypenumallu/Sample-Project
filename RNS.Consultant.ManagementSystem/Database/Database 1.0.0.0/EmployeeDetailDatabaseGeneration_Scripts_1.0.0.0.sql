USE [master]
GO
/****** Object:  Database [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext]    Script Date: 4/2/2017 5:52:15 PM ******/
CREATE DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET ARITHABORT OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET RECOVERY FULL 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET  MULTI_USER 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext', N'ON'
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET QUERY_STORE = OFF
GO
USE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext]
GO
/****** Object:  User [sandeep]    Script Date: 4/2/2017 5:52:16 PM ******/
CREATE USER [sandeep] FOR LOGIN [sandeep] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_datareader] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [sandeep]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [sandeep]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 4/2/2017 5:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Companies]    Script Date: 4/2/2017 5:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[SkillSet] [nvarchar](max) NULL,
	[WorkStartDate] [datetime] NOT NULL,
	[WorkEndDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EducationDetails]    Script Date: 4/2/2017 5:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InstituteName] [nvarchar](max) NULL,
	[PassYear] [nvarchar](max) NULL,
	[CGP] [nvarchar](max) NULL,
	[Specialization] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.EducationDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 4/2/2017 5:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Companies_Id] [int] NULL,
	[Educationdetai_Id] [int] NULL,
	[Employee_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EmployeeDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/2/2017 5:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[DateOfBirth] [nvarchar](max) NULL,
	[Gender] [nvarchar](max) NULL,
	[MailingAddress] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Nationality] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_Educationdetai_Id]    Script Date: 4/2/2017 5:52:17 PM ******/
CREATE NONCLUSTERED INDEX [IX_Educationdetai_Id] ON [dbo].[EmployeeDetails]
(
	[Educationdetai_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employee_Id]    Script Date: 4/2/2017 5:52:17 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employee_Id] ON [dbo].[EmployeeDetails]
(
	[Employee_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmployeeDetails_dbo.Companies_Companies_Id] FOREIGN KEY([Companies_Id])
REFERENCES [dbo].[Companies] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails] CHECK CONSTRAINT [FK_dbo.EmployeeDetails_dbo.Companies_Companies_Id]
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmployeeDetails_dbo.EducationDetails_Educationdetai_Id] FOREIGN KEY([Educationdetai_Id])
REFERENCES [dbo].[EducationDetails] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails] CHECK CONSTRAINT [FK_dbo.EmployeeDetails_dbo.EducationDetails_Educationdetai_Id]
GO
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmployeeDetails_dbo.Employees_Employee_Id] FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[EmployeeDetails] CHECK CONSTRAINT [FK_dbo.EmployeeDetails_dbo.Employees_Employee_Id]
GO
USE [master]
GO
ALTER DATABASE [RNS.Consultancy.DataAccessLayer.DataModels.EmployeeContext] SET  READ_WRITE 
GO
