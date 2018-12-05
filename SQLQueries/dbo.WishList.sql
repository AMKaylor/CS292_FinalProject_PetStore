CREATE TABLE [dbo].[WishList] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductName] VARCHAR(50) NOT NULL,
    [Price] DECIMAL NULL, 
    [Description] VARCHAR(200) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[StoreItems] ([Id])
);

