CREATE PROCEDURE [dbo].[User_Delete]
	@UserId nvarchar(128)
as
begin
	set nocount on
	delete
	from dbo.Phuong_User
	where UserId = @UserId
end
