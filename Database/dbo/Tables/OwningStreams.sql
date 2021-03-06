﻿CREATE TABLE [dbo].[OwningStreams] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
	[CreatedBy]      NVARCHAR (50)  NULL,
    [CreatedOn]      DATETIME2 (7)  NOT NULL,
    [DeleteMark]     BIT            NOT NULL,
    [ModifiedBy]     NVARCHAR (50)  NULL,
    [ModifiedOn]     DATETIME2 (7)  NULL,
    [Name]           NVARCHAR (MAX) NULL,
    [dlEmailAddress] NVARCHAR (MAX) NULL,
	AppId	int ,
    CONSTRAINT [PK_OwningStreams] PRIMARY KEY CLUSTERED ([Id] ASC)
);

