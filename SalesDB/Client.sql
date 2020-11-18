CREATE TABLE [dbo].[Client](
	[Id] [int] NOT NULL,
	[ClientName] [nvarchar](max) NULL,
	[ClientDescription] [nvarchar](max) NULL,
	[IdContact] [int] NULL,
	[Credit] [money] NULL,
	[Debt] [money] NULL,
	[Birthdate] [datetime] NULL,
	[IdReservedItens] [int] NULL,
	[Activated] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
