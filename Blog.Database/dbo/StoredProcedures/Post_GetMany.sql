CREATE PROCEDURE [dbo].[Post_GetMany]
	
AS
begin
	set nocount on
	select *
	from dbo.Phuong_Posts
	order By Created
end