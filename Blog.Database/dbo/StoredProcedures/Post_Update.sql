CREATE PROCEDURE [dbo].[Post_Update]
	@PostId int,
	@Title nvarchar(256),
	@Content nvarchar(MAX)
AS
begin
	set nocount on
	update dbo.Phuong_Posts
	set Title=@Title,Content=@Content
	where PostId = @PostId
end