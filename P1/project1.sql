--one column primary key of stores
--one column pointing to primary key of product
--automatic insertion or deletion
--junction table for store inventory


--Create Tables
CREATE TABLE Customer (
	[CustomerId] INT IDENTITY(10, 1) Primary Key,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
    [Address] NVARCHAR(70),
    [City] NVARCHAR(40),
    [State] NVARCHAR(40),
    [Country] NVARCHAR(40),
    [PostalCode] NVARCHAR(10),
    [Phone] NVARCHAR(24),
    [Email] NVARCHAR(60) NOT NULL,
    [Password] NVARCHAR(40) NOT NULL,
);

CREATE TABLE Product (
    [ProductId] int IDENTITY(1, 1) Primary Key,
    [StoreID] INT NOT NULL,
    [Name] NVARCHAR(200) NOT NULL,
    [Color] NVARCHAR(50),
    [Size] NVARCHAR(50),
    [Description] NVARCHAR(300),
    [UnitPrice] INT NOT NULL,
    [Quantity] INT NOT NULL,
);
ALTER TABLE Product
ADD FOREIGN KEY (StoreID) REFERENCES Store(StoreID);

CREATE TABLE Store (
    [StoreId] int IDENTITY(10, 10) Primary Key,
    [Address] NVARCHAR(70),
    [City] NVARCHAR(40),
    [State] NVARCHAR(40),
    [PostalCode] NVARCHAR(10),
    [Phone] NVARCHAR(24),
    [Email] NVARCHAR(60) NOT NULL,
); 
--store & product junction for inventory
CREATE TABLE Inventory (
    [InventoryId] int IDENTITY(10, 1) Primary Key,
    [InventoryNumber] int NOT NULL,
    [ProductId] int FOREIGN KEY REFERENCES Product(ProductId),
    [StoreId] int FOREIGN KEY REFERENCES Store(StoreId),
    DateCreated DATETIME not null DEFAULT(GETDATE())
);

CREATE TABLE Orders (
    [OrderId] int IDENTITY(1, 1) Primary Key,
    [CustomerId] int FOREIGN KEY REFERENCES Customer(CustomerId),
    [ProductId] int FOREIGN KEY REFERENCES Product(ProductId),
    [OrderDate] DATETIME NOT NULL,
    [Total] INT NOT NULL,
);
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
