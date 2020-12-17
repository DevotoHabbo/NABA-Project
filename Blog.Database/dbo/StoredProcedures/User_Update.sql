CREATE PROCEDURE [dbo].[User_Update]
	@UserId nvarchar(128),
	@Name nvarchar(128)
AS
begin
	set nocount on
	update dbo.Phuong_User
	set Name=@Name
	where UserId = @UserId
end