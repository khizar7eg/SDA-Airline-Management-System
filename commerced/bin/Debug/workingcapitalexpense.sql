USE [competition]
GO

/****** Object:  Table [dbo].[workingcapitalexpense]    Script Date: 06/23/2015 22:32:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[workingcapitalexpense](
	[EXPNO] [int] IDENTITY(1,1) NOT NULL,
	[EXpensetype] [varchar](50) NOT NULL,
	[DATE] [varchar](50) NOT NULL,
	[AMOUNT] [varchar](50) NOT NULL,
 CONSTRAINT [PK_workingcapitalexpense] PRIMARY KEY CLUSTERED 
(
	[EXPNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


