CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT  IDENTITY (1, 1) NOT NULL, 
    [RecipientName] VARCHAR(100) NOT NULL, 
    [DeliveryStreet] VARCHAR(100) NOT NULL, 
    [DeliveryCity] VARCHAR(50) NULL, 
    [DeliveryState] VARCHAR(50) NULL, 
    [DeliveryPostalCode] VARCHAR(10) NULL, 
    [Phone] VARCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId])
)
