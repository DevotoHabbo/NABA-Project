CREATE PROCEDURE [dbo].[Post_Delete]
	@PostId int
AS
begin
	set nocount on
	delete
	from dbo.Phuong_Posts
	where PostId=@PostId
end