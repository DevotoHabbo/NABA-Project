CREATE PROCEDURE [dbo].[Comment_Delete_ByPostId]
	@PostId int
AS
begin
	set nocount on
	delete
	from dbo.Phuong_Comments
	where PostId = @PostId
end