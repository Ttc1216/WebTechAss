CREATE TABLE [dbo].[User]
(
    [Id] BIGINT IDENTITY(1,1) NOT NULL,
    [FirstName] VARCHAR(50) NULL,
    [MiddleName] VARCHAR(50) NULL,
    [LastName] VARCHAR(50) NULL,
    [Mobile] VARCHAR(15) NULL,
    [Email] VARCHAR(50) NULL,
    [RegisteredAt] DATETIME NOT NULL,
    [LastLogin] DATETIME NULL,
    [Intro] NVARCHAR(MAX) NULL,
    [Profile] NVARCHAR(MAX) NULL,
    [aspnetuserID] NVARCHAR(450) NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_User_ToTable] FOREIGN KEY ([aspnetuserID]) REFERENCES [AspNetUsers]([ID]),
)
