USE [LtqCNTT2_Lesson10Db]
GO
/****** Object:  Table [dbo].[Ltq_Ketqua]    Script Date: 24/06/2024 3:08:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ltq_Ketqua](
	[LtqMaSV] [nchar](10) NOT NULL,
	[LtqMaMH] [nchar](10) NOT NULL,
	[LtqDiem] [nchar](10) NULL,
 CONSTRAINT [PK_Ltq_Ketqua] PRIMARY KEY CLUSTERED 
(
	[LtqMaSV] ASC,
	[LtqMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ltq_Monhoc]    Script Date: 24/06/2024 3:08:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ltq_Monhoc](
	[LtqMaMH] [nchar](10) NOT NULL,
	[LtqTenMH] [nvarchar](50) NULL,
	[LtqSotiet] [int] NULL,
 CONSTRAINT [PK_Ltq_Monhoc] PRIMARY KEY CLUSTERED 
(
	[LtqMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ltq_SinhVien]    Script Date: 24/06/2024 3:08:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ltq_SinhVien](
	[LtqMaSV] [nchar](10) NOT NULL,
	[LtqHoSV] [nvarchar](50) NULL,
	[LtqTenSV] [nvarchar](50) NULL,
	[LtqPhai] [bit] NULL,
	[LtqNgaySinh] [date] NULL,
	[LtqNoiSinh] [nvarchar](50) NULL,
	[LtqMaKH] [nchar](10) NULL,
	[LtqHocBong] [float] NULL,
	[LtqDiemTrungBinh] [float] NULL,
 CONSTRAINT [PK_Ltq_SinhVien] PRIMARY KEY CLUSTERED 
(
	[LtqMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ltqKhoa]    Script Date: 24/06/2024 3:08:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ltqKhoa](
	[LtqMaKH] [nchar](10) NOT NULL,
	[LtqTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_ltqKhoa] PRIMARY KEY CLUSTERED 
(
	[LtqMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ltq_Ketqua] ([LtqMaSV], [LtqMaMH], [LtqDiem]) VALUES (N'2210900012', N'KTLT      ', N'6         ')
INSERT [dbo].[Ltq_Ketqua] ([LtqMaSV], [LtqMaMH], [LtqDiem]) VALUES (N'2210900057', N'CSDL      ', N'8         ')
GO
INSERT [dbo].[Ltq_Monhoc] ([LtqMaMH], [LtqTenMH], [LtqSotiet]) VALUES (N'CSDL      ', N'Cơ sở dữ liệu', 40)
INSERT [dbo].[Ltq_Monhoc] ([LtqMaMH], [LtqTenMH], [LtqSotiet]) VALUES (N'KTLT      ', N'Kĩ thuật lập trình', 50)
GO
INSERT [dbo].[Ltq_SinhVien] ([LtqMaSV], [LtqHoSV], [LtqTenSV], [LtqPhai], [LtqNgaySinh], [LtqNoiSinh], [LtqMaKH], [LtqHocBong], [LtqDiemTrungBinh]) VALUES (N'2210900012', N'Nguyên Văn', N'A', 1, CAST(N'2004-09-03' AS Date), N'Hà Nội', N'220123456 ', 0, 6)
INSERT [dbo].[Ltq_SinhVien] ([LtqMaSV], [LtqHoSV], [LtqTenSV], [LtqPhai], [LtqNgaySinh], [LtqNoiSinh], [LtqMaKH], [LtqHocBong], [LtqDiemTrungBinh]) VALUES (N'2210900057', N'Lê Thanh', N'Quan', 1, CAST(N'2004-04-05' AS Date), N'Phú Thọ', N'220123456 ', 0, 8)
GO
INSERT [dbo].[ltqKhoa] ([LtqMaKH], [LtqTenKH]) VALUES (N'220123456 ', N'K22CNTT2')
GO
ALTER TABLE [dbo].[Ltq_Ketqua]  WITH CHECK ADD  CONSTRAINT [FK_Ltq_Ketqua_Ltq_Monhoc] FOREIGN KEY([LtqMaMH])
REFERENCES [dbo].[Ltq_Monhoc] ([LtqMaMH])
GO
ALTER TABLE [dbo].[Ltq_Ketqua] CHECK CONSTRAINT [FK_Ltq_Ketqua_Ltq_Monhoc]
GO
ALTER TABLE [dbo].[Ltq_Ketqua]  WITH CHECK ADD  CONSTRAINT [FK_Ltq_Ketqua_Ltq_SinhVien] FOREIGN KEY([LtqMaSV])
REFERENCES [dbo].[Ltq_SinhVien] ([LtqMaSV])
GO
ALTER TABLE [dbo].[Ltq_Ketqua] CHECK CONSTRAINT [FK_Ltq_Ketqua_Ltq_SinhVien]
GO
ALTER TABLE [dbo].[Ltq_SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_Ltq_SinhVien_ltqKhoa] FOREIGN KEY([LtqMaKH])
REFERENCES [dbo].[ltqKhoa] ([LtqMaKH])
GO
ALTER TABLE [dbo].[Ltq_SinhVien] CHECK CONSTRAINT [FK_Ltq_SinhVien_ltqKhoa]
GO
