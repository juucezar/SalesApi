CREATE TABLE [dbo].[Product_DB]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CategorieId] INT NULL, 
    [ProductId] INT NULL, 
    [PriceId] INT NULL, 
    [Name] NCHAR(100) NULL, 
    [Description] NCHAR(255) NULL, 
    [Reserved] NCHAR(10) NULL, 
    [Activated] NCHAR(10) NULL, 
    [DateActivated] DATETIME NULL, 
    [DateDeactivated] DATETIME NULL
)

