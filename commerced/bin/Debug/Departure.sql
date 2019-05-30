USE [competition]
GO

/****** Object:  Table [dbo].[Departure]    Script Date: 06/23/2015 22:29:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Departure](
	[Dep_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[To_country] [varchar](50) NOT NULL,
	[passport_Type] [varchar](50) NOT NULL,
	[passport_No] [varchar](50) NOT NULL,
	[Tax] [varchar](50) NOT NULL,
	[checking] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Date] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departure] PRIMARY KEY CLUSTERED 
(
	[Dep_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


