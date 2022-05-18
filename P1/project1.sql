--one column primary key of stores
--one column pointing to primary key of product
--automatic insertion or deletion
--junction table for store inventory


--Create Tables
CREATE TABLE Customer (
	[CustomerId] INT IDENTITY(1, 1) Primary Key,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
    [Address] NVARCHAR(70),
    [Email] NVARCHAR(60) NOT NULL,
    [Password] NVARCHAR(30) NOT NULL,
    [DateCreated] DATETIME NOT NULL DEFAULT(GETDATE()),
);
CREATE TABLE Product (
    [ProductId] int IDENTITY(1, 1) Primary Key,
    [ProductName] NVARCHAR(200) NOT NULL,
    [Description] NVARCHAR(300),
    [Price] DECIMAL[5,2] NOT NULL,
    [Quantity] INT NOT NULL DEFAULT(1),
    [DateCreated] DATETIME NOT NULL DEFAULT(GETDATE()),
);
CREATE TABLE Store (
    [StoreId] int IDENTITY(10, 1) Primary Key,
    [Name] NVARCHAR(24),
    [Location] NVARCHAR(70),
    [DateCreated] DATETIME NOT NULL DEFAULT(GETDATE()),  
); 
CREATE TABLE Inventory (
    [InventoryId] int IDENTITY(10, 1) Primary Key,
    [ProductId_FK] int FOREIGN KEY REFERENCES Product(ProductId),
    [StoreId_FK] int FOREIGN KEY REFERENCES Store(StoreId),
    [Quantity] INT NOT NULL DEFAULT(1),
    [DateCreated] DATETIME NOT NULL DEFAULT(GETDATE()),
);

CREATE TABLE Orders (
    [LineItemId] int IDENTITY(1,1) Primary Key, 
    [OrderId] UNIQUEIDENTIFIER NOT NULL,
    [CustomerId_FK] int NOT NULL FOREIGN KEY REFERENCES Customer(CustomerId),
    [ProductId_FK] int NOT NULL FOREIGN KEY REFERENCES Product(ProductId),
    [StoreId_FK] int NOT NULL FOREIGN KEY REFERENCES Store(StoreId),
    [Price] decimal (4,2) NOT NULL,
    [DateCreated] DATETIME NOT NULL DEFAULT(GETDATE()),
);


ALTER TABLE OrderHistory
ADD FOREIGN KEY (StoreID) REFERENCES Store(StoreID);
 [StoreId] int FOREIGN KEY REFERENCES Store(StoreId),

--Create Procedures
CREATE PROCEDURE Customer_GetOrder
AS
BEGIN
    SELECT id, FirstName, LastName
    FROM customerID
END
--join store and product for inventory
--iNVENTORY JOIN
SELECT Store.StoreId, Product.ProductId
FROM Store LEFT JOIN Product
ON  

SELECT Orders.OrderID, Customers.CustomerId, Product.ProductId
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;
