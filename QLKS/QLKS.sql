USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 22/12/2020 4:17:35 CH ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLKS.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLKS_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLKS]
GO
/****** Object:  UserDefinedFunction [dbo].[autopass]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[autopass](@id int,@ch char(2)) 
Returns char(10) 
As 
Begin 
 	 Return (@ch+char(@id / 2600000 % 26 + 65) + 
    			  char(@id / 1000000 % 10 + 48 ) + 
			  char(@id / 100000 % 15 + 32) +
   	 		  char(@id / 10000 % 26 + 97) + 
    			  char(@id / 1000 % 28 + 63) + 
			  char(@id/100 %27 +64)+
			  char(@id/10 %28 +95)+
    			  char(@id % 10 + 48)) 
  End

GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chucvu](
	[macv] [varchar](2) NOT NULL,
	[tencv] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[macv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ctdp]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ctdp](
	[maphong] [varchar](5) NOT NULL,
	[makh] [varchar](5) NOT NULL,
	[hoten] [nvarchar](30) NULL,
	[madv] [varchar](5) NOT NULL,
	[ngayden] [datetime] NULL,
	[ngaydi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[maphong] ASC,
	[makh] ASC,
	[madv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dangnhap](
	[tendangnhap] [nvarchar](20) NOT NULL,
	[matkhau] [nvarchar](20) NOT NULL,
	[maquyen] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[datphong]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[datphong](
	[madp] [varchar](5) NOT NULL,
	[manv] [varchar](5) NOT NULL,
	[makh] [varchar](5) NOT NULL,
	[maphong] [varchar](5) NOT NULL,
	[ngaydat] [datetime] NOT NULL DEFAULT (getdate()),
	[ngayden] [datetime] NOT NULL DEFAULT (getdate()),
	[ngaydi] [datetime] NOT NULL DEFAULT (getdate()),
	[tiendatcoc] [int] NULL,
	[soluong] [int] NOT NULL,
	[trangthai] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[madp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dichvu](
	[madv] [varchar](5) NOT NULL,
	[tendv] [nvarchar](30) NOT NULL,
	[giadv] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[madv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahd] [varchar](5) NOT NULL,
	[maphong] [varchar](5) NOT NULL,
	[makh] [varchar](5) NOT NULL,
	[ngayden] [datetime] NOT NULL DEFAULT (getdate()),
	[ngaydi] [datetime] NOT NULL DEFAULT (getdate()),
	[thanhtien] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [varchar](5) NOT NULL,
	[hoten] [nvarchar](30) NOT NULL,
	[gioitinh] [nvarchar](3) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[sdt] [varchar](10) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[tendangnhap] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lichlamviec]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lichlamviec](
	[malich] [varchar](5) NOT NULL,
	[manv] [varchar](5) NULL,
	[ca] [nvarchar](5) NULL,
	[ngaylv] [datetime] NOT NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[malich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [varchar](5) NOT NULL,
	[macv] [varchar](2) NOT NULL,
	[hoten] [nvarchar](30) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[gioitinh] [nvarchar](3) NOT NULL,
	[sdt] [varchar](12) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[tendangnhap] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phong]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phong](
	[maphong] [varchar](5) NOT NULL,
	[tenlp] [nvarchar](20) NULL,
	[tinhtrang] [nvarchar](20) NULL,
	[giaphong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[quyen]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[quyen](
	[maquyen] [varchar](5) NOT NULL,
	[tenquyen] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[hhtt]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create view [dbo].[hhtt] as 

 SELECT dbo.ctdp.ngayden as 'Ngày đến', dbo.ctdp.ngaydi as 'Ngày đi', dbo.dichvu.giadv as 'Dịch vụ', dbo.phong.giaphong as 'Giá phòng'
FROM   dbo.ctdp INNER JOIN
             dbo.dichvu ON dbo.ctdp.madv = dbo.dichvu.madv INNER JOIN
             dbo.phong ON dbo.ctdp.maphong = dbo.phong.maphong 
GO
/****** Object:  View [dbo].[hhtt_kh]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hhtt_kh] as 

 SELECT dbo.ctdp.maphong as 'Mã Phòng', dbo.ctdp.hoten as 'Tên Khách Hàng', dbo.ctdp.ngayden as 'Ngày Đến', dbo.ctdp.ngaydi as ' Ngày Đi', dbo.dichvu.giadv as ' Giá Dịch Vụ', dbo.dichvu.tendv as ' Tên Dịch Vụ', dbo.phong.giaphong as 'Giá Phòng'
FROM   dbo.ctdp INNER JOIN
             dbo.dichvu ON dbo.ctdp.madv = dbo.dichvu.madv INNER JOIN
             dbo.khachhang ON dbo.ctdp.makh = dbo.khachhang.makh INNER JOIN
             dbo.phong ON dbo.ctdp.maphong = dbo.phong.maphong
GO
/****** Object:  View [dbo].[trong_view]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[trong_view] as
select tinhtrang
from phong
where tinhtrang=N'Phòng Trống'

GO
/****** Object:  View [dbo].[View_1]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT dbo.ctdp.ngayden, dbo.ctdp.ngaydi, dbo.dichvu.giadv, dbo.phong.giaphong, dbo.ctdp.hoten, dbo.ctdp.madv, dbo.ctdp.maphong
FROM   dbo.ctdp INNER JOIN
             dbo.dichvu ON dbo.ctdp.madv = dbo.dichvu.madv INNER JOIN
             dbo.phong ON dbo.ctdp.maphong = dbo.phong.maphong

GO
/****** Object:  View [dbo].[View_2]    Script Date: 22/12/2020 4:17:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_2]
AS
SELECT dbo.ctdp.maphong, dbo.ctdp.hoten, dbo.ctdp.ngayden, dbo.ctdp.ngaydi, dbo.dichvu.giadv, dbo.dichvu.tendv, dbo.phong.giaphong
FROM   dbo.ctdp INNER JOIN
             dbo.dichvu ON dbo.ctdp.madv = dbo.dichvu.madv INNER JOIN
             dbo.khachhang ON dbo.ctdp.makh = dbo.khachhang.makh INNER JOIN
             dbo.phong ON dbo.ctdp.maphong = dbo.phong.maphong

GO
INSERT [dbo].[chucvu] ([macv], [tencv]) VALUES (N'NV', N'Nhân Viên')
INSERT [dbo].[chucvu] ([macv], [tencv]) VALUES (N'QT', N'Người Quản Trị')
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'D001', N'KH001', N'Minh Đủ', N'DV003', CAST(N'2020-12-23 00:00:00.000' AS DateTime), CAST(N'2020-12-25 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'D003', N'KH001', N'Minh Đủ', N'DV010', CAST(N'2020-12-21 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'D003', N'KH002', N'Ngân', N'DV004', CAST(N'2020-12-21 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'S001', N'KH001', N'Minh Đủ', N'DV001', CAST(N'2020-12-21 00:00:00.000' AS DateTime), CAST(N'2020-12-21 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'S001', N'KH002', N'Ngân', N'DV006', CAST(N'2020-12-22 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'S001', N'KH002', N'Ngân', N'DV008', CAST(N'2020-12-22 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'S003', N'KH001', N'Minh Đủ', N'DV002', CAST(N'2020-12-21 00:00:00.000' AS DateTime), CAST(N'2020-12-21 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'S003', N'KH001', N'Minh Đủ', N'DV009', CAST(N'2020-12-22 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'S003', N'KH001', N'Minh Đủ', N'DV012', CAST(N'2020-12-22 00:00:00.000' AS DateTime), CAST(N'2020-12-22 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'T005', N'KH002', N'Ngân', N'DV007', CAST(N'2020-12-21 00:00:00.000' AS DateTime), CAST(N'2020-12-24 00:00:00.000' AS DateTime))
INSERT [dbo].[ctdp] ([maphong], [makh], [hoten], [madv], [ngayden], [ngaydi]) VALUES (N'V001', N'KH001', N'Minh Đủ', N'DV009', CAST(N'2020-12-21 00:00:00.000' AS DateTime), CAST(N'2020-12-26 00:00:00.000' AS DateTime))
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'minhdu', N'123456', N'C')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'ngan', N'123456', N'A')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'ngocngan', N'123456', N'C')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'phuongdai', N'123456', N'B')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'quocnghi', N'123456', N'B')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'thanhly', N'123456', N'A')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'thanhngan', N'123456', N'C')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'thanhtruc', N'123456', N'B')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'trangdai', N'123456', N'C')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'trucnhan', N'123456', N'B')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'truonganh', N'123456', N'B')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'tuongvi', N'654789', N'B')
INSERT [dbo].[dangnhap] ([tendangnhap], [matkhau], [maquyen]) VALUES (N'Tuyetanh', N'123456', N'B')
INSERT [dbo].[datphong] ([madp], [manv], [makh], [maphong], [ngaydat], [ngayden], [ngaydi], [tiendatcoc], [soluong], [trangthai]) VALUES (N'DP007', N'NV001', N'KH003', N'S004', CAST(N'2020-10-12 00:00:00.000' AS DateTime), CAST(N'2020-11-12 00:00:00.000' AS DateTime), CAST(N'2020-12-12 00:00:00.000' AS DateTime), 5000000, 1, N'Ðã d?t')
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV001', N'Bữa Sáng', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV002', N'Bữa Trưa', 200000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV003', N'Bữa Tối', 500000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV004', N'Đưa Đón Sân Bay', 200000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV005', N'Cho thuê xe tự lái', 2000000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV006', N'Bể bơi bốn mùa', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV007', N'Karaoke', 100000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV008', N'Quầy Bar', 200000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV009', N'Giặt Ủi', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV010', N'Phòng tập thể thao', 50000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV011', N'Sân tennis', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV012', N'Đặt vé máy bay, tour du lịch', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV013', N'Trông trẻ', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV014', N'Minibar tại phòng ', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'DV015', N'Văn Phòng', 0)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'fff', N'dff', 10000)
INSERT [dbo].[dichvu] ([madv], [tendv], [giadv]) VALUES (N'fsd', N'ghh', 10000)
INSERT [dbo].[hoadon] ([mahd], [maphong], [makh], [ngayden], [ngaydi], [thanhtien]) VALUES (N'HD002', N'S003', N'KH002', CAST(N'2020-11-14 00:00:00.000' AS DateTime), CAST(N'2020-11-16 00:00:00.000' AS DateTime), 2400000.0000)
INSERT [dbo].[khachhang] ([makh], [hoten], [gioitinh], [cmnd], [sdt], [diachi], [tendangnhap]) VALUES (N'KH001', N'Minh Đủ', N'Nam', N'987456321', N'0321456987', N'Vĩnh Long', N'minhdu')
INSERT [dbo].[khachhang] ([makh], [hoten], [gioitinh], [cmnd], [sdt], [diachi], [tendangnhap]) VALUES (N'KH002', N'Ngâ', N'Nam', N'325641789', N'0214569873', N'Vinh Long', N'ngocngan')
INSERT [dbo].[khachhang] ([makh], [hoten], [gioitinh], [cmnd], [sdt], [diachi], [tendangnhap]) VALUES (N'KH003', N'Trang Đài', N'Nữ', N'123654789', N'0654789321', N'Vĩnh Long', N'trangdai')
INSERT [dbo].[khachhang] ([makh], [hoten], [gioitinh], [cmnd], [sdt], [diachi], [tendangnhap]) VALUES (N'KH004', N'Thanh Ngân', N'Nữ', N'456789123', N'0123654789', N'Vĩnh Long', N'thanhngan')
INSERT [dbo].[lichlamviec] ([malich], [manv], [ca], [ngaylv]) VALUES (N'L1', N'NV005', N'Sáng', CAST(N'2020-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[lichlamviec] ([malich], [manv], [ca], [ngaylv]) VALUES (N'L2', N'NV006', N'Trưa', CAST(N'2020-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[lichlamviec] ([malich], [manv], [ca], [ngaylv]) VALUES (N'L3', N'NV005', N'Sáng', CAST(N'2020-11-24 00:00:00.000' AS DateTime))
INSERT [dbo].[nhanvien] ([manv], [macv], [hoten], [ngaysinh], [gioitinh], [sdt], [cmnd], [diachi], [tendangnhap]) VALUES (N'NV001', N'NV', N'Tuyết Anh', CAST(N'2000-12-21 00:00:00.000' AS DateTime), N'Nữ', N'0123654789', N'987654321', N'Vĩnh Long', N'Tuyetanh')
INSERT [dbo].[nhanvien] ([manv], [macv], [hoten], [ngaysinh], [gioitinh], [sdt], [cmnd], [diachi], [tendangnhap]) VALUES (N'NV002', N'NV', N'Võ Quốc Nghi', CAST(N'2000-12-21 00:00:00.000' AS DateTime), N'Nam', N'0123654789', N'321654789', N'Vinh Long', N'quocnghi')
INSERT [dbo].[nhanvien] ([manv], [macv], [hoten], [ngaysinh], [gioitinh], [sdt], [cmnd], [diachi], [tendangnhap]) VALUES (N'NV004', N'QT', N'Tuongvi', CAST(N'2000-12-06 00:00:00.000' AS DateTime), N'Nữ', N'0321456987', N'987456321', N'Vĩnh Long', N'tuongvi')
INSERT [dbo].[nhanvien] ([manv], [macv], [hoten], [ngaysinh], [gioitinh], [sdt], [cmnd], [diachi], [tendangnhap]) VALUES (N'NV005', N'NV', N'Phuong dai', CAST(N'1990-12-21 00:00:00.000' AS DateTime), N'Nam', N'0123654789', N'321654986', N'Vinh Long', N'phuongdai')
INSERT [dbo].[nhanvien] ([manv], [macv], [hoten], [ngaysinh], [gioitinh], [sdt], [cmnd], [diachi], [tendangnhap]) VALUES (N'NV006', N'NV', N'Trúc Nhân', CAST(N'2000-12-22 00:00:00.000' AS DateTime), N'Nữ', N'0125487963', N'654778912', N'Vĩnh Long', N'trucnhan')
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D001', N'Phòng Đôi', N'Phòng Đầy', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D002', N'Phòng Đôi', N'Phòng Trống', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D003', N'Phòng Đôi', N'Phòng Đầy', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D004', N'Phòng Đôi', N'Phòng Trống', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D005', N'Phòng Đôi', N'Phòng Đang Dọn Dẹp', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D006', N'Phòng Đôi', N'Phòng Đang Dọn Dẹp', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D007', N'Phòng Đôi', N'Phòng Trống', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'D008', N'Phòng Đôi', N'Phòng Đầy', 1500000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S001', N'Phòng Đơn', N'Phòng Đầy', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S002', N'Phòng Đơn', N'Phòng Đầy', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S003', N'Phòng Đơn', N'Phòng Đầy', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S004', N'Phòng Đơn', N'Phòng Đang Dọn Dẹp', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S005', N'Phòng Đơn', N'Phòng Trống', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S006', N'Phòng Đơn', N'Phòng Đầy', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S007', N'Phòng Đơn', N'Phòng Đầy', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'S008', N'Phòng Đơn', N'Phòng Đầy', 1000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T001', N'Phòng Tập Thể', N'Phòng Đầy', 220000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T002', N'Phòng Tập Thể', N'Phòng Đầy', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T003', N'Phòng Tập Thể', N'Phòng Đầy', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T004', N'Phòng Tập Thể', N'Phòng Đầy', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T005', N'Phòng Tập Thể', N'Phòng Ð?y', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T006', N'Phòng Tập Thể', N'Phòng Đang Dọn Dẹp', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T007', N'Phòng Tập Thể', N'Phòng Đang Dọn Dẹp', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'T008', N'Phòng Tập Thể', N'Phòng Đang Dọn Dẹp', 2200000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'V001', N'Phòng VIP', N'Phòng Đầy', 3000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'V002', N'Phòng VIP', N'Phòng Trống', 3000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'V003', N'Phòng VIP', N'Phòng Trống', 3000000)
INSERT [dbo].[phong] ([maphong], [tenlp], [tinhtrang], [giaphong]) VALUES (N'V004', N'Phòng VIP', N'Phòng Trống', 3000000)
INSERT [dbo].[quyen] ([maquyen], [tenquyen]) VALUES (N'A', N'Quản trị')
INSERT [dbo].[quyen] ([maquyen], [tenquyen]) VALUES (N'B', N'Nhân viên')
INSERT [dbo].[quyen] ([maquyen], [tenquyen]) VALUES (N'C', N'Khách')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__khachhan__22BEB80D90D3E9E3]    Script Date: 22/12/2020 4:17:35 CH ******/
ALTER TABLE [dbo].[khachhang] ADD UNIQUE NONCLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__khachhan__CE900A1E6B9B96FE]    Script Date: 22/12/2020 4:17:35 CH ******/
ALTER TABLE [dbo].[khachhang] ADD UNIQUE NONCLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__nhanvien__22BEB80D2262BAB2]    Script Date: 22/12/2020 4:17:35 CH ******/
ALTER TABLE [dbo].[nhanvien] ADD UNIQUE NONCLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ctdp]  WITH CHECK ADD  CONSTRAINT [fk_madv] FOREIGN KEY([madv])
REFERENCES [dbo].[dichvu] ([madv])
GO
ALTER TABLE [dbo].[ctdp] CHECK CONSTRAINT [fk_madv]
GO
ALTER TABLE [dbo].[ctdp]  WITH CHECK ADD  CONSTRAINT [fk_makh] FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[ctdp] CHECK CONSTRAINT [fk_makh]
GO
ALTER TABLE [dbo].[ctdp]  WITH CHECK ADD  CONSTRAINT [fk_map] FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[ctdp] CHECK CONSTRAINT [fk_map]
GO
ALTER TABLE [dbo].[dangnhap]  WITH CHECK ADD FOREIGN KEY([maquyen])
REFERENCES [dbo].[quyen] ([maquyen])
GO
ALTER TABLE [dbo].[dangnhap]  WITH CHECK ADD  CONSTRAINT [FK_dangnhap_quyen] FOREIGN KEY([maquyen])
REFERENCES [dbo].[quyen] ([maquyen])
GO
ALTER TABLE [dbo].[dangnhap] CHECK CONSTRAINT [FK_dangnhap_quyen]
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[datphong]  WITH CHECK ADD FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD FOREIGN KEY([maphong])
REFERENCES [dbo].[phong] ([maphong])
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD  CONSTRAINT [consFK_khachhang] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[dangnhap] ([tendangnhap])
GO
ALTER TABLE [dbo].[khachhang] CHECK CONSTRAINT [consFK_khachhang]
GO
ALTER TABLE [dbo].[lichlamviec]  WITH CHECK ADD FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [consFK_nhanvien] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[dangnhap] ([tendangnhap])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [consFK_nhanvien]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([macv])
REFERENCES [dbo].[chucvu] ([macv])
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD CHECK  (([cmnd] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD CHECK  (([gioitinh]=N'Nữ' OR [gioitinh]=N'Nam'))
GO
ALTER TABLE [dbo].[khachhang]  WITH CHECK ADD CHECK  (([sdt] like '[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD CHECK  (([cmnd] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD CHECK  (([gioitinh]=N'Nữ' OR [gioitinh]=N'Nam'))
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD CHECK  (([ngaysinh]<getdate()))
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD CHECK  (([sdt] like '[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ctdp"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "dichvu"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "phong"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ctdp"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "dichvu"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "khachhang"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "phong"
            Begin Extent = 
               Top = 9
               Left = 894
               Bottom = 206
               Right = 1116
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
