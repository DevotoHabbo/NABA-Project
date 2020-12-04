CREATE PROCEDURE [dbo].[Post_GetById]
	@PostId int
AS
begin
	set nocount on
	select PostId,Title,Content,UserId,UserName,Created
	from dbo.Phuong_Posts
	where PostId = @PostId
end