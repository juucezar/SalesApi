CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CategorieId] INT NULL, 
    [ProductId] INT NULL, 
    [PriceId] INT NULL, 
    [Name] VARCHAR(100) NULL, 
    [Description] VARCHAR(255) NULL, 
    [Reserved] VARCHAR(10) NULL, 
    [Activated] VARCHAR(10) NULL, 
    [DateActivated] DATETIME NULL, 
    [DateDeactivated] DATETIME NULL
)

