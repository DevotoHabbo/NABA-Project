CREATE PROCEDURE [dbo].[Comment_Get_ById]
	@CommentId int
AS
begin
	set nocount on
	select CommentId,Content,UserName,Created
	from dbo.Phuong_Comments
	where CommentId=@CommentId
end

