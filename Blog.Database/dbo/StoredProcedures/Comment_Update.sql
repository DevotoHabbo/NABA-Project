CREATE PROCEDURE [dbo].[Comment_Update]
	@CommentId int,
	@Content nvarchar(max)
AS
begin
	set nocount on
	update dbo.Phuong_Comments
	set Content = @Content
	where CommentId = @CommentId
	select c.CommentId,c.PostId,c.Content,u.UserName,c.Created
	from dbo.Phuong_Comments c 
	left join AspNetUsers u on c.UserId = u.Id
	where CommentId = @CommentId
end