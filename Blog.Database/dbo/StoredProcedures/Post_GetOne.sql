﻿CREATE PROCEDURE [dbo].[Post_GetOne]
	@PostId int
AS
begin
	set nocount on
	select PostId,Title,Content,UserId,Created
	from dbo.Phuong_Posts
	where PostId = @PostId
end