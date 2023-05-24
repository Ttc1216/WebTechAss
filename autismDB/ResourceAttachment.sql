CREATE TABLE [dbo].[ResourceAttachment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FileName] NVARCHAR(MAX) NOT NULL, 
    [FilePath] NVARCHAR(MAX) NOT NULL, 
    [LanguageId] INT NULL, 
    [FileSize] BIGINT NULL, 
    [DateUpload] DATETIME2 NULL, 
    [UploderId] INT NULL, 
    [ResourceId] INT NOT NULL, 
    CONSTRAINT [FK_ResourceAttachment_ToLanguage] FOREIGN KEY ([LanguageId]) REFERENCES [Language]([Id]), 
    CONSTRAINT [FK_ResourceAttachment_ToResource] FOREIGN KEY ([ResourceId]) REFERENCES [Resource]([Id])
)
