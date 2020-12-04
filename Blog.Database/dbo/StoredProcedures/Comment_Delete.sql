CREATE PROCEDURE [dbo].[Comment_Delete]
	@CommentId int
AS
begin
	set nocount on
	delete
	from dbo.Phuong_Comments
	where CommentId = @CommentId
end