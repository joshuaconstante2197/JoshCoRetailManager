CREATE TABLE [dbo].[User]
(
    [Id] NCHAR(128) NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(50) NULL, 
    [LastName] NCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(256) NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
