USE [competition]
GO

/****** Object:  Table [dbo].[Arivalpeaple]    Script Date: 06/23/2015 22:28:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Arivalpeaple](
	[Ar_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[host_country] [varchar](50) NOT NULL,
	[Purpose] [varchar](50) NOT NULL,
	[Passport_Type] [varchar](50) NOT NULL,
	[passport_No] [varchar](50) NOT NULL,
	[Taxamounts] [varchar](50) NOT NULL,
	[checking] [varchar](50) NOT NULL,
	[Age] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Date] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Arivalpeaple] PRIMARY KEY CLUSTERED 
(
	[Ar_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


