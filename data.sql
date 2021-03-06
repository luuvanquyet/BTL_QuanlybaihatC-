USE [master]
GO
/****** Object:  Database [QuanLiNhac]    Script Date: 5/22/2019 9:23:10 PM ******/
CREATE DATABASE [QuanLiNhac]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiNhac', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiNhac.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiNhac_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiNhac_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiNhac] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiNhac].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiNhac] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiNhac] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiNhac] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiNhac] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiNhac] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiNhac] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLiNhac] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiNhac] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiNhac] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiNhac] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiNhac] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiNhac] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiNhac] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiNhac] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiNhac] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiNhac] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiNhac] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiNhac] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiNhac] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiNhac] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiNhac] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiNhac] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiNhac] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiNhac] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiNhac] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiNhac] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiNhac] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiNhac] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiNhac] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLiNhac]
GO
/****** Object:  Table [dbo].[ALBUM]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ALBUM](
	[MaAlbum] [varchar](10) NOT NULL,
	[TenAlbum] [nvarchar](100) NOT NULL,
	[NamPhatHanh] [char](4) NOT NULL,
 CONSTRAINT [PK_ALBUM] PRIMARY KEY CLUSTERED 
(
	[MaAlbum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BAIHAT]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAIHAT](
	[MaBaiHat] [varchar](10) NOT NULL,
	[TenBaiHat] [nvarchar](100) NOT NULL,
	[MaTheLoai] [varchar](10) NOT NULL,
	[MaAlbum] [varchar](10) NOT NULL,
	[MaCaSi] [varchar](10) NOT NULL,
	[MaTacGia] [varchar](10) NOT NULL,
	[MaHangSanXuat] [varchar](10) NOT NULL,
	[LoiBaiHat] [nvarchar](2000) NOT NULL,
 CONSTRAINT [PK_BAIHAT] PRIMARY KEY CLUSTERED 
(
	[MaBaiHat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CASI]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CASI](
	[MaCaSi] [varchar](10) NOT NULL,
	[TenCaSi] [nvarchar](35) NOT NULL,
 CONSTRAINT [PK_CASI] PRIMARY KEY CLUSTERED 
(
	[MaCaSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CASI_BAIHAT]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CASI_BAIHAT](
	[MaCaSi] [varchar](10) NOT NULL,
	[MaBaiHat] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CASI_BAIHAT] PRIMARY KEY CLUSTERED 
(
	[MaCaSi] ASC,
	[MaBaiHat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGSANXUAT]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGSANXUAT](
	[MaHangSanXuat] [varchar](10) NOT NULL,
	[TenHangSanXuat] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_HANGSANXUAT] PRIMARY KEY CLUSTERED 
(
	[MaHangSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTacGia] [varchar](10) NOT NULL,
	[TenTacGia] [nvarchar](35) NOT NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 5/22/2019 9:23:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTheLoai] [varchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL001', N'Nhạc Việt Hót tháng 4/2019', N'2019')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL002', N'Em xin anh', N'2014')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL003', N'Một vòng trái đất', N'2013')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL004', N'Hoa nở về đêm', N'2017')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL005', N'Nhạc cách mạng một thời', N'2017')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL006', N'Mãi Là Người Lính', N'2016')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL007', N'Một Đời Người Một Rừng Cây', N'2015')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL008', N'Còn Tuổi Nào Cho Em', N'2015')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL009', N'Nỗi Lòng Người Đi', N'2014')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL010', N'Đội Kèn Tí Hon ', N'2017')
INSERT [dbo].[ALBUM] ([MaAlbum], [TenAlbum], [NamPhatHanh]) VALUES (N'AL011', N'MV', N'2018')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH001', N'Em xin anh', N'TL001', N'AL002', N'CS001', N'TG001', N'SX002', N'Anh! Em đã biết tất cả, nhưng không muốn nói thật ra... 
Em tin sau cơn mê ai cũng thức tỉnh... 
Đêm qua anh với cô ta... 
Em sao không thể nhận ra... 
Em quay đi cố như không, như không biết điều gì... 
Phải cố kềm nén bão tố ở trong lòng. 
Nói ra thì ta sẽ nhìn mặt nhau thế nào! 
Người ơi em van xin anh dừng lại trước lúc mọi chuyện đi quá xa... 
Đi quá xa... 

Em yếu đuối chẳng biết phải đối diện thế nào! 
Sợ xa anh còn lại mình em sống sao... 
Nếu lòng anh muốn biết lý do vì sao em cam tâm, 
Thì người ơi em yêu anh, anh nhớ không 
Đừng để đến lúc tất cả đã là quá muộn 
Đừng để đến lúc nước mắt không thể tuông. 
Là lúc em sẽ chẳng thiết tha điều gì đâu anh ơi, 
Dù gục ngã hay bất chấp em cũng buông tay... 
Em xin anh. 

Điều ta đã trải qua chẳng lẽ không thể giữ anh ở lại 
Hãy dừng lại đi... 
Hãy tỉnh lại đi... ')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH002', N'Còn Tuổi Nào Cho Em', N'TL004', N'AL008', N'CS011', N'TG010', N'SX001', N'Tuổi nào nhìn lá vàng úa chiều nay 
Tuổi nào ngồi hát mây bay ngang trời 
Tay măng trôi trên vùng tóc dài 
Bao nhiêu cơn mơ vừa tuổi này 
Tuổi nào ngơ ngác tìm tiếng gió heo may 
Tuổi nào vừa thoáng buồn áo gầy vai 
Tuổi nào ghi dấu chân chim qua trời 
Xin cho tay em còn muốt dài 
Xin cho cô đơn vào tuổi này 
Tuổi nào lang thang thành phố tóc mây cài 
Em xin tuổi nào còn tuổi nào cho nhau 
Trời xanh trong mắt em sâu 
Mây xuống vây quanh giọt sầu 
Em xin tuổi nào Còn tuổi trời hư vô 
Bàn tay che dấu lệ nhòa Ôi buồn! 
Tuổi nào ngồi khóc tình đã nghìn thu 
Tuổi nào mơ kết mây trong sương mù 
Xin chân em qua từng phiến ngà 
Xin mây xe thêm màu áo lụa 
Tuổi nào thôi hết từng tháng năm mong chờ..')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH003', N'Một Vòng Trái Đất', N'TL001', N'AL001', N'CS001', N'TG002', N'SX014', N'Trái đất cứ lặng lẽ quay 
Đôi ta cứ lặng lẽ yêu 
Hứa yêu nhau đến muôn đời sau 
Hứa yêu nhau có trăng và sao. 

Trái đất cứ lặng lẽ quay 
Đôi ta cứ lặng lẽ xa 
Xa nhau không phải không hợp nhau 
Xa nhau vì bao lỗi lầm. 

Yêu em không 
Anh yêu em. Yêu anh không 
Thật em yêu anh 
Lời nói đó vẫn in sâu vào tâm trí của anh. 

[ĐK:] 
Một vòng trái đất, em ngồi đây 
Anh ngồi đây 
Bên cạnh nhau ngỡ như thật xa 
Không dám nhìn, không nói gì 
Dường như chúng ta chưa từng quen. 

Một vòng trái đất, em ngồi đây 
Em lặng đi, anh ngồi đây ngước mắt nhìn theo 
Không dám gọi tên, nước mắt rơi từ khoé mắt sâu vào tim. 

[Nói 1:] 
Đố các bạn, trên thế gian này khoảng cách nào là xa nhất? 
Nó không phải là khoảng cách từ ngọn núi này đến ngọn núi kia 
Không phải là khoảng cách từ đại dương này đến đại dương kia 
Cũng không phải là khoảng cách giữa châu lục này đến châu lục kia 
Mà nó chính là khoảng cách của một vòng trái đất. 

Một vòng trái đất, đó cũng chính là khoảng cách ngắn nhất 
Vì khi đó hai người được ngồi cạnh bên nhau 
Nhưng không biết phải nói gì, cũng không biết phải làm gì 
Mời các bạn cùng lắng nghe ca khúc: "Một Vòng Trái Đất". 

[Nói 2:] 
Một vòng trái đất 
Người ta thường nói có người đã đi một vòng lớn 
Cuối cùng cũng gặp lại nhau 
Chỉ đáng tiếc là khi gặp lại nhau 
Giữa hai người dường như có một khoảng cách rất lớn 
Đến nỗi không biết phải làm sao để lấp lại khoảng cách đó. 

Một vòng trái đất 
Đến cuối cùng hai người đều có hai cuộc sống riêng 
Hai thế giới riêng 
Mà trong hai thế giới đó 
Đều đã không còn hình bóng của đối phương 
Vậy thì theo các bạn 
Số phận đã đưa hai người đó đi một vòng lớn rồi lại gặp nhau để làm gì?')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH004', N'Đến Giờ Phút Này', N'TL001', N'AL003', N'CS001', N'TG002', N'SX014', N'Đến giờ phút này đây 
Đến bây giờ trên thế gian sẽ không còn ai quan trọng với em 
Cũng bởi vì là anh đó, người quan trọng nhất cũng đã lìa xa 
Từng ngày qua em nhớ anh thật nhiều 
Nhớ nụ cười nhớ ánh mắt bờ môi 
Từng ngày qua em nhớ, lòng đau thật đau 
Vì ai đã bỏ rơi em 

Đến giờ phút này đây không ai là quan trọng với em 
Đến giờ phút này đây không ai là quan trọng nữa đâu 
Bởi vì anh quan trọng nhất cũng đã lìa xa 
Thì giờ em biết phải tin vào ai 
Đến giờ phút này đây không ai là quan trọng với em 
Đến giờ phút này đây em sẽ không vì ai đớn đau 
Dù em biết sẽ có một ngày 
Anh sẽ nhớ và quay về đây 
Nhưng em không còn yêu anh.')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH005', N'Hoa Nở Về Đêm', N'TL003', N'AL004', N'CS002', N'TG003', N'SX014', N'Chuyện từ một đêm cuối nẻo một người tiễn một người đi 
Đẹp tựa bài thơ nở giữa đêm sương nở tận tâm hồn 
Chuyện một mình tôi chép dòng tâm tình tặng người chưa biết một lần 
Vì giây phút ấy ... tôi tình cờ hiểu rằng ... 
tình yêu đẹp nghìn đời là tình yêu khi đơn côi 

Vào chuyện từ một đêm khoác bờ vai một mảnh áo dạ đường khuya 
Bồi hồi người trai hướng nẻo đêm sâu, dấu tình yêu đầu 
Vì còn tìm nhau lối về ngõ hẹp còn chờ in dấu chân anh 
Niềm thương mến đó bây giờ và nghìn đời 
Dù gió đùa dạt dào còn đẹp như khi quen nhau 

Ai lớn lên không từng hẹn hò không từng yêu thương 
Nhưng có mấy người tìm được một tình yêu ngát hương 
Mến những người chưa quen 
Một người ở lại đèn trăng gối mộng 
Yêu ai anh băng sông dài cho đẹp lòng trai 

Một người tìm vui mãi tận trời nào giá lạnh hồn đông 
Một người chợt nghe gió giữa mênh mông rót vào trong lòng 
Và một mình tôi chép dòng tâm tình tặng người chưa biết một lần 
Vì trong phút ấy tôi tìm mình thì thầm giờ đã gặp được một nụ hoa nở về đêm')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH006', N'Một Vòng Trái Đất', N'TL001', N'AL003', N'CS003', N'TG002', N'SX014', N'Trái đất cứ lặng lẽ quay 
Đôi ta cứ lặng lẽ yêu 
Hứa yêu nhau đến muôn đời sau 
Hứa yêu nhau có trăng và sao. 

Trái đất cứ lặng lẽ quay 
Đôi ta cứ lặng lẽ xa 
Xa nhau không phải không hợp nhau 
Xa nhau vì bao lỗi lầm. 

Yêu em không 
Anh yêu em. Yêu anh không 
Thật em yêu anh 
Lời nói đó vẫn in sâu vào tâm trí của anh. 

[ĐK:] 
Một vòng trái đất, em ngồi đây 
Anh ngồi đây 
Bên cạnh nhau ngỡ như thật xa 
Không *** nhìn, không nói gì 
Dường như chúng ta chưa từng ***. 

Một vòng trái đất, em ngồi đây 
Em lặng đi, anh ngồi đây ngước mắt nhìn theo 
Không *** gọi tên, nước mắt rơi từ khoé mắt sâu vào tim. 

[Nói 1:] 
Đố các bạn, trên thế gian này khoảng cách nào là xa nhất? 
Nó không phải là khoảng cách từ ngọn núi này đến ngọn núi kia 
Không phải là khoảng cách từ đại dương này đến đại dương kia 
Cũng không phải là khoảng cách giữa châu lục này đến châu lục kia 
Mà nó chính là khoảng cách của một vòng trái đất. 

Một vòng trái đất, đó cũng chính là khoảng cách ngắn nhất 
Vì khi đó hai người được ngồi cạnh bên nhau 
Nhưng không biết phải nói gì, cũng không biết phải làm gì 
Mời các bạn cùng lắng nghe ca khúc: "Một Vòng Trái Đất". 

[Nói 2:] 
Một vòng trái đất 
Người ta thường nói có người đã đi một vòng lớn 
Cuối cùng cũng gặp lại nhau 
Chỉ đáng tiếc là khi gặp lại nhau 
Giữa hai người dường như có một khoảng cách rất lớn 
Đến nỗi không biết phải làm sao để lấp lại khoảng cách đó. 

Một vòng trái đất 
Đến cuối cùng hai người đều có hai cuộc sống riêng 
Hai thế giới riêng 
Mà trong hai thế giới đó 
Đều đã không còn hình bóng của đối phương 
Vậy thì theo các bạn 
Số phận đã đưa hai người đó đi một vòng lớn rồi lại gặp nhau để làm gì?')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH007', N'Con Đường Mưa', N'TL001', N'AL003', N'CS004', N'TG004', N'SX014', N'Nếu ngày xưa bước đi nhanh qua con đường mưa. 
Thì anh đã không gặp người. 
Nếu ngày xưa em nhìn anh nhưng không mỉm cười. 
Thì anh đã không mộng mơ. 

Nếu tình ta chẳng phải xa khi đang đậm sâu. 
Thì anh đã không đau buồn . 
Nếu lòng anh không còn yêu em hơn chính mình 
Thì anh đã quên được em 

ĐK: 

Làm sao để đường xưa đừng in dấu chân anh mỗi ngày 
Làm sao cho lòng anh thôi gọi tên em trong giấc mơ 
Làm sao để mưa mùa thu đừng rơi khi anh đang nhớ em. 
Làm sao khi thấy mưa anh không buồn 

Làm sao để quên niềm vui niềm hạnh phúc khi anh có người 
Làm sao quên ngày chia tay lệ em rơi trên đôi mắt cay 
Làm sao để thôi chờ mong 
Làm sao tim anh thôi đừng mơ rằng ngày mai thấy em quay trở về 

***Nếu ngày xưa bước đi nhanh qua con đường mưa 
Thì anh đã không gặp người 
Nếu ngày xưa em nhìn anh nhưng không mỉm cười 
Thì anh đã không mộng mơ 

Nếu thời gian có quay về trước khi gặp em 
Thì anh vẫn xin đi cùng 
Nếu ngày xưa mưa mùa thu rơi trên lối về 
Thì anh vẫn không vội qua')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH008', N'Đất Nước', N'TL002', N'AL005', N'CS005', N'TG005', N'SX014', N'Đất nước tôi thon thả giọt đàn bầu, 
Nghe dịu nỗi đau của mẹ 
Ba lần tiễn con đi, hai lần khóc thầm lặng lẽ, 
Các anh không về mình mẹ lặng im.. 

Đất nước tôi, đất nước tôi, đất nước tôi ! 
Từ thuở còn nằm nôi, Sáng chắn bão giông, 
chiều ngăn nắng lửa Lao xao trưa hè một giọng ca dao, 
Lao xao trưa hè một giọng ca dao. 

Xin hát về người đất nước ơi ! 
Xin hát về mẹ Tổ Quốc ơi, suốt đời lam lũ.. 
Thương lũy tre làng bãi dâu bến nước, 
Yêu trọn tình đời muối mặn gừng cay.. 

Xin hát về người đất nước ơi ! 
Xin hát về mẹ Tổ quốc ơi, mấy mùa không ngủ 
Ngăn bước quân thù phía Nam phía Bắc 
Vai mẹ lại gầy gánh gạo nuôi con. 

2. Đất nước tôi thon thả giọt đàn bầu, 
Nghe dịu nỗi đau của mẹ 
Ba lần tiễn con đi, hai lần khóc thầm lặng lẽ, 
Các anh không về mình mẹ lặng im.. 
Đất nước tôi, đất nước tôi, đất nước tôi 

Từ thuở còn nằm nôi, 
Sáng chắn bão giông, chiều ngăn nắng lửa 
Lao xao trưa hè một giọng ca dao, 
Lao xao trưa hè một giọng ca dao... 

Xin hát về người đất nước ơi ! 
Xin hát về mẹ Tổ Quốc ơi, suốt đời lam lũ.. 
Thương lũy tre làng bãi dâu bến nước, 
Yêu trọn tình đời muối mặn gừng cay.. 

Xin hát về mẹ Tổ Quốc ơi.. 
vẫn còn gian khổ Hạt thóc 
chia đều dẫu no dẫu đói 
Ta vẫn vẹn tình đắng ngọt cùng vui.. 

Đất nước tôi, đất nước tôi, đất nước tôi ! 
Sáng ngời muôn thuở 
khi trăng đã vào cửa sổ đòi thơ...')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH009', N'Tàu Anh Qua Núi', N'TL002', N'AL005', N'CS006', N'TG006', N'SX003', N'Ði dọc Việt Nam theo bánh con tàu quay 
Qua đèo Hải Vân mây bay đỉnh núi 
Nhớ khi xưa qua đèo qua suối 
Mà lòng ta mơ, tàu qua núi cao 

Ngày hôm nay thênh thang con đường lớn 
Tàu anh đi trong yêu thương chào đón 
Tha thiết bao niềm vui, theo bánh con tàu đi 
Là thương nhau em bắc cầu cho tàu anh tới 
Là yêu nhau mấy suối ta cũng lội 
Là yêu nhau mấy núi ta cũng trèo 

2) 
Con tàu Việt Nam đi suốt bốn mùa xuân 
Qua đèo Hải Vân mây bay đỉnh núi 
Nhớ thương nhau em chờ anh tới 
Là tàu anh đi vượt qua núi cao 

Trời quê hương trong xanh như lời hát 
Biển quê hương ru êm êm bờ cát 
Ðưa chúng ta cùng đi ra Bắc hay vào Nam 
Là thương nhau em bắc cầu cho tàu anh tới 
Là yêu nhau mấy suối ta cũng lội 
Là yêu nhau mấy núi ta cũng trèo')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH010', N'Khát Vọng', N'TL002', N'AL005', N'CS007', N'TG005', N'SX003', N'Hãy sống như đời sông, để biết yêu nguồn cội 
Hãy sống như đồi núi, vươn tới những tầm cao 
Hãy sống như biển trào, như biển trào để thấy bờ bến rộng 
Hãy sống và ước vọng để thấy đời mênh mông. 

Và sao không là gió, là mây để thấy trời bao la 
Và sao không là phù sa, dâng mỡ màu cho hoa 
Sao không là bài ca, của tình yêu đôi lứa 
Sao không là mặt trời, gieo hạt nắng vô tư. 

Và sao không là bão, là giông, là ánh lửa đêm đông 
Và sao không là hạt giống, xanh đất mẹ bao dung 
Sao không là đàn chim, gọi bình minh thức giấc 
Sao không là mặt trời, gieo hạt nắng vô tư')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH011', N'Làng Tôi', N'TL002', N'AL006', N'CS008', N'TG007', N'SX014', N'Làng tôi ở miền biển khơi với đồng cát trắng. 
Sóng reo vang vang dập rờn ánh nắng vàng tươi 
Làng tôi ở miền biển khơi những chiều gió mát 
Sóng reo vang vang vờn nô nước thủy triều lên 

Dân làng tôi những chiều biển lặng 
Cánh buồm dơi đón gió ra ngoài khơi 
Dân làng vui những chiều cánh buồm dơi trở về đầy cá trắng tinh 
Dân làng vui bóng chiều rộn rịp 

Vai nặng in tiếng gót vang dồn xa 
Theo lời ca ấm lòng bóng hoàng hôn đợi người về lợp mái tranh 
Làng tôi tan tác đã lâu rồi: Nhà hoang đường vắng người qua 
Giặc lên càn quét ngày đêm, phá đồng cát muối, phá thuyền đi khơi 

Còn đâu xanh ngát đồng quê 
Cây vườn nắng héo vắng người gieo ươm 
Căm thù sục sôi dân làng tôi quyết chiến 
Những ngày đêm cầm súng giết quân thù 

Làng quê chôn giặc thù trọn lời thề son sắc tình quê 
Căm thù sục sôi dân làng tôi chiến đấu 
Với đường thôn cùng ngăn bước quân thù 
Làng quê quyết rửa thùh ẹn một ngày trở lại với ngày xưa 
Hẹn một ngày trở lại những ngày vui. 

[Coda:] 
Đêm đêm nước thủy triều reo vang vang ầm sóng vỗ 
Nhớ thuyền xưa cùng tiếng hát trên bờ 
Gió reo trên sóng vi vu 
Mang theo tiếng súng căm thù giặc tan 
Mang theo tiếng súng căm thù giặc tan!')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH012', N'Tôi Người Lính Trẻ', N'TL002', N'AL006', N'CS008', N'TG007', N'SX014', N'Tôi người lính trẻ đi giữa hàng quân 
Mang nòng súng thép ca bài quân hành 
Tôi người lính trẻ theo bước đoàn quân 
Chung lòng cứu quốc sao vàng tung bay 

Ai người lính trẻ hôm trước đầu quân 
Theo lời non nước sôi sục lên đường 
Tôi người lính trẻ theo bước đoàn quân 
Chung lòng cứu quốc trên đường vinh quang 

Ta đi qua núi qua sông trên đất quê hương 
Giữ quê hương, giữ non sông 
Tôi người lính trẻ đi giữa hàng quân 
Mang nòng súng thép ca bài quân hành 

Tôi người lính trẻ theo bước đoàn quân 
Chung lòng cứu quốc sao vàng tung bay 
Chung lòng cứu quốc sao vàng tung bay 
Sao vàng tung bay! Tung bay! Tung bay!')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH013', N'Thơ Tình Của Núi', N'TL002', N'AL007', N'CS009', N'TG008', N'SX005', N'Bản em lưng chừng núi lưng chừng đèo 
Từng bậc thang lên xuống như cung đàn ngân dài 
Một lần đi tuần tra anh tới 
Gặp em bên suối hát gì 
Mà rừng ban nở trắng xinh 
Cùng lặng nghe em hát 
Những yêu thương cuộc đời 
Để lại bao thương nhớ trong lòng mình 
Một cô gái miền núi đã thắp ngọn lửa tình 
Rồi một hôm anh ghé qua thăm bản 
Tìm gặp em cô gái nhen ngọn lửa tim mình 
Bản làng vui điệu xòe hoa náo nức 
Nhịp trầm thanh ru con lấp đất rung 
Từ xa em đã thấy tôi 
Rời cuộc vui em tới 
Em cho tôi vòng nhỏ 
Và từ ấy người lính có thơ tình 
Tìm người thương thì hãy qua thác ghềnh sẽ gặp 
Một rừng ban nở trắng xinh 
Một tình yêu tôi có... nơi núi rừng mờ xa')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH014', N'Xin Em Đừng Khóc Vu Quy', N'TL003', N'AL004', N'CS010', N'TG009', N'SX014', N'Đừng nhìn nhau chi mà hoen lệ bờ mi,
Tình dù chưa phai không trách được từ ly
Ai biết đời mai sau bao giờ
Ai biết đâu ngờ tình hai chúng ta lẽ nào phôi pha

Xót xa từng kỷ niệm đầy vơi
Lòng mình muối sát sao không mặn người ơi
Trăng nước còn đây em đâu rồi
Ngăn cách phương trời hận tình không tan trọn đời riêng mang

Xe xe hoa đưa em về ngỡ ngàng là đòan xe tang tiễn hồn anh sang
Ngục tối đau thương , độc hành đêm trường,
Điệp khúc yêu đương chỉ còn cung buồn não nùng

Đớn đau từng tiếng lòng người ơi,
Trời đầy hai đứa ôm cách biệt hai nơi
Lau mắt rồi thôi xin dám cười làm vui lòng người
Đành chờ kiếp sau hẹn lại yêu nhau

Xe xe hoa đưa em về ngỡ ngàng là đoàn xe tang tiễn hồn anh sang
Ngục tối đau thương, độc hành đêm trường,
Điệp khúc yêu đương chỉ còn cung buồn não nùng

Đớn đau từng tiếng lòng người ơi,
Trời đày hai đứa ôm cách biệt hai nơi
Lau mắt rồi thôi xin dám cười làm vui lòng người
Đành chờ kiếp sau hẹn lại yêu nhau

Lau mắt rồi thôi xin dám cười làm vui lòng người
Đành chờ kiếp sau hẹn lại yêu nhau')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH015', N'Cát Bụi', N'TL004', N'AL008', N'CS012', N'TG010', N'SX001', N'Hạt bụi nào hóa kiếp thân tôi 
Để một mai vươn hình hài lớn dậy . 
Ôi cát bụi tuyệt vời . 
Mặt trời soi một kiếp rong chơi . 

Hạt bụi nào hóa kiếp thân tôi . 
Để một mai tôi về làm cát bụi . 
Ôi cát bụi mệt nhoài . 
Tiếng động nào gõ nhịp khôn nguôi . 

Bao nhiêu năm làm kiếp con người . 
Chợt một chiều tóc trắng như vôi . 
Lá úa trên cao rụng đầy . 
Cho trăm năm vào chết một ngày . 

Mặt trời nào soi sáng tim tôi . 
Để tình yêu xay mòn thành đá cuội . 
Xin úp mặt bùi ngùi . 
Từng ngày qua mỏi ngóng tin vui . 

Cụm rừng nào lá xác xơ cây . 
Từ vực sâu nghe lời mời đã dậy . 
Ôi cát bụi phận này . 
Vết mực nào xóa bỏ không hay...')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH016', N'Diễm Xưa', N'TL004', N'AL008', N'CS012', N'TG010', N'SX001', N'Mưa vẫn mưa bay trên tầng tháp cổ 
Dài tay em mấy thuở mắt xanh xao 
Nghe lá thu mưa reo mòn gót nhỏ 
Đường dài hun hút cho mắt thêm sâu 

Mưa vẫn hay mưa trên hàng lá nhỏ 
Buổi chiều ngồi ngóng những chuyến mưa qua 
Trên bước chân em âm thầm lá đổ 
Chợt hồn xanh buốt cho mình xót xa 

Chiều nay còn mưa sao em không lại 
Nhỡ mai trong cơn đau vùi 
Làm sao có nhau, hằn lên nỗi đau 
Bước chân em xin về mau 

Mưa vẫn hay mưa cho đời biển động 
Làm sao em biết bia đá không đau 
Xin hãy cho mưa qua miền đất rộng 
Để người phiêu lãng quên mình lãng du 

Xin hãy cho mưa qua miền đất rộng 
Ngày sau sỏi đá cũng cần có nhau')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH017', N'Gửi Gió Cho Mây Ngàn Bay', N'TL005', N'AL009', N'CS006', N'TG011', N'SX005', N'Với bao tà áo xanh đây mùa thu 
Hoa lá tàn, hàng cây đứng hững hờ 
Lá vàng từng cánh rơi từng cánh 
Rơi xuống âm thầm trên đất xưa 

Gửi gió cho mây ngàn bay 
Gửi bướm muôn màu về hoa 
Gửi thêm ánh trăng màu xanh lá thư 
Về đây với thu trần gian 

Gửi gió cho mây ngàn bay 
Gửi phím tơ đồng tìm duyên 
Gửi thêm lá thư màu xanh ái ân 
Về đôi mắt như hồ thu 

Thấy hối tiếc nhiều 
Thuyền đã sang bờ 
Đường về không lối 
Giòng đời trôi đã về chiều 
Mà lòng mến còn nhiều 
Đập gương xưa tìm bóng 
Nhưng thôi tiếc mà chi 
Chim rồi bay, anh rồi đi 
Đường trần quên lối cũ 
Người đời xa cách mãi 
Tình trần khôn hàn gắn thương lòng 

Gửi gió cho mây ngàn bay 
Gửi bướm đa tình về hoa 
Gửi thêm ánh trăng màu xanh lá thư 
Về đây với thu trần gian.')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH018', N'Buồn Tàn Thu', N'TL005', N'AL009', N'CS006', N'TG012', N'SX005', N'Ai lướt đi ngoài sương gió 
Không dừng chân đến em bẽ bàng 
Ôi vừa thoáng nghe em 
Mơ ngày bước chân chàng 
Từ từ xa đường vắng 
Đêm mùa thu chết 
Nghe mùa đang rớt rơi theo lá vàng 
Em ngồi đan áo 
Lòng buồn vương vấn 
Em thương nhớ chàng 
Người ơi còn biết em nhớ mang 
Tình xưa còn đó xa xôi lòng 
Nhờ bóng chim uyên nhờ gió đưa duyên 
Chim với gió 
Bay về chàng quên hết lời thề 
Áo đan hết rồi 
Cố quên dáng người 
Chàng ngày nao tìm đến còn nhớ đêm xưa 
Kề má say xưa 
Nhưng năm tháng qua dần mùa thu chết bao lần 
Thôi tình em đấy như mùa thu chết rơi theo lá vàng 

Nghe bước chân người sương gió 
Xa dần như tiếng thu đang tàn 
Ôi người gió sương em mơ thương ái bao lần 
Và chờ tin hồng đến 
Đem mùa thu chết 
Nghe mùa đang rớt rơi theo lá vàng 
Em ngồi đan áo 
Lòng buồn vương vấn em thương nhớ chàng 
Người ơi còn biết em nhớ mong 
Đường xưa còn đó xa xôi lòng 
Nhờ bóng chim uyên nhờ gió đưa duyên 
Chim với gió 
Bay về chàng quên hết lời thề 

Ai lướt đi ngoài sương gió 
Không dừng chân đến em bẽ bàng 
Ôi vừa thoáng nghe em 
Mơ ngày bước chân chàng 
Từ từ xa đường vắng 
Đêm mùa thu chết 
Nghe mùa đang rớt rơi theo lá vàng 
Em ngồi đan áo 
Lòng buồn vương vấn 
Em thương nhớ chàng 
Người ơi còn biết em nhớ mang 
Tình xưa còn đó xa xôi lòng 
Nhờ bóng chim uyên nhờ gió đưa duyên 
Chim với gió 
Bay về chàng quên hết lời thề 
Áo đan hết rồi 
Cố quên dáng người 
Chàng ngày nao tìm đến còn nhớ đêm xưa 
Kề má say xưa 
Nhưng năm tháng qua dần mùa thu chết bao lần 
Thôi tình em đấy như mùa thu chết rơi theo lá vàng.')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH019', N'Giọt Mưa Thu', N'TL005', N'AL009', N'CS006', N'TG013', N'SX005', N'Ngoài hiên giọt mưa thu thánh thót rơi 
Trời lắng u buồn mây hắt hiu ngừng trôi 
Nghe gió thoảng mơ hồ trong mưa thu 
Ai khóc ai than hờ! 

Vài con chim non chiêm chiếp kêu trên cành 
như nhủ trời xanh 
Gió ngừng đi 
mưa buồn chi 
cho cõi lòng lâm ly 

Hồn thu tới nơi đây gieo buồn lây 
Lòng vắng muôn bề không liếp che gió về 
Ai nức nở thương đời 
châu buông mau 
dương thế bao la sầu 

Người mong mây tan cho gió hiu hiu lạnh 
mây ngỏ trời xanh 
chắc gì vui 
mưa còn rơi 
bao kiếp sầu ta nguôi 

Gió xa xôi vẫn về 
Mưa giăng mù lê thê 
Đến bao năm nữa trời ... 
... Vợ chồng Ngâu thôi khóc vì thu')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH020', N'Mơ Hoa', N'TL005', N'AL009', N'CS006', N'TG014', N'SX005', N'Cô hái hoa tươi, hãy dừng bước chân 
Trên đường thầm xa, tôi nhắn cô em đôi lời 
Lòng không lưu luyến, sao đành cô lãng quên, 
Quên người gặp gỡ trong một chiều mơ. 

Chuông chiều ngân tiếng vấn vương lòng trông theo cô hái hoa, 
Bước đi bâng khuâng muôn ngàn sầu nhớ 
bóng mờ mờ xa. 
Tan giấc mơ hoa! 
Bóng người khuất xa, đôi đường từ đây 
Ai bước đi không hẹn ngày, 
Người tuy xa cách nhưng lòng ta khắc ghi, 
Bên đèn một bóng tháng ngày chờ mong 

Lưu luyến chi nhau, thêm sầu đớn đau 
Muôn trùng từ đây, trong gió sương thân giang hồ. 
Đường xa xa tắp ngại ngùng chân bước quên, 
Bên lòng thầm nhớ bóng hình người mơ. 

Trên đường xa vắng bóng ai mờ khuất 
lòng thêm vấn vương, 
Gió thông xa đưa reo buồn sầu nhớ 
tới người chiều xưa 
Cô hái hoa ơi! 
Mắt mờ đoái trông, sao đành thờ ơ 
Trong giấc mơ ta mong chờ, 
Dù hoa quen bướm âm thầm riêng có ta 
Hoa còn tàn úa tơ lòng còn vương.')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH021', N'Đội Kèn Tí Hon', N'TL006', N'AL010', N'CS013', N'TG015', N'SX002', N'Te tò te đây là ban kèn hơi 
Tò là tò tò te có anh nào muốn chơi 
Mau lại đây có cây kèn to tí 
Tò la tò te tí bước đều chân cùng đi 

Te tò te anh nào kêu thật to. 
Tò tò tò tò te đứng ra đằng trước cho. 
Anh nào kêu bé trong mồm te tí. 
Tò tò tò te tí sắp đàng sau cùng đi. ')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH022', N'Em Đi Chơi Thuyền', N'TL006', N'AL010', N'CS013', N'TG016', N'SX002', N'Em đi chơi thuyền 
Trong Thảo Cầm Viên 
Chim kêu hót mừng chào đón xuân về 
Thuyền em thuyền con vịt, nó bơi bơi bơi 
Thuyền em thuyền con rồng, nó bay bay bay 
Má dặn em ngồi yên khi đi chơi thuyền 
Vui qua bạn ơi, mai em vào em đi xe hơi ')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH023', N'Thật Là Hay', N'TL006', N'AL010', N'CS013', N'TG017', N'SX002', N'Nghe véo von trong vòm cây hoạ mi với chim oanh 
Hai chú chim cao giọng hát hót líu lo vang lừng 
Vui rất vui bay từ xa chim khuyên tới hót theo 
Li lí li... li lí li thật là hay... hay... hay. ')
INSERT [dbo].[BAIHAT] ([MaBaiHat], [TenBaiHat], [MaTheLoai], [MaAlbum], [MaCaSi], [MaTacGia], [MaHangSanXuat], [LoiBaiHat]) VALUES (N'BH024', N'Hồng Nhan', N'TL007', N'AL011', N'CS014', N'TG018', N'SX014', N'Và dòng thư tay em gửi trao anh ngày nào 
Giờ còn lại hư vô em gửi anh đây lời chào 
Mà nhìn người đi vội mình làm gì nên tội 
Tại sao lại cách xa còn yêu như thế mà 
Để lệ hoen mi khi mùa xuân đang thầm thì 
Nhìn người mà ra đi anh chẳng níu kéo điều gì 
Mà nghe sao đáng thương nhìn nhau như cố hương 
Tìm em ở bốn phương vì say nên vấn vương 
Em ơi vô tình dù tình mình gặp không may 
Em xa nơi này để giọt lệ ở bên đây 
Bầu trời giờ hắt hiu nhìn về nơi đó đây 
Ngoài trời thì có mây chỉ còn lại là đắng cay 
Thương cha thương mẹ để đành lòng mà quay lưng 
25 âm lịch nhìn người cười mà rưng rưng 
Bên kia là pháo hoa rộn ràng người đến xem 
Họ hàng mừng kết duyên còn phần mình là hết duyên 

[Rap 1:] 
Ohh 
Anh như kẻ lạc còn tâm tối giữa rừng thông 
Nơi cánh chim nhỏ lạc đàn tìm bến đỗ để ngừng trông 
Anh là 1 con đom đóm mắt anh sáng đến xoay vòng 
Gieo cho anh cả 1 mầm sống nhưng chẳng chịu công vun trồng 
Vì lúc ấy ta còn trẻ nên đời bạc và mưu sinh 
Anh chưa học hết lớp 10 người ta gọi là lưu linh 
Anh gắn bó với sông nước và cảnh vật này hữu tình 
Còn người ta cho em áo lụa hỏi tại sao chẳng phụ mình 

[Mel:] 
Tình yêu ơi bình yên ơi 
Về đây đi để anh ôm để gió cuốn đêm nay ai đưa về nhà 
Để gió vang lên câu tình ca 
Để lệ hoen mi khi mùa xuân đang thầm thì 
Nhìn người mà ra đi anh chẳng níu kéo điều gì 
Mà nghe sao đáng thương nhìn nhau như cố hương 
Tìm em ở bốn phương vì say nên vấn vương 
Hết rồi cuối cùng nắng thì cũng đã ngã vàng 
Bên người nhân tình em phải thương bản thân mình 


')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS001', N'Minh Hằng')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS002', N'Như Quỳnh')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS003', N'Tim')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS004', N'Cao Thái Sơn')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS005', N'Quang Thọ (NSND)')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS006', N'Anh Thơ')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS007', N'Lan Anh')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS008', N'Tuấn Dũng')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS009', N'Trọng Tấn')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS010', N'Quang Lê')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS011', N'Ngọc Lan')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS012', N'Khánh Linh')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS013', N'Bé Thanh Ngân')
INSERT [dbo].[CASI] ([MaCaSi], [TenCaSi]) VALUES (N'CS014', N'Jack')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS001', N'BH001')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS001', N'BH003')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS001', N'BH004')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS001', N'BH006')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS002', N'BH005')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS003', N'BH006')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS004', N'BH007')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS005', N'BH008')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS006', N'BH009')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS006', N'BH017')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS006', N'BH018')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS006', N'BH019')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS006', N'BH020')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS007', N'BH010')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS008', N'BH011')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS008', N'BH012')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS009', N'BH013')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS010', N'BH014')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS011', N'BH002')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS012', N'BH015')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS012', N'BH016')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS013', N'BH021')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS013', N'BH022')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS013', N'BH023')
INSERT [dbo].[CASI_BAIHAT] ([MaCaSi], [MaBaiHat]) VALUES (N'CS014', N'BH024')
INSERT [dbo].[HANGSANXUAT] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'SX001', N'WEPRO Entertainment')
INSERT [dbo].[HANGSANXUAT] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'SX002', N'Vietnam Artist Agency (VAA)')
INSERT [dbo].[HANGSANXUAT] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'SX003', N'Hồng Ân Entertainment')
INSERT [dbo].[HANGSANXUAT] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'SX004', N'M-TP Entertainment')
INSERT [dbo].[HANGSANXUAT] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'SX005', N'1989s Production')
INSERT [dbo].[HANGSANXUAT] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'SX014', N'NTC_Official')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG001', N'Nguyễn Hồng Thuận')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG002', N'Nhật Trung')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG003', N'Mạnh Phát')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG004', N'Nguyễn Văn Chung')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG005', N'Phạm Minh Tuấn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG006', N'Phan Lạc Hoa')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG007', N'Nguyễn Trọng Lanh')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG008', N'An Thuyên')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG009', N'Minh Phương')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG010', N'Trịnh Công Sơn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG011', N'Đoàn Chuẩn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG012', N'Văn Cao')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG013', N'Đặng Thế Phong')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG014', N'Hoàng Giác')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG015', N'Huỳnh Điểu')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG016', N'Trần Kiết Tường')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG017', N'Hoàng Lan')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG018', N'Jack')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL001', N'Nhạc trẻ')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL002', N'Nhạc cách mạng')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL003', N'Nhạc trữ tình')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL004', N'Nhạc Trịnh')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL005', N'Tiền Chiến')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL006', N'Thiếu nhi')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL007', N'Rap Việt')
ALTER TABLE [dbo].[BAIHAT]  WITH CHECK ADD  CONSTRAINT [FK1_BAIHAT] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO
ALTER TABLE [dbo].[BAIHAT] CHECK CONSTRAINT [FK1_BAIHAT]
GO
ALTER TABLE [dbo].[BAIHAT]  WITH CHECK ADD  CONSTRAINT [FK2_BAIHAT] FOREIGN KEY([MaAlbum])
REFERENCES [dbo].[ALBUM] ([MaAlbum])
GO
ALTER TABLE [dbo].[BAIHAT] CHECK CONSTRAINT [FK2_BAIHAT]
GO
ALTER TABLE [dbo].[BAIHAT]  WITH CHECK ADD  CONSTRAINT [FK3_BAIHAT] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TACGIA] ([MaTacGia])
GO
ALTER TABLE [dbo].[BAIHAT] CHECK CONSTRAINT [FK3_BAIHAT]
GO
ALTER TABLE [dbo].[BAIHAT]  WITH CHECK ADD  CONSTRAINT [FK4_BAIHAT] FOREIGN KEY([MaHangSanXuat])
REFERENCES [dbo].[HANGSANXUAT] ([MaHangSanXuat])
GO
ALTER TABLE [dbo].[BAIHAT] CHECK CONSTRAINT [FK4_BAIHAT]
GO
ALTER TABLE [dbo].[CASI_BAIHAT]  WITH CHECK ADD  CONSTRAINT [FK1_CASI_BAIHAT] FOREIGN KEY([MaCaSi])
REFERENCES [dbo].[CASI] ([MaCaSi])
GO
ALTER TABLE [dbo].[CASI_BAIHAT] CHECK CONSTRAINT [FK1_CASI_BAIHAT]
GO
ALTER TABLE [dbo].[CASI_BAIHAT]  WITH CHECK ADD  CONSTRAINT [FK2_CASI_BAIHAT] FOREIGN KEY([MaBaiHat])
REFERENCES [dbo].[BAIHAT] ([MaBaiHat])
GO
ALTER TABLE [dbo].[CASI_BAIHAT] CHECK CONSTRAINT [FK2_CASI_BAIHAT]
GO
USE [master]
GO
ALTER DATABASE [QuanLiNhac] SET  READ_WRITE 
GO
