CREATE PROCEDURE [dbo].[Posts_GetBySearch]
	@Search nvarchar(100)
AS
begin
	set nocount on
		select PostId,Title,Content,UserId,UserName,Created
		from dbo.Phuong_Posts
		where Title like '%' + @Search + '%'
	union
		select PostId,Title,Content,UserId,UserName,Created
		from dbo.Phuong_Posts
		where Content like '%' + @Search + '%'
	union
		select PostId,Title,Content,UserId,UserName,Created
		from dbo.Phuong_Posts
		where UserName like '%' + @Search + '%'
end