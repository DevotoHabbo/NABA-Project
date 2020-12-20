CREATE TABLE [dbo].[Phuong_Posts]
(
	[PostId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NCHAR(256) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL,
    [UserId] NVARCHAR(128) NULL,
    [Created] DATETIME2 NULL DEFAULT getutcdate(), 

)
