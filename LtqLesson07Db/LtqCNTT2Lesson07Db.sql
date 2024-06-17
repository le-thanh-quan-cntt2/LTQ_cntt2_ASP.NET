USE [LtqCNTT2Lesson07Db]
GO
/****** Object:  Table [dbo].[ltqKhoa]    Script Date: 17/06/2024 2:40:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ltqKhoa](
	[LtqMaKH] [nchar](10) NOT NULL,
	[LtqtenKH] [nvarchar](50) NULL,
	[LtqTrangThai] [bit] NULL,
 CONSTRAINT [PK_ltqKhoa] PRIMARY KEY CLUSTERED 
(
	[LtqMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ltqSinhVien]    Script Date: 17/06/2024 2:40:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ltqSinhVien](
	[LtqMaSV] [nvarchar](50) NOT NULL,
	[LtqHoSV] [nvarchar](50) NULL,
	[LtqTenSV] [nvarchar](50) NULL,
	[LtqNgaySinh] [date] NULL,
	[LtqPhai] [bit] NULL,
	[LtqPhone] [nchar](10) NULL,
	[LtqEmail] [nvarchar](50) NULL,
	[LtqMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_ltqSinhVien] PRIMARY KEY CLUSTERED 
(
	[LtqMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ltqKhoa] ([LtqMaKH], [LtqtenKH], [LtqTrangThai]) VALUES (N'CNTT3     ', N'CNTT2', 1)
GO
INSERT [dbo].[ltqSinhVien] ([LtqMaSV], [LtqHoSV], [LtqTenSV], [LtqNgaySinh], [LtqPhai], [LtqPhone], [LtqEmail], [LtqMaKH]) VALUES (N'2210900057', N'Lê Thanh', N'Quan', CAST(N'2004-04-05' AS Date), 1, N'0357695529', N'quanlekrn01@gmail.com', N'CNTT2     ')
GO
