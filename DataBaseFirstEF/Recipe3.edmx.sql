
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/04/2017 02:04:57
-- Generated from EDMX file: \\crp40ppfs09.medassets.com\homedirs_vdi_old\rjamal\documents\visual studio 2015\Projects\DataBaseFirstEF\DataBaseFirstEF\Recipe3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EF6Recipes];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[Chapter2].[Album]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Album];
GO
IF OBJECT_ID(N'[Chapter2].[Artist]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Artist];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [AlbumId] int IDENTITY(1,1) NOT NULL,
    [AlbumName] varchar(max)  NULL
);
GO

-- Creating table 'Artists'
CREATE TABLE [dbo].[Artists] (
    [ArtistId] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(max)  NULL,
    [LastName] varchar(max)  NULL,
    [MiddleName] varchar(max)  NULL
);
GO

-- Creating table 'ArtistAlbum'
CREATE TABLE [dbo].[ArtistAlbum] (
    [Artists_ArtistId] int  NOT NULL,
    [Albums_AlbumId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AlbumId] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([AlbumId] ASC);
GO

-- Creating primary key on [ArtistId] in table 'Artists'
ALTER TABLE [dbo].[Artists]
ADD CONSTRAINT [PK_Artists]
    PRIMARY KEY CLUSTERED ([ArtistId] ASC);
GO

-- Creating primary key on [Artists_ArtistId], [Albums_AlbumId] in table 'ArtistAlbum'
ALTER TABLE [dbo].[ArtistAlbum]
ADD CONSTRAINT [PK_ArtistAlbum]
    PRIMARY KEY CLUSTERED ([Artists_ArtistId], [Albums_AlbumId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Artists_ArtistId] in table 'ArtistAlbum'
ALTER TABLE [dbo].[ArtistAlbum]
ADD CONSTRAINT [FK_ArtistAlbum_Artist]
    FOREIGN KEY ([Artists_ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Albums_AlbumId] in table 'ArtistAlbum'
ALTER TABLE [dbo].[ArtistAlbum]
ADD CONSTRAINT [FK_ArtistAlbum_Album]
    FOREIGN KEY ([Albums_AlbumId])
    REFERENCES [dbo].[Albums]
        ([AlbumId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistAlbum_Album'
CREATE INDEX [IX_FK_ArtistAlbum_Album]
ON [dbo].[ArtistAlbum]
    ([Albums_AlbumId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------