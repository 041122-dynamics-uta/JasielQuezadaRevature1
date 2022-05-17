--CUSTOMER INSERTS (10)
SET IDENTITY_INSERT [dbo].[Store] ON
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [Email], [Password]) 
VALUES ('Eduardo', 'Martins', '123 Sesame Street Birdington, USA', 'eduardo@woodstock.com', 'fjkdifj');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [Email], [Password]) 
VALUES ('Alexandre', 'Rocha', 'Av. Paulista, 2022, São Paulo,SP , Brazil',  'alero@uol.com', 'dgjsbdhg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [Email], [Password]) 
VALUES ('Kathy', 'Chase', '801 W 4th Street, Reno, NV, USA', 'kachase@hotmail.com', 'dfjjdfb');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [Email], [Password]) 
VALUES ('Heather', 'Leacock', '120 S Orange Ave, Orlando, FL, USA', 'hleacock@gmail.com', 'dbgjksdbg');
INSERT INTO [Customer] ([FirstName], [LastName], [Address], [Email], [Password]) 
VALUES ('John', 'Gordon', '69 Salem Street, Boston, MA, USA', 'johngordon22@yahoo.com', 'dgasdg');


--STORE INSERTS (2)
INSERT INTO Store ([StoreID], [Name], [Location]) 
VALUES(10, 'Marvel Merch Avenue', 'Atlanta, Georgia');
INSERT INTO Store ([StoreID], [Name], [Location]) 
VALUES(20, 'Marvel Merch Street', 'Los Angeles, California');

--PRODUCT INSERTS (10) atl store
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('WandaVison T-Shirt', 'Black WandaVision screen printed cotton T-shirt one size', 15, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Loki T-Shirt','Black Loki screen printed cotton T-shirt one size', 15, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Hulk Gloves','Green Hulk Smash Play Gloves Large', 15, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Iron Man Helmet','Light-Up Iron Man helmet with voice activated Jarvis responces custom size ', 400, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Thor Pajamas','Two piece top and pants pajama set One Size', 15, 20);
--LA Store
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('WandaVison T-Shirt', 'Black WandaVision screen printed cotton T-shirt one size', 20, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Loki T-Shirt','Black Loki screen printed cotton T-shirt one size', 20, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Hulk Gloves','Green Hulk Smash Play Gloves Large', 20, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Iron Man Helmet','Light-Up Iron Man helmet with voice activated Jarvis responces custom size ', 500, 20);
INSERT INTO Product ([Name], [Description], [UnitPrice], [Quantity]) 
VALUES('Thor Pajamas','Two piece top and pants pajama set One Size', 20, 20);


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
