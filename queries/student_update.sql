use USLS
go

--UPDATE Students
--SET LastName = 'Johnson'
--WHERE StudentID = 102;

--use USLS
--go

--UPDATE Students
--SET Username = 'justine'
--WHERE StudentID = 102;

UPDATE Students
SET Password ='123'
WHERE StudentID = 102;

select * from Students