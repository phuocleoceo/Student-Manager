USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2/13/2021 9:44:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2/13/2021 9:44:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [nvarchar](100) NULL,
	[Ten] [nvarchar](100) NULL,
	[NgaySinh] [datetime2](7) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[NganhHoc] [nvarchar](100) NULL,
	[MaSinhVien] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Id], [UserName], [PassWord]) VALUES (1, N'1', N'1')
INSERT [dbo].[Account] ([Id], [UserName], [PassWord]) VALUES (2, N'phuoc', N'1')
INSERT [dbo].[Account] ([Id], [UserName], [PassWord]) VALUES (3, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([Id], [Ho], [Ten], [NgaySinh], [GioiTinh], [DiaChi], [NganhHoc], [MaSinhVien], [Email]) VALUES (1, N'Trương Minh', N'Phước', CAST(N'2001-08-10T00:00:00.0000000' AS DateTime2), 1, N'Quảng Trị', N'CNTT', NULL, NULL)
INSERT [dbo].[SinhVien] ([Id], [Ho], [Ten], [NgaySinh], [GioiTinh], [DiaChi], [NganhHoc], [MaSinhVien], [Email]) VALUES (2, N'Lê Mạnh', N'Duy', CAST(N'2001-03-03T00:00:00.0000000' AS DateTime2), 1, N'Đà Nẵng', N'CNTT', NULL, NULL)
INSERT [dbo].[SinhVien] ([Id], [Ho], [Ten], [NgaySinh], [GioiTinh], [DiaChi], [NganhHoc], [MaSinhVien], [Email]) VALUES (3, N'Nguyễn Khoa', N'Hoàng', CAST(N'2001-04-04T00:00:00.0000000' AS DateTime2), 1, N'Huế', N'CNTT', NULL, NULL)
INSERT [dbo].[SinhVien] ([Id], [Ho], [Ten], [NgaySinh], [GioiTinh], [DiaChi], [NganhHoc], [MaSinhVien], [Email]) VALUES (4, N'Trương Thạch Kim', N'Ngân', CAST(N'2001-05-05T00:00:00.0000000' AS DateTime2), 0, N'Quảng Nam', N'CNTT', NULL, NULL)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Account__C9F2845638E40812]    Script Date: 2/13/2021 9:44:37 AM ******/
ALTER TABLE [dbo].[Account] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
