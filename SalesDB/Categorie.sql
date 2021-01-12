CREATE TABLE [dbo].[Categorie]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(200) NOT NULL, 
    [Description] VARCHAR(255) NULL, 
    [Activated] VARCHAR(10) NULL, 
    [DateActivated] DATETIME NULL, 
    [DateDeactivated] DATETIME NULL
)
