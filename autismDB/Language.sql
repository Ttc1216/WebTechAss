﻿CREATE TABLE [dbo].[Language]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [English] NVARCHAR(50) NOT NULL, 
    [Chinese] NVARCHAR(50) NOT NULL, 
    [Malay] NVARCHAR(50) NOT NULL,
)
