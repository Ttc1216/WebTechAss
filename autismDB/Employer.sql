CREATE TABLE [dbo].[Employer]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(50) NOT NULL,
    [Address] NVARCHAR(100) NULL,
    [PhoneNumber] NVARCHAR(15) NULL,
    [Email] NVARCHAR(50) NULL
);
