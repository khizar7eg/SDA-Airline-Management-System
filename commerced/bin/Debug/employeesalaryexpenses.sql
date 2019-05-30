USE [competition]
GO

/****** Object:  Table [dbo].[employeesalaryexpense]    Script Date: 06/23/2015 22:31:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[employeesalaryexpense](
	[employeeid] [int] IDENTITY(1,1) NOT NULL,
	[salaryforthemonth] [varchar](50) NOT NULL,
	[year] [varchar](50) NOT NULL,
	[employeename] [varchar](50) NOT NULL,
	[Job_Title] [varchar](50) NOT NULL,
	[Basicsalary] [varchar](50) NOT NULL,
	[Hrs] [varchar](50) NOT NULL,
	[Extra_money] [varchar](50) NOT NULL,
	[Noleaves] [varchar](50) NOT NULL,
	[salaryDate] [varchar](50) NOT NULL,
	[Gross_salary] [varchar](50) NOT NULL,
	[Net_salary] [varchar](50) NOT NULL,
 CONSTRAINT [PK_employeesalaryexpense] PRIMARY KEY CLUSTERED 
(
	[employeeid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


