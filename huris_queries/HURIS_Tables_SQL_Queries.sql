use USLS
go

--CREATE TABLE [dbo].[Sub_Department]
--(
--	[sub_department_ID] INT IDENTITY (101,1) NOT NULL,
--	[sub_department_name] NVARCHAR (100) NOT NULL,
--	[sub_department_address] NVARCHAR (100) NULL,
--	[sub_department_desc] NVARCHAR (100) NULL,
--	--[department_ID] INT FOREIGN KEY REFERENCES Department(department_ID),
--	CONSTRAINT [PK_Sub_Department] PRIMARY KEY CLUSTERED ([sub_department_ID] ASC)
--);


CREATE TABLE [dbo].[Department]
(
	[department_ID] INT IDENTITY(101,1) NOT NULL,
	[department_name] NVARCHAR (100) NOT NULL,
	[department_address] NVARCHAR (100) NULL,
	[department_desc] NVARCHAR (100) NULL, 
	[sub_department_ID] INT FOREIGN KEY REFERENCES Sub_Department(sub_department_ID),
	CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED ([department_ID] ASC) 
);

CREATE TABLE [dbo].[Job_Title]
(
	[job_title_ID] INT IDENTITY (101,1) NOT NULL,
	[job_description] NVARCHAR (100) NOT NULL,
	CONSTRAINT [PK_Job_Title] PRIMARY KEY CLUSTERED ([job_title_ID] ASC)
);


CREATE TABLE [dbo].[Employee_Type]
(
	[employee_type_ID] INT IDENTITY (101,1) NOT NULL,
	[employee_type_name] NVARCHAR (100) NOT NULL,
	CONSTRAINT [PK_Employee_Type] PRIMARY KEY CLUSTERED ([employee_type_ID] ASC)


);
CREATE TABLE [dbo].[Compensation]
(
	[compensation_ID] INT IDENTITY (101,1) NOT NULL,
	[employee_type_ID] INT FOREIGN KEY REFERENCES Employee_Type (employee_type_ID),
	CONSTRAINT [PK_Compensation] PRIMARY KEY CLUSTERED ([compensation_ID] ASC) 
);


CREATE TABLE [dbo].[Employee_Status]
(
	[empstatus_ID] INT IDENTITY (101,1) NOT NULL,
	[empstatus_name] NVARCHAR (100) NOT NULL, 
	CONSTRAINT [PK_Employee_Status] PRIMARY KEY CLUSTERED ([empstatus_ID] ASC)
);


CREATE TABLE [dbo].[Employee]
(
	[employee_ID] INT IDENTITY(101,1) NOT NULL,
	[employee_first_name] NVARCHAR (100) NOT NULL,
	[employee_middle_name] NVARCHAR (100) NULL,
	[employee_last_name] NVARCHAR (100) NOT NULL,
	[hire_date] DATE,
	[local_address] NVARCHAR (100) NULL,
	[permanent_adress] NVARCHAR (100) NOT NULL,
	[email] NVARCHAR (100) NOT NULL,
	[mobile_number] NVARCHAR (11) NOT NULL,
	[telephone_number] NVARCHAR (10) NULL,
	[department_ID] INT FOREIGN KEY REFERENCES Department(department_ID),
	[job_title_ID] INT FOREIGN KEY REFERENCES Job_Title(job_title_ID),
	[compensation_ID] INT FOREIGN KEY REFERENCES Compensation(compensation_ID),
	[empstatus_ID]INT FOREIGN KEY REFERENCES Employee_Status(empstatus_ID),
	CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([employee_ID] ASC)
); 





