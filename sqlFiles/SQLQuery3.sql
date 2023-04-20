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
VALUES ('Kellogs'),
('General Mills'),
('Nike'),
('Adidas')
GO

--Inserting data into the Category table
USE StockManagementDB;
INSERT INTO [dbo].[Category]
           ([Name]
           )
VALUES ('Cereal'),
('Clothes')
GO

--Inserting data into the LedgerType table
USE StockManagementDB;
INSERT INTO [dbo].[LedgerType]
           ([Name]
           )
VALUES ('Sale'),
('Return'),
('Replenishment'),
('Delivery'),
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
VALUES ('Cornflakes', 1, 1, 100),
('Branflakes', 1, 1, 100),
('ULTRABOOST 5 DNA RUNNING LIFESTYLE SHOES', 2, 4, 100),
('Mens Nike Revolution 6 Black/White Shoe', 2, 3, 100)
GO

--Inserting data into the ItemLedger table
USE StockManagementDB;
INSERT INTO [dbo].ItemLedger
VALUES (2, 1, 100,'2023-04-18')
GO