USE [competition]
GO

/****** Object:  Table [dbo].[EXPORTS]    Script Date: 06/23/2015 22:31:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[EXPORTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[material_Name] [varchar](50) NOT NULL,
	[Owner] [varchar](50) NOT NULL,
	[Tax] [varchar](50) NOT NULL,
	[from_country] [varchar](50) NOT NULL,
	[To_country] [varchar](50) NOT NULL,
	[size] [varchar](50) NOT NULL,
	[weight] [varchar](50) NOT NULL,
	[Date] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EXPORTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


