USE [competition]
GO

/****** Object:  Table [dbo].[myairport]    Script Date: 06/23/2015 22:32:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[myairport](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Airportname] [varchar](50) NULL,
	[Airportlocation] [varchar](50) NULL,
	[Noemployee] [varchar](50) NULL,
	[Noairplanes] [varchar](50) NULL,
	[Trafic] [varchar](50) NULL,
	[airportmanager] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[Datecreated] [varchar](50) NULL,
 CONSTRAINT [PK_myairport] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


