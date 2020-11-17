CREATE TABLE [dbo].[Categorie_TB]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(200) NOT NULL, 
    [Description] NCHAR(255) NULL, 
    [Activated] NCHAR(10) NULL, 
    [DateActivated] DATETIME NULL, 
    [DateDeactivated] DATETIME NULL
)
