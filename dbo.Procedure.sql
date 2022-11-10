CREATE PROCEDURE [dbo].[addStudent]
	@FullName nvarchar(50),
	@Phone nvarchar(50),
	@IDNO nvarchar(25),
	@Email nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.Student_tbl(FullName,Phone,IDNO,Email) VALUES(@FullName,@Phone,@IDNO,@Email)
	END

