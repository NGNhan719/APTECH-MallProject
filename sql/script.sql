USE [malldb]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CommonKey]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommonKey](
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CommonKey] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CreditCard]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CreditCard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardNumber] [varchar](50) NULL,
	[CardOwner] [varchar](50) NULL,
	[CardType] [varchar](50) NULL,
	[ExpiredDate] [datetime] NULL,
	[CVC] [int] NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [text] NULL,
	[Rate] [int] NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Image]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Image](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Thumbnail] [varchar](2048) NULL,
	[CommonKeyId] [int] NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mall]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Address] [varchar](250) NULL,
	[Tel] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Description] [text] NULL,
	[CommonKeyId] [int] NULL,
 CONSTRAINT [PK_Mall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
	[ReleaseDate] [datetime] NULL,
	[RunningTime] [int] NULL,
	[Introduction] [text] NULL,
	[Trailer] [varchar](2083) NULL,
	[Rate] [int] NULL,
	[CommonKeyId] [int] NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ScreenHall]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ScreenHall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScreenName] [varchar](100) NULL,
	[SeatQty] [int] NULL,
	[ServiceProviderId] [int] NULL,
 CONSTRAINT [PK_ScreenHall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Service]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Service](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varbinary](50) NULL,
 CONSTRAINT [PK_ServiceCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServiceProvider]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServiceProvider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Floor] [varchar](10) NULL,
	[Tel] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[Description] [text] NULL,
	[ServiceId] [int] NULL,
	[CommonKeyId] [int] NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShowTime]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShowTime](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[StartHour] [time](0) NULL,
	[EndHour] [time](0) NULL,
	[TotalTicket] [int] NULL,
	[MovieId] [int] NULL,
	[ScreenId] [int] NULL,
 CONSTRAINT [PK_ShowTime] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 24/4/2021 1:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [float] NULL,
	[SeatNo] [int] NULL,
	[ShowTimeId] [int] NULL,
	[CreditCardId] [int] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_CommonKey] FOREIGN KEY([CommonKeyId])
REFERENCES [dbo].[CommonKey] ([Id])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_CommonKey]
GO
ALTER TABLE [dbo].[Mall]  WITH CHECK ADD  CONSTRAINT [FK_Mall_CommonKey] FOREIGN KEY([CommonKeyId])
REFERENCES [dbo].[CommonKey] ([Id])
GO
ALTER TABLE [dbo].[Mall] CHECK CONSTRAINT [FK_Mall_CommonKey]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_CommonKey] FOREIGN KEY([CommonKeyId])
REFERENCES [dbo].[CommonKey] ([Id])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_CommonKey]
GO
ALTER TABLE [dbo].[ScreenHall]  WITH CHECK ADD  CONSTRAINT [FK_ScreenHall_ServiceProvider] FOREIGN KEY([ServiceProviderId])
REFERENCES [dbo].[ServiceProvider] ([Id])
GO
ALTER TABLE [dbo].[ScreenHall] CHECK CONSTRAINT [FK_ScreenHall_ServiceProvider]
GO
ALTER TABLE [dbo].[ServiceProvider]  WITH CHECK ADD  CONSTRAINT [FK_ServiceProvider_CommonKey] FOREIGN KEY([CommonKeyId])
REFERENCES [dbo].[CommonKey] ([Id])
GO
ALTER TABLE [dbo].[ServiceProvider] CHECK CONSTRAINT [FK_ServiceProvider_CommonKey]
GO
ALTER TABLE [dbo].[ServiceProvider]  WITH CHECK ADD  CONSTRAINT [FK_ServiceProvider_Service] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Service] ([Id])
GO
ALTER TABLE [dbo].[ServiceProvider] CHECK CONSTRAINT [FK_ServiceProvider_Service]
GO
ALTER TABLE [dbo].[ShowTime]  WITH CHECK ADD  CONSTRAINT [FK_ShowTime_Movie] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[ShowTime] CHECK CONSTRAINT [FK_ShowTime_Movie]
GO
ALTER TABLE [dbo].[ShowTime]  WITH CHECK ADD  CONSTRAINT [FK_ShowTime_Screen] FOREIGN KEY([ScreenId])
REFERENCES [dbo].[ScreenHall] ([Id])
GO
ALTER TABLE [dbo].[ShowTime] CHECK CONSTRAINT [FK_ShowTime_Screen]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_CreditCard] FOREIGN KEY([CreditCardId])
REFERENCES [dbo].[CreditCard] ([Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_CreditCard]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_ShowTime] FOREIGN KEY([ShowTimeId])
REFERENCES [dbo].[ShowTime] ([Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_ShowTime]
GO
