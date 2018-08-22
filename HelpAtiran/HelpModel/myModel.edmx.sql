
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/09/2018 23:32:23
-- Generated from EDMX file: C:\Users\msm_bghr\Source\Repos2\csharps\HelpAtiran\HelpModel\myModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AtiranHelp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Answers_Questions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Answers] DROP CONSTRAINT [FK_Answers_Questions];
GO
IF OBJECT_ID(N'[dbo].[FK_UsePermition_UsersManagement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsePermition] DROP CONSTRAINT [FK_UsePermition_UsersManagement];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Answers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Answers];
GO
IF OBJECT_ID(N'[dbo].[overal_setting]', 'U') IS NOT NULL
    DROP TABLE [dbo].[overal_setting];
GO
IF OBJECT_ID(N'[dbo].[Questions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Questions];
GO
IF OBJECT_ID(N'[dbo].[UsePermition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsePermition];
GO
IF OBJECT_ID(N'[dbo].[UsersManagement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersManagement];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Answers'
CREATE TABLE [dbo].[Answers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [answer] nvarchar(max)  NULL,
    [active] char(1)  NULL,
    [Questions_id] int  NOT NULL
);
GO

-- Creating table 'overal_setting'
CREATE TABLE [dbo].[overal_setting] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dis] nvarchar(1000)  NULL,
    [value] bigint  NULL
);
GO

-- Creating table 'Questions'
CREATE TABLE [dbo].[Questions] (
    [id] int IDENTITY(1,1) NOT NULL,
    [question] nvarchar(max)  NULL,
    [active] char(1)  NULL
);
GO

-- Creating table 'UsePermition'
CREATE TABLE [dbo].[UsePermition] (
    [id] int IDENTITY(1,1) NOT NULL,
    [permitionId] int  NOT NULL,
    [UsersManagement_id] int  NOT NULL
);
GO

-- Creating table 'UsersManagement'
CREATE TABLE [dbo].[UsersManagement] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(50)  NULL,
    [password] nvarchar(50)  NULL,
    [status] int  NULL,
    [DeviceId] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [PK_Answers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'overal_setting'
ALTER TABLE [dbo].[overal_setting]
ADD CONSTRAINT [PK_overal_setting]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [PK_Questions]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'UsePermition'
ALTER TABLE [dbo].[UsePermition]
ADD CONSTRAINT [PK_UsePermition]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'UsersManagement'
ALTER TABLE [dbo].[UsersManagement]
ADD CONSTRAINT [PK_UsersManagement]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Questions_id] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [FK_Answers_Questions]
    FOREIGN KEY ([Questions_id])
    REFERENCES [dbo].[Questions]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Answers_Questions'
CREATE INDEX [IX_FK_Answers_Questions]
ON [dbo].[Answers]
    ([Questions_id]);
GO

-- Creating foreign key on [UsersManagement_id] in table 'UsePermition'
ALTER TABLE [dbo].[UsePermition]
ADD CONSTRAINT [FK_UsePermition_UsersManagement]
    FOREIGN KEY ([UsersManagement_id])
    REFERENCES [dbo].[UsersManagement]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsePermition_UsersManagement'
CREATE INDEX [IX_FK_UsePermition_UsersManagement]
ON [dbo].[UsePermition]
    ([UsersManagement_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------