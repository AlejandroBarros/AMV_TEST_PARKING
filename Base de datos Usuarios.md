# AMV_TEST_PARKING


USE [MyCompany]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/11/2021 8:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [varchar](100) NOT NULL,
	[PasswordUser] [varchar](100) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[Position] [varchar](100) NOT NULL,
	[Email] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([UserID], [LoginName], [PasswordUser], [FirstName], [LastName], [Position], [Email]) VALUES (1, N'admin', N'admin', N'Alejandro', N'Barros', N'Administrator', N'abarrosamoedo@gmail.com')
GO
INSERT [dbo].[Users] ([UserID], [LoginName], [PasswordUser], [FirstName], [LastName], [Position], [Email]) VALUES (2, N'Kat', N'12345', N'Kathrine', N'Smith', N'Accounting', N'KathySmith@MyCompany.com')
GO
INSERT [dbo].[Users] ([UserID], [LoginName], [PasswordUser], [FirstName], [LastName], [Position], [Email]) VALUES (3, N'Ben', N'12345', N'Benjamin', N'Thompson', N'Receptionist', N'BenThompson@MyCompany.com')
GO
INSERT [dbo].[Users] ([UserID], [LoginName], [PasswordUser], [FirstName], [LastName], [Position], [Email]) VALUES (5, N'user', N'user', N'invitado', N'invitado', N'user', N'@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF8DE6530D]    Script Date: 15/11/2021 8:08:46 ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
