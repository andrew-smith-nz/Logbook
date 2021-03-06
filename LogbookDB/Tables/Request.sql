﻿CREATE TABLE [dbo].[Request]
(
	[RequestId] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(), 
	[UserId] UNIQUEIDENTIFIER NOT NULL,
    [Expires] DATETIME NOT NULL DEFAULT DATEADD(DAY, 1, GETDATE()), 
    [RequestType] NVARCHAR(32) NOT NULL, 
    [Consumed] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Request] PRIMARY KEY ([RequestId]), 
    CONSTRAINT [FK_Request_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId]) 
)
