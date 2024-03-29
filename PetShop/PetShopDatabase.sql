USE [PetShopDatabase]
GO
/****** Object:  Table [dbo].[Classis]    Script Date: 03.12.2018 21:43:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classis](
	[ClassisID] [int] IDENTITY(1,1) NOT NULL,
	[Classis] [nvarchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Species]    Script Date: 03.12.2018 21:43:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Species](
	[SpeciesID] [int] IDENTITY(1,1) NOT NULL,
	[Species] [varchar](64) NOT NULL,
	[Classis] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SpeciesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sex]    Script Date: 03.12.2018 21:43:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sex](
	[SexID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Sex] [nvarchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SexID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 03.12.2018 21:43:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[AnimalID] [int] IDENTITY(1,1) NOT NULL,
	[Classis] [int] NOT NULL,
	[Species] [int] NOT NULL,
	[Sex] [tinyint] NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Weight] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[AnimalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AnimalView]    Script Date: 03.12.2018 21:43:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[AnimalView]
AS
SELECT A.AnimalID, C.Classis , Sp.Species, Se.Sex, A.DateOfBirth, A.Weight
FROM [dbo].[Animal] A
JOIN [dbo].Classis C on A.Classis = C.ClassisID
JOIN [dbo].Species Sp on A.Species = Sp.SpeciesID
JOIN [dbo].Sex Se on A.Sex = Se.SexID
GO
SET IDENTITY_INSERT [dbo].[Animal] ON 

INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (1, 9, 32, 1, CAST(N'2015-03-14' AS Date), 30)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (2, 3, 5, 1, CAST(N'1994-12-10' AS Date), 16)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (3, 1, 3, 1, CAST(N'2009-02-15' AS Date), 4000)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (4, 6, 34, 1, CAST(N'2018-07-17' AS Date), 0.004)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (5, 5, 24, 1, CAST(N'2015-04-02' AS Date), 3)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (6, 5, 22, 1, CAST(N'2017-01-22' AS Date), 0.5)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (7, 1, 9, 2, CAST(N'2013-11-11' AS Date), 80)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (8, 1, 7, 2, CAST(N'2010-08-19' AS Date), 300)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (9, 3, 28, 1, CAST(N'2011-10-02' AS Date), 40)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (10, 3, 28, 2, CAST(N'2011-01-26' AS Date), 50)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (11, 3, 30, 2, CAST(N'2017-11-07' AS Date), 15)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (12, 1, 16, 1, CAST(N'2016-01-12' AS Date), 30)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (13, 1, 16, 1, CAST(N'2012-04-17' AS Date), 50)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (14, 1, 13, 1, CAST(N'2014-02-11' AS Date), 170)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (15, 1, 17, 2, CAST(N'2017-12-16' AS Date), 8)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (16, 1, 17, 2, CAST(N'2017-12-16' AS Date), 7)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (17, 1, 8, 1, CAST(N'2013-07-24' AS Date), 32.5)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (18, 1, 6, 2, CAST(N'2015-07-24' AS Date), 37.5)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (19, 1, 10, 2, CAST(N'2009-03-25' AS Date), 130)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (20, 1, 13, 2, CAST(N'2011-04-28' AS Date), 180)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (21, 1, 2, 2, CAST(N'2009-06-14' AS Date), 330)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (22, 1, 14, 1, CAST(N'2006-12-01' AS Date), 270)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (23, 1, 4, 1, CAST(N'2007-12-11' AS Date), 550)
INSERT [dbo].[Animal] ([AnimalID], [Classis], [Species], [Sex], [DateOfBirth], [Weight]) VALUES (24, 1, 1, 1, CAST(N'2010-10-02' AS Date), 440)
SET IDENTITY_INSERT [dbo].[Animal] OFF
SET IDENTITY_INSERT [dbo].[Classis] ON 

INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (1, N'ssaki')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (2, N'ptaki')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (3, N'gady')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (4, N'płazy')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (5, N'ryby')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (6, N'owady')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (7, N'pajęczaki')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (8, N'skorupiaki')
INSERT [dbo].[Classis] ([ClassisID], [Classis]) VALUES (9, N'głowonogi')
SET IDENTITY_INSERT [dbo].[Classis] OFF
SET IDENTITY_INSERT [dbo].[Sex] ON 

INSERT [dbo].[Sex] ([SexID], [Sex]) VALUES (1, N'samica')
INSERT [dbo].[Sex] ([SexID], [Sex]) VALUES (2, N'samiec')
SET IDENTITY_INSERT [dbo].[Sex] OFF
SET IDENTITY_INSERT [dbo].[Species] ON 

INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (1, N'koń arabski', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (2, N'żyrafa', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (3, N'słoń afrykański', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (4, N'bawół afrykański', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (5, N'żółw błotny', 3)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (6, N'jaguar amerykański', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (7, N'lew afrykański', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (8, N'lampart plamisty', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (9, N'pantera', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (10, N'irbis śnieżny', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (11, N'niedźwiedź grizli', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (12, N'niedźwiedź brunatny', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (13, N'niedźwiedź polarny', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (14, N'niedźwiedź himalajski', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (15, N'niedźwiedź czarny', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (16, N'panda wielka', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (17, N'diabeł tasmański', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (18, N'lampart plamisty', 1)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (19, N'rekin wielorybki', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (20, N'ameka wspaniała', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (21, N'bkara błękitna', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (22, N'barwnik szmaragdowy', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (23, N'bocja szara', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (24, N'bojownik wspaniały', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (25, N'szczupieńczyk karłowaty', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (26, N'Szczupieńczyk karłowaty', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (27, N'pyton królewski', 3)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (28, N'pyton tygrysi', 3)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (29, N'mamba zielona', 3)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (30, N'mamba czarna', 3)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (31, N'zdradnica śmiercionośna', 3)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (32, N'ośmiornica', 9)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (33, N'Helikon trójbarwny', 5)
INSERT [dbo].[Species] ([SpeciesID], [Species], [Classis]) VALUES (34, N'pszczoła miodna', 6)
SET IDENTITY_INSERT [dbo].[Species] OFF
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD FOREIGN KEY([Classis])
REFERENCES [dbo].[Classis] ([ClassisID])
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD FOREIGN KEY([Sex])
REFERENCES [dbo].[Sex] ([SexID])
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD FOREIGN KEY([Species])
REFERENCES [dbo].[Species] ([SpeciesID])
GO
ALTER TABLE [dbo].[Species]  WITH CHECK ADD FOREIGN KEY([Classis])
REFERENCES [dbo].[Classis] ([ClassisID])
GO
