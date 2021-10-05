﻿CREATE TABLE [dbo].[Country]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NameLabel] int NOT NULL,
    [ISO3] VARCHAR(3) NULL, 
    [Code] VARCHAR(3) NULL, 
    [ISO2] VARCHAR(2) NULL, 
    [PhoneCode] VARCHAR(255) NULL, 
    [CapitalLabel] int NULL, 
    [Currency] VARCHAR(255) NULL, 
    [Symbol] VARCHAR(255) NULL, 
    [TLD] VARCHAR(255) NULL, 
    [NativeLabel] INT NULL, 
    [RegionLabel] INT NULL, 
    [SubRegionLabel] INT NULL, 
    [TimeZones] INT NULL, 
    [Latitude] DECIMAL(10, 8) NULL, 
    [Longitude] DECIMAL(10, 8) NULL, 
    [Emoji] VARCHAR(200) NULL, 
    [EmojiU] VARCHAR(200) NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Flag] BIT NULL DEFAULT 0, 
    [WikiDataId] VARCHAR(255) NULL,
    [Deleted] BIT NOT NULL DEFAULT 0

)
