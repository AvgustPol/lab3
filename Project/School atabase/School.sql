USE [master]
GO
/****** Object:  Database [School]    Script Date: 20.04.2017 1:07:23 ******/
CREATE DATABASE [School]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'School', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER_ANTON\MSSQL\DATA\School.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'School_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER_ANTON\MSSQL\DATA\School_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [School] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [School] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [School] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [School] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [School] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [School] SET ARITHABORT OFF 
GO
ALTER DATABASE [School] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [School] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [School] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [School] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [School] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [School] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [School] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [School] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [School] SET  DISABLE_BROKER 
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [School] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [School] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [School] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [School] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [School] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [School] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [School] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [School] SET  MULTI_USER 
GO
ALTER DATABASE [School] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [School] SET DB_CHAINING OFF 
GO
ALTER DATABASE [School] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [School] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [School] SET DELAYED_DURABILITY = DISABLED 
GO
USE [School]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 20.04.2017 1:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Symbol] [nchar](10) NOT NULL,
	[Teacher] [int] NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Symbol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marks]    Script Date: 20.04.2017 1:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks](
	[IdStudent] [int] NOT NULL,
	[IdSubject] [int] NOT NULL,
	[Mark] [int] NOT NULL,
 CONSTRAINT [PK_Marks] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC,
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 20.04.2017 1:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[IdStudent] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Class] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 20.04.2017 1:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[IdSubject] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 20.04.2017 1:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[IdTeacher] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[IdTeacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teaches]    Script Date: 20.04.2017 1:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teaches](
	[IdTeacher] [int] NOT NULL,
	[IdSubject] [int] NOT NULL,
	[Hours] [int] NOT NULL,
 CONSTRAINT [PK_Teaches] PRIMARY KEY CLUSTERED 
(
	[IdTeacher] ASC,
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Classes] ([Symbol], [Teacher]) VALUES (N'1a        ', 1)
INSERT [dbo].[Classes] ([Symbol], [Teacher]) VALUES (N'1b        ', 1)
INSERT [dbo].[Classes] ([Symbol], [Teacher]) VALUES (N'2a        ', 2)
INSERT [dbo].[Marks] ([IdStudent], [IdSubject], [Mark]) VALUES (3, 1, 5)
INSERT [dbo].[Marks] ([IdStudent], [IdSubject], [Mark]) VALUES (3, 2, 5)
INSERT [dbo].[Marks] ([IdStudent], [IdSubject], [Mark]) VALUES (3, 3, 4)
INSERT [dbo].[Marks] ([IdStudent], [IdSubject], [Mark]) VALUES (4, 3, 2)
INSERT [dbo].[Marks] ([IdStudent], [IdSubject], [Mark]) VALUES (5, 2, 5)
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([IdStudent], [Name], [Surname], [Class]) VALUES (3, N'Anton', N'Vlasiuk', N'1a        ')
INSERT [dbo].[Students] ([IdStudent], [Name], [Surname], [Class]) VALUES (4, N'Anna', N'Nowak', N'1b        ')
INSERT [dbo].[Students] ([IdStudent], [Name], [Surname], [Class]) VALUES (5, N'Jan', N'Kowalski', N'2a        ')
INSERT [dbo].[Students] ([IdStudent], [Name], [Surname], [Class]) VALUES (6, N'123', N'123', N'1b        ')
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([IdSubject], [SubjectName]) VALUES (1, N'English')
INSERT [dbo].[Subjects] ([IdSubject], [SubjectName]) VALUES (2, N'Math')
INSERT [dbo].[Subjects] ([IdSubject], [SubjectName]) VALUES (3, N'Art')
INSERT [dbo].[Subjects] ([IdSubject], [SubjectName]) VALUES (5, N'Subject name')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([IdTeacher], [Name], [Surname], [Salary]) VALUES (1, N'Ola', N'Mannur', 4000)
INSERT [dbo].[Teachers] ([IdTeacher], [Name], [Surname], [Salary]) VALUES (2, N'Jan', N'Adamus', 3000)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
INSERT [dbo].[Teaches] ([IdTeacher], [IdSubject], [Hours]) VALUES (1, 1, 300)
INSERT [dbo].[Teaches] ([IdTeacher], [IdSubject], [Hours]) VALUES (1, 2, 150)
INSERT [dbo].[Teaches] ([IdTeacher], [IdSubject], [Hours]) VALUES (2, 3, 450)
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD  CONSTRAINT [FK_Classes_Teachers] FOREIGN KEY([Teacher])
REFERENCES [dbo].[Teachers] ([IdTeacher])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Classes] CHECK CONSTRAINT [FK_Classes_Teachers]
GO
ALTER TABLE [dbo].[Marks]  WITH CHECK ADD  CONSTRAINT [FK_Marks_Subjects] FOREIGN KEY([IdSubject])
REFERENCES [dbo].[Subjects] ([IdSubject])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Marks] CHECK CONSTRAINT [FK_Marks_Subjects]
GO
ALTER TABLE [dbo].[Marks]  WITH CHECK ADD  CONSTRAINT [marks_to_students] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Students] ([IdStudent])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Marks] CHECK CONSTRAINT [marks_to_students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Classes] FOREIGN KEY([Class])
REFERENCES [dbo].[Classes] ([Symbol])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Classes]
GO
ALTER TABLE [dbo].[Teaches]  WITH CHECK ADD  CONSTRAINT [FK_Teaches_Subjects] FOREIGN KEY([IdSubject])
REFERENCES [dbo].[Subjects] ([IdSubject])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teaches] CHECK CONSTRAINT [FK_Teaches_Subjects]
GO
ALTER TABLE [dbo].[Teaches]  WITH CHECK ADD  CONSTRAINT [FK_Teaches_Teachers] FOREIGN KEY([IdTeacher])
REFERENCES [dbo].[Teachers] ([IdTeacher])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teaches] CHECK CONSTRAINT [FK_Teaches_Teachers]
GO
USE [master]
GO
ALTER DATABASE [School] SET  READ_WRITE 
GO
