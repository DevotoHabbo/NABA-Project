CREATE PROCEDURE [dbo].[Post_Comments]

AS
begin
	set nocount on
	select p.PostId,p.Title,p.Content,p.UserName,p.Created,
			c.PostId,c.CommentId,c.Content,c.UserName,c.Created
	from dbo.Phuong_Posts p left join dbo.Phuong_Comments c on p.PostId = c.PostId
end