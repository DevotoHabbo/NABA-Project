CREATE PROCEDURE [dbo].[User_Insert]
	@UserId nvarchar(128),
	@Name nvarchar(128)
AS
begin
	set nocount on
	insert into dbo.Phuong_User(UserId,Name)
	values(@UserId,@Name)
end