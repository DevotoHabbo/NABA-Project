CREATE PROCEDURE [dbo].[Comment_GetBy_PostId]
	@PostId int
AS
begin
	set nocount on
	select CommentId,PostId,Content,UserName,Created
	from dbo.Phuong_Comments
	where PostId = @PostId
end
