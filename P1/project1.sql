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
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId])
);
GO
CREATE TABLE Product (
    [ProductId] int IDENTITY(1, 1) Primary Key,
    [Name] NVARCHAR(200) NOT NULL,
    [Color] NVARCHAR(50),
    [Size] NVARCHAR(50),
    [Description] NVARCHAR(300) ,
    [StoreID] INT NOT NULL,
    [UnitPrice] NUMERIC(10,5) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId])
);
GO 
CREATE TABLE Store (
    [StoreId] int IDENTITY(10, 10) Primary Key,
    [Address] NVARCHAR(70),
    [City] NVARCHAR(40),
    [State] NVARCHAR(40),
    [PostalCode] NVARCHAR(10),
    [Phone] NVARCHAR(24),
    [Email] NVARCHAR(60) NOT NULL,
    CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED ([StoreId])
); 
GO
CREATE TABLE Invoice (
    [InvoiceId] int IDENTITY(10, 1) Primary Key,
    [CustomerId] INT NOT NULL,
    [InvoiceDate] DATETIME NOT NULL,
    [BillingAddress] NVARCHAR(70),
    [BillingCity] NVARCHAR(40),
    [BillingState] NVARCHAR(40),
    [BillingCountry] NVARCHAR(40),
    [BillingPostalCode] NVARCHAR(10),
    [Total] NUMERIC(10,2) NOT NULL,
    DateCreated DATETIME2 not null DEFAULT(GETDATE())
    CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([InvoiceId])
);
GO
CREATE TABLE _InvoiceLine (
    [InvoiceLineId] int IDENTITY(1, 1) Primary Key,
    [InvoiceId] INT NOT NULL,
    [UnitPrice] NUMERIC(15,2) NOT NULL,
    [Quantity] INT NOT NULL,
    CONSTRAINT [PK_InvoiceLine] PRIMARY KEY CLUSTERED ([InvoiceLineId])
);
GO
--Create Foreign Keys
ALTER TABLE [Customer] ADD CONSTRAINT [FK_CustomerId]
FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([CustomerId]) ON DELETE NO ACTION ON UPDATE NO ACTION;
    GO
ALTER TABLE [Product] ADD CONSTRAINT [FK_ProductId]
FOREIGN KEY ([ProductId]) REFERENCES [Product] ([ProductId]) ON DELETE NO ACTION ON UPDATE NO ACTION;
    GO
ALTER TABLE [Store] ADD CONSTRAINT [FK_StoreId]
FOREIGN KEY ([StoreId]) REFERENCES [Store] ([StoreId]) ON DELETE NO ACTION ON UPDATE NO ACTION;
    GO
ALTER TABLE [Invoice] ADD CONSTRAINT [FK_InvoiceId]
FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice] ([InvoiceId]) ON DELETE NO ACTION ON UPDATE NO ACTION;
    GO
ALTER TABLE [InvoiceLine] ADD CONSTRAINT [FK_InvoiceLineId]
FOREIGN KEY ([InvoiceLineId]) REFERENCES [InvoiceLine] ([InvoiceLineId]) ON DELETE NO ACTION ON UPDATE NO ACTION;
    GO

--Create Procedures
CREATE PROCEDURE Customer_GetAll
AS
BEGIN
    SELECT id, FirstName, LastName
    FROM customerID
END

--Populate Tables
