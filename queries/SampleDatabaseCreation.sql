use master
go

IF EXISTS (SELECT [name] FROM sys.databases WHERE [name] LIKE N'SampleDatabase')
	DROP DATABASE [SampleDatabase]
GO

CREATE DATABASE [SampleDatabase]
GO

USE  [SampleDatabase]
GO

CREATE TABLE [dbo].[Employees]
(
	[EmpID]		INT		IDENTITY(101,1) NOT NULL,
	[FirstName]		NVARCHAR (100) NULL,
	[LastName]		NVARCHAR (100) NULL,
	[ContactNumber] NVARCHAR (11) NULL,
	[EmpUsername] NVARCHAR (60) NULL,
	[EmpPassword] NVARCHAR (32) NULL,
	CONSTRAINT [PK_Students]	PRIMARY KEY CLUSTERED ([EmpID] ASC) 
);