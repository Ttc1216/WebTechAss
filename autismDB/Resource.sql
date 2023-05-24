CREATE TABLE [dbo].[Resource]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [ResourceCategoryId] INT NULL, 
    [ResourceAgeRangeId] INT NULL,
    CONSTRAINT [FK_Resource_ToResourceCategory] FOREIGN KEY ([ResourceCategoryId]) REFERENCES [ResourceCategory]([Id]), 
    CONSTRAINT [FK_Resource_ToResourceAgeRange] FOREIGN KEY ([ResourceAgeRangeId]) REFERENCES [ResourceAgeRange]([Id]),

)
