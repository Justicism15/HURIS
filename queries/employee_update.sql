use SampleDatabase
go

UPDATE Employees
SET EmpUsername = 'justine',
EmpPassword ='123'
WHERE EmpID = 101;


Select * from Employees