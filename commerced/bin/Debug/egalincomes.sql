USE [competition]
GO

/****** Object:  Table [dbo].[egalincomes]    Script Date: 06/23/2015 22:30:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[egalincomes](
	[INno] [int] IDENTITY(1,1) NOT NULL,
	[Indescription] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[DATE] [varchar](50) NOT NULL,
	[Amounts] [varchar](50) NOT NULL,
 CONSTRAINT [PK_egalincomes] PRIMARY KEY CLUSTERED 
(
	[INno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


