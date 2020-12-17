CREATE PROCEDURE [dbo].[Post_Insert]
	@Title nvarchar(256),
	@Content nvarchar(MAX),
	@UserId nvarchar(256)
AS
begin
	set nocount on
	insert into dbo.Phuong_Posts(Title,Content,UserId)
	values(@Title,@Content,@UserId)
	select SCOPE_IDENTITY() as PostId
end