USE master;
GO

CREATE DATABASE StockManagementDB;
GO

-- Create Band table
USE StockManagementDB;
CREATE TABLE [dbo].[Brand](
    [BrandID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](100) UNIQUE NOT NULL
);
GO

--Primary key constraint
USE StockManagementDB;
ALTER TABLE Brand
ADD CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED ([BrandID] ASC);
GO

-- Create Category table
USE StockManagementDB;
CREATE TABLE [dbo].[Category](
    [CategoryID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](100) NOT NULL
);
GO

--Primary key constraint
USE StockManagementDB;
ALTER TABLE Category
ADD CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Create LedgerType table
USE StockManagementDB;
CREATE TABLE [dbo].[LedgerType](
    [LedgerTypeID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](100) NOT NULL
);
GO

--Primary key constraint
USE StockManagementDB;
ALTER TABLE LedgerType
ADD CONSTRAINT [PK_LedgerType] PRIMARY KEY CLUSTERED ([LedgerTypeID] ASC);
GO

-- Create our Item table
USE StockManagementDB;
CREATE TABLE [dbo].[Item](
    [ItemID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](120) NULL,
    [CategoryID] [int] NULL,
	[BrandID] [int] NULL,
	[InitialStock] [int] NOT NULL
);
GO

--Primary key constraint
USE StockManagementDB;
ALTER TABLE dbo.Item
ADD CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

--Forign Key constraint
USE StockManagementDB;
ALTER TABLE dbo.Item
ADD CONSTRAINT [FK_Item_Category]
FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID);
Go

--Forign Key constraint
USE StockManagementDB;
ALTER TABLE dbo.Item
ADD CONSTRAINT [FK_Item_Brand]
FOREIGN KEY (BrandID) REFERENCES Brand(BrandID);
Go

-- Create our ItemLedger table
USE StockManagementDB;
CREATE TABLE [dbo].[ItemLedger](
    [LedgerID] [int] IDENTITY(1,1) NOT NULL,
    [LedgerTypeID] [int] NULL,
	[ItemID] [int] NULL,
	[Quantity] [int] NULL,
	[DateOccured] [datetime] NULL
);
GO

--Primary key constraint
USE StockManagementDB;
ALTER TABLE dbo.ItemLedger
ADD CONSTRAINT [PK_ItemLedger] PRIMARY KEY CLUSTERED ([LedgerID] ASC);
GO

--Forign Key constraint
USE StockManagementDB;
ALTER TABLE dbo.ItemLedger
ADD CONSTRAINT [FK_ItemLedger_LedgerType]
FOREIGN KEY (LedgerTypeID) REFERENCES LedgerType(LedgerTypeID);
Go

--Forign Key constraint
USE StockManagementDB;
ALTER TABLE dbo.ItemLedger
ADD CONSTRAINT [FK_ItemLedger_Item]
FOREIGN KEY (ItemID) REFERENCES Item(ItemID);
Go




--Insert Data

--Inserting data into the Brand table
USE StockManagementDB;
INSERT INTO [dbo].[Brand]
           ([Name]
           )
VALUES ('Nestle'),
('Kraft Heinz'),
('General Mills'),
('Kellogg''s'),
('Coca-Cola'),
('Adidas'),
('Levis'),
('Ralph Lauren'),
('Vans'),
('Tommy Hilfiger'),
('Apple'),
('Samsung')
GO

--Inserting data into the Category table
USE StockManagementDB;
INSERT INTO [dbo].[Category]
           ([Name]
           )
VALUES ('Food'),
('Clothes'),
('Electronics')
GO

--Inserting data into the LedgerType table
USE StockManagementDB;
INSERT INTO [dbo].[LedgerType]
           ([Name]
           )
VALUES ('Sale'),
('Return'),
('Restock'),
('Broken')
GO

--Inserting data into the Item table
USE StockManagementDB;
INSERT INTO [dbo].[Item](
    [Name],
    [CategoryID],
	[BrandID],
	[InitialStock]
)
VALUES ('KitKat', 1, 1, 100),
('Nescafe', 1, 1, 100),
('Hot Pockets', 1, 1, 100),
('Gerber baby food', 1, 1, 100),
('Toll House chocolate chips', 1, 1, 100),
('Kraft Macaroni and Cheese', 1, 2, 100),
('Heinz Tomato Ketchup', 1, 2, 100),
('Philadelphia Cream Cheese', 1, 2, 100),
('Oscar Mayer Bacon', 1, 2, 100),
('Planters Peanuts', 1, 2, 100),
('Cheerios', 1, 3, 100),
('Betty Crocker cake mix', 1, 3, 100),
('Pillsbury cookie dough', 1, 3, 100),
('Nature Valley granola bars', 1, 3, 100),
('Gold Medal flour', 1, 3, 100),
('Frosted Flakes', 1, 4, 100),
('Pop-Tarts', 1, 4, 100),
('Rice Krispies', 1, 4, 100),
('Special K cereal', 1, 4, 100),
('Eggo Waffles', 1, 4, 100),
('Coca-Cola Classic', 1, 5, 100),
('Sprite', 1, 5, 100),
('Dasani water', 1, 5, 100),
('Minute Maid orange juice', 1, 5, 100),
('Powerade sports drink', 1, 5, 100),
('Superstar Sneakers', 2, 6, 100),
('Classic T-Shirt', 2, 6, 100),
('Hooded Sweatshirt', 2, 6, 100),
('Pleated Mini Skirt', 2, 6, 100),
('Cropped Denim Jacket', 2, 6, 100),
('Leather Biker Boots', 2, 7, 100),
('Cotton Polo Shirt', 2, 7, 100),
('Leather Belt', 2, 7, 100),
('Wool Peacoat', 2, 7, 100),
('Slip-On Sneakers', 2, 8, 100),
('Canvas Backpack', 2, 8, 100),
('Fleece Jacket', 2, 8, 100),
('Slim Fit Chinos', 2, 8, 100),
('Plaid Button-Up Shirt', 2, 9, 100),
('Wool Sweater', 2, 9, 100),
('Cotton Shorts', 2, 9, 100),
('High Waisted Jeans', 2, 9, 100),
('Knit Beanie', 2, 10, 100),
('Cotton Tank Top', 2, 10, 100),
('Leather Loafers', 2, 10, 100),
('iPhone 13 Pro', 3, 11, 100),
('MacBook Air', 3, 11, 100),
('AirPods Pro', 3, 11, 100),
('Apple Watch Series 7', 3, 11, 100),
('iPad Pro', 3, 11, 100),
('Galaxy S21 Ultra', 3, 12, 100),
('Galaxy Book Pro 360', 3, 12, 100),
('Galaxy Buds Pro', 3, 12, 100),
('Galaxy Watch 4', 3, 12, 100),
('Galaxy Tab S7+', 3, 12, 100)
GO

--Inserting data into the ItemLedger table
USE StockManagementDB;
INSERT INTO [dbo].ItemLedger
VALUES (4 ,48 ,3 ,'2022-10-20 22:47:53'),
(4 ,9 ,3 ,'2019-08-23 08:57:42'),
(1 ,50 ,5 ,'2022-02-17 10:04:44'),
(3 ,17 ,4 ,'2020-04-13 23:32:00'),
(2 ,48 ,4 ,'2021-03-26 10:33:11'),
(4 ,21 ,4 ,'2021-05-29 02:37:46'),
(1 ,13 ,4 ,'2020-11-01 06:16:30'),
(2 ,24 ,4 ,'2021-05-07 09:44:52'),
(2 ,29 ,3 ,'2020-11-21 22:13:30'),
(2 ,33 ,2 ,'2019-01-26 23:44:18'),
(1 ,5 ,1 ,'2020-05-03 01:38:18'),
(1 ,23 ,3 ,'2022-12-17 18:22:45'),
(3 ,47 ,5 ,'2022-10-09 21:38:37'),
(3 ,44 ,2 ,'2022-02-27 11:14:35'),
(4 ,42 ,4 ,'2022-08-27 19:38:01'),
(4 ,14 ,2 ,'2021-07-23 01:20:12'),
(1 ,45 ,1 ,'2020-07-20 06:03:07'),
(3 ,8 ,4 ,'2021-07-17 21:14:12'),
(3 ,16 ,2 ,'2021-07-01 10:52:56'),
(1 ,4 ,2 ,'2019-03-17 01:25:45'),
(4 ,20 ,5 ,'2022-01-20 22:46:09'),
(3 ,41 ,3 ,'2022-01-01 18:44:52'),
(2 ,6 ,1 ,'2022-08-12 12:57:17'),
(2 ,25 ,3 ,'2020-09-24 09:50:01'),
(1 ,1 ,4 ,'2019-02-27 23:39:37'),
(2 ,32 ,1 ,'2020-10-12 19:26:29'),
(2 ,34 ,5 ,'2023-02-28 05:53:25'),
(1 ,6 ,5 ,'2021-08-08 13:33:17'),
(4 ,31 ,3 ,'2022-07-06 17:06:14'),
(4 ,28 ,4 ,'2021-08-05 07:26:33'),
(1 ,8 ,5 ,'2019-07-15 01:46:08'),
(2 ,45 ,5 ,'2022-06-04 00:03:39'),
(4 ,50 ,4 ,'2019-05-28 03:55:17'),
(3 ,24 ,2 ,'2021-09-15 17:42:09'),
(4 ,38 ,1 ,'2021-09-09 02:22:22'),
(3 ,9 ,1 ,'2022-08-10 04:06:59'),
(4 ,16 ,1 ,'2023-03-17 06:15:00'),
(3 ,33 ,5 ,'2022-01-10 17:09:51'),
(1 ,12 ,3 ,'2019-10-19 18:48:03'),
(1 ,44 ,3 ,'2020-06-15 10:00:44'),
(1 ,27 ,3 ,'2021-10-28 18:47:02'),
(1 ,9 ,4 ,'2020-07-14 15:39:16'),
(2 ,1 ,2 ,'2022-03-26 05:42:11'),
(4 ,11 ,2 ,'2020-01-21 14:40:04'),
(4 ,46 ,5 ,'2020-06-05 23:59:16'),
(4 ,29 ,4 ,'2019-03-07 12:14:25'),
(2 ,10 ,2 ,'2020-07-20 14:36:34'),
(4 ,49 ,3 ,'2019-12-22 08:21:01'),
(2 ,41 ,5 ,'2020-04-27 06:19:45'),
(4 ,50 ,5 ,'2021-11-22 20:21:14'),
(4 ,3 ,2 ,'2019-03-11 09:08:55'),
(2 ,50 ,4 ,'2022-06-28 14:18:55'),
(4 ,24 ,5 ,'2020-11-16 23:19:31'),
(3 ,5 ,5 ,'2022-01-18 23:50:47'),
(4 ,8 ,2 ,'2019-02-15 18:34:26'),
(4 ,22 ,4 ,'2022-06-02 10:00:38'),
(4 ,27 ,4 ,'2020-08-25 15:49:07'),
(4 ,49 ,2 ,'2022-11-30 23:36:01'),
(2 ,45 ,2 ,'2021-07-09 15:19:08'),
(2 ,25 ,3 ,'2022-04-16 03:01:48'),
(1 ,41 ,4 ,'2021-09-04 21:34:07'),
(3 ,23 ,2 ,'2021-11-08 00:04:28'),
(3 ,7 ,5 ,'2019-08-11 07:10:00'),
(1 ,19 ,3 ,'2019-02-19 17:53:26'),
(3 ,49 ,1 ,'2021-10-09 07:52:28'),
(2 ,22 ,4 ,'2019-12-04 18:34:30'),
(3 ,26 ,2 ,'2020-11-21 02:35:25'),
(2 ,1 ,5 ,'2023-01-05 06:18:12'),
(4 ,20 ,4 ,'2021-03-30 15:07:35'),
(4 ,26 ,3 ,'2022-08-30 17:31:11'),
(3 ,2 ,2 ,'2023-02-18 06:21:24'),
(2 ,10 ,2 ,'2022-03-05 09:19:42'),
(1 ,25 ,4 ,'2020-09-11 04:49:17'),
(2 ,19 ,1 ,'2020-05-24 12:49:29'),
(3 ,2 ,1 ,'2019-04-11 17:15:58'),
(3 ,6 ,2 ,'2020-10-25 12:47:31'),
(3 ,46 ,4 ,'2020-04-28 23:17:32'),
(1 ,42 ,3 ,'2022-10-07 00:07:42'),
(3 ,9 ,2 ,'2019-09-23 01:58:23'),
(4 ,10 ,5 ,'2021-01-25 19:41:54'),
(3 ,37 ,2 ,'2022-01-31 17:45:55'),
(4 ,33 ,2 ,'2022-11-28 13:14:25'),
(2 ,30 ,1 ,'2022-07-21 09:03:13'),
(3 ,27 ,5 ,'2023-03-30 02:06:15'),
(3 ,8 ,2 ,'2023-03-30 16:16:46'),
(2 ,2 ,3 ,'2021-11-10 04:30:37'),
(4 ,26 ,3 ,'2022-11-25 05:36:12'),
(1 ,30 ,5 ,'2022-09-04 15:03:07'),
(2 ,2 ,3 ,'2022-10-08 17:21:39'),
(3 ,21 ,5 ,'2020-04-21 04:32:05'),
(1 ,13 ,1 ,'2020-05-26 16:33:40'),
(3 ,38 ,5 ,'2022-03-22 22:24:38'),
(1 ,12 ,3 ,'2021-07-28 21:31:28'),
(1 ,22 ,2 ,'2021-11-11 21:39:52'),
(2 ,26 ,3 ,'2019-03-14 10:24:03'),
(1 ,36 ,1 ,'2019-11-17 13:37:21'),
(2 ,45 ,4 ,'2019-11-07 04:03:28'),
(3 ,4 ,4 ,'2023-01-09 23:07:59'),
(1 ,45 ,2 ,'2020-11-22 13:54:24'),
(1 ,32 ,3 ,'2021-01-01 20:10:51'),
(2 ,9 ,4 ,'2019-12-08 03:50:13'),
(2 ,14 ,3 ,'2019-06-21 19:17:55'),
(3 ,24 ,4 ,'2020-06-11 21:21:11'),
(2 ,7 ,3 ,'2020-12-24 14:58:12'),
(1 ,8 ,1 ,'2022-06-27 02:23:01'),
(3 ,9 ,2 ,'2019-02-17 15:47:43'),
(1 ,5 ,2 ,'2022-08-05 04:50:47'),
(2 ,31 ,2 ,'2019-06-26 10:49:44'),
(1 ,32 ,2 ,'2019-08-14 04:21:59'),
(3 ,18 ,3 ,'2019-06-26 12:00:29'),
(4 ,48 ,5 ,'2021-08-11 01:51:40'),
(2 ,46 ,1 ,'2022-12-29 17:18:17'),
(3 ,34 ,3 ,'2022-01-15 12:44:34'),
(2 ,41 ,4 ,'2020-02-18 04:31:00'),
(1 ,11 ,5 ,'2021-11-15 08:22:07'),
(1 ,34 ,5 ,'2019-10-06 08:42:03'),
(2 ,13 ,4 ,'2019-08-12 07:21:07'),
(4 ,1 ,1 ,'2021-06-26 23:26:36'),
(4 ,2 ,3 ,'2021-10-07 23:27:21'),
(3 ,21 ,3 ,'2021-08-14 22:08:53'),
(4 ,32 ,2 ,'2020-05-05 07:12:47'),
(4 ,3 ,5 ,'2022-08-08 02:59:57'),
(2 ,40 ,1 ,'2021-05-24 09:09:47'),
(3 ,35 ,5 ,'2020-06-27 13:37:51'),
(3 ,49 ,4 ,'2019-02-20 12:49:12'),
(3 ,17 ,1 ,'2020-09-21 01:40:55'),
(1 ,39 ,5 ,'2019-03-30 23:07:21'),
(1 ,48 ,5 ,'2020-02-02 01:29:51'),
(4 ,26 ,4 ,'2019-06-26 01:34:07'),
(4 ,24 ,5 ,'2022-05-13 04:28:26'),
(1 ,27 ,4 ,'2020-04-03 04:09:48'),
(3 ,43 ,5 ,'2021-11-18 22:58:01'),
(1 ,12 ,4 ,'2021-12-23 12:48:58'),
(4 ,20 ,3 ,'2020-12-07 05:15:45'),
(3 ,17 ,1 ,'2019-10-21 12:44:18'),
(2 ,2 ,2 ,'2020-06-21 22:53:18'),
(3 ,21 ,2 ,'2019-12-01 09:57:19'),
(1 ,3 ,1 ,'2021-03-18 09:58:53'),
(2 ,9 ,4 ,'2022-02-21 01:43:02'),
(3 ,22 ,2 ,'2020-02-16 00:10:48'),
(4 ,29 ,5 ,'2021-04-18 12:30:27'),
(3 ,42 ,5 ,'2019-09-13 17:00:15'),
(1 ,19 ,2 ,'2019-04-17 17:13:06'),
(3 ,49 ,2 ,'2019-06-30 10:40:49'),
(4 ,38 ,1 ,'2021-10-05 16:32:31'),
(2 ,22 ,5 ,'2023-02-08 13:43:42'),
(1 ,34 ,5 ,'2020-02-25 17:51:52'),
(2 ,16 ,5 ,'2022-06-15 14:25:03'),
(1 ,46 ,4 ,'2020-02-12 15:47:38'),
(4 ,4 ,1 ,'2019-09-08 09:52:46'),
(1 ,31 ,5 ,'2019-01-26 12:34:07'),
(4 ,20 ,2 ,'2021-01-05 04:45:36'),
(2 ,20 ,1 ,'2021-04-07 15:44:35'),
(3 ,27 ,2 ,'2022-03-15 20:28:32'),
(4 ,31 ,5 ,'2022-06-13 19:00:41'),
(2 ,27 ,4 ,'2022-08-07 17:57:53'),
(4 ,11 ,3 ,'2020-05-19 05:26:10'),
(3 ,47 ,4 ,'2021-05-17 09:01:21'),
(1 ,17 ,5 ,'2022-09-21 07:22:31'),
(1 ,26 ,2 ,'2022-04-03 11:30:27'),
(4 ,15 ,4 ,'2019-10-19 23:54:13'),
(3 ,24 ,5 ,'2019-05-26 18:49:00'),
(2 ,47 ,2 ,'2022-06-06 21:00:45'),
(1 ,11 ,5 ,'2022-12-31 01:18:08'),
(1 ,13 ,5 ,'2022-10-24 07:34:13'),
(4 ,16 ,5 ,'2021-04-14 04:42:52'),
(4 ,36 ,2 ,'2019-05-14 01:56:28'),
(2 ,34 ,4 ,'2022-05-25 10:08:43'),
(1 ,12 ,1 ,'2019-10-08 08:45:39'),
(3 ,18 ,5 ,'2022-04-12 21:06:28'),
(3 ,15 ,2 ,'2022-07-28 15:10:40'),
(4 ,17 ,4 ,'2021-09-29 03:07:43'),
(3 ,15 ,2 ,'2019-05-04 15:39:54'),
(3 ,24 ,3 ,'2019-01-27 01:45:59'),
(3 ,28 ,4 ,'2021-06-02 05:15:35'),
(1 ,22 ,5 ,'2023-03-16 17:20:47'),
(4 ,11 ,4 ,'2021-01-04 05:47:21'),
(3 ,12 ,3 ,'2019-11-28 11:32:55'),
(1 ,41 ,4 ,'2021-09-18 07:41:53'),
(2 ,29 ,2 ,'2023-01-08 03:45:19'),
(3 ,38 ,5 ,'2021-04-26 05:50:21'),
(2 ,46 ,1 ,'2019-08-13 18:24:30'),
(1 ,10 ,1 ,'2019-09-23 23:09:47'),
(1 ,36 ,3 ,'2021-09-15 00:29:21'),
(2 ,45 ,1 ,'2021-06-30 10:08:05'),
(2 ,38 ,4 ,'2021-07-28 14:05:41'),
(3 ,25 ,4 ,'2021-07-04 20:42:41'),
(4 ,43 ,5 ,'2020-08-09 06:12:03'),
(3 ,4 ,1 ,'2021-12-28 06:12:16'),
(3 ,41 ,5 ,'2021-03-17 22:31:43'),
(3 ,36 ,2 ,'2019-05-17 11:47:20'),
(2 ,25 ,3 ,'2021-03-29 22:15:31'),
(1 ,26 ,3 ,'2021-06-26 00:57:37'),
(1 ,30 ,4 ,'2023-03-20 06:58:05'),
(1 ,17 ,1 ,'2021-12-31 04:15:54'),
(1 ,15 ,1 ,'2019-02-14 15:07:58'),
(1 ,34 ,4 ,'2021-07-24 09:21:15'),
(1 ,36 ,4 ,'2023-02-03 16:07:41'),
(2 ,16 ,4 ,'2021-01-29 03:44:52'),
(4 ,46 ,3 ,'2023-02-07 17:14:46')
GO