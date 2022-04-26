ALTER PROC UserAdd
@Username varchar(50),
@Password varchar(50)
AS 
	INSERT INTO Users(Username,Password)
	VALUES (@Username, @Password)