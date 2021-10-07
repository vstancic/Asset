CREATE TABLE [Asset] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Location] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Asset] PRIMARY KEY ([Id])
);
GO


