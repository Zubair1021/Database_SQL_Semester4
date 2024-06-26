USE [master]
GO
/****** Object:  Database [Lab2_Home]    Script Date: 1/28/2024 7:53:54 PM ******/
CREATE DATABASE [Lab2_Home]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lab2_Home', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Lab2_Home.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Lab2_Home_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Lab2_Home_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Lab2_Home] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lab2_Home].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lab2_Home] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lab2_Home] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lab2_Home] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lab2_Home] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lab2_Home] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lab2_Home] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lab2_Home] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lab2_Home] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lab2_Home] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lab2_Home] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lab2_Home] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lab2_Home] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lab2_Home] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lab2_Home] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lab2_Home] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Lab2_Home] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lab2_Home] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lab2_Home] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lab2_Home] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lab2_Home] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lab2_Home] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lab2_Home] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lab2_Home] SET RECOVERY FULL 
GO
ALTER DATABASE [Lab2_Home] SET  MULTI_USER 
GO
ALTER DATABASE [Lab2_Home] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lab2_Home] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lab2_Home] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lab2_Home] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Lab2_Home] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Lab2_Home] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Lab2_Home', N'ON'
GO
ALTER DATABASE [Lab2_Home] SET QUERY_STORE = ON
GO
ALTER DATABASE [Lab2_Home] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Lab2_Home]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 1/28/2024 7:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [nchar](10) NOT NULL,
	[CourseName] [nchar](10) NOT NULL,
	[StudentName] [nchar](10) NOT NULL,
	[TeacherName] [nchar](10) NOT NULL,
	[Semester] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 1/28/2024 7:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[StudentID] [nchar](10) NOT NULL,
	[StudentName] [nchar](10) NOT NULL,
	[CourseName] [nchar](10) NOT NULL,
	[Marks] [int] NOT NULL,
	[Grade] [nchar](10) NOT NULL,
	[Section] [nchar](10) NOT NULL,
	[Semester] [int] NOT NULL,
	[Session] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student1]    Script Date: 1/28/2024 7:53:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student1](
	[RegNo] [nchar](10) NULL,
	[Name] [nchar](10) NULL,
	[Dept] [nchar](10) NULL,
	[Session] [int] NULL,
	[Address] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Course] ([CourseID], [CourseName], [StudentName], [TeacherName], [Semester]) VALUES (N'UET12     ', N'OOPS      ', N'Zubair    ', N'Laeeq     ', N'02        ')
INSERT [dbo].[Course] ([CourseID], [CourseName], [StudentName], [TeacherName], [Semester]) VALUES (N'UET13     ', N'LA        ', N'Ali       ', N'Umar      ', N'03        ')
INSERT [dbo].[Course] ([CourseID], [CourseName], [StudentName], [TeacherName], [Semester]) VALUES (N'UET14     ', N'DSA       ', N'Amir      ', N'Khalid    ', N'03        ')
GO
INSERT [dbo].[Result] ([StudentID], [StudentName], [CourseName], [Marks], [Grade], [Section], [Semester], [Session]) VALUES (N'2022-CS-20', N'Zubair    ', N'OOP       ', 80, N'A         ', N'A         ', 2, 2022)
INSERT [dbo].[Result] ([StudentID], [StudentName], [CourseName], [Marks], [Grade], [Section], [Semester], [Session]) VALUES (N'2022-CS-17', N'Hamza     ', N'LA        ', 85, N'A         ', N'A         ', 2, 2022)
INSERT [dbo].[Result] ([StudentID], [StudentName], [CourseName], [Marks], [Grade], [Section], [Semester], [Session]) VALUES (N'2022-CS-30', N'Awais     ', N'PF        ', 70, N'B         ', N'A         ', 1, 2022)
INSERT [dbo].[Result] ([StudentID], [StudentName], [CourseName], [Marks], [Grade], [Section], [Semester], [Session]) VALUES (N'2022-CS-89', N'Ali       ', N'THQ       ', 59, N'B+        ', N'C         ', 3, 2022)
GO
INSERT [dbo].[Student1] ([RegNo], [Name], [Dept], [Session], [Address]) VALUES (N'2022-CS-20', N'Zubair    ', N'CS        ', 2022, N'Mughalpura')
INSERT [dbo].[Student1] ([RegNo], [Name], [Dept], [Session], [Address]) VALUES (N'2022-CS-13', N'Ahmed     ', N'CS        ', 2022, N'Sailkot   ')
INSERT [dbo].[Student1] ([RegNo], [Name], [Dept], [Session], [Address]) VALUES (N'2022-CS-13', N'Ali       ', N'CS        ', 2023, N'Islamabad ')
GO
USE [master]
GO
ALTER DATABASE [Lab2_Home] SET  READ_WRITE 
GO
