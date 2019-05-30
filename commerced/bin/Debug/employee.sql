USE [competition]
GO

/****** Object:  Table [dbo].[employee]    Script Date: 06/23/2015 22:30:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
	[address] [varchar](50) NULL,
	[Telephone] [varchar](50) NULL,
	[salary] [money] NULL,
	[job] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[Nationality] [varchar](50) NULL,
	[vilage] [varchar](50) NULL,
	[Datejoined] [varchar](50) NULL,
 CONSTRAINT [PK_formemployee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


