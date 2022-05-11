CREATE TABLE [dbo].[InventoryTbl] (
    [Date]        VARCHAR (50) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [PlateNumber] VARCHAR (50) NOT NULL,
    [MakeAndBody] VARCHAR (50) NOT NULL,
    [Service]     VARCHAR (50) NOT NULL,
    [Sales]       VARCHAR (50) NOT NULL,
    [Staff]       VARCHAR (50) NULL,
    [Streak] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

