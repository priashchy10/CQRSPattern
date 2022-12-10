USE [CQRSPattern]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/11/2022 12:01:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[email] [varchar](80) NULL,
	[phone] [varchar](15) NULL,
	[address] [varchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [name], [email], [phone], [address]) VALUES (1, N'Priash', N'string', N'string', N'string')
INSERT [dbo].[Users] ([id], [name], [email], [phone], [address]) VALUES (2, N'priash', N'abc@gmail.com', N'0123456789', N'mogbazar')
INSERT [dbo].[Users] ([id], [name], [email], [phone], [address]) VALUES (4, N'test', N'test@gmail.com', N'1254367', N'string')
INSERT [dbo].[Users] ([id], [name], [email], [phone], [address]) VALUES (5, N'adi', N'adi@gmail.com', N'123456', N'abcd')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
