CREATE TABLE [dbo].[Phuong_Comments]
(
	[CommentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PostId] INT NOT NULL,
    [UserId] NCHAR(150) NOT NULL, 
    [UserName] NCHAR(150) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL, 
    [Created] NCHAR(10) NULL DEFAULT getutcdate()
)
