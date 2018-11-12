--stored procedure

use USLS
go

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_StudentRecords')
	DROP procedure [usp_StudentRecords]
GO
CREATE procedure [usp_StudentRecords]
(
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@ContactNumber VARCHAR(11)
)
WITH ENCRYPTION
AS
BEGIN TRANSACTION
SET NOCOUNT OFF

	INSERT INTO Students
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
