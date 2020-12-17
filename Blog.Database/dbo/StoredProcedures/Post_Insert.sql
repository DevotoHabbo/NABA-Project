CREATE PROCEDURE [dbo].[Post_Insert]
	@Title nvarchar(256),
	@Content nvarchar(MAX)
AS
begin
	set nocount on
	insert into dbo.Phuong_Posts(Title,Content)
	values(@Title,@Content)
	select SCOPE_IDENTITY() as PostId
end