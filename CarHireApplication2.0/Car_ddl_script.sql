/*
 * Developer: Claudio Ferreira
 * Completed: 23/04/2018
 * 
 */

/*
 * Manually create the database 'CarRental'
 * Then execute this query
 */

USE [CarRental]
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[bookingID] [int] IDENTITY(0,1) NOT NULL,
	[CustomerNo] [int] NOT NULL,
    [EmpID] [int] NOT NULL,
	[vin] [nvarchar](17) NOT NULL,
	[pickupDate] [date] NOT NULL,
	[pickupTime] [time](7) NOT NULL,
	[returnDate] [date] NOT NULL,
	[returnTime] [time](7) NOT NULL,
	[observationsOutbound] [nvarchar](100) NULL,
	[observationsInbound] [nvarchar](100) NULL,
	[totalCost] [money] NOT NULL,
    [odoReadingOutbound] [nvarchar](10) NULL,
	[odoReadingInbound] [nvarchar](10) NULL,        
 CONSTRAINT [PK__Bookings] PRIMARY KEY CLUSTERED 
(
	[bookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 8/03/2018 6:03:24 PM ******/
SET ANSI_NULLS ON

GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerNo] [int] IDENTITY(0,1) NOT NULL,
	[firstName] [nvarchar](20) NOT NULL,
	[lastName] [nvarchar](20) NOT NULL,
	[address] [nvarchar](30) NOT NULL,
	[city] [nvarchar](15) NOT NULL,
	[postCode] [nvarchar](5) NOT NULL,
	[state] [nvarchar](5) NOT NULL,
	[country] [nvarchar](15) NOT NULL,
	[mobileNo] [nvarchar](15) NOT NULL,
	[driverLicenseNo] [nvarchar](10) NOT NULL,
	[paymentCardNo] [nvarchar](20) NOT NULL,
	[creditCardType] [nvarchar](10) NOT NULL,
    	[cardExpDate] [date] NOT NULL,
	[nameOnCard] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 8/03/2018 6:03:24 PM ******/
SET ANSI_NULLS ON

GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](30) NOT NULL,
	[lastName] [nvarchar](30) NOT NULL,
	[mobileNo] [int] NOT NULL,
	[address] [nvarchar](60) NOT NULL,
	[city] [nvarchar](30) NOT NULL,
	[state] [nvarchar](15) NOT NULL,
	[postCode] [int] NOT NULL,
	[homePh] [int] NOT NULL,
	[driverLicenceNo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 8/03/2018 6:03:24 PM ******/
SET ANSI_NULLS ON

GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[vinNo] [nvarchar](17) NOT NULL,
	[make] [nvarchar](20) NOT NULL,
	[model] [nvarchar](20) NOT NULL,
	[colour] [nvarchar](20) NOT NULL,
	[transType] [nvarchar](10) NOT NULL,
	[odometer] [nvarchar](10) NOT NULL,
	[fuelType] [nvarchar](10) NOT NULL,
	[regoNo] [nvarchar](10) NOT NULL,
	[regoExpiry] [date] NOT NULL,
	[dailyRate] [money] NOT NULL,
	[hourlyRate] [money] NOT NULL,
	[bodyType] [nvarchar](10) NOT NULL,
	[accumulatedObsvs] [nvarchar](3000) NOT NULL,		
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[vinNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleServices]    Script Date: 8/03/2018 6:03:24 PM ******/
SET ANSI_NULLS ON

GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleServices](
	[serviceID] [int] IDENTITY(0,1) NOT NULL,
	[vin] [nvarchar](17) NOT NULL,
	[odometer] [nvarchar](8) NOT NULL,
	[serviceDate] [date] NOT NULL,
	[serviceTime] [time](7) NOT NULL,
	[serviceDetails] [nvarchar](100) NOT NULL,
	[serviceType] [nvarchar](100) NOT NULL,
	[serviceCost] [money] NOT NULL,
 CONSTRAINT [PK_VehicleServices] PRIMARY KEY CLUSTERED 
(
	[serviceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([bookingID], [EmpID], [CustomerNo], [vin], [pickupDate], [pickupTime], [returnDate], [returnTime], [observationsOutbound], [observationsInbound], [totalCost], [OdoReadingOutbound], [OdoReadingInbound]) 
	VALUES (0, 1, N'0', N'18523485697185325', CAST(N'2018-05-09' AS Date), CAST(N'14:45:00' AS Time), CAST(N'2018-05-16' AS Date), CAST(N'16:30:00' AS Time), N'', NULL, 1344.0000, 42913, 43821)
INSERT [dbo].[Bookings] ([bookingID], [EmpID], [CustomerNo], [vin], [pickupDate], [pickupTime], [returnDate], [returnTime], [observationsOutbound], [observationsInbound], [totalCost], [OdoReadingOutbound], [OdoReadingInbound]) 
	VALUES (1, 2, N'3', N'35248256915328751', CAST(N'2018-05-21' AS Date), CAST(N'12:30:00' AS Time), CAST(N'2018-05-25' AS Date), CAST(N'15:00:00' AS Time), N'', NULL, 240.0000, 30000, 32000)
INSERT [dbo].[Bookings] ([bookingID], [EmpID], [CustomerNo], [vin], [pickupDate], [pickupTime], [returnDate], [returnTime], [observationsOutbound], [observationsInbound], [totalCost], [OdoReadingOutbound], [OdoReadingInbound]) 
	VALUES (2, 3, N'4', N'35248256915328751', CAST(N'2019-07-03' AS Date), CAST(N'12:30:00' AS Time), CAST(N'2019-07-10' AS Date), CAST(N'10:00:00' AS Time), N'', NULL, 600.0000, 158000, 160000)
INSERT [dbo].[Bookings] ([bookingID], [EmpID], [CustomerNo], [vin], [pickupDate], [pickupTime], [returnDate], [returnTime], [observationsOutbound], [observationsInbound], [totalCost], [OdoReadingOutbound], [OdoReadingInbound]) 
	VALUES (3, 2, N'1', N'18547524596317582', CAST(N'2019-10-12' AS Date), CAST(N'10:00:00' AS Time), CAST(N'2019-10-26' AS Date), CAST(N'12:30:00' AS Time), N'', NULL, 1344.0000, 199000, 203000)
SET IDENTITY_INSERT [dbo].[Bookings] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerNo], [firstName], [lastName], [address], [city], [postCode], [state], [country], [mobileNo], [driverLicenseNo], [paymentCardNo], [creditCardType], [cardExpDate], [nameOnCard])
	VALUES (0, N'Jonathan', N'Zempt', N'12 Zeplin Road', N'Wangara', N'5489', N'WA', N'Australia', N'0435816825', N'7256419', N'1524652154896526', 'Visa', CAST(N'2020-05-25' AS Date), 'J Zempt')
INSERT [dbo].[Customers] ([CustomerNo], [firstName], [lastName], [address], [city], [postCode], [state], [country], [mobileNo], [driverLicenseNo], [paymentCardNo], [creditCardType], [cardExpDate], [nameOnCard]) 
	VALUES (1, N'Maxwell', N'Brent', N'81 Biggs Street', N'Rockingham', N'5136', N'WA', N'Australia', N'0438546279', N'4753185', N'4851245697852157', 'Visa', CAST(N'2019-03-18' AS Date), 'M Brent')
INSERT [dbo].[Customers] ([CustomerNo], [firstName], [lastName], [address], [city], [postCode], [state], [country], [mobileNo], [driverLicenseNo], [paymentCardNo], [creditCardType], [cardExpDate], [nameOnCard]) 
	VALUES (2, N'Coops', N'Crosswell', N'52 Pathway Lane', N'Two Rocks', N'9135', N'WA', N'Australia', N'0434851275', N'4512895', N'1289756482579536', 'Mastercard', CAST(N'2021-05-07' AS Date), 'C Crosswell')
INSERT [dbo].[Customers] ([CustomerNo], [firstName], [lastName], [address], [city], [postCode], [state], [country], [mobileNo], [driverLicenseNo], [paymentCardNo], [creditCardType], [cardExpDate], [nameOnCard]) 
	VALUES (3, N'Zooki', N'Sue', N'109 Beachside Drive', N'Mullaloo', N'5174', N'WA', N'Australia', N'0439524817', N'3527482', N'1479538256751498', 'Amex', CAST(N'2020-09-25' AS Date), 'Z Sue')
INSERT [dbo].[Customers] ([CustomerNo], [firstName], [lastName], [address], [city], [postCode], [state], [country], [mobileNo], [driverLicenseNo], [paymentCardNo], [creditCardType], [cardExpDate], [nameOnCard]) 
	VALUES (4, N'Clarence', N'Spacey', N'846 Moonlanding Parade', N'Northam', N'6589', N'WA', N'Australia', N'0431352483', N'4892517', N'1479538785641498', 'Mastercard', CAST(N'2022-02-13' AS Date), 'C Spacey')
SET IDENTITY_INSERT [dbo].[Customers] OFF

INSERT [dbo].[Vehicles] ([vinNo], [make], [model], [colour], [transType], [odometer], [fuelType], [regoNo], [regoExpiry], [dailyRate], [hourlyRate], [bodyType], [accumulatedObsvs]) 
	VALUES (N'18523485697185325', N'Holden', N'Malloo', N'Blue', N'Manual', N'123,000', N'Petrol', N'1gun523', CAST(N'2019-05-17' AS Date), 192.0000, 8.0000, N'Ute', 'Brakes squeak, small dent on rear bumper')
INSERT [dbo].[Vehicles] ([vinNo], [make], [model], [colour], [transType], [odometer], [fuelType], [regoNo], [regoExpiry], [dailyRate], [hourlyRate], [bodyType], [accumulatedObsvs]) 
	VALUES (N'18547524596317582', N'Nissan', N'Pathfinder', N'Grey', N'Auto', N'197,000', N'Diesel', N'1ibh154', CAST(N'2019-08-07' AS Date), 96.0000, 4.0000, N'SUV', 'Window chip on windscreen, small scratch on right rear bumper')
INSERT [dbo].[Vehicles] ([vinNo], [make], [model], [colour], [transType], [odometer], [fuelType], [regoNo], [regoExpiry], [dailyRate], [hourlyRate], [bodyType], [accumulatedObsvs]) 
	VALUES (N'35248256915328751', N'Hyandai', N'i30', N'Green', N'Auto', N'98,000', N'Petrol', N'1bcd154', CAST(N'2020-10-28' AS Date), 60.0000, 2.5000, N'Hatch', 'Cracked front passenger fog light')

INSERT INTO [dbo].[Employees] ([firstName], [lastName], [mobileNo], [address], [city], [state], [postCode], [homePh], [driverLicenceNo])
	VALUES('Luke','Hodge','0432589751','32 Road Somewhere','Blue Beach','QLD','1568','0432589751','1865237')
INSERT INTO [dbo].[Employees] ([firstName], [lastName], [mobileNo], [address], [city], [state], [postCode], [homePh], [driverLicenceNo])
	VALUES('Joan','Gams','449359751','85 Black Top Place','Wongorup','SYD','8546','449359751','9876824')
INSERT INTO [dbo].[Employees] ([firstName], [lastName], [mobileNo], [address], [city], [state], [postCode], [homePh], [driverLicenceNo])
	VALUES('Finny','Lumbard','439865249','185 Barnyard Blitz ','Joondana','NT','3846','439865249','1687954')

USE [master]
GO
ALTER DATABASE [CarRental] SET  READ_WRITE 
GO
