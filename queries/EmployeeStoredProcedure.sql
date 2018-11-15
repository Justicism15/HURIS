--stored procedure
use SampleDatabase
go

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeRecords')
	DROP procedure [usp_EmployeeRecords]
GO
CREATE procedure [usp_EmployeeRecords]
(
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@ContactNumber VARCHAR(11)
)
WITH ENCRYPTION
AS
BEGIN TRANSACTION
SET NOCOUNT OFF

	INSERT INTO Employees
	(
		FirstName,LastName,ContactNumber
	)
	VALUES
	(
		@FirstName,@LastName,@ContactNumber
	)
	--SELECT SCOPE_IDENTITY()

IF @@ERROR <> 0 
	BEGIN
		ROLLBACK TRANSACTION
		RAISERROR ('Error',16,1)
		END
	COMMIT TRANSACTION
GO


IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeLogin')
	DROP PROCEDURE [usp_EmployeeLogin]
GO
CREATE PROCEDURE [usp_EmployeeLogin]
(
	@Username NVARCHAR(180),
	@Password NVARCHAR(32)
)
WITH ENCRYPTION 
AS
SET NOCOUNT OFF
	Select EmpUsername from [Employees] Where EmpUsername = @username and [EmpPassword] = @Password;
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeRegister')
	DROP PROCEDURE [usp_EmployeeRegister]
GO
CREATE PROCEDURE [usp_EmployeeRegister]
(
	@fname NVARCHAR(100),
	@lname NVARCHAR(100),
	@contact NVARCHAR(11)
)
WITH ENCRYPTION 
AS
SET NOCOUNT OFF
	INSERT INTO Employees
	(
		FirstName,LastName,ContactNumber
	)
	VALUES
	(
		@fname,@lname,@contact
	)
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeSearch')
	DROP PROCEDURE [usp_EmployeeSearch]
GO
CREATE PROCEDURE [usp_EmployeeSearch]
(
	@Keywords NVARCHAR(180)
)
WITH ENCRYPTION 
AS
SET NOCOUNT OFF
	Select *
	FROM Employees 
	where (FirstName like '%' + @Keywords + '%' OR LastName like '%' + @Keywords + '%') 
			OR (CONCAT (FirstName, ' ' , LastName ) Like '%' + @Keywords + '%') 
			OR (CONCAT (LastName, ', ' , FirstName ) Like '%' + @Keywords + '%')
			OR (CONCAT (LastName, ',' , FirstName ) Like '%' + @Keywords + '%')  
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeMasterList')
	DROP PROCEDURE [usp_EmployeeMasterList]
GO
CREATE PROCEDURE [usp_EmployeeMasterList]
AS
SELECT * FROM Employees
RETURN

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeDataUpdate')
	DROP PROCEDURE [usp_EmployeeDataUpdate]
GO
CREATE PROCEDURE [usp_EmployeeDataUpdate]
(
	@FirstName NVARCHAR(100),
	@LastName NVARCHAR(100),
	@Contact NVARCHAR(11),
	@EmpID INT
)
WITH ENCRYPTION 
AS
SET NOCOUNT OFF
	UPDATE Employees SET FirstName = @FirstName,LastName = @LastName, ContactNumber = @Contact Where EmpID = @EmpID;
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EmployeeIndividualRecord')
	DROP PROCEDURE [usp_EmployeeIndividualRecord]
GO
CREATE PROCEDURE [usp_EmployeeIndividualRecord]
(
	@EmpID INT
)
WITH ENCRYPTION 
AS
SET NOCOUNT OFF
	SELECT * FROM Employees where EmpID = @EmpID;
GO