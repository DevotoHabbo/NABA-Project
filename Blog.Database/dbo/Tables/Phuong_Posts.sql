﻿CREATE TABLE [dbo].[Phuong_Posts]
(
	[PostId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NCHAR(256) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL,
    [UserId] NCHAR(128) NOT NULL,
    [Created] DATETIME2 NULL DEFAULT getutcdate(), 

)
