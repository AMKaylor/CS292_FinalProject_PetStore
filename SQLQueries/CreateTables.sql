CREATE TABLE StoreItems (
	Id				int				Not Null	IDENTITY	PRIMARY KEY,
	ProductName		nvarchar(60)	Not Null,
	ProductType		nvarchar(60)	Not Null,
	Price			decimal			Not Null	DEFAULT 0.0,
	Descriptor		nvarchar(200)
);

CREATE TABLE WishList (
	Id				int				Not Null	IDENTITY	PRIMARY KEY,
	ProductId		int				Not Null	FOREIGN KEY(Id) REFERENCES StoreItems(Id),
);