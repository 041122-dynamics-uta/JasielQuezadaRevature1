--CUSTOMER INSERTS (10)
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (10, 'Eduardo', 'Martins', 'Rua Dr. Falcão Filho, 155', 'São Paulo', 'SP', 'Brazil', '01007-010', '+55 (11) 3033-4564', 'eduardo@woodstock.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (11, 'Alexandre', 'Rocha', 'Av. Paulista, 2022', 'São Paulo', 'SP', 'Brazil', '01310-200', '+55 (11) 3055-3278', 'alero@uol.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (12, 'Kathy', 'Chase', '801 W 4th Street', 'Reno', 'NV', 'USA', '89503', '+1 (775) 223-7665', 'kachase@hotmail.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (13, 'Heather', 'Leacock', '120 S Orange Ave', 'Orlando', 'FL', 'USA', '32801', '+1 (407) 999-7788', 'hleacock@gmail.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (14, 'John', 'Gordon', '69 Salem Street', 'Boston', 'MA', 'USA', '2113', '+1 (617) 522-1333', 'johngordon22@yahoo.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (15, 'Jennifer', 'Peterson', 'Rogers Canada', '700 W Pender Street', 'Vancouver', 'BC', 'Canada', 'V6C 1G8', '+1 (604) 688-2255', 'jenniferp@rogers.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (16, 'Frank', 'Harris', 'Google Inc.', '1600 Amphitheatre Parkway', 'Mountain View', 'CA', 'USA', '94043-1351', '+1 (650) 253-0000', 'fharris@google.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (17, 'Jack', 'Smith', '1 Microsoft Way', 'Redmond', 'WA', 'USA', '98052-8300', '+1 (425) 882-8081', 'jacksmith@microsoft.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email]) 
VALUES (18, 'Michelle', 'Brooks', '627 Broadway', 'New York', 'NY', 'USA', '10012-2612', '+1 (212) 221-3546', 'michelleb@aol.com');
INSERT INTO [Customer] ([CustomerId], [FirstName], [LastName], [Address], [City], [State], [Country], [PostalCode], [Phone], [Email], [SupportRepId]) 
VALUES (20, 'Dan', 'Miller', '541 Del Medio Avenue', 'Mountain View', 'CA', 'USA', '94040-111', '+1 (650) 644-3358', 'dmiller@comcast.com');

--STORE INSERTS (2)
INSERT INTO Store ([[StoreID]], [Address], [City], [State], [PostalCode], [Phone], [Email]) 
VALUES(10, '123 Marvel Avenue', 'Atlanta', 'Georgia', '30145', '40440140102', 'MarvelMerch@Gmail.com');
INSERT INTO Store ([[StoreID]], [Address], [City], [State], [PostalCode], [Phone], [Email]) 
VALUES(20, '321 Marvel Street', 'Los Angeles', 'California', '90210', '9129329121', 'MarvelMerch@Gmail.com');

--PRODUCT INSERTS (10)
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(1, 'WandaVision T-Shirt','Black','One Size','Black WandaVision screen printed cotton T-shirt', 10, 15);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(2, 'Loki T-Shirt','Black','One Size','Black Loki screen printed cotton T-shirt', 10, 15);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(3, 'Hulk Gloves','Green','One Size','Green Hulk Smash Play Gloves', 10, 10);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(4, 'Iron Man Helmet','Red & Gold','One Size','Light-Up Iron Man helmet with voice activated Jarvis responces ', 10, 400);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(5, 'Thor Pajamas','Red','One Size','Two piece top and pants pajama set', 10, 15);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(6, 'WandaVision T-Shirt','Black','One Size','Black WandaVision screen printed cotton T-shirt', 20, 15);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(7, 'Loki T-Shirt','Black','One Size','Black Loki screen printed cotton T-shirt', 120, 15);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(8, 'Hulk Gloves','Green','One Size','Green Hulk Smash Play Gloves', 20, 10);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(9, 'Iron Man Helmet','Red & Gold','One Size','Light-Up Iron Man helmet with voice activated Jarvis responces ', 120, 400);
INSERT INTO Product ([ProductId], [Name], [Color], [Size], [Description], [StoreID],  [UnitPrice]) 
VALUES(10, 'Thor Pajamas','Red','One Size','Two piece top and pants pajama set', 20, 15);

--INVOICE INSERTS (11)
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (10, 36, '2022/5/5', 'Tauentzienstraße 8', 'Berlin', 'Germany', '10789', 17.98);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (11, 38, '2022/5/6', 'Barbarossastraße 19', 'Berlin', 'Germany', '10779', 35.96);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (12, 15, '2022/6/5', '700 W Pender Street', 'Vancouver', 'BC', 'Canada', 'V6C 1G8', 17.98);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (13, 27, '2022/6/10', '1033  Park Ave', 'Tucson', 'AZ', 'USA', '85719', 550.91);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (14, 55, '2022/7/7', '421 Bourke Street', 'Sidney', 'NSW', 'Australia', '2010', 35.96);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (15, 23, '2022/9/11', '69 Salem Street', 'Boston', 'MA', 'USA', '2113', 80.91);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (16, 26, '2022/11/7', '2211 W Berry Street', 'Fort Worth', 'TX', 'USA', '76110', 100.98);  
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (17, 28, '2022/11/7', '302 S 700 E', 'Salt Lake [City]', 'UT', 'USA', '84102', 60.98);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (18, 28, '2022/11/7', '302 S 700 E', 'Salt Lake [City]', 'UT', 'USA', '84102', 55.98);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (19, 47, '2022/1/9', 'Via Degli Scipioni, 43', 'Rome', 'RM', 'Italy', '00192', 300.96);
INSERT INTO Invoice ([InvoiceId], [CustomerId], [InvoiceDate], [BillingAddress], [Billing[City]], [BillingCountry], [Total]) 
VALUES (20, 24, '2010/3/21', '162 E Superior Street', 'Chicago', 'IL', 'USA', '60611', 150.86);

--INVOICE LINE INSERTS
