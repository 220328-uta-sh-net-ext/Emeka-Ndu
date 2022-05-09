SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[cname] [nvarchar](100) NULL,
	[cpassword] [nvarchar](100) NULL,
	[aname] [nvarchar](100) NULL,
	[apassword] [nvarchar](100) NULL,
    [restname] [nvarchar](100) NULL,
    [reststreet] [nvarchar](100) NULL,
    [restcity] [nvarchar](100) NULL,
    [restzipcode] [int] NULL,
    [raterest] [int] NULL,
    [reviewrest] [nvarchar](5000) NULL,
	[AccountCreated] [datetime2](7) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (sysutcdatetime()) FOR [AccountCreated]
GO
