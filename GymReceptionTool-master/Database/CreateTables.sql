USE [master]
GO
/****** Object:  Database [GymReceptionTool]    Script Date: 5/4/2022 4:38:14 PM ******/
CREATE DATABASE [GymReceptionTool]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GymReceptionTool', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GymReceptionTool.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GymReceptionTool_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GymReceptionTool_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GymReceptionTool] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GymReceptionTool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GymReceptionTool] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GymReceptionTool] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GymReceptionTool] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GymReceptionTool] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GymReceptionTool] SET ARITHABORT OFF 
GO
ALTER DATABASE [GymReceptionTool] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GymReceptionTool] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GymReceptionTool] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GymReceptionTool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GymReceptionTool] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GymReceptionTool] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GymReceptionTool] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GymReceptionTool] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GymReceptionTool] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GymReceptionTool] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GymReceptionTool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GymReceptionTool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GymReceptionTool] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GymReceptionTool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GymReceptionTool] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GymReceptionTool] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GymReceptionTool] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GymReceptionTool] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GymReceptionTool] SET  MULTI_USER 
GO
ALTER DATABASE [GymReceptionTool] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GymReceptionTool] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GymReceptionTool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GymReceptionTool] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GymReceptionTool] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GymReceptionTool] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GymReceptionTool] SET QUERY_STORE = OFF
GO
USE [GymReceptionTool]
GO
/****** Object:  Table [dbo].[Instructors]    Script Date: 5/4/2022 4:38:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructors](
	[Name] [nvarchar](255) NULL,
	[Surname] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[UserRegistered] [int] NULL,
	[Tel] [int] NULL,
	[Address] [nvarchar](255) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 5/4/2022 4:38:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[Name] [nvarchar](255) NULL,
	[Surname] [nvarchar](255) NULL,
	[JoinDate] [datetime] NULL,
	[MembershipExp] [datetime] NULL,
	[Age] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Tel] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[Balance] [int] NULL,
	[Gender] [nvarchar](255) NULL,
	[UserRegistered] [int] NULL,
	[Instructor] [int] NULL,
	[MembershipID] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Memberships]    Script Date: 5/4/2022 4:38:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Memberships](
	[Name] [nvarchar](255) NULL,
	[MembershipAmount] [int] NULL,
	[UserCreated] [int] NULL,
	[MemberShipPeriod] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 5/4/2022 4:38:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PTime] [datetime] NULL,
	[PDate] [datetime] NULL,
	[UserID] [int] NULL,
	[MemberID] [int] NULL,
	[Amount] [int] NULL,
	[Note] [nvarchar](max) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/4/2022 4:38:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Name] [nvarchar](255) NULL,
	[Tel] [int] NULL,
	[Address] [nvarchar](255) NULL,
	[Username] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[DateAdded] [datetime] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [GymReceptionTool] SET  READ_WRITE 
GO
