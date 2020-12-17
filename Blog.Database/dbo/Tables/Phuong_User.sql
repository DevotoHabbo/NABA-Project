CREATE TABLE [dbo].[Phuong_User]
(
	[UserId] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [Name] NCHAR(128) NOT NULL, 
    [Created] DATETIME2 NULL DEFAULT getutcdate()
)
