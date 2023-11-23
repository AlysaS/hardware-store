USE [master]
GO
/****** Object:  Database [Mcon368storeDB]    Script Date: 5/28/2023 11:19:08 PM ******/
CREATE DATABASE [Mcon368storeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mcon368storeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Mcon368storeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mcon368storeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Mcon368storeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Mcon368storeDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mcon368storeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mcon368storeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Mcon368storeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mcon368storeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mcon368storeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Mcon368storeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mcon368storeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Mcon368storeDB] SET  MULTI_USER 
GO
ALTER DATABASE [Mcon368storeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mcon368storeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mcon368storeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mcon368storeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mcon368storeDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Mcon368storeDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Mcon368storeDB] SET QUERY_STORE = OFF
GO
USE [Mcon368storeDB]
GO
/****** Object:  Table [dbo].[account]    Script Date: 5/28/2023 11:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[accountID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](25) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[fName] [varchar](20) NOT NULL,
	[lName] [varchar](30) NOT NULL,
	[balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item]    Script Date: 5/28/2023 11:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[itemID] [int] IDENTITY(1,1) NOT NULL,
	[itemName] [varchar](45) NOT NULL,
	[price] [decimal](8, 2) NOT NULL,
	[details] [varchar](100) NOT NULL,
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase]    Script Date: 5/28/2023 11:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchase](
	[purchaseID] [int] IDENTITY(1,1) NOT NULL,
	[accountID] [int] NOT NULL,
	[itemID] [int] NOT NULL,
	[totalPrice] [decimal](8, 2) NOT NULL,
	[purchasedDate] [date] NOT NULL,
	[qty] [int] NOT NULL,
 CONSTRAINT [PK_purchase] PRIMARY KEY CLUSTERED 
(
	[purchaseID] ASC,
	[accountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 
GO
INSERT [dbo].[account] ([accountID], [userName], [password], [fName], [lName], [balance]) VALUES (1, N'user1', N'pass123', N'Sam', N'Ross', CAST(333.76 AS Decimal(8, 2)))
GO
INSERT [dbo].[account] ([accountID], [userName], [password], [fName], [lName], [balance]) VALUES (2, N'user2', N'password', N'Bob', N'Fan', CAST(0.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[account] ([accountID], [userName], [password], [fName], [lName], [balance]) VALUES (3, N'user3', N'1234', N'Lea', N'Star', CAST(643.70 AS Decimal(8, 2)))
GO
INSERT [dbo].[account] ([accountID], [userName], [password], [fName], [lName], [balance]) VALUES (4, N'user4', N'9876', N'Stacy', N'Kar', CAST(0.00 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[account] OFF
GO
SET IDENTITY_INSERT [dbo].[item] ON 
GO
INSERT [dbo].[item] ([itemID], [itemName], [price], [details]) VALUES (2, N'Washer', CAST(100.00 AS Decimal(8, 2)), N'made in the US')
GO
INSERT [dbo].[item] ([itemID], [itemName], [price], [details]) VALUES (3, N'Dryer', CAST(120.80 AS Decimal(8, 2)), N'made in the US')
GO
INSERT [dbo].[item] ([itemID], [itemName], [price], [details]) VALUES (4, N'Screw Driver', CAST(10.00 AS Decimal(8, 2)), N'stainless steel')
GO
INSERT [dbo].[item] ([itemID], [itemName], [price], [details]) VALUES (5, N'Sink', CAST(100.50 AS Decimal(8, 2)), N'made in Europe')
GO
SET IDENTITY_INSERT [dbo].[item] OFF
GO
SET IDENTITY_INSERT [dbo].[purchase] ON 
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (1, 1, 2, CAST(300.00 AS Decimal(8, 2)), CAST(N'2023-05-26' AS Date), 3)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (2, 1, 4, CAST(20.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 2)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (3, 1, 5, CAST(201.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 2)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (4, 1, 5, CAST(100.50 AS Decimal(8, 2)), CAST(N'2023-06-01' AS Date), 1)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (5, 2, 2, CAST(200.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 2)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (6, 2, 5, CAST(402.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 4)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (7, 2, 3, CAST(120.80 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 1)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (8, 3, 2, CAST(200.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 2)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (9, 3, 3, CAST(241.60 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 2)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (10, 3, 5, CAST(100.50 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 1)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (11, 3, 4, CAST(50.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 5)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (12, 3, 4, CAST(20.00 AS Decimal(8, 2)), CAST(N'2023-06-01' AS Date), 2)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (13, 1, 5, CAST(301.50 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 3)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (14, 1, 3, CAST(120.80 AS Decimal(8, 2)), CAST(N'2023-06-01' AS Date), 1)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (15, 3, 4, CAST(10.00 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 1)
GO
INSERT [dbo].[purchase] ([purchaseID], [accountID], [itemID], [totalPrice], [purchasedDate], [qty]) VALUES (16, 3, 3, CAST(241.60 AS Decimal(8, 2)), CAST(N'2023-05-28' AS Date), 2)
GO
SET IDENTITY_INSERT [dbo].[purchase] OFF
GO
ALTER TABLE [dbo].[purchase] ADD  CONSTRAINT [DF_purchase_purchasedDate]  DEFAULT (getdate()) FOR [purchasedDate]
GO
ALTER TABLE [dbo].[purchase]  WITH CHECK ADD  CONSTRAINT [FK_purchase_account] FOREIGN KEY([accountID])
REFERENCES [dbo].[account] ([accountID])
GO
ALTER TABLE [dbo].[purchase] CHECK CONSTRAINT [FK_purchase_account]
GO
ALTER TABLE [dbo].[purchase]  WITH CHECK ADD  CONSTRAINT [FK_purchase_item] FOREIGN KEY([itemID])
REFERENCES [dbo].[item] ([itemID])
GO
ALTER TABLE [dbo].[purchase] CHECK CONSTRAINT [FK_purchase_item]
GO
ALTER TABLE [dbo].[purchase]  WITH CHECK ADD  CONSTRAINT [ck_qty] CHECK  (([qty]>=(1)))
GO
ALTER TABLE [dbo].[purchase] CHECK CONSTRAINT [ck_qty]
GO
USE [master]
GO
ALTER DATABASE [Mcon368storeDB] SET  READ_WRITE 
GO
