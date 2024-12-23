USE [Db TıcarıOtomasyon]
GO
/****** Object:  Table [dbo].[Tbl1]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl1](
	[Toplam] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLADMIN]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLADMIN](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[KULLANICIAD] [varchar](10) NULL,
	[SIFRE] [varchar](10) NULL,
 CONSTRAINT [PK_TBLADMIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLARACLAR]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLARACLAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](50) NULL,
 CONSTRAINT [PK_TBLARACLAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLARIZADETAY]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLARIZADETAY](
	[ARIZAID] [int] IDENTITY(1,1) NOT NULL,
	[ISLEM] [int] NULL,
	[SORUN] [varchar](250) NULL,
	[ACIKLAMA] [varchar](250) NULL,
	[ONFIYAT] [decimal](18, 2) NULL,
	[NETFIYAT] [decimal](18, 2) NULL,
	[ISLEMLER] [varchar](500) NULL,
 CONSTRAINT [PK_TBLARIZADETAY] PRIMARY KEY CLUSTERED 
(
	[ARIZAID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLCARI]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCARI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](30) NULL,
	[SOYAD] [varchar](30) NULL,
	[TELEFON] [varchar](20) NULL,
	[MAIL] [varchar](50) NULL,
	[IL] [varchar](13) NULL,
	[ILCE] [varchar](13) NULL,
	[BANKA] [varchar](50) NULL,
	[VERGIDAIRESI] [varchar](50) NULL,
	[VERGINO] [varchar](50) NULL,
	[STATU] [varchar](10) NULL,
	[ADRES] [varchar](250) NULL,
 CONSTRAINT [PK_TBLCARI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLDEPARTMAN]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLDEPARTMAN](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](50) NULL,
	[ACIKLAMA] [varchar](100) NULL,
 CONSTRAINT [PK_TBLDEPARTMAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLFATURABILGI]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLFATURABILGI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SERI] [char](1) NULL,
	[SIRANO] [varchar](6) NULL,
	[TARIH] [smalldatetime] NULL,
	[SAAT] [char](5) NULL,
	[VERGIDAIRE] [varchar](50) NULL,
	[CARI] [int] NULL,
	[PERSONEL] [smallint] NULL,
 CONSTRAINT [PK_TBLFATURABILGI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLFATURADETAY]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLFATURADETAY](
	[FATURADETAYID] [int] IDENTITY(1,1) NOT NULL,
	[URUN] [varchar](50) NULL,
	[ADET] [smallint] NULL,
	[FIYAT] [decimal](18, 2) NULL,
	[TUTAR] [decimal](18, 2) NULL,
	[FATURAID] [int] NULL,
 CONSTRAINT [PK_TBLFATURADETAY] PRIMARY KEY CLUSTERED 
(
	[FATURADETAYID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLGIDER]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLGIDER](
	[GIDERID] [int] IDENTITY(1,1) NOT NULL,
	[GIDERACIKLAMA] [varchar](50) NULL,
	[TARIH] [smalldatetime] NULL,
	[TUTAR] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TBLGIDER] PRIMARY KEY CLUSTERED 
(
	[GIDERID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLHAKKIMIZDA]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLHAKKIMIZDA](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[METIN] [varchar](1000) NULL,
 CONSTRAINT [PK_TBLHAKKIMIZDA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLILCELER]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLILCELER](
	[id] [int] NOT NULL,
	[ilce] [nvarchar](255) NULL,
	[sehir] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ilceler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLILETISIM]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLILETISIM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADSOYAD] [varchar](50) NULL,
	[MAIL] [varchar](50) NULL,
	[KONU] [varchar](50) NULL,
	[MESAJ] [varchar](500) NULL,
 CONSTRAINT [PK_TBLILETISIM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLILLER]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLILLER](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sehir] [nvarchar](255) NULL,
 CONSTRAINT [PK_iller] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLKATEGORI]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLKATEGORI](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](50) NULL,
 CONSTRAINT [PK_TBLKATEGORI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLNOTLARIM]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLNOTLARIM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BASLIK] [varchar](50) NULL,
	[ICERIK] [varchar](500) NULL,
	[DURUM] [bit] NULL,
	[TARIH] [smalldatetime] NULL,
 CONSTRAINT [PK_TBLNOTLARIM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLPERSONEL]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLPERSONEL](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](30) NULL,
	[SOYAD] [varchar](30) NULL,
	[DEPARTMAN] [tinyint] NULL,
	[FOTOĞRAF] [varchar](100) NULL,
	[MAIL] [varchar](30) NULL,
	[TELEFON] [varchar](20) NULL,
 CONSTRAINT [PK_TBLPERSONEL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLURUN]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLURUN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](30) NULL,
	[MARKA] [varchar](30) NULL,
	[ALISFIYAT] [decimal](18, 2) NULL,
	[SATISFIYAT] [decimal](18, 2) NULL,
	[STOK] [smallint] NULL,
	[KATEGORI] [tinyint] NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_TBLURUN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLURUNHAREKET]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLURUNHAREKET](
	[HARAKET] [int] IDENTITY(1,1) NOT NULL,
	[URUN] [int] NULL,
	[MUSTERI] [int] NULL,
	[PERSONEL] [smallint] NULL,
	[TARIH] [smalldatetime] NULL,
	[ADET] [smallint] NULL,
	[FIYAT] [decimal](18, 2) NULL,
	[URUNSERINO] [char](5) NULL,
 CONSTRAINT [PK_TBLURUNHAREKET] PRIMARY KEY CLUSTERED 
(
	[HARAKET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLURUNKABUL]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLURUNKABUL](
	[ISLEMID] [int] IDENTITY(1,1) NOT NULL,
	[CARI] [int] NULL,
	[PERSONEL] [smallint] NULL,
	[GELISTARIH] [smalldatetime] NULL,
	[CIKISTARIHI] [smalldatetime] NULL,
	[URUNSERINO] [char](5) NULL,
	[URUNDURUM] [bit] NULL,
	[URUNDURUMDETAY] [varchar](30) NULL,
 CONSTRAINT [PK_TBLURUNKABUL] PRIMARY KEY CLUSTERED 
(
	[ISLEMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLURUNTAKIP]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLURUNTAKIP](
	[TAKIPID] [int] IDENTITY(1,1) NOT NULL,
	[ACIKLAMA] [varchar](250) NULL,
	[TARIH] [smalldatetime] NULL,
	[SERINO] [nchar](5) NULL,
 CONSTRAINT [PK_TBLURUNTAKIP] PRIMARY KEY CLUSTERED 
(
	[TAKIPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YETKİLENDİRME]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YETKİLENDİRME](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
	[YetkiKategori] [int] NULL,
 CONSTRAINT [PK_YETKİLENDİRME] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Tbl1] ([Toplam]) VALUES (26)
GO
SET IDENTITY_INSERT [dbo].[TBLADMIN] ON 

INSERT [dbo].[TBLADMIN] ([ID], [KULLANICIAD], [SIFRE]) VALUES (1, N'admin', N'1234')
INSERT [dbo].[TBLADMIN] ([ID], [KULLANICIAD], [SIFRE]) VALUES (2, N'ticoto', N'ticoto55')
SET IDENTITY_INSERT [dbo].[TBLADMIN] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLARACLAR] ON 

INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (1, N'Ribbon Control')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (2, N'Bar Button')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (3, N'Gridview')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (4, N'Group Control')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (5, N'Picture Edit')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (6, N'Simple Button')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (7, N'Text Edit')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (8, N'Look Up Edit')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (9, N'Label Control')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (10, N'Chart Control')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (11, N'Panel Control')
INSERT [dbo].[TBLARACLAR] ([ID], [AD]) VALUES (12, N'XtraMdi')
SET IDENTITY_INSERT [dbo].[TBLARACLAR] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLCARI] ON 

INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (1, N'ALI', N'YILDIRIM', N'(534) 216-5464', N'deneme@gamil.com', N'ANKARA', N'MAMAK', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (2, N'AYSE', N'CINAR', N'(532) 654-9879', N'deneme@outlook.com', N'ANKARA ', N'KIZILAY', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (3, N'EMEL', N'KAYA', N'(532) 165-4985', N'deneme@hotmail.com', N'ISTANBUL', N'SISLI', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (4, N'MEHMET', N'GUNES', N'(532) 165-4985', N'deneme1@gmail.com', N'ISTANBUL ', N'BAKIRKOY', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (5, N'MEHMET', N'YILMAZ', N'(532) 165-4985', N'deneme1@hotmail.com', N'ISTANBUL', N'BAKIRKOY', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (6, N'HAKAN', N'OZTURK', N'(532) 165-4985', N'deneme1@outlook.com', N'ADANA', N'SEYHAN', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (7, N'ZEYNEP', N'KARA', N'(532) 165-4985', N'deneme2@gmail.com', N'BURSA', N'GEMLIK', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (8, N'SALIH', N'YILDIZ', N'(532) 165-4985', N'deneme2@hotmail.com', N'TRABZON', N'OF', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (9, N'AYLIN', N'OZTURK', N'(532) 165-4985', N'deneme2@outlook.com', N'AYDIN', N'NAZILLI', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (10, N'ZEHRA', N'BEYAZLI', N'(532) 165-4985', N'deneme3@gmail.com', N'IZMIR', N'BUCA', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (13, N'MEHMET', N'MENKESE', N'(532) 165-4985', N'deneme4@gmail.com', N'GAZIANTEP', N'SAHINBEY', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (14, N'ELIF', N'YILDIRIM', N'(532) 165-4985', N'deneme4@hotmail.com', N'ELAZIG', N'MERKEZ', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (15, N'EYLUL ', N'SARI', N'(532) 165-4985', N'deneme4@outlook.com', N'ANKARA', N'YETIMHANE', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (16, N'TURGAY', N'KARAHASAN', N'(532) 165-4985', N'deneme5@gmail.com', N'ADANA', N'YUREGIR', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (17, N'ELIF', N'DINC', N'(532) 165-4985', N'deneme5@hotmail.com', N'ANTALYA', N'ELMALI', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (18, N'CÜNEYIT', N'KIRGIZ', N'(532) 165-4985', N'deneme6@gmail.com', N'ANKARA', N'YENIMAHALLE', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (20, N'EMIRCAN', N'ALTAY', N'(532) 165-4985', N'deneme5@hotmail.com', N'HATAY', N'DÖRTYOL', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (21, N'SERHAT', N'ZUNLUOGLU', N'(532) 165-4985', N'deneme5@hotmail.com', N'ISTANBUL', N'MALTEPE', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (24, N'ERDEM', N'ÜSTÜNTAY', N'(532) 165-4985', N'deneme5@hotmail.com', N'KARABÜK', N'YENÝCE', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (25, N'SEMA', N'ERMIN', N'(532) 618-4984', N'semaermin@gmail.com', N'ISTANBUL', N'ADALAR', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLCARI] ([ID], [AD], [SOYAD], [TELEFON], [MAIL], [IL], [ILCE], [BANKA], [VERGIDAIRESI], [VERGINO], [STATU], [ADRES]) VALUES (27, N'CAVIT', N'YILDIRIM', N'(538) 585-6911', N'cavit@gmail.com', N'SAMSUN', N'BAFRA', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TBLCARI] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLDEPARTMAN] ON 

INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (1, N'DENEME2', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (2, N'GUVENLIK', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (3, N'SEKRETER', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (4, N'SATIN ALMA', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (5, N'MUSTERI ILISKILERI', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (6, N'MUDUR', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (7, N'STAJYER', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (8, N'PAZARLAMA', N'E')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (10, N'SATIS MÜDÜRÜ', NULL)
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (12, N'SERVIS', N'asdsad')
INSERT [dbo].[TBLDEPARTMAN] ([ID], [AD], [ACIKLAMA]) VALUES (13, N'ALIM MÜDÜRÜ', N'WQEQWE')
SET IDENTITY_INSERT [dbo].[TBLDEPARTMAN] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLFATURABILGI] ON 

INSERT [dbo].[TBLFATURABILGI] ([ID], [SERI], [SIRANO], [TARIH], [SAAT], [VERGIDAIRE], [CARI], [PERSONEL]) VALUES (13, N'A', N'100000', CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'16:30', N'SISLI', 1, 1)
INSERT [dbo].[TBLFATURABILGI] ([ID], [SERI], [SIRANO], [TARIH], [SAAT], [VERGIDAIRE], [CARI], [PERSONEL]) VALUES (14, N'B', N'100001', CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'19:30', N'MALTEPE', 1, 1)
INSERT [dbo].[TBLFATURABILGI] ([ID], [SERI], [SIRANO], [TARIH], [SAAT], [VERGIDAIRE], [CARI], [PERSONEL]) VALUES (15, N'A', N'100102', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'18:40', N'KADIKÖY', 2, 2)
INSERT [dbo].[TBLFATURABILGI] ([ID], [SERI], [SIRANO], [TARIH], [SAAT], [VERGIDAIRE], [CARI], [PERSONEL]) VALUES (20, N'B', N'100007', CAST(N'2024-03-14T00:00:00' AS SmallDateTime), N'14:30', N'ASDASD', 6, 7)
INSERT [dbo].[TBLFATURABILGI] ([ID], [SERI], [SIRANO], [TARIH], [SAAT], [VERGIDAIRE], [CARI], [PERSONEL]) VALUES (22, N'A', N'100202', CAST(N'2024-04-28T00:00:00' AS SmallDateTime), N'14:32', N'KADIKÖY', 1, 1)
INSERT [dbo].[TBLFATURABILGI] ([ID], [SERI], [SIRANO], [TARIH], [SAAT], [VERGIDAIRE], [CARI], [PERSONEL]) VALUES (23, N'B', N'100203', CAST(N'2024-05-10T00:00:00' AS SmallDateTime), N'17:00', N'URLA', 8, 3)
SET IDENTITY_INSERT [dbo].[TBLFATURABILGI] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLFATURADETAY] ON 

INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (11, N'SU ISITICI', 1, CAST(40.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 13)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (12, N'FOTOGRAF MAKINESI', 1, CAST(1800.00 AS Decimal(18, 2)), CAST(1800.00 AS Decimal(18, 2)), 14)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (13, N'LAPTOP', 1, CAST(15000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (14, N'BUZDOLABI', 1, CAST(9000.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (15, N'BULASIK MAKINESI', 1, CAST(8500.00 AS Decimal(18, 2)), CAST(8500.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (16, N'FIRIN', 1, CAST(5000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (17, N'KULAKLIK', 1, CAST(4000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (20, N'KULAKLIK', 1, CAST(4000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), 14)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (21, N'LAPTOP', 1, CAST(20000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)), 13)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (25, N'FIRIN', 100, CAST(360.00 AS Decimal(18, 2)), CAST(36000.00 AS Decimal(18, 2)), 22)
INSERT [dbo].[TBLFATURADETAY] ([FATURADETAYID], [URUN], [ADET], [FIYAT], [TUTAR], [FATURAID]) VALUES (27, N'BILGISAYAR', 5, CAST(100000.00 AS Decimal(18, 2)), CAST(120000.00 AS Decimal(18, 2)), 23)
SET IDENTITY_INSERT [dbo].[TBLFATURADETAY] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLHAKKIMIZDA] ON 

INSERT [dbo].[TBLHAKKIMIZDA] ([ID], [METIN]) VALUES (1, N'Bu proje Aralik 2024 tarihinde baslayip Nisan 2024 tarihinde bitirilmistir.Platform olarak aspnet web form,master page,tasarim kisminda bootstrap, Html5 ve Css eklentileri kullanilmistir.Projenin masaüstü noktasinda C# form,devexpress ve modern ui araçlari kullanildi.Projede ürün satisi,ürün takibi ve arizali ürün islemleri gerçeklestirilmektedir.')
SET IDENTITY_INSERT [dbo].[TBLHAKKIMIZDA] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLILCELER] ON 

INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (1, N'SEYHAN', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (2, N'CEYHAN', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (3, N'FEKE', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (4, N'KARAÝSALI', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (5, N'KARATAÞ', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (6, N'KOZAN', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (7, N'POZANTI', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (8, N'SAÝMBEYLÝ', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (9, N'TUFANBEYLÝ', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (10, N'YUMURTALIK', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (11, N'YÜREÐÝR', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (12, N'ALADAÐ', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (13, N'ÝMAMOÐLU', 1)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (14, N'ADIYAMAN MERKEZ', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (15, N'BESNÝ', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (16, N'ÇELÝKHAN', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (17, N'GERGER', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (18, N'GÖLBAÞI', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (19, N'KAHTA', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (20, N'SAMSAT', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (21, N'SÝNCÝK', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (22, N'TUT', 2)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (23, N'AFYONMERKEZ', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (24, N'BOLVADÝN', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (25, N'ÇAY', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (26, N'DAZKIRI', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (27, N'DÝNAR', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (28, N'EMÝRDAÐ', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (29, N'ÝHSANÝYE', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (30, N'SANDIKLI', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (31, N'SÝNANPAÞA', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (32, N'SULDANDAÐI', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (33, N'ÞUHUT', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (34, N'BAÞMAKÇI', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (35, N'BAYAT', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (36, N'ÝÞCEHÝSAR', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (37, N'ÇOBANLAR', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (38, N'EVCÝLER', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (39, N'HOCALAR', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (40, N'KIZILÖREN', 3)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (41, N'AKSARAY MERKEZ', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (42, N'ORTAKÖY', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (43, N'AÐAÇÖREN', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (44, N'GÜZELYURT', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (45, N'SARIYAHÞÝ', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (46, N'ESKÝL', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (47, N'GÜLAÐAÇ', 68)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (48, N'AMASYA MERKEZ', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (49, N'GÖYNÜÇEK', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (50, N'GÜMÜÞHACIKÖYÜ', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (51, N'MERZÝFON', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (52, N'SULUOVA', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (53, N'TAÞOVA', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (54, N'HAMAMÖZÜ', 5)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (55, N'ALTINDAÐ', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (56, N'AYAS', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (57, N'BALA', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (58, N'BEYPAZARI', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (59, N'ÇAMLIDERE', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (60, N'ÇANKAYA', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (61, N'ÇUBUK', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (62, N'ELMADAÐ', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (63, N'GÜDÜL', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (64, N'HAYMANA', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (65, N'KALECÝK', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (66, N'KIZILCAHAMAM', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (67, N'NALLIHAN', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (68, N'POLATLI', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (69, N'ÞEREFLÝKOÇHÝSAR', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (70, N'YENÝMAHALLE', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (71, N'GÖLBAÞI', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (72, N'KEÇÝÖREN', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (73, N'MAMAK', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (74, N'SÝNCAN', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (75, N'KAZAN', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (76, N'AKYURT', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (77, N'ETÝMESGUT', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (78, N'EVREN', 6)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (79, N'ANSEKÝ', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (80, N'ALANYA', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (81, N'ANTALYA MERKEZÝ', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (82, N'ELMALI', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (83, N'FÝNÝKE', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (84, N'GAZÝPAÞA', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (85, N'GÜNDOÐMUÞ', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (86, N'KAÞ', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (87, N'KORKUTELÝ', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (88, N'KUMLUCA', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (89, N'MANAVGAT', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (90, N'SERÝK', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (91, N'DEMRE', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (92, N'ÝBRADI', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (93, N'KEMER', 7)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (94, N'ARDAHAN MERKEZ', 75)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (95, N'GÖLE', 75)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (96, N'ÇILDIR', 75)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (97, N'HANAK', 75)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (98, N'POSOF', 75)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (99, N'DAMAL', 75)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (100, N'ARDANUÇ', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (101, N'ARHAVÝ', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (102, N'ARTVÝN MERKEZ', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (103, N'BORÇKA', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (104, N'HOPA', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (105, N'ÞAVÞAT', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (106, N'YUSUFELÝ', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (107, N'MURGUL', 8)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (108, N'AYDIN MERKEZ', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (109, N'BOZDOÐAN', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (110, N'ÇÝNE', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (111, N'GERMENCÝK', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (112, N'KARACASU', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (113, N'KOÇARLI', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (114, N'KUÞADASI', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (115, N'KUYUCAK', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (116, N'NAZÝLLÝ', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (117, N'SÖKE', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (118, N'SULTANHÝSAR', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (119, N'YENÝPAZAR', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (120, N'BUHARKENT', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (121, N'ÝNCÝRLÝOVA', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (122, N'KARPUZLU', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (123, N'KÖÞK', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (124, N'DÝDÝM', 9)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (125, N'AÐRI MERKEZ', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (126, N'DÝYADÝN', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (127, N'DOÐUBEYAZIT', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (128, N'ELEÞKÝRT', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (129, N'HAMUR', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (130, N'PATNOS', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (131, N'TAÞLIÇAY', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (132, N'TUTAK', 4)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (133, N'AYVALIK', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (134, N'BALIKESÝR MERKEZ', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (135, N'BALYA', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (136, N'BANDIRMA', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (137, N'BÝGADÝÇ', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (138, N'BURHANÝYE', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (139, N'DURSUNBEY', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (140, N'EDREMÝT', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (141, N'ERDEK', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (142, N'GÖNEN', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (143, N'HAVRAN', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (144, N'ÝVRÝNDÝ', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (145, N'KEPSUT', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (146, N'MANYAS', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (147, N'SAVAÞTEPE', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (148, N'SINDIRGI', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (149, N'SUSURLUK', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (150, N'MARMARA', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (151, N'GÖMEÇ', 10)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (152, N'BARTIN MERKEZ', 74)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (153, N'KURUCAÞÝLE', 74)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (154, N'ULUS', 74)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (155, N'AMASRA', 74)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (156, N'BATMAN MERKEZ', 72)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (157, N'BEÞÝRÝ', 72)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (158, N'GERCÜÞ', 72)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (159, N'KOZLUK', 72)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (160, N'SASON', 72)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (161, N'HASANKEYF', 72)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (162, N'BAYBURT MERKEZ', 69)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (163, N'AYDINTEPE', 69)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (164, N'DEMÝRÖZÜ', 69)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (165, N'BOLU MERKEZ', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (166, N'GEREDE', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (167, N'GÖYNÜK', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (168, N'KIBRISCIK', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (169, N'MENGEN', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (170, N'MUDURNU', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (171, N'SEBEN', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (172, N'DÖRTDÝVAN', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (173, N'YENÝÇAÐA', 14)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (174, N'AÐLASUN', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (175, N'BUCAK', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (176, N'BURDUR MERKEZ', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (177, N'GÖLHÝSAR', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (178, N'TEFENNÝ', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (179, N'YEÞÝLOVA', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (180, N'KARAMANLI', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (181, N'KEMER', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (182, N'ALTINYAYLA', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (183, N'ÇAVDIR', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (184, N'ÇELTÝKÇÝ', 15)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (185, N'GEMLÝK', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (186, N'ÝNEGÖL', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (187, N'ÝZNÝK', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (188, N'KARACABEY', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (189, N'KELES', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (190, N'MUDANYA', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (191, N'MUSTAFA K. PAÞA', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (192, N'ORHANELÝ', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (193, N'ORHANGAZÝ', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (194, N'YENÝÞEHÝR', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (195, N'BÜYÜK ORHAN', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (196, N'HARMANCIK', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (197, N'NÜLÝFER', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (198, N'OSMAN GAZÝ', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (199, N'YILDIRIM', 16)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (200, N'GÜRSU', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (201, N'KESTEL', 16)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (202, N'BÝLECÝK MERKEZ', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (203, N'BOZÜYÜK', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (204, N'GÖLPAZARI', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (205, N'OSMANELÝ', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (206, N'PAZARYERÝ', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (207, N'SÖÐÜT', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (208, N'YENÝPAZAR', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (209, N'ÝNHÝSAR', 11)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (210, N'BÝNGÖL MERKEZ', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (211, N'GENÇ', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (212, N'KARLIOVA', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (213, N'KÝGI', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (214, N'SOLHAN', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (215, N'ADAKLI', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (216, N'YAYLADERE', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (217, N'YEDÝSU', 12)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (218, N'ADÝLCEVAZ', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (219, N'AHLAT', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (220, N'BÝTLÝS MERKEZ', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (221, N'HÝZAN', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (222, N'MUTKÝ', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (223, N'TATVAN', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (224, N'GÜROYMAK', 13)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (225, N'DENÝZLÝ MERKEZ', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (226, N'ACIPAYAM', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (227, N'BULDAN', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (228, N'ÇAL', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (229, N'ÇAMELÝ', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (230, N'ÇARDAK', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (231, N'ÇÝVRÝL', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (232, N'GÜNEY', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (233, N'KALE', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (234, N'SARAYKÖY', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (235, N'TAVAS', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (236, N'BABADAÐ', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (237, N'BEKÝLLÝ', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (238, N'HONAZ', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (239, N'SERÝNHÝSAR', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (240, N'AKKÖY', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (241, N'BAKLAN', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (242, N'BEYAÐAÇ', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (243, N'BOZKURT', 20)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (244, N'DÜZCE MERKEZ', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (245, N'AKÇAKOCA', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (246, N'YIÐILCA', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (247, N'CUMAYERÝ', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (248, N'GÖLYAKA', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (249, N'ÇÝLÝMLÝ', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (250, N'GÜMÜÞOVA', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (251, N'KAYNAÞLI', 81)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (252, N'DÝYARBAKIR MERKEZ', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (253, N'BÝSMÝL', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (254, N'ÇERMÝK', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (255, N'ÇINAR', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (256, N'ÇÜNGÜÞ', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (257, N'DÝCLE', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (258, N'ERGANÝ', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (259, N'HANÝ', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (260, N'HAZRO', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (261, N'KULP', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (262, N'LÝCE', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (263, N'SÝLVAN', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (264, N'EÐÝL', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (265, N'KOCAKÖY', 21)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (266, N'EDÝRNE MERKEZ', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (267, N'ENEZ', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (268, N'HAVSA', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (269, N'ÝPSALA', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (270, N'KEÞAN', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (271, N'LALAPAÞA', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (272, N'MERÝÇ', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (273, N'UZUNKÖPRÜ', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (274, N'SÜLOÐLU', 22)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (275, N'ELAZIÐ MERKEZ', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (276, N'AÐIN', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (277, N'BASKÝL', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (278, N'KARAKOÇAN', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (279, N'KEBAN', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (280, N'MADEN', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (281, N'PALU', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (282, N'SÝVRÝCE', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (283, N'ARICAK', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (284, N'KOVANCILAR', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (285, N'ALACAKAYA', 23)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (286, N'ERZURUM MERKEZ', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (287, N'PALANDÖKEN', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (288, N'AÞKALE', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (289, N'ÇAT', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (290, N'HINIS', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (291, N'HORASAN', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (292, N'OLTU', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (293, N'ÝSPÝR', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (294, N'KARAYAZI', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (295, N'NARMAN', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (296, N'OLUR', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (297, N'PASÝNLER', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (298, N'ÞENKAYA', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (299, N'TEKMAN', 25)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (300, N'TORTUM', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (301, N'KARAÇOBAN', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (302, N'UZUNDERE', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (303, N'PAZARYOLU', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (304, N'ILICA', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (305, N'KÖPRÜKÖY', 25)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (306, N'ÇAYIRLI', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (307, N'ERZÝNCAN MERKEZ', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (308, N'ÝLÝÇ', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (309, N'KEMAH', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (310, N'KEMALÝYE', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (311, N'REFAHÝYE', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (312, N'TERCAN', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (313, N'OTLUKBELÝ', 24)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (314, N'ESKÝÞEHÝR MERKEZ', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (315, N'ÇÝFTELER', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (316, N'MAHMUDÝYE', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (317, N'MÝHALIÇLIK', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (318, N'SARICAKAYA', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (319, N'SEYÝTGAZÝ', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (320, N'SÝVRÝHÝSAR', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (321, N'ALPU', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (322, N'BEYLÝKOVA', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (323, N'ÝNÖNÜ', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (324, N'GÜNYÜZÜ', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (325, N'HAN', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (326, N'MÝHALGAZÝ', 26)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (327, N'ARABAN', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (328, N'ÝSLAHÝYE', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (329, N'NÝZÝP', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (330, N'OÐUZELÝ', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (331, N'YAVUZELÝ', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (332, N'ÞAHÝNBEY', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (333, N'ÞEHÝT KAMÝL', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (334, N'KARKAMIÞ', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (335, N'NURDAÐI', 27)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (336, N'GÜMÜÞHANE MERKEZ', 29)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (337, N'KELKÝT', 29)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (338, N'ÞÝRAN', 29)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (339, N'TORUL', 29)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (340, N'KÖSE', 29)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (341, N'KÜRTÜN', 29)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (342, N'ALUCRA', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (343, N'BULANCAK', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (344, N'DERELÝ', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (345, N'ESPÝYE', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (346, N'EYNESÝL', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (347, N'GÝRESUN MERKEZ', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (348, N'GÖRELE', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (349, N'KEÞAP', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (350, N'ÞEBÝNKARAHÝSAR', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (351, N'TÝREBOLU', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (352, N'PÝPAZÝZ', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (353, N'YAÐLIDERE', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (354, N'ÇAMOLUK', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (355, N'ÇANAKÇI', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (356, N'DOÐANKENT', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (357, N'GÜCE', 28)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (358, N'HAKKARÝ MERKEZ', 30)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (359, N'ÇUKURCA', 30)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (360, N'ÞEMDÝNLÝ', 30)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (361, N'YÜKSEKOVA', 30)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (362, N'ALTINÖZÜ', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (363, N'DÖRTYOL', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (364, N'HATAY MERKEZ', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (365, N'HASSA', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (366, N'ÝSKENDERUN', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (367, N'KIRIKHAN', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (368, N'REYHANLI', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (369, N'SAMANDAÐ', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (370, N'YAYLADAÐ', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (371, N'ERZÝN', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (372, N'BELEN', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (373, N'KUMLU', 31)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (374, N'ISPARTA MERKEZ', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (375, N'ATABEY', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (376, N'KEÇÝBORLU', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (377, N'EÐÝRDÝR', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (378, N'GELENDOST', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (379, N'SÝNÝRKENT', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (380, N'ULUBORLU', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (381, N'YALVAÇ', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (382, N'AKSU', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (383, N'GÖNEN', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (384, N'YENÝÞAR BADEMLÝ', 32)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (385, N'IÐDIR MERKEZ', 76)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (386, N'ARALIK', 76)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (387, N'TUZLUCA', 76)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (388, N'KARAKOYUNLU', 76)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (389, N'AFÞÝN', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (390, N'ANDIRIN', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (391, N'ELBÝSTAN', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (392, N'GÖKSUN', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (393, N'KAHRAMANMARAÞ MERKEZ', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (394, N'PAZARCIK', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (395, N'TÜRKOÐLU', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (396, N'ÇAÐLAYANCERÝT', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (397, N'EKÝNÖZÜ', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (398, N'NURHAK', 46)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (399, N'EFLANÝ', 78)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (400, N'ESKÝPAZAR', 78)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (401, N'KARABÜK MERKEZ', 78)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (402, N'OVACIK', 78)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (403, N'SAFRANBOLU', 78)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (404, N'YENÝCE', 78)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (405, N'ERMENEK', 70)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (406, N'KARAMAN MERKEZ', 70)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (407, N'AYRANCI', 70)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (408, N'KAZIMKARABEKÝR', 70)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (409, N'BAÞYAYLA', 70)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (410, N'SARIVELÝLER', 70)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (411, N'KARS MERKEZ', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (412, N'ARPAÇAY', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (413, N'DÝGOR', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (414, N'KAÐIZMAN', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (415, N'SARIKAMIÞ', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (416, N'SELÝM', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (417, N'SUSUZ', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (418, N'AKYAKA', 36)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (419, N'ABANA', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (420, N'KASTAMONU MERKEZ', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (421, N'ARAÇ', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (422, N'AZDAVAY', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (423, N'BOZKURT', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (424, N'CÝDE', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (425, N'ÇATALZEYTÝN', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (426, N'DADAY', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (427, N'DEVREKANÝ', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (428, N'ÝNEBOLU', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (429, N'KÜRE', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (430, N'TAÞKÖPRÜ', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (431, N'TOSYA', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (432, N'ÝHSANGAZÝ', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (433, N'PINARBAÞI', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (434, N'ÞENPAZAR', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (435, N'AÐLI', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (436, N'DOÐANYURT', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (437, N'HANÖNÜ', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (438, N'SEYDÝLER', 37)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (439, N'BÜNYAN', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (440, N'DEVELÝ', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (441, N'FELAHÝYE', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (442, N'ÝNCESU', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (443, N'PINARBAÞI', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (444, N'SARIOÐLAN', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (445, N'SARIZ', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (446, N'TOMARZA', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (447, N'YAHYALI', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (448, N'YEÞÝLHÝSAR', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (449, N'AKKIÞLA', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (450, N'TALAS', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (451, N'KOCASÝNAN', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (452, N'MELÝKGAZÝ', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (453, N'HACILAR', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (454, N'ÖZVATAN', 38)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (455, N'DERÝCE', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (456, N'KESKÝN', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (457, N'KIRIKKALE MERKEZ', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (458, N'SALAK YURT', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (459, N'BAHÞÝLÝ', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (460, N'BALIÞEYH', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (461, N'ÇELEBÝ', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (462, N'KARAKEÇÝLÝ', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (463, N'YAHÞÝHAN', 71)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (464, N'KIRKKLARELÝ MERKEZ', 39)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (465, N'BABAESKÝ', 39)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (466, N'DEMÝRKÖY', 39)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (467, N'KOFÇAY', 39)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (468, N'LÜLEBURGAZ', 39)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (469, N'VÝZE', 39)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (470, N'KIRÞEHÝR MERKEZ', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (471, N'ÇÝÇEKDAÐI', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (472, N'KAMAN', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (473, N'MUCUR', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (474, N'AKPINAR', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (475, N'AKÇAKENT', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (476, N'BOZTEPE', 40)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (477, N'KOCAELÝ MERKEZ', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (478, N'GEBZE', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (479, N'GÖLCÜK', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (480, N'KANDIRA', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (481, N'KARAMÜRSEL', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (482, N'KÖRFEZ', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (483, N'DERÝNCE', 41)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (484, N'KONYA MERKEZ', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (485, N'AKÞEHÝR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (486, N'BEYÞEHÝR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (487, N'BOZKIR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (488, N'CÝHANBEYLÝ', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (489, N'ÇUMRA', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (490, N'DOÐANHÝSAR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (491, N'EREÐLÝ', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (492, N'HADÝM', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (493, N'ILGIN', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (494, N'KADINHANI', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (495, N'KARAPINAR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (496, N'KULU', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (497, N'SARAYÖNÜ', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (498, N'SEYDÝÞEHÝR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (499, N'YUNAK', 42)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (500, N'AKÖREN', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (501, N'ALTINEKÝN', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (502, N'DEREBUCAK', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (503, N'HÜYÜK', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (504, N'KARATAY', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (505, N'MERAM', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (506, N'SELÇUKLU', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (507, N'TAÞKENT', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (508, N'AHIRLI', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (509, N'ÇELTÝK', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (510, N'DERBENT', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (511, N'EMÝRGAZÝ', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (512, N'GÜNEYSINIR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (513, N'HALKAPINAR', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (514, N'TUZLUKÇU', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (515, N'YALIHÜYÜK', 42)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (516, N'KÜTAHYA  MERKEZ', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (517, N'ALTINTAÞ', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (518, N'DOMANÝÇ', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (519, N'EMET', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (520, N'GEDÝZ', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (521, N'SÝMAV', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (522, N'TAVÞANLI', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (523, N'ASLANAPA', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (524, N'DUMLUPINAR', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (525, N'HÝSARCIK', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (526, N'ÞAPHANE', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (527, N'ÇAVDARHÝSAR', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (528, N'PAZARLAR', 43)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (529, N'KÝLÝS MERKEZ', 79)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (530, N'ELBEYLÝ', 79)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (531, N'MUSABEYLÝ', 79)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (532, N'POLATELÝ', 79)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (533, N'MALATYA MERKEZ', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (534, N'AKÇADAÐ', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (535, N'ARAPGÝR', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (536, N'ARGUVAN', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (537, N'DARENDE', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (538, N'DOÐANÞEHÝR', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (539, N'HEKÝMHAN', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (540, N'PÜTÜRGE', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (541, N'YEÞÝLYURT', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (542, N'BATTALGAZÝ', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (543, N'DOÐANYOL', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (544, N'KALE', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (545, N'KULUNCAK', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (546, N'YAZIHAN', 44)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (547, N'AKHÝSAR', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (548, N'ALAÞEHÝR', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (549, N'DEMÝRCÝ', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (550, N'GÖRDES', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (551, N'KIRKAÐAÇ', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (552, N'KULA', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (553, N'MANÝSA MERKEZ', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (554, N'SALÝHLÝ', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (555, N'SARIGÖL', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (556, N'SARUHANLI', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (557, N'SELENDÝ', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (558, N'SOMA', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (559, N'TURGUTLU', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (560, N'AHMETLÝ', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (561, N'GÖLMARMARA', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (562, N'KÖPRÜBAÞI', 45)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (563, N'DERÝK', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (564, N'KIZILTEPE', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (565, N'MARDÝN MERKEZ', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (566, N'MAZIDAÐI', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (567, N'MÝDYAT', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (568, N'NUSAYBÝN', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (569, N'ÖMERLÝ', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (570, N'SAVUR', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (571, N'YEÞÝLLÝ', 47)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (572, N'MERSÝN MERKEZ', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (573, N'ANAMUR', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (574, N'ERDEMLÝ', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (575, N'GÜLNAR', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (576, N'MUT', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (577, N'SÝLÝFKE', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (578, N'TARSUS', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (579, N'AYDINCIK', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (580, N'BOZYAZI', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (581, N'ÇAMLIYAYLA', 33)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (582, N'BODRUM', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (583, N'DATÇA', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (584, N'FETHÝYE', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (585, N'KÖYCEÐÝZ', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (586, N'MARMARÝS', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (587, N'MÝLAS', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (588, N'MUÐLA MERKEZ', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (589, N'ULA', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (590, N'YATAÐAN', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (591, N'DALAMAN', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (592, N'KAVAKLI DERE', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (593, N'ORTACA', 48)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (594, N'BULANIK', 49)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (595, N'MALAZGÝRT', 49)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (596, N'MUÞ MERKEZ', 49)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (597, N'VARTO', 49)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (598, N'HASKÖY', 49)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (599, N'KORKUT', 49)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (600, N'NEVÞEHÝR MERKEZ', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (601, N'AVANOS', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (602, N'DERÝNKUYU', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (603, N'GÜLÞEHÝR', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (604, N'HACIBEKTAÞ', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (605, N'KOZAKLI', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (606, N'ÜRGÜP', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (607, N'ACIGÖL', 50)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (608, N'NÝÐDE MERKEZ', 51)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (609, N'BOR', 51)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (610, N'ÇAMARDI', 51)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (611, N'ULUKIÞLA', 51)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (612, N'ALTUNHÝSAR', 51)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (613, N'ÇÝFTLÝK', 51)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (614, N'AKKUÞ', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (615, N'AYBASTI', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (616, N'FATSA', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (617, N'GÖLKÖY', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (618, N'KORGAN', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (619, N'KUMRU', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (620, N'MESUDÝYE', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (621, N'ORDU MERKEZ', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (622, N'PERÞEMBE', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (623, N'ULUBEY', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (624, N'ÜNYE', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (625, N'GÜLYALI', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (626, N'GÜRGENTEPE', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (627, N'ÇAMAÞ', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (628, N'ÇATALPINAR', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (629, N'ÇAYBAÞI', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (630, N'ÝKÝZCE', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (631, N'KABADÜZ', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (632, N'KABATAÞ', 52)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (633, N'BAHÇE', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (634, N'KADÝRLÝ', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (635, N'OSMANÝYE MERKEZ', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (636, N'DÜZÝÇÝ', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (637, N'HASANBEYLÝ', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (638, N'SUMBAÞ', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (639, N'TOPRAKKALE', 80)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (640, N'RÝZE MERKEZ', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (641, N'ARDEÞEN', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (642, N'ÇAMLIHEMÞÝN', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (643, N'ÇAYELÝ', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (644, N'FINDIKLI', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (645, N'ÝKÝZDERE', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (646, N'KALKANDERE', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (647, N'PAZAR', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (648, N'GÜNEYSU', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (649, N'DEREPAZARI', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (650, N'HEMÞÝN', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (651, N'ÝYÝDERE', 53)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (652, N'AKYAZI', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (653, N'GEYVE', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (654, N'HENDEK', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (655, N'KARASU', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (656, N'KAYNARCA', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (657, N'SAKARYA MERKEZ', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (658, N'PAMUKOVA', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (659, N'TARAKLI', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (660, N'FERÝZLÝ', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (661, N'KARAPÜRÇEK', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (662, N'SÖÐÜTLÜ', 54)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (663, N'ALAÇAM', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (664, N'BAFRA', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (665, N'ÇARÞAMBA', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (666, N'HAVZA', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (667, N'KAVAK', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (668, N'LADÝK', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (669, N'SAMSUN MERKEZ', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (670, N'TERME', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (671, N'VEZÝRKÖPRÜ', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (672, N'ASARCIK', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (673, N'ONDOKUZMAYIS', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (674, N'SALIPAZARI', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (675, N'TEKKEKÖY', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (676, N'AYVACIK', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (677, N'YAKAKENT', 55)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (678, N'AYANCIK', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (679, N'BOYABAT', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (680, N'SÝNOP MERKEZ', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (681, N'DURAÐAN', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (682, N'ERGELEK', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (683, N'GERZE', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (684, N'TÜRKELÝ', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (685, N'DÝKMEN', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (686, N'SARAYDÜZÜ', 57)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (687, N'DÝVRÝÐÝ', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (688, N'GEMEREK', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (689, N'GÜRÜN', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (690, N'HAFÝK', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (691, N'ÝMRANLI', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (692, N'KANGAL', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (693, N'KOYUL HÝSAR', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (694, N'SÝVAS MERKEZ', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (695, N'SU ÞEHRÝ', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (696, N'ÞARKIÞLA', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (697, N'YILDIZELÝ', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (698, N'ZARA', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (699, N'AKINCILAR', 58)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (700, N'ALTINYAYLA', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (701, N'DOÐANÞAR', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (702, N'GÜLOVA', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (703, N'ULAÞ', 58)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (704, N'BAYKAN', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (705, N'ERUH', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (706, N'KURTALAN', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (707, N'PERVARÝ', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (708, N'SÝÝRT MERKEZ', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (709, N'ÞÝRVARÝ', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (710, N'AYDINLAR', 56)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (711, N'TEKÝRDAÐ MERKEZ', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (712, N'ÇERKEZKÖY', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (713, N'ÇORLU', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (714, N'HAYRABOLU', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (715, N'MALKARA', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (716, N'MURATLI', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (717, N'SARAY', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (718, N'ÞARKÖY', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (719, N'MARAMARAEREÐLÝSÝ', 59)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (720, N'ALMUS', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (721, N'ARTOVA', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (722, N'TOKAT MERKEZ', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (723, N'ERBAA', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (724, N'NÝKSAR', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (725, N'REÞADÝYE', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (726, N'TURHAL', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (727, N'ZÝLE', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (728, N'PAZAR', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (729, N'YEÞÝLYURT', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (730, N'BAÞÇÝFTLÝK', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (731, N'SULUSARAY', 60)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (732, N'TRABZON MERKEZ', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (733, N'AKÇAABAT', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (734, N'ARAKLI', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (735, N'ARÞÝN', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (736, N'ÇAYKARA', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (737, N'MAÇKA', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (738, N'OF', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (739, N'SÜRMENE', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (740, N'TONYA', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (741, N'VAKFIKEBÝR', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (742, N'YOMRA', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (743, N'BEÞÝKDÜZÜ', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (744, N'ÞALPAZARI', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (745, N'ÇARÞIBAÞI', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (746, N'DERNEKPAZARI', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (747, N'DÜZKÖY', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (748, N'HAYRAT', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (749, N'KÖPRÜBAÞI', 61)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (750, N'TUNCELÝ MERKEZ', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (751, N'ÇEMÝÞGEZEK', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (752, N'HOZAT', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (753, N'MAZGÝRT', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (754, N'NAZÝMÝYE', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (755, N'OVACIK', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (756, N'PERTEK', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (757, N'PÜLÜMÜR', 62)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (758, N'BANAZ', 64)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (759, N'EÞME', 64)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (760, N'KARAHALLI', 64)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (761, N'SÝVASLI', 64)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (762, N'ULUBEY', 64)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (763, N'UÞAK MERKEZ', 64)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (764, N'BAÞKALE', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (765, N'VAN MERKEZ', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (766, N'EDREMÝT', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (767, N'ÇATAK', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (768, N'ERCÝÞ', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (769, N'GEVAÞ', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (770, N'GÜRPINAR', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (771, N'MURADÝYE', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (772, N'ÖZALP', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (773, N'BAHÇESARAY', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (774, N'ÇALDIRAN', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (775, N'SARAY', 65)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (776, N'YALOVA MERKEZ', 77)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (777, N'ALTINOVA', 77)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (778, N'ARMUTLU', 77)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (779, N'ÇINARCIK', 77)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (780, N'ÇÝFTLÝKKÖY', 77)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (781, N'TERMAL', 77)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (782, N'AKDAÐMADENÝ', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (783, N'BOÐAZLIYAN', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (784, N'YOZGAT MERKEZ', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (785, N'ÇAYIRALAN', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (786, N'ÇEKEREK', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (787, N'SARIKAYA', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (788, N'SORGUN', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (789, N'ÞEFAATLI', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (790, N'YERKÖY', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (791, N'KADIÞEHRÝ', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (792, N'SARAYKENT', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (793, N'YENÝFAKILI', 66)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (794, N'ÇAYCUMA', 67)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (795, N'DEVREK', 67)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (796, N'ZONGULDAK MERKEZ', 67)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (797, N'EREÐLÝ', 67)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (798, N'ALAPLI', 67)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (799, N'GÖKÇEBEY', 67)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (800, N'ÇANAKKALE MERKEZ', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (801, N'AYVACIK', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (802, N'BAYRAMÝÇ', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (803, N'BÝGA', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (804, N'BOZCAADA', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (805, N'ÇAN', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (806, N'ECEABAT', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (807, N'EZÝNE', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (808, N'LAPSEKÝ', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (809, N'YENÝCE', 17)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (810, N'ÇANKIRI MERKEZ', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (811, N'ÇERKEÞ', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (812, N'ELDÝVAN', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (813, N'ILGAZ', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (814, N'KURÞUNLU', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (815, N'ORTA', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (816, N'ÞABANÖZÜ', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (817, N'YAPRAKLI', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (818, N'ATKARACALAR', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (819, N'KIZILIRMAK', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (820, N'BAYRAMÖREN', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (821, N'KORGUN', 18)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (822, N'ALACA', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (823, N'BAYAT', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (824, N'ÇORUM MERKEZ', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (825, N'ÝKSÝPLÝ', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (826, N'KARGI', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (827, N'MECÝTÖZÜ', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (828, N'ORTAKÖY', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (829, N'OSMANCIK', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (830, N'SUNGURLU', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (831, N'DODURGA', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (832, N'LAÇÝN', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (833, N'OÐUZLAR', 19)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (834, N'ADALAR', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (835, N'BAKIRKÖY', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (836, N'BEÞÝKTAÞ', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (837, N'BEYKOZ', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (838, N'BEYOÐLU', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (839, N'ÇATALCA', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (840, N'EMÝNÖNÜ', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (841, N'EYÜP', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (842, N'FATÝH', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (843, N'GAZÝOSMANPAÞA', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (844, N'KADIKÖY', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (845, N'KARTAL', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (846, N'SARIYER', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (847, N'SÝLÝVRÝ', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (848, N'ÞÝLE', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (849, N'ÞÝÞLÝ', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (850, N'ÜSKÜDAR', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (851, N'ZEYTÝNBURNU', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (852, N'BÜYÜKÇEKMECE', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (853, N'KAÐITHANE', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (854, N'KÜÇÜKÇEKMECE', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (855, N'PENDÝK', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (856, N'ÜMRANÝYE', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (857, N'BAYRAMPAÞA', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (858, N'AVCILAR', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (859, N'BAÐCILAR', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (860, N'BAHÇELÝEVLER', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (861, N'GÜNGÖREN', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (862, N'MALTEPE', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (863, N'SULTANBEYLÝ', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (864, N'TUZLA', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (865, N'ESENLER', 34)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (866, N'ALÝAÐA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (867, N'BAYINDIR', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (868, N'BERGAMA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (869, N'BORNOVA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (870, N'ÇEÞME', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (871, N'DÝKÝLÝ', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (872, N'FOÇA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (873, N'KARABURUN', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (874, N'KARÞIYAKA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (875, N'KEMALPAÞA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (876, N'KINIK', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (877, N'KÝRAZ', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (878, N'MENEMEN', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (879, N'ÖDEMÝÞ', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (880, N'SEFERÝHÝSAR', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (881, N'SELÇUK', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (882, N'TÝRE', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (883, N'TORBALI', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (884, N'URLA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (885, N'BEYDAÐ', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (886, N'BUCA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (887, N'KONAK', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (888, N'MENDERES', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (889, N'BALÇOVA', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (890, N'ÇÝGLÝ', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (891, N'GAZÝEMÝR', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (892, N'NARLIDERE', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (893, N'GÜZELBAHÇE', 35)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (894, N'ÞANLIURFA MERKEZ', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (895, N'AKÇAKALE', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (896, N'BÝRECÝK', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (897, N'BOZOVA', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (898, N'CEYLANPINAR', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (899, N'HALFETÝ', 63)
GO
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (900, N'HÝLVAN', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (901, N'SÝVEREK', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (902, N'SURUÇ', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (903, N'VÝRANÞEHÝR', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (904, N'HARRAN', 63)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (905, N'BEYTÜÞÞEBAP', 73)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (906, N'ÞIRNAK MERKEZ', 73)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (907, N'CÝZRE', 73)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (908, N'ÝDÝL', 73)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (909, N'SÝLOPÝ', 73)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (910, N'ULUDERE', 73)
INSERT [dbo].[TBLILCELER] ([id], [ilce], [sehir]) VALUES (911, N'GÜÇLÜKONAK', 73)
SET IDENTITY_INSERT [dbo].[TBLILCELER] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLILETISIM] ON 

INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (1, N'Emre Koçovali', N'Emrekocovali@gmail.com', N'Tesekkür', N'Aldigim tv sorunsuz ve güzel sekilde çalisiyor. Fiyat performans ürünü.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (2, N'Ali Yilmaz', N'Aliyilmaz@gmail.com', N'Tesekkür', N'Lütfen tvlerde indirim yapin.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (3, N'Mehmet Çinar', N'mehmetcnr@hotmail.com', N'Rica', N'Lütfen tvlerde indirim yapin.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (4, N'Zeynep Günes', N'zeynep01@gmail.com', N'Sikayet', N'Son aldigim tv ünitesi gerçekten çok güzel elinize saglik.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (5, N'Ayse Öztürk', N'ayseozturk@hotmail.com', N'Sikayet', N'Son aldigim buzdolabi 3.kez arizalandi.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (6, N'Aylin Yildirim', N'aylinyildirim@gmail.com', N'Tesekkür', N'Arçelik marka bulasik makinesinden çok memnunum.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (7, N'Sabri Taner Burak', N'sabriburaktaner@gmail.com', N'Tesekkür', N'Arskomda çalismak çok güzeldi')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (8, N'Sema ', N'sema@gmail.com', N'Sikayet', N'Aldigim laptop çok kötü')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (9, N'Zeynep Günes', N'zeynep01@gmail.com', N'Tesekkür', N'Son aldigim tv ünitesi gerçekten çok güzel elinize saglik.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (10, N'Mehmet Çinar', N'mehmetcnr@hotmail.com', N'Rica', N'Lütfen tvlerde indirim yapin.')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (11, N'Emircan', N'emircangs1905@gmail.com', N'Rica', N'ariza yapti hiç iyi degil')
INSERT [dbo].[TBLILETISIM] ([ID], [ADSOYAD], [MAIL], [KONU], [MESAJ]) VALUES (12, N'nidal', N'nidal@gmail.com', N'Tesekkür', N'Ürün basarili')
SET IDENTITY_INSERT [dbo].[TBLILETISIM] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLILLER] ON 

INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (1, N'ADANA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (2, N'ADIYAMAN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (3, N'AFYON')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (4, N'AĞRI')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (5, N'AMASYA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (6, N'ANKARA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (7, N'ANTALYA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (8, N'ARTVİN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (9, N'AYDIN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (10, N'BALIKESİR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (11, N'BİLECİK')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (12, N'BİNGÖL')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (13, N'BİTLİS')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (14, N'BOLU')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (15, N'BURDUR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (16, N'BURSA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (17, N'ÇANAKKALE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (18, N'ÇANKIRI')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (19, N'ÇORUM')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (20, N'DENİZLİ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (21, N'DİYARBAKIR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (22, N'EDİRNE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (23, N'ELAZIĞ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (24, N'ERZİNCAN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (25, N'ERZURUM')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (26, N'ESKİŞEHİR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (27, N'GAZİANTEP')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (28, N'GİRESUN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (29, N'GÜMÜŞHANE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (30, N'HAKKARİ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (31, N'HATAY')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (32, N'ISPARTA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (33, N'İÇEL')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (34, N'İSTANBUL')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (35, N'İZMİR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (36, N'KARS')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (37, N'KASTAMONU')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (38, N'KAYSERİ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (39, N'KIRKLARELİ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (40, N'KIRŞEHİR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (41, N'KOCAELİ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (42, N'KONYA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (43, N'KÜTAHYA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (44, N'MALATYA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (45, N'MANİSA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (46, N'KAHRAMANMARAŞ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (47, N'MARDİN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (48, N'MUĞLA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (49, N'MUŞ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (50, N'NEVŞEHİR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (51, N'NİĞDE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (52, N'ORDU')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (53, N'RİZE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (54, N'SAKARYA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (55, N'SAMSUN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (56, N'SİİRT')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (57, N'SİNOP')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (58, N'SİVAS')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (59, N'TEKİRDAĞ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (60, N'TOKAT')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (61, N'TRABZON')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (62, N'TUNCELİ')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (63, N'ŞANLIURFA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (64, N'UŞAK')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (65, N'VAN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (66, N'YOZGAT')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (67, N'ZONGULDAK')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (68, N'AKSARAY')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (69, N'BAYBURT')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (70, N'KARAMAN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (71, N'KIRIKKALE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (72, N'BATMAN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (73, N'ŞIRNAK')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (74, N'BARTIN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (75, N'ARDAHAN')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (76, N'IĞDIR')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (77, N'YALOVA')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (78, N'KARABÜK')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (79, N'KİLİS')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (80, N'OSMANİYE')
INSERT [dbo].[TBLILLER] ([id], [sehir]) VALUES (81, N'DÜZCE')
SET IDENTITY_INSERT [dbo].[TBLILLER] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLKATEGORI] ON 

INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (1, N'BILGISAYAR')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (2, N'TELEFON')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (3, N'KUCUK EV ALETI')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (4, N'BEYAZ ESYA')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (5, N'TV')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (6, N'MOBILYA')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (7, N'NEVRESIM')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (8, N'BILGISAYAR PARCALARI')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (9, N'USB BELLEKLER')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (10, N'SES SISTEMLERI')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (11, N'KULAKLIK')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (12, N'TABLET')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (13, N'CANTALAR')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (15, N'DENEME')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (16, N'Test')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (17, N'test')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (19, N'ARAÇ')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (21, N'TESTTTT')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (23, N'MAKINE')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (26, N'TEST ET')
INSERT [dbo].[TBLKATEGORI] ([ID], [AD]) VALUES (27, N'T')
SET IDENTITY_INSERT [dbo].[TBLKATEGORI] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLNOTLARIM] ON 

INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (1, N'TOPLANTI', N'27 ocak 2020 tarihinde Çinar Demir ile saat 14:00''de toplanti var.', 0, CAST(N'2024-02-16T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (2, N'ÖDEME', N'Telefonlar için 1400 TL ödeme yapilacak', 0, CAST(N'2023-07-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (3, N'TOPLANTI', N'Sevgi hanim ile yapilacak toplanti ertelenmistir.', 0, CAST(N'2023-07-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (4, N'TOPLANTI', N'Bülent bey toplantiya katilamayacak.', 0, CAST(N'2023-07-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (5, N'ÖDEME', N'Kaya ticarete 20000 TL daha ödenecek', 0, CAST(N'2023-07-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (6, N'TOPLANTI', N'Saat 14:00 da toplanti var.', 0, CAST(N'2023-02-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (7, N'ÖDEME', N'Kaya ticarette 25000 TL ödeme.', 0, CAST(N'2023-02-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (8, N'TOPLANTI', N'Hasan Bey saat 18:30da toplantiya geliyor.', 0, CAST(N'2023-02-17T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (9, N'GÖRÜSME', N'Ali Bey ile yarin görüsülecek.', 0, CAST(N'2023-02-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (10, N'MAL SEVKIYATI', N'Saat 18:00 da 20 kutu usb gelecek.', 0, CAST(N'2023-02-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (11, N'ARAMA', N'Gün içinde Zeynep hanimi arayalim.', 0, CAST(N'2023-02-17T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (13, N'IS BASVURUSU', N'Bugün yeni 3 çalisan pazarlama için gelecek.', 0, CAST(N'2023-02-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (29, N'TOPLANTI', N'27 ocak 2020 tarihinde Çinar Demir ile saat 14:00''de toplanti var.', 0, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (30, N'ÖDEME', N'Telefonlar için 1400 TL ödeme yapilacak', 1, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (31, N'GÖRÜSME', N'Ali Bey ile yarin görüsülecek.', 1, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (32, N'ÖDEME', N'Kaya ticarette 25000 TL ödeme.', 1, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (33, N'MAL SEVKIYATI', N'Saat 18:00 da 20 kutu usb gelecek.', 1, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (34, N'TOPLANTI', N'Sevgi hanim ile yapilacak toplanti ertelenmistir.', 1, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (35, N'TOPLANTI', N'Bülent bey toplantiya katilamayacak.', 1, CAST(N'2024-04-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (36, N'Yardim', N'Mizrak yardima gelecek', 1, CAST(N'2024-05-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (37, N'içerik düzenleme', N'içerikler düzenlendi', 0, CAST(N'2024-05-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (38, N'ÖDEME', N'Kaya ticarette 25000 TL ödeme.', 1, CAST(N'2023-02-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[TBLNOTLARIM] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (39, N'YARDIM', N'erdem sahin bugün yardima gelecek.', 1, CAST(N'2024-05-07T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[TBLNOTLARIM] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLPERSONEL] ON 

INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (1, N'MEHMET', N'ERSIN', 1, NULL, N'mehmetersin@gmail.com', N'(532) 564-2316')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (2, N'SEVGI', N'EKICI', 3, NULL, N'sevgiekc@gmail.com', N'(532) 156-4687')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (3, N'BÜLENT', N'DELEN', 5, NULL, N'delenbulent@gmail.com', N'(532) 654-8765')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (4, N'ARZU', N'ÜSTÜNEL', 12, NULL, N'arzuüstnl34@gmail.com', N'(532) 165-4987')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (5, N'HASAN', N'KAYA', 6, NULL, N'kayahasan01@outlook.com', N'(532) 165-4657')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (6, N'MAHMUT', N'OZCAN', 7, NULL, N'mahmutzcn@gmail.com', N'(538) 216-5498')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (7, N'EMIRCAN', N'ALTAY', 2, NULL, N'emircan@gmail.com', N'(542) 894-7624')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (8, N'TUNAHAN', N'BALCI', 13, NULL, N'tunahan@gmail.com', N'(532) 165-4654')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (11, N'AZIZ ', N'KELES', 5, NULL, N'aziz@gmail.com', N'(532) 165-4987')
INSERT [dbo].[TBLPERSONEL] ([ID], [AD], [SOYAD], [DEPARTMAN], [FOTOĞRAF], [MAIL], [TELEFON]) VALUES (14, N'FINDIKK', N'KAVURMACI', 8, NULL, N'findik52@gmail.com', N'(532) 564-9847')
SET IDENTITY_INSERT [dbo].[TBLPERSONEL] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLURUN] ON 

INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (2, N'LAPTOP', N'SAMSUNG', CAST(2985.00 AS Decimal(18, 2)), CAST(3200.00 AS Decimal(18, 2)), 28, 4, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (3, N'LAPTOP', N'LENOVO', CAST(3650.00 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), 50, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (5, N'LAPTOP', N'CASPER', CAST(2500.00 AS Decimal(18, 2)), CAST(3200.00 AS Decimal(18, 2)), 10, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (6, N'UTU', N'ARZUM', CAST(250.00 AS Decimal(18, 2)), CAST(350.00 AS Decimal(18, 2)), 26, 3, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (7, N'SU ISITICI', N'BOSCH', CAST(25.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 198, 3, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (8, N'LAPTOP', N'ACER', CAST(4100.00 AS Decimal(18, 2)), CAST(4600.00 AS Decimal(18, 2)), 20, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (9, N'SU ISITICI', N'SIEMENS', CAST(20.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)), 150, 3, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (10, N'FIRIN', N'SIEMENS', CAST(250.00 AS Decimal(18, 2)), CAST(360.00 AS Decimal(18, 2)), 19, 4, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (11, N'BUZDOLABI', N'ARCELIK', CAST(2100.00 AS Decimal(18, 2)), CAST(2650.00 AS Decimal(18, 2)), 150, 4, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (12, N'BUZDOLABI', N'BEKO', CAST(1400.00 AS Decimal(18, 2)), CAST(1850.00 AS Decimal(18, 2)), 99, 4, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (13, N'FIRIN', N'SIEMENS', CAST(350.00 AS Decimal(18, 2)), CAST(390.00 AS Decimal(18, 2)), 120, 4, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (14, N'HARDDISK', N'KINGSTON', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 99, 8, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (16, N'KULAKLIK', N'JBL', CAST(6000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), 60, 16, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (22, N'CANTA', N'ZARA', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 100, 12, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (23, N'KLAVYE', N'LG', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 100, 8, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (24, N'KLAVYE', N'RAMPAGE', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 35, 8, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (25, N'HDD', N'SEAGATE', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 15, 8, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (26, N'RAM', N'FURY', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 11, 8, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (27, N'TABLET', N'HUAWEI', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 100, 13, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (28, N'BILGISAYAR', N'MONSTER', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 99, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (29, N'BILGISAYAR', N'ASUS', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 17, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (30, N'KAMERA', N'CANON', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 100, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (31, N'KAMERA', N'NIKON', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 35, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (32, N'BILGISAYAR', N'MSI', CAST(1400.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 25, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (33, N'KULAKLIK', N'TRUST', CAST(3000.00 AS Decimal(18, 2)), CAST(4850.00 AS Decimal(18, 2)), 20, 12, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (34, N'KULAKLIK', N'JBL', CAST(4000.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), 8, 11, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (35, N'LAPTOP', N'SAMSUNG', CAST(9000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), 1, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (36, N'LAPTOP', N'ACER', CAST(20000.00 AS Decimal(18, 2)), CAST(25000.00 AS Decimal(18, 2)), 2, 1, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (57, N'TELEFON', N'APPLE', CAST(15000.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)), 50, 2, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (59, N'TELEFON', N'LG', CAST(8000.00 AS Decimal(18, 2)), CAST(18000.00 AS Decimal(18, 2)), 20, 2, 0)
INSERT [dbo].[TBLURUN] ([ID], [AD], [MARKA], [ALISFIYAT], [SATISFIYAT], [STOK], [KATEGORI], [DURUM]) VALUES (61, N'TELEFON', N'B', CAST(9000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), 50, 2, 0)
SET IDENTITY_INSERT [dbo].[TBLURUN] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLURUNHAREKET] ON 

INSERT [dbo].[TBLURUNHAREKET] ([HARAKET], [URUN], [MUSTERI], [PERSONEL], [TARIH], [ADET], [FIYAT], [URUNSERINO]) VALUES (2, 6, 9, 1, CAST(N'2023-07-07T00:00:00' AS SmallDateTime), 1, CAST(350.00 AS Decimal(18, 2)), N'A7851')
INSERT [dbo].[TBLURUNHAREKET] ([HARAKET], [URUN], [MUSTERI], [PERSONEL], [TARIH], [ADET], [FIYAT], [URUNSERINO]) VALUES (3, 8, 5, 3, CAST(N'2023-07-06T00:00:00' AS SmallDateTime), 1, CAST(4600.00 AS Decimal(18, 2)), N'12345')
INSERT [dbo].[TBLURUNHAREKET] ([HARAKET], [URUN], [MUSTERI], [PERSONEL], [TARIH], [ADET], [FIYAT], [URUNSERINO]) VALUES (4, 5, 4, 5, CAST(N'2024-03-03T00:00:00' AS SmallDateTime), 1, CAST(20000.00 AS Decimal(18, 2)), N'LPT12')
INSERT [dbo].[TBLURUNHAREKET] ([HARAKET], [URUN], [MUSTERI], [PERSONEL], [TARIH], [ADET], [FIYAT], [URUNSERINO]) VALUES (13, 7, 21, 8, CAST(N'2024-03-13T00:00:00' AS SmallDateTime), 1, CAST(8000.00 AS Decimal(18, 2)), N'CMS01')
INSERT [dbo].[TBLURUNHAREKET] ([HARAKET], [URUN], [MUSTERI], [PERSONEL], [TARIH], [ADET], [FIYAT], [URUNSERINO]) VALUES (15, 28, 1, 3, CAST(N'2024-03-13T00:00:00' AS SmallDateTime), 1, CAST(15000.00 AS Decimal(18, 2)), N'BLG11')
INSERT [dbo].[TBLURUNHAREKET] ([HARAKET], [URUN], [MUSTERI], [PERSONEL], [TARIH], [ADET], [FIYAT], [URUNSERINO]) VALUES (18, 2, 18, 11, CAST(N'2024-03-23T00:00:00' AS SmallDateTime), 2, CAST(80000.00 AS Decimal(18, 2)), N'LPT03')
SET IDENTITY_INSERT [dbo].[TBLURUNHAREKET] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLURUNKABUL] ON 

INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (1, 9, 1, CAST(N'2023-07-06T00:00:00' AS SmallDateTime), NULL, N'A7851', 1, N'Parça Bekliyor.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (2, 9, 1, CAST(N'2023-07-06T00:00:00' AS SmallDateTime), NULL, N'A7851', 1, N'Parça Bekliyor.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (3, 5, 3, CAST(N'2023-07-06T00:00:00' AS SmallDateTime), NULL, N'12345', 1, N'Mesaj Bekliyor')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (4, 3, 3, CAST(N'2024-02-09T00:00:00' AS SmallDateTime), NULL, N'UT957', 1, N'Fiyat Verildi.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (5, 6, 2, CAST(N'2024-02-09T00:00:00' AS SmallDateTime), NULL, N'BLG01', 1, N'Ürün Kaydoldu.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (6, 5, 2, CAST(N'2024-02-22T00:00:00' AS SmallDateTime), NULL, N'12345', 1, N'Mesaj Bekliyor.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (7, 16, 5, CAST(N'2024-02-22T00:00:00' AS SmallDateTime), NULL, N'CMS14', 1, N'Iptal Bekliyor.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (8, 17, 3, CAST(N'2024-02-22T00:00:00' AS SmallDateTime), NULL, N'BLG04', 1, N'Mesaj Bekliyor.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (9, 13, 1, CAST(N'2024-02-22T00:00:00' AS SmallDateTime), NULL, N'BLG00', 1, N'Ürün Kaydoldu')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (10, 14, 1, CAST(N'2024-02-22T00:00:00' AS SmallDateTime), NULL, N'ALG01', 1, N'Ürün Kaydoldu.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (11, 1, 2, CAST(N'2024-03-07T00:00:00' AS SmallDateTime), NULL, N'BLG07', NULL, N'Ürün Kaydoldu')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (12, 1, 1, CAST(N'2024-03-07T00:00:00' AS SmallDateTime), NULL, N'BLG01', NULL, N'Ürün Kaydoldu.')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (13, 7, 6, CAST(N'2024-03-07T00:00:00' AS SmallDateTime), NULL, N'BLG02', NULL, N'Ürün Kaydoldu')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (18, 21, 1, CAST(N'2024-03-12T00:00:00' AS SmallDateTime), NULL, N'BLG03', NULL, N'Ürün Kaydoldu')
INSERT [dbo].[TBLURUNKABUL] ([ISLEMID], [CARI], [PERSONEL], [GELISTARIH], [CIKISTARIHI], [URUNSERINO], [URUNDURUM], [URUNDURUMDETAY]) VALUES (19, 1, 1, CAST(N'2024-05-11T00:00:00' AS SmallDateTime), NULL, N'ASD12', NULL, N'Ürün Kaydoldu')
SET IDENTITY_INSERT [dbo].[TBLURUNKABUL] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLURUNTAKIP] ON 

INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (2, N'Ürün teknik serviste onarima alindi', CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (3, N'Ürünün Hdd diski bozuk.Yeni bir hdd disk alinmasi gerekiyor', CAST(N'2023-07-07T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (4, N'Ürün hdd degistirildi, teslim alim için hazir.', CAST(N'2023-07-11T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (5, N'Ürün kargolandi.', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (6, N'Ürün onarim için servise getirildi.', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'A7851')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (7, N'Ürün arizasi tespit edildi, isitici kismi bozuk.', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'A7851')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (8, N'Ürün isitici ünitesi degistirildi.', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'A7851')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (9, N'Ürün kargolandi.', CAST(N'2023-07-10T00:00:00' AS SmallDateTime), N'A7851')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (10, N'DENEME ', CAST(N'2024-02-23T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (11, N'Fiyat verdik haber bekliyoruz.', CAST(N'2024-02-23T00:00:00' AS SmallDateTime), N'UT957')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (12, N'Ürün siparisi iptal edildi', CAST(N'2024-02-23T00:00:00' AS SmallDateTime), N'ALG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (13, N'hala parça bekliyoruz gün sayisini geçti.', CAST(N'2024-02-23T00:00:00' AS SmallDateTime), N'ALG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (14, N'FIYAT', CAST(N'2024-03-12T00:00:00' AS SmallDateTime), N'ALG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (15, N'IPTAL', CAST(N'2024-03-13T00:00:00' AS SmallDateTime), N'ALG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (16, N'KAYIT', CAST(N'2024-03-13T00:00:00' AS SmallDateTime), N'ALG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (17, N'DENEME 2', CAST(N'2024-03-13T00:00:00' AS SmallDateTime), N'BLG01')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (19, N'PARÇA', CAST(N'2024-03-13T00:00:00' AS SmallDateTime), N'AAA11')
INSERT [dbo].[TBLURUNTAKIP] ([TAKIPID], [ACIKLAMA], [TARIH], [SERINO]) VALUES (21, N'ASDASF', CAST(N'2024-03-26T00:00:00' AS SmallDateTime), N'AAA55')
SET IDENTITY_INSERT [dbo].[TBLURUNTAKIP] OFF
GO
SET IDENTITY_INSERT [dbo].[YETKİLENDİRME] ON 

INSERT [dbo].[YETKİLENDİRME] ([KullaniciID], [KullaniciAdi], [Sifre], [YetkiKategori]) VALUES (1, N'kullanici', N'1234', 1)
INSERT [dbo].[YETKİLENDİRME] ([KullaniciID], [KullaniciAdi], [Sifre], [YetkiKategori]) VALUES (2, N'kullanici2', N'1234', 2)
INSERT [dbo].[YETKİLENDİRME] ([KullaniciID], [KullaniciAdi], [Sifre], [YetkiKategori]) VALUES (3, N'kullanici3', N'1234', 3)
INSERT [dbo].[YETKİLENDİRME] ([KullaniciID], [KullaniciAdi], [Sifre], [YetkiKategori]) VALUES (4, N'kullanici4', N'1234', 4)
SET IDENTITY_INSERT [dbo].[YETKİLENDİRME] OFF
GO
ALTER TABLE [dbo].[TBLNOTLARIM] ADD  CONSTRAINT [DF_Table_1_OKUMA]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBLURUN] ADD  CONSTRAINT [DF_TBLURUN_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBLURUNKABUL] ADD  CONSTRAINT [DF_TBLURUNKABUL_GELISTARIH]  DEFAULT (getdate()) FOR [GELISTARIH]
GO
ALTER TABLE [dbo].[TBLFATURABILGI]  WITH CHECK ADD  CONSTRAINT [FK_TBLFATURABILGI_TBLCARI] FOREIGN KEY([CARI])
REFERENCES [dbo].[TBLCARI] ([ID])
GO
ALTER TABLE [dbo].[TBLFATURABILGI] CHECK CONSTRAINT [FK_TBLFATURABILGI_TBLCARI]
GO
ALTER TABLE [dbo].[TBLFATURABILGI]  WITH CHECK ADD  CONSTRAINT [FK_TBLFATURABILGI_TBLPERSONEL] FOREIGN KEY([PERSONEL])
REFERENCES [dbo].[TBLPERSONEL] ([ID])
GO
ALTER TABLE [dbo].[TBLFATURABILGI] CHECK CONSTRAINT [FK_TBLFATURABILGI_TBLPERSONEL]
GO
ALTER TABLE [dbo].[TBLFATURADETAY]  WITH CHECK ADD  CONSTRAINT [FK_TBLFATURADETAY_TBLFATURABILGI] FOREIGN KEY([FATURAID])
REFERENCES [dbo].[TBLFATURABILGI] ([ID])
GO
ALTER TABLE [dbo].[TBLFATURADETAY] CHECK CONSTRAINT [FK_TBLFATURADETAY_TBLFATURABILGI]
GO
ALTER TABLE [dbo].[TBLILCELER]  WITH CHECK ADD  CONSTRAINT [FK_TBLILCELER_TBLILLER] FOREIGN KEY([sehir])
REFERENCES [dbo].[TBLILLER] ([id])
GO
ALTER TABLE [dbo].[TBLILCELER] CHECK CONSTRAINT [FK_TBLILCELER_TBLILLER]
GO
ALTER TABLE [dbo].[TBLPERSONEL]  WITH CHECK ADD  CONSTRAINT [FK_TBLPERSONEL_TBLDEPARTMAN] FOREIGN KEY([DEPARTMAN])
REFERENCES [dbo].[TBLDEPARTMAN] ([ID])
GO
ALTER TABLE [dbo].[TBLPERSONEL] CHECK CONSTRAINT [FK_TBLPERSONEL_TBLDEPARTMAN]
GO
ALTER TABLE [dbo].[TBLURUN]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUN_TBLKATEGORI] FOREIGN KEY([KATEGORI])
REFERENCES [dbo].[TBLKATEGORI] ([ID])
GO
ALTER TABLE [dbo].[TBLURUN] CHECK CONSTRAINT [FK_TBLURUN_TBLKATEGORI]
GO
ALTER TABLE [dbo].[TBLURUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUNHAREKET_TBLCARI] FOREIGN KEY([MUSTERI])
REFERENCES [dbo].[TBLCARI] ([ID])
GO
ALTER TABLE [dbo].[TBLURUNHAREKET] CHECK CONSTRAINT [FK_TBLURUNHAREKET_TBLCARI]
GO
ALTER TABLE [dbo].[TBLURUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUNHAREKET_TBLPERSONEL] FOREIGN KEY([PERSONEL])
REFERENCES [dbo].[TBLPERSONEL] ([ID])
GO
ALTER TABLE [dbo].[TBLURUNHAREKET] CHECK CONSTRAINT [FK_TBLURUNHAREKET_TBLPERSONEL]
GO
ALTER TABLE [dbo].[TBLURUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUNHAREKET_TBLURUN] FOREIGN KEY([URUN])
REFERENCES [dbo].[TBLURUN] ([ID])
GO
ALTER TABLE [dbo].[TBLURUNHAREKET] CHECK CONSTRAINT [FK_TBLURUNHAREKET_TBLURUN]
GO
ALTER TABLE [dbo].[TBLURUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUNHAREKET_TBLURUN1] FOREIGN KEY([URUN])
REFERENCES [dbo].[TBLURUN] ([ID])
GO
ALTER TABLE [dbo].[TBLURUNHAREKET] CHECK CONSTRAINT [FK_TBLURUNHAREKET_TBLURUN1]
GO
ALTER TABLE [dbo].[TBLURUNKABUL]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUNKABUL_TBLCARI] FOREIGN KEY([CARI])
REFERENCES [dbo].[TBLCARI] ([ID])
GO
ALTER TABLE [dbo].[TBLURUNKABUL] CHECK CONSTRAINT [FK_TBLURUNKABUL_TBLCARI]
GO
ALTER TABLE [dbo].[TBLURUNKABUL]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUNKABUL_TBLPERSONEL] FOREIGN KEY([PERSONEL])
REFERENCES [dbo].[TBLPERSONEL] ([ID])
GO
ALTER TABLE [dbo].[TBLURUNKABUL] CHECK CONSTRAINT [FK_TBLURUNKABUL_TBLPERSONEL]
GO
/****** Object:  StoredProcedure [dbo].[makskategoriurun]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[makskategoriurun]	
AS
SELECT TOP 1 TBLKATEGORI.AD FROM TBLURUN 
INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID=TBLURUN.KATEGORI
GROUP BY TBLKATEGORI.AD ORDER BY COUNT(*) DESC

exec makskategoriurun
GO
/****** Object:  StoredProcedure [dbo].[makskategoriurun2]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[makskategoriurun2]	
AS
SELECT TBLKATEGORI.AD, COUNT(*) AS Sayi
FROM TBLURUN 
INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI
GROUP BY TBLKATEGORI.AD
HAVING COUNT(*) = (
    SELECT TOP 1 COUNT(*) AS Sayi
    FROM TBLURUN
    INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI
    GROUP BY TBLKATEGORI.AD
    ORDER BY Sayi DESC
	)
exec makskategoriurun2
GO
/****** Object:  StoredProcedure [dbo].[maksurunmarka]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[maksurunmarka]
AS
SELECT TOP 1 MARKA FROM TBLURUN GROUP BY MARKA
ORDER BY COUNT(*) DESC
GO
/****** Object:  StoredProcedure [dbo].[urunkategori]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[urunkategori]
AS
SELECT TBLKATEGORI.AD,COUNT(TBLURUN.AD) AS 'ADET'
FROM TBLURUN INNER JOIN TBLKATEGORI
ON TBLKATEGORI.ID=TBLURUN.KATEGORI
GROUP BY TBLKATEGORI.AD
ORDER BY ADET
GO
/****** Object:  Trigger [dbo].[Arttir]    Script Date: 13.05.2024 14:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[Arttir]
On [dbo].[TBLKATEGORI]
After insert
as
update tbl1 set toplam = toplam +1
GO
ALTER TABLE [dbo].[TBLKATEGORI] ENABLE TRIGGER [Arttir]
GO
/****** Object:  Trigger [dbo].[STOKAZALT]    Script Date: 13.05.2024 14:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[STOKAZALT]
On [dbo].[TBLURUNHAREKET]
After insert
as
DECLARE @URUN int
DECLARE @ADET int
SELECT @URUN = URUN , @ADET = ADET FROM inserted
UPDATE TBLURUN SET STOK = STOK-@ADET WHERE ID=@URUN
GO
ALTER TABLE [dbo].[TBLURUNHAREKET] ENABLE TRIGGER [STOKAZALT]
GO
