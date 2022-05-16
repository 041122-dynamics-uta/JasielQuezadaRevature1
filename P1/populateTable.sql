--CUSTOMER INSERTS (10)
SET IDENTITY_INSERT [dbo].[Store] ON
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Eduardo', 'Martins', '123 Sesame Street', 'Birdington', 'USA', '01007-010', '+1 (11) 3033-4564', 'eduardo@woodstock.com', 'fjkdifj');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Alexandre', 'Rocha', 'Av. Paulista, 2022', 'São Paulo', 'SP', 'Brazil', '01310-200', '+55 (11) 3055-3278', 'alero@uol.com', 'dgjsbdhg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Kathy', 'Chase', '801 W 4th Street', 'Reno', 'NV', 'USA', '89503', '+1 (775) 223-7665', 'kachase@hotmail.com', 'dfjjdfb');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Heather', 'Leacock', '120 S Orange Ave', 'Orlando', 'FL', 'USA', '32801', '+1 (407) 999-7788', 'hleacock@gmail.com', 'dbgjksdbg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('John', 'Gordon', '69 Salem Street', 'Boston', 'MA', 'USA', '2113', '+1 (617) 522-1333', 'johngordon22@yahoo.com', 'dgasdg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Jennifer', 'Peterson', '700 W Pender Street', 'Vancouver', 'BC', 'Canada', 'V6C 1G8', '+1 (604) 688-2255', 'jenniferp@rogers.com', 'adfgadfg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Frank', 'Harris', '1600 Amphitheatre Parkway', 'Mountain View', 'CA', 'USA', '94043-1351', '+1 (650) 253-0000', 'fharris@google.com', 'sdfgadgf');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Jack', 'Smith', '1 Microsoft Way', 'Redmond', 'WA', 'USA', '98052-8300', '+1 (425) 882-8081', 'jacksmith@microsoft.com', 'afgdadg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Michelle', 'Brooks', '627 Broadway', 'New York', 'NY', 'USA', '10012-2612', '+1 (212) 221-3546', 'michelleb@aol.com', 'afgdgd');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [Password]) 
VALUES ('Dan', 'Miller', '541 Del Medio Avenue', 'Mountain View', 'CA', 'USA', '94040-111', '+1 (650) 644-3358', 'dmiller@comcast.com', 'dgsdfg');

--STORE INSERTS (2)
INSERT INTO Store ([StoreID], [Address], [City], [State], [PostalCode], [Phone], [Email]) 
VALUES(10, '123 Marvel Avenue', 'Atlanta', 'Georgia', '30145', '40440140102', 'MarvelMerch@Gmail.com');
INSERT INTO Store ([StoreID], [Address], [City], [State], [PostalCode], [Phone], [Email]) 
VALUES(20, '321 Marvel Street', 'Los Angeles', 'California', '90210', '9129329121', 'MarvelMerch@Gmail.com');

--PRODUCT INSERTS (10)
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(10, 'WandaVision T-Shirt','Black','One Size','Black WandaVision screen printed cotton T-shirt', 15, 20);
INSERT INTO Product ( [StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(10, 'Loki T-Shirt','Black','One Size','Black Loki screen printed cotton T-shirt', 15, 20);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(10, 'Hulk Gloves','Green','One Size','Green Hulk Smash Play Gloves', 15, 20);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(10, 'Iron Man Helmet','Red & Gold','One Size','Light-Up Iron Man helmet with voice activated Jarvis responces ', 400, 20);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(10, 'Thor Pajamas','Red','One Size','Two piece top and pants pajama set', 15, 20);

INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(20, 'WandaVision T-Shirt','Black','One Size','Black WandaVision screen printed cotton T-shirt', 15, 30);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(20, 'Loki T-Shirt','Black','One Size','Black Loki screen printed cotton T-shirt', 15, 30);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(20, 'Hulk Gloves','Green','One Size','Green Hulk Smash Play Gloves', 10, 30);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(20, 'Iron Man Helmet','Red & Gold','One Size','Light-Up Iron Man helmet with voice activated Jarvis responces ', 500, 30);
INSERT INTO Product ([StoreID], [Name], [Color], [Size], [Description], [UnitPrice], [Quantity]) 
VALUES(20, 'Thor Pajamas','Red','One Size','Two piece top and pants pajama set', 20, 30);

- Orders INSERTS (11)
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate],[Total]) 
VALUES (36, 2, '2022/5/5', 17.98);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (38, 3, '2022/5/6', 35.96);
INSERT INTO Orders ([CustomerId], [ProductId],  [OrderDate], [Total]) 
VALUES (15, 3, '2022/6/5', 17.98);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (27, 9, '2022/6/10', 550.91);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (55, 6, '2022/7/7', 35.96);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (23, 7, '2022/9/11', 80.91);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (26, 10, '2022/11/7', 400.98);  
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (28, 11, '2022/11/7', 60.98);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (28, 10,  '2022/11/7', 55.98);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate], [Total]) 
VALUES (47, 8, '2022/1/9', 400.96);
INSERT INTO Orders ([CustomerId], [ProductId], [OrderDate],  [Total]) 
VALUES (24, 11, '2010/3/21', 150.86);
