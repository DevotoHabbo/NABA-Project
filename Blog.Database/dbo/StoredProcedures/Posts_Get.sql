CREATE PROCEDURE [dbo].[Posts_Get]
	
AS
begin
	set nocount on
	select *
	from dbo.Phuong_Posts
	order By Created
end