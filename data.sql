USE [QuanLyBanhangdientu]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[ID_banner] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[link] [text] NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[ID_banner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoHanh]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHanh](
	[MaHH] [varchar](50) NOT NULL,
	[ID_Xuat] [varchar](50) NOT NULL,
	[ThoiGianBaoHanh] [datetime] NULL,
 CONSTRAINT [PK_BaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC,
	[ID_Xuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHD_Nhap]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD_Nhap](
	[MAHD_Nhap] [varchar](50) NOT NULL,
	[MAHH] [varchar](5) NOT NULL,
	[SoLuong_Nhap] [int] NULL,
	[DonGia_Nhap] [float] NOT NULL,
	[Thanhtien] [float] NULL,
	[DonVi] [nvarchar](50) NULL,
	[Vat] [int] NULL,
 CONSTRAINT [PK_ChiTietHD_Nhap] PRIMARY KEY CLUSTERED 
(
	[MAHD_Nhap] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHD_Xuat]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD_Xuat](
	[MAHD_Xuat] [varchar](50) NOT NULL,
	[MAHH] [varchar](5) NOT NULL,
	[SoLuong_Xuat] [int] NULL,
	[DonGia_Xuat] [float] NULL,
	[ThanhTienXuat] [float] NULL,
	[Vat] [int] NOT NULL,
	[DonVi] [nvarchar](50) NULL,
	[username] [varchar](50) NULL,
 CONSTRAINT [PK_ChiTietHD_Xuat_1] PRIMARY KEY CLUSTERED 
(
	[MAHD_Xuat] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCv] [varchar](50) NOT NULL,
	[TenCv] [nvarchar](50) NULL,
	[LCB] [float] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [varchar](5) NOT NULL,
	[MaLoai] [varchar](5) NULL,
	[Duongdan] [nvarchar](max) NULL,
	[TenHH] [nvarchar](200) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Giabanle] [bigint] NULL,
	[Giabansi] [float] NULL,
	[Gianhap] [float] NULL,
	[SoLuongtonkho] [int] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_Nhap]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_Nhap](
	[MAHD_Nhap] [varchar](50) NOT NULL,
	[MaNC] [varchar](50) NULL,
	[MANV] [varchar](5) NULL,
	[NgayLapHD] [date] NULL,
	[TinhTrangNhap] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MAHD_Nhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_Xuat]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_Xuat](
	[MAHD_Xuat] [varchar](50) NOT NULL,
	[MAKH] [varchar](5) NOT NULL,
	[MANV] [varchar](5) NULL,
	[NgayLap_Xuat] [date] NULL,
	[TinhTrangXuat] [bit] NULL,
 CONSTRAINT [PK_HoaDon_Xuat_1] PRIMARY KEY CLUSTERED 
(
	[MAHD_Xuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](5) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[Maloaikh] [varchar](5) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[IDKho] [int] IDENTITY(1,1) NOT NULL,
	[MAHH] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_Kho_1] PRIMARY KEY CLUSTERED 
(
	[IDKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLoai] [varchar](5) NOT NULL,
	[TenLoai] [nvarchar](200) NOT NULL,
	[Linkloaihang] [text] NOT NULL,
	[TinhTrangHang] [bit] NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 7/31/2020 11:26:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[Maloaikh] [varchar](5) NOT NULL,
	[Tenloaikh] [nvarchar](50) NULL,
	[soluongkh] [int] NULL,
 CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY CLUSTERED 
(
	[Maloaikh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[UserName] [varchar](50) NOT NULL,
	[PassWord] [varchar](200) NULL,
	[Loai] [varchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [varchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[NgayVaoLam] [date] NOT NULL,
	[NgayKetThuc] [date] NULL,
	[MaCV] [varchar](50) NULL,
	[Luong] [float] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuChi](
	[MaPhieuChi] [varchar](5) NOT NULL,
	[DoiTuong] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaNV] [varchar](5) NULL,
	[Sotienchi] [money] NULL,
	[NgayGhiNhan] [date] NULL,
 CONSTRAINT [PK_PhieuChi] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[MaPhieuChi] [varchar](5) NOT NULL,
	[DoiTuong] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaNV] [varchar](5) NULL,
	[Sotienchi] [money] NULL,
	[Ngayghinhan] [date] NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanTriNguoiDung]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTriNguoiDung](
	[ID_I] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NULL,
	[MANV] [varchar](5) NULL,
	[MaCV] [varchar](50) NULL,
 CONSTRAINT [PK_QuanTriNguoiDung] PRIMARY KEY CLUSTERED 
(
	[ID_I] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserKhachHang]    Script Date: 7/31/2020 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserKhachHang](
	[UserName] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[MaKH] [varchar](5) NULL,
 CONSTRAINT [PK_UserKhachHang] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Banner] ON 

INSERT [dbo].[Banner] ([ID_banner], [name], [link]) VALUES (1, N'baner1', N'https://i.imgur.com/xa1cqiV.jpg')
INSERT [dbo].[Banner] ([ID_banner], [name], [link]) VALUES (2, N'banner2', N'https://i.imgur.com/Yzjuawf.jpg')
INSERT [dbo].[Banner] ([ID_banner], [name], [link]) VALUES (3, N'banner3', N'https://i.imgur.com/cWn6U0x.png')
INSERT [dbo].[Banner] ([ID_banner], [name], [link]) VALUES (4, N'banner4', N'https://i.imgur.com/uTPXnk9.png')
INSERT [dbo].[Banner] ([ID_banner], [name], [link]) VALUES (5, N'banner5', N'https://i.imgur.com/I4MpOPy.jpg')
SET IDENTITY_INSERT [dbo].[Banner] OFF
INSERT [dbo].[ChucVu] ([MaCv], [TenCv], [LCB]) VALUES (N'CV001', N'Quản Lý', 130000)
INSERT [dbo].[ChucVu] ([MaCv], [TenCv], [LCB]) VALUES (N'CV002', N'Nhân Viên', 20000)
INSERT [dbo].[ChucVu] ([MaCv], [TenCv], [LCB]) VALUES (N'CV003', N'Admin', 3000)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH001', N'LH006', N'https://i.imgur.com/jYgfio4.jpg', N'Ram Laptop Crucial DDR4 4GB Bus 2666', N'Thanh', N'More speed. More battery life. More memory capacity. Fuel your next-gen laptop.

Ram Laptop Crucial DDR4 4GB Bus 2666 phá vỡ mọi giới hạn tốc độ của DDR3 khi bị thắt cổ chai. Cải thiện hiệu suất máy tính, tiết kiệm năng lượng hơn và dung lượng lớn hơn rất nhiều, hỗ trợ tất cả các dòng vi xử lý thế hệ mới nhất - Xung bus cực cao lên đến 2666 MT/s. - Khả năng tăng băng thông lên đến 30%. - Giảm tiêu thụ năng lượng lên đến 40% và kéo dài tuổi thọ pin. - Tăng tốc độ truy cập để cải thiện thông lượng dữ liệu tuần tự. - Tối ưu hóa cho các bộ xử lý và các nền tảng thế hệ mới nhất. - Dung lượng module lên đến 32GB. - Thời hạn bảo hành lên đến 36 tháng.', 490000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH002', N'LH001', N'https://i.imgur.com/hrlk69H.jpg', N'Ram Laptop Kingston DDR4 8GB Bus 2400', N'Thanh', N'Ram Kingston DDR4 2400MHz tự hào là bộ nhớ có tần số nhanh nhất thế giới SO-DIMM - 2400MHz - đáp ứng mọi nhu cầu của mọi nền tảng máy tính. Tự động nhận dạng các nền tảng được cắm vào, không cần phải điều chỉnh bất kì thiết lập nào trong hệ thống BIOS. Vì vậy, bạn sẽ có được hiệu suất cực cao nhờ các công nghệ của các bộ xử lý AMD hoặc các công nghệ Intel CPU mới nhất một cách dễ dàng - ngay cả khi bạn là một Newbie. Ram Kingston DDR4 2400MHz mang đến cho bạn trải nghiệm cực tốt khi chơi Games hay dùng những chương trình nặng mà vẫn giữ hệ thống của bạn mát mẻ. Được thiết kế với điện áp thấp ở 1.2V cho tiêu thụ điện năng ít hơn, giảm sinh nhiệt và hoạt động yên tĩnh. Kiểu dáng mỏng đẹp làm nổi bật hệ thống máy tính của bạn.Nổi trội hơn hết, Ram Kingston DDR4 2400MHz mang lại hiệu năng cao với chi phí thấp. Được bảo hành 3 năm chính hãng và hỗ trợ kỹ thuật miễn phí với độ tin cậy huyền thoại.', 770000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH003', N'LH001', N'https://i.imgur.com/518Unoz.jpg', N'Ram G.Skill Ripjaws DDR4 8GB Bus 2133MHz', N'Thanh', N'Ram Laptop G.SKILL Ripjaws DDR4 SO-DIMM tương thích với các máy tính xách tay chơi game hiệu suất cao và các máy tính có kích thước nhỏ hỗ trợ bộ nhớ DDR4 SO-DIMM. Đây là một trong những cách dễ nhất và hiệu quả nhất để nâng cấp máy tính của bạn, bất kể nhu cầu của bạn là chơi game hay làm việc.', 799000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH004', N'LH001', N'https://i.imgur.com/AI376HI.jpg', N'Ram Laptop Samsung DDR4 4GB Bus 2400MHz', N'Thanh', N'Bạn đang cần giải pháp tăng cường bộ nhớ phù hợp nhất để nâng cao hiệu năng máy tính? Samsung chính là nhà tiên phong hàng đầu trong thị trường bộ nhớ DRAM được tất cả các nhà sản xuất máy tính chọn làm RAM OEM (Original Equipment Manufacturer) trong nhiều năm. Bạn sẽ được trải nghiệm những tính năng tiên tiến nhất của Ram Laptop Samsung DDR4 để đưa máy tính của bạn đến một tâm cao mới với tốc độ siêu cao và độ tiêu thụ điện năng cực thấp.', 495000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH005', N'LH002', N'https://i.imgur.com/GlHZy7k.jpg', N'SSD Kingston A400 SATA 3 120GB', N'Thanh', N'Ổ cứng SSD Kingston A400 Series của Kingston giúp cải thiện tối đa hiệu năng của hệ thống hiện tại với thời gian khởi động, load các chương trình và dữ liệu được giảm tối đa. Bộ điều khiển Controller mới nhất cho tốc độ đọc và ghi lên đến 500MB/s và 450MB/s (bản 480GB), nhanh hơn gấp 10 lần so với ổ cứng HDD truyền thống, đáp ứng tất cả các nhu cầu của bạn. Ổ cứng SSD Kingston A400 hoạt động bằng bộ nhớ Flash, không có các bộ phận chuyển động cơ quay giúp tăng độ bền, hoạt động mát mẻ và không hề tạo ra bất kì tiếng động nào. Và đặc biệt là khả năng chống Sock cực tốt, rất lý tưởng cho máy tính xách tay và các thiết bị máy tính di động khác. Ổ cứng SSD Kingston A400 có nhiều dung lượng từ 120GB-480GB để cung cấp cho bạn tất cả không gian cần thiết cho các ứng dụng, video, hình ảnh và các tài liệu quan trọng khác. Ổ cứng SSD Kingston A400 được thiết kế để sử dụng trong máy tính để bàn và máy tính xách tay phổ thông, không dành cho các hệ thống Server.', 530000, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH006', N'LH002', N'https://i.imgur.com/hPoLvvN.jpg', N'SSD Gigabyte 2.5-Inch SATA III 120GB', N'Thanh', N'SSD Toolbox luôn được Gigabyte cập nhật mới nhất, là một ứng dụng giúp người dùng theo dõi trạng thái SSD, cung cấp thông tin chung như tên Model, phiên bản FW, tình trạng sức khỏe, tối ưu hóa ổ đĩa và theo dõi nhiệt độ hoạt động thông qua các cảm biến. Hơn nữa, bạn cũng có thể xóa tất cả dữ liệu an toàn bằng chức năng Sercure Eraser. SSD Toolbox có thể được Download tại trang chủ của Gigabyte. ', 580000, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH007', N'LH002', N'https://i.imgur.com/1fn4DsA.jpg', N'SSD Crucial BX500 3D NAND SATA III  120GB', N'Thanh', N'SSD Toolbox luôn được Gigabyte cập nhật mới nhất, là một ứng dụng giúp người dùng theo dõi trạng thái SSD, cung cấp thông tin chung như tên Model, phiên bản FW, tình trạng sức khỏe, tối ưu hóa ổ đĩa và theo dõi nhiệt độ hoạt động thông qua các cảm biến. Hơn nữa, bạn cũng có thể xóa tất cả dữ liệu an toàn bằng chức năng Sercure Eraser. SSD Toolbox có thể được Download tại trang chủ của Gigabyte. ', 590000, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH008', N'LH002', N'https://i.imgur.com/srWrppz.jpg', N'SSD Transcend M.2 2242 SATA III 120GB', N'Thanh', N'Bạn đang tìm một sản phẩm giúp nâng hiệu năng tổng thể và khả năng lưu trữ của máy tính? Ổ cứng SSD Transcend M.2 2242 SATA III MTS420S 3D-NAND sẽ giúp bạn. Sản phẩm ổ cứng SSD Transcend M.2 2242 SATA III MTS420S 3D-NAND của Transcend có dung lượng lên tới 240GB, kích thước nhỏ gọn và chuẩn giao tiếp SATA III 6GB/s thế hệ mới, phù hợp với tất cả các dòng máy tính Laptop hỗ trợ cổng M.2 SATA III 2242, giúp giảm thiểu tối đa thời gian đáp ứng của hệ thống, kích thước nhỏ gọn. Giúp bạn làm việc nhanh hơn và tiết kiệm thời gian hơn.

', 690000, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH009', N'LH002', N'https://i.imgur.com/SJWnT0K.jpg', N'SSD Crucial MX500 3D-NAND M.2 2280 SATA III 250GB', N'Thanh', N'Ổ cứng SSD Crucial MX500 3D NAND Sata III với công nghệ tiên tiến bậc nhất giúp tăng tốc độ, độ bền, và hiệu năng tổng thể hệ thống của bạn. Máy tính của bạn sẽ khởi động và load các chương trình cực nặng chỉ trong vài giây khi được trang bị công nghệ 3D flash NAND mới nhất với sự thành công đã được chứng minh của những dòng SSD MX-series trước đó. Ổ cứng SSD Crucial MX500 3D NAND Sata III không chỉ làm tăng hiệu năng hệ thống mà còn giúp bạn lưu trữ tất cả mọi dữ liệu quan trọng. Micron - Chất lượng bậc nhất thế giới', 1050000, NULL, NULL, NULL)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH010', N'LH002', N'https://i.imgur.com/z3K2y4T.jpg', N'SSD Intel 545s Series M.2 2280 Sata III 256GB', N'Thanh', N'Dòng ổ cứng SSD Intel 545s Series của Intel là một giải pháp lưu trữ siêu nhỏ gọn, an toàn và tiết kiệm năng lượng, được thiết kế cho nhiều thiết bị như Ultrabook, máy tính để bàn và máy tính xách tay Laptop, mang lại sự kết hợp hoàn hảo giữa hiệu suất, chất lượng và độ tin cậy của Intel và tiết kiệm tối đa năng lượng để tối ưu hóa hiệu năng tổng thể máy tính của bạn.', 990000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH011', N'LH003', N'https://i.imgur.com/Dtn5Lsj.jpg', N'CPU Intel Core i3-9100F Processor (6M Cache, 4.20 GHz)', N'Cái', N'Tương thích với các dòng bo mạch chủ sử dụng Intel 300 Series Chipset.
Xung nhịp mặc định 3.6 GHz.
Xung nhịp tối đa 4.2 GHz.
Bộ vi xử lý 4 nhân, 4 luồng.
Cache 6 MB.
Không tích hợp đồ họa, cần có VGA rời.
Hỗ trợ bộ nhớ DDR4, tối đa 64 GB.
Socket LGA 1151 (Bo mạch chủ 300 Series).
TDP 65W.
Tản nhiệt đi kèm sản phẩm.', 1790000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH012', N'LH003', N'https://i.imgur.com/4YeIffx.jpg', N'CPU Intel Core i3-10100 Processor (6M Cache, 3.6 GHz up to 4.30 GHz)', N'Cái', N'Bảo hành 36 tháng
Tương thích với các dòng bo mạch chủ sử dụng Intel 400 Series Chipset.
Dòng vi xử lý đem lại trải nghiệm VR tuyệt vời hơn.
Xung nhịp mặc định 3.6 GHz, xung Boost tối đa 4.3 GHz.
Bộ vi xử lý 4 nhân, 8 luồng.
Cache 6 MB.
Tích hợp đồ họa Intel UHD Graphics 630.
Hỗ trợ bộ nhớ DDR4, tối đa 128 GB.
Socket LGA 1200 (Bo mạch chủ 400 Series).
TDP 65W.
Tản nhiệt đi kèm sản phẩm.', 3250000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH013', N'LH003', N'https://i.imgur.com/iDK203Y.jpg', N'CPU Intel Core I3-8100 Processor (6M Cache, 3.60 GHz)', N'Cái', N'Bảo mật tích hợp bổ sung thêm một tầng bảo vệ trọng yếu, giúp đơn giản hóa và đảm bảo an toàn khi đăng nhập bằng mật khẩu, trình duyệt và thanh toán trực tuyến3. Bạn có thể đăng nhập bằng ánh mắt, giọng nói hay dấu vân tay để đảm bảo bảo mật “cứng như đá”3, nhanh chóng và dễ dàng. Lưu mật khẩu, thông tin cá nhân và tự động điền thông tin bằng một mật khẩu chính. Ngoài ra còn có màn hình cảm ứng, ra lệnh bằng giọng nói và các tùy chọn bút stylus giúp tương tác tự nhiên và trực quan.', 3290000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH014', N'LH003', N'https://i.imgur.com/k3ZMb6d.jpg', N'CPU Intel Core i5-9400F Processor (9M Cache, 2.9 GHz up to 4.10 GHz)', N'Cái', N'
Bảo hành 36 tháng
Tương thích với các dòng bo mạch chủ sử dụng Intel 300 Series Chipset.
Dòng vi xử lý đem lại trải nghiệm VR tuyệt vời hơn.
Xung nhịp mặc định 2.9 GHz, xung Boost tối đa 4.1 GHz.
Bộ vi xử lý 6 nhân, 6 luồng.
Cache 9 MB.
Không tích hợp card đồ họa.
Hỗ trợ bộ nhớ DDR4, tối đa 64 GB.
Socket LGA 1151 (Bo mạch chủ 300 Series).
TDP 65W.
Tản nhiệt đi kèm sản phẩm.', 3790000, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH015', N'LH004', N'https://i.imgur.com/h9HBDYT.jpg', N'Case Xigmatek Gemini – RGB Led Strip (No Fan)', N'Cái', N'
Vật liệu: SECC phủ đen, Plastic ABS
Kích thước: 403 x 200 x 397 mm
Hỗ trợ: 2.5 “” x 2 / 3.5″” x 2
Khe mở rộng: 4 slots
Hỗ trợ Mainboard: Micro-ATX, ITX
Cổng kết nối: USB3.0 x 1 – USB2.0 x1 – Audio in/out x 1 (HD Audio)
Hỗ trợ tản nhiệt CPU 160mm
Hỗ trợ VGA 320mm', NULL, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH016', N'LH004', N'https://i.imgur.com/ppe09pL.jpg', N'Case Deepcool E-Shield ATX', N'Cái', N'
Vật liệu: SECC phủ đen, Plastic ABS
Kích thước: 403 x 200 x 397 mm
Hỗ trợ: 2.5 “” x 2 / 3.5″” x 2
Khe mở rộng: 4 slots
Hỗ trợ Mainboard: Micro-ATX, ITX
Cổng kết nối: USB3.0 x 1 – USB2.0 x1 – Audio in/out x 1 (HD Audio)
Hỗ trợ tản nhiệt CPU 160mm
Hỗ trợ VGA 320mm', NULL, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH017', N'LH004', N'https://i.imgur.com/C2ehSRH.jpg', N'Case Cooler Master MasterCase H500M RGB – ATX', N'Cái', N'Mặt trước : 3 x 120mm / 140mm hoặc 2 x 200mm fan (2 x 200mm ARGB Fan đi kèm, tốc độ 800RPM / Kết nối: 3Pin + ARGB 3pin )Mặt trên : 3 x 120mm hoặc 2 x 140mm / 200mm fan
Mặt sau: 1 x 120mm hoặc 1 x 140mm fan (1 x 140mm fan đi kèm, tốc độ: 1200RPM / Kết nối: 3Pin)

Các tùy chọn két nước
Trước:  Tối đa 360mm
Sau -Tối đa 120mm/ 140mm
Trên – Tối đa 360mm', NULL, NULL, NULL, 10)
INSERT [dbo].[HangHoa] ([MaHH], [MaLoai], [Duongdan], [TenHH], [DonViTinh], [MoTa], [Giabanle], [Giabansi], [Gianhap], [SoLuongtonkho]) VALUES (N'HH018', N'LH004', N'https://i.imgur.com/gM8Sr0E.jpg', N'Case Cooler Master MasterBox TD500 Mesh ARGB ATX Black', N'Cái', N'Mặt trước : 3 x 120mm / 140mm hoặc 2 x 200mm fan (2 x 200mm ARGB Fan đi kèm, tốc độ 800RPM / Kết nối: 3Pin + ARGB 3pin )Mặt trên : 3 x 120mm hoặc 2 x 140mm / 200mm fan
Mặt sau: 1 x 120mm hoặc 1 x 140mm fan (1 x 140mm fan đi kèm, tốc độ: 1200RPM / Kết nối: 3Pin)

Các tùy chọn két nước
Trước:  Tối đa 360mm
Sau -Tối đa 120mm/ 140mm
Trên – Tối đa 360mm', NULL, NULL, NULL, 10)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [Email], [GioiTinh], [Maloaikh]) VALUES (N'KH001', N'ztt', N's', N'4354354', NULL, NULL, N'LK002')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [Email], [GioiTinh], [Maloaikh]) VALUES (N'KH002', N'Mai Thành Nhân', N'Tp HCM', N'093249720', NULL, NULL, N'LK003')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [Email], [GioiTinh], [Maloaikh]) VALUES (N'KH009', NULL, NULL, NULL, NULL, NULL, N'LK004')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [Email], [GioiTinh], [Maloaikh]) VALUES (N'KH010', N'mai thành nhânsad', N'sad', N'33434', NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT], [Email], [GioiTinh], [Maloaikh]) VALUES (N'KH011', N'sad', N'sad', N'33434', N'sdsdsd', N'Nữ', N'LK002')
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai], [Linkloaihang], [TinhTrangHang]) VALUES (N'LH001', N'Ram', N'https://i.imgur.com/3O4UNEX.png', 1)
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai], [Linkloaihang], [TinhTrangHang]) VALUES (N'LH002', N'SSD', N'https://i.imgur.com/e2O5Xl5.jpg', 1)
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai], [Linkloaihang], [TinhTrangHang]) VALUES (N'LH003', N'CPU', N'https://i.imgur.com/ktK10UX.jpg', 1)
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai], [Linkloaihang], [TinhTrangHang]) VALUES (N'LH004', N'Case Máy Tính', N'https://i.imgur.com/JMxn2jb.jpg', 0)
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai], [Linkloaihang], [TinhTrangHang]) VALUES (N'LH005', N'Cho Thanh', N'https://i.imgur.com/bBRMntL.jpg', 0)
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai], [Linkloaihang], [TinhTrangHang]) VALUES (N'LH006', N'Man Hinh Vi Tinh', N'https://i.imgur.com/3O4UNEX.png', 0)
INSERT [dbo].[LoaiKhachHang] ([Maloaikh], [Tenloaikh], [soluongkh]) VALUES (N'LK002', N'Bán Buôn', NULL)
INSERT [dbo].[LoaiKhachHang] ([Maloaikh], [Tenloaikh], [soluongkh]) VALUES (N'LK003', N'Bán Lẻ', NULL)
INSERT [dbo].[LoaiKhachHang] ([Maloaikh], [Tenloaikh], [soluongkh]) VALUES (N'LK004', N'A', 0)
INSERT [dbo].[LoaiKhachHang] ([Maloaikh], [Tenloaikh], [soluongkh]) VALUES (N'LK005', N'Vip', 0)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'bao', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', N'1', 0)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'nhan', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'1', 1)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'nhanvien2', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'0', 1)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'quanh', N'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855', N'0', 0)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'test', N'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', N'0', 0)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'test2', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'1', 0)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'Thuong', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'2', 0)
INSERT [dbo].[NguoiDung] ([UserName], [PassWord], [Loai], [Active]) VALUES (N'triet', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'0', 1)
INSERT [dbo].[NhaCungCap] ([MaNC], [TenNCC], [DIACHI], [SDT], [Trangthai]) VALUES (N'NC001', N'Công Ty Hữu Hạn Thiết Nghệ', N'Tp Hồ Chí Minh', N'093232323', NULL)
INSERT [dbo].[NhaCungCap] ([MaNC], [TenNCC], [DIACHI], [SDT], [Trangthai]) VALUES (N'NC002', N'Dựng Châu Long-Công Ty TNH', N'Vũng Tàu', N'0931122', NULL)
INSERT [dbo].[NhaCungCap] ([MaNC], [TenNCC], [DIACHI], [SDT], [Trangthai]) VALUES (N'NC003', N'Hệ Thống Xây Dựng Châu Âu', N'Hà Nội', N'0971594488', NULL)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV002', N'Quỳnh Xuân Trường', N'Nữ', CAST(N'1999-08-14' AS Date), N'Quỳnh Xuân Trường', N'0932497270', CAST(N'2019-11-20' AS Date), NULL, N'CV001', NULL, 0)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV003', N'Nguyễn Thị Quanh', N'Nam', CAST(N'1999-08-02' AS Date), N'Nguyễn Thị Quanh', N'0732424230', CAST(N'2019-11-20' AS Date), CAST(N'2019-11-21' AS Date), N'CV002', 20000, 0)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV004', N'Admin', N'Nam', CAST(N'1999-08-12' AS Date), N'Admin', N'033333', CAST(N'2019-11-23' AS Date), NULL, N'CV003', NULL, 1)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV006', N'Đặng Thương', N'Nam', CAST(N'1999-08-12' AS Date), N'Vũng Tàu', N'0938942207', CAST(N'2019-11-20' AS Date), NULL, N'CV002', NULL, 0)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV007', N'Mai Thành Nhân', N'Nam', CAST(N'1999-08-14' AS Date), N'Vũng Tàu', N'097893235', CAST(N'2020-03-03' AS Date), CAST(N'2019-11-23' AS Date), N'CV001', 40000, 0)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV008', N'nhanvien', N'Nam', CAST(N'1999-08-14' AS Date), N'an nhut', N'0938942207', CAST(N'2020-05-24' AS Date), NULL, N'CV002', NULL, 1)
INSERT [dbo].[NhanVien] ([MANV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayVaoLam], [NgayKetThuc], [MaCV], [Luong], [TinhTrang]) VALUES (N'NV009', N'Mai Thành Nhân', N'Nam', CAST(N'2018-08-18' AS Date), N'Vung Tau', N'0938942207', CAST(N'2010-08-18' AS Date), NULL, N'CV002', NULL, 1)
INSERT [dbo].[QuanTriNguoiDung] ([ID_I], [UserName], [MANV], [MaCV]) VALUES (N'ID_ND001', N'nhan', N'NV004', N'CV003')
INSERT [dbo].[QuanTriNguoiDung] ([ID_I], [UserName], [MANV], [MaCV]) VALUES (N'ID_ND002', N'triet', N'NV007', N'CV001')
INSERT [dbo].[QuanTriNguoiDung] ([ID_I], [UserName], [MANV], [MaCV]) VALUES (N'ID_ND003', N'nhanvien2', N'NV003', N'CV002')
INSERT [dbo].[UserKhachHang] ([UserName], [Password], [MaKH]) VALUES (N'nhan', N'', NULL)
INSERT [dbo].[UserKhachHang] ([UserName], [Password], [MaKH]) VALUES (N'nhan2', N'123456', NULL)
INSERT [dbo].[UserKhachHang] ([UserName], [Password], [MaKH]) VALUES (N'nhan3', N'123456', NULL)
INSERT [dbo].[UserKhachHang] ([UserName], [Password], [MaKH]) VALUES (N'nhan4', N'122434', NULL)
ALTER TABLE [dbo].[ChiTietHD_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Nhap_HangHoa] FOREIGN KEY([MAHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietHD_Nhap] CHECK CONSTRAINT [FK_ChiTietHD_Nhap_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietHD_Xuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Xuat_HangHoa] FOREIGN KEY([MAHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietHD_Xuat] CHECK CONSTRAINT [FK_ChiTietHD_Xuat_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietHD_Xuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Xuat_HoaDon_Xuat] FOREIGN KEY([MAHD_Xuat])
REFERENCES [dbo].[HoaDon_Xuat] ([MAHD_Xuat])
GO
ALTER TABLE [dbo].[ChiTietHD_Xuat] CHECK CONSTRAINT [FK_ChiTietHD_Xuat_HoaDon_Xuat]
GO
ALTER TABLE [dbo].[ChiTietHD_Xuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Xuat_UserKhachHang] FOREIGN KEY([username])
REFERENCES [dbo].[UserKhachHang] ([UserName])
GO
ALTER TABLE [dbo].[ChiTietHD_Xuat] CHECK CONSTRAINT [FK_ChiTietHD_Xuat_UserKhachHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHang] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHang] ([MaLoai])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHang]
GO
ALTER TABLE [dbo].[HoaDon_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Nhap_NhaCungCap] FOREIGN KEY([MaNC])
REFERENCES [dbo].[NhaCungCap] ([MaNC])
GO
ALTER TABLE [dbo].[HoaDon_Nhap] CHECK CONSTRAINT [FK_HoaDon_Nhap_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDon_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Nhap_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[HoaDon_Nhap] CHECK CONSTRAINT [FK_HoaDon_Nhap_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon_Xuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Xuat_KhachHang1] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon_Xuat] CHECK CONSTRAINT [FK_HoaDon_Xuat_KhachHang1]
GO
ALTER TABLE [dbo].[HoaDon_Xuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Xuat_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[HoaDon_Xuat] CHECK CONSTRAINT [FK_HoaDon_Xuat_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhachHang] FOREIGN KEY([Maloaikh])
REFERENCES [dbo].[LoaiKhachHang] ([Maloaikh])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhachHang]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_HangHoa] FOREIGN KEY([MAHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_HangHoa]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCv])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_PhieuChi_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK_PhieuChi_NhanVien]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThu_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK_PhieuThu_NhanVien]
GO
ALTER TABLE [dbo].[QuanTriNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QuanTriNguoiDung_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCv])
GO
ALTER TABLE [dbo].[QuanTriNguoiDung] CHECK CONSTRAINT [FK_QuanTriNguoiDung_ChucVu]
GO
ALTER TABLE [dbo].[QuanTriNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QuanTriNguoiDung_NguoiDung] FOREIGN KEY([UserName])
REFERENCES [dbo].[NguoiDung] ([UserName])
GO
ALTER TABLE [dbo].[QuanTriNguoiDung] CHECK CONSTRAINT [FK_QuanTriNguoiDung_NguoiDung]
GO
ALTER TABLE [dbo].[QuanTriNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QuanTriNguoiDung_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[QuanTriNguoiDung] CHECK CONSTRAINT [FK_QuanTriNguoiDung_NhanVien]
GO
ALTER TABLE [dbo].[UserKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_UserKhachHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[UserKhachHang] CHECK CONSTRAINT [FK_UserKhachHang_KhachHang]
GO
