CREATE PROCEDURE [dbo].[Post_Insert]
	@Title nvarchar(256),
	@Content nvarchar(MAX),
	@UserId nvarchar(150),
	@UserName nvarchar(150)
AS
begin
	set nocount on
	insert into dbo.Phuong_Posts(Title,Content,UserId,UserName)
	values(@Title,@Content,@UserId,@UserName)
	select SCOPE_IDENTITY() as PostId
end