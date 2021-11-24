# FlashParkingV2
## SQL Script
#### Create new data base called FlashPark
#### USE [FlashPark]
#### GO

#### /****** Object:  Table [dbo].[LocationDetails]    Script Date: 11/23/2021 6:14:47 PM ******/
#### SET ANSI_NULLS ON
#### GO

#### SET QUOTED_IDENTIFIER ON
#### GO

#### CREATE TABLE [dbo].[LocationDetails](
####	[Id] [int] IDENTITY(1,1) NOT NULL,
####	[LocationId] [int] NOT NULL,
####	[TotalSpots] [int] NOT NULL,
####	[AvailableSpots] [int] NOT NULL,
#### CONSTRAINT [pk_parkinglocationDetails] PRIMARY KEY NONCLUSTERED 
#### (
####	[Id] ASC
#### )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
#### ) ON [PRIMARY]

#### GO

#### ALTER TABLE [dbo].[LocationDetails]  WITH CHECK ADD  CONSTRAINT [FK_LocationDetails] FOREIGN KEY([LocationId])
#### REFERENCES [dbo].[Locations] ([Id])
#### GO

ALTER TABLE [dbo].[LocationDetails] CHECK CONSTRAINT [FK_LocationDetails]
GO




