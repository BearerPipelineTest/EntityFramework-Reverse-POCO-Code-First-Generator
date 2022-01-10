﻿CREATE TABLE [dbo].[CMS_Tag] (
    [TagId]   INT           IDENTITY (1, 1) NOT NULL,
    [TagName] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_CMS_Tag] PRIMARY KEY CLUSTERED ([TagId] ASC)
);

