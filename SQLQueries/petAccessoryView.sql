CREATE VIEW [dbo].[View]
	AS SELECT ProductName as 'Product Name',Price, Descriptor as 'Description' FROM [dbo].[StoreItems]
	WHERE ProductType = 'Pet Accessory'