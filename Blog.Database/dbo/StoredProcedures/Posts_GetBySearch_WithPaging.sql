CREATE PROCEDURE [dbo].[Posts_GetBySearch_WithPaging]
	@Search nvarchar(100),
	@PageNumber int,
	@PageSize int
AS
begin
	select PostId,Title,Content,UserId,UserName,Created
	from(select PostId,Title,COntent,UserId,UserName,Created from dbo.Phuong_Posts where Title like '%' + @Search +'%'
	union
	select PostId,Title,COntent,UserId,UserName,Created from dbo.Phuong_Posts where Content like '%' + @Search +'%'
	union
	select PostId,Title,COntent,UserId,UserName,Created from dbo.Phuong_Posts where UserName like '%' + @Search +'%') Sub
	order by PostId
	offset @PageSize *(@PageNumber -1) Rows
	fetch next @PageSize rows only
end

