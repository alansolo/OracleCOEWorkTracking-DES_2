﻿CREATE TABLE [dbo].[OraclePreProdEnvironments] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]  NVARCHAR (50)  NULL,
    [CreatedOn]  DATETIME2 (7)  NOT NULL,
    [DeleteMark] BIT            NOT NULL,
    [ModifiedBy] NVARCHAR (50)  NULL,
    [ModifiedOn] DATETIME2 (7)  NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [ApplicationId] INT NULL, 
    CONSTRAINT [PK_OraclePreProdEnvironments] PRIMARY KEY CLUSTERED ([Id] ASC)
);

