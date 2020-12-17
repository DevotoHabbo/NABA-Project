CREATE PROCEDURE [dbo].[User_GetMany]
as
begin
	set nocount on
	select*
	from dbo.Phuong_User
	order By Created
end