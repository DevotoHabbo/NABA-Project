CREATE PROCEDURE [dbo].[User_GetOne]
	@UserId nvarchar(128)
AS
begin
	set nocount on
	select*
	from dbo.Phuong_User
	where UserId = @UserId
end