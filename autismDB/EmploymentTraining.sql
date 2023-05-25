CREATE TABLE [dbo].[EmploymentTraining]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(50) NOT NULL,
    [Location] NVARCHAR(100) NULL,
    [StartDate] DATE NULL,
    [EndDate] DATE NULL
);
