CREATE PROCEDURE [dbo].[Comment_Insert]
	@PostId int,
	@Content nvarchar(max),
	@UserId nvarchar(150),
	@UserName nvarchar(150)
AS
begin
	set nocount on
	insert into dbo.Phuong_Comments(PostId,Content,UserId,UserName)
	select @PostId,@Content,@UserId,@UserName

	select CommentId,Content,UserName,UserId,Created
	from dbo.Phuong_Comments
	where CommentId = SCOPE_IDENTITY()
end
