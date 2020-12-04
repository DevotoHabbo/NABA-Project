CREATE PROCEDURE [dbo].[Post_Exists]
	@PostId int
AS
begin
	set nocount on
	select case when exists (select PostId from dbo.Phuong_Posts where PostId = @PostId)
	then cast(1 as bit) else cast (0 as bit) end as Result
end