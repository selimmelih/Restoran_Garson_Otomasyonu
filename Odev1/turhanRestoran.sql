USE [master]
GO
/****** Object:  Database [TurhanRestoran]    Script Date: 30.07.2023 19:41:01 ******/
CREATE DATABASE [TurhanRestoran]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TurhanRestoran', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TurhanRestoran.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TurhanRestoran_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TurhanRestoran_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TurhanRestoran] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TurhanRestoran].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TurhanRestoran] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TurhanRestoran] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TurhanRestoran] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TurhanRestoran] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TurhanRestoran] SET ARITHABORT OFF 
GO
ALTER DATABASE [TurhanRestoran] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TurhanRestoran] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TurhanRestoran] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TurhanRestoran] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TurhanRestoran] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TurhanRestoran] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TurhanRestoran] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TurhanRestoran] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TurhanRestoran] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TurhanRestoran] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TurhanRestoran] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TurhanRestoran] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TurhanRestoran] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TurhanRestoran] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TurhanRestoran] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TurhanRestoran] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TurhanRestoran] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TurhanRestoran] SET RECOVERY FULL 
GO
ALTER DATABASE [TurhanRestoran] SET  MULTI_USER 
GO
ALTER DATABASE [TurhanRestoran] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TurhanRestoran] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TurhanRestoran] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TurhanRestoran] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TurhanRestoran] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TurhanRestoran] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TurhanRestoran', N'ON'
GO
ALTER DATABASE [TurhanRestoran] SET QUERY_STORE = ON
GO
ALTER DATABASE [TurhanRestoran] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TurhanRestoran]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAd] [varchar](50) NULL,
	[KullaniciAdi] [varchar](25) NULL,
	[Sifre] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[SiparisID] [int] IDENTITY(1,1) NOT NULL,
	[MasaNo] [varchar](10) NULL,
	[Yiyecek] [varchar](30) NULL,
	[YiyecekAdet] [int] NULL,
	[Icecek] [varchar](30) NULL,
	[IcecekAdet] [int] NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([PersonelID], [PersonelAd], [KullaniciAdi], [Sifre]) VALUES (1, N'selim melih', N'selimmelih', N'123')
INSERT [dbo].[Personeller] ([PersonelID], [PersonelAd], [KullaniciAdi], [Sifre]) VALUES (2, N'deneme', N'admin', N'password')
SET IDENTITY_INSERT [dbo].[Personeller] OFF
GO
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([SiparisID], [MasaNo], [Yiyecek], [YiyecekAdet], [Icecek], [IcecekAdet]) VALUES (1, N'123', N'kebap', 3, N'ayran', 3)
INSERT [dbo].[Siparisler] ([SiparisID], [MasaNo], [Yiyecek], [YiyecekAdet], [Icecek], [IcecekAdet]) VALUES (2, N'B-1', N'Urfa', 5, N'zero kola', 3)
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
GO
/****** Object:  StoredProcedure [dbo].[PListele]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PListele]
as begin
Select PersonelAd,KullaniciAdi from Personeller
end
GO
/****** Object:  StoredProcedure [dbo].[SGuncelle]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SGuncelle]
@SiparisID int, @MasaNo varchar(10),@Yiyecek varchar(30),@YiyecekAdet int, @Icecek varchar(30), @IcecekAdet int
as begin
update Siparisler set MasaNo=@MasaNo, Yiyecek=@Yiyecek, YiyecekAdet=@YiyecekAdet, Icecek=@Icecek, IcecekAdet = @IcecekAdet
where SiparisID = @SiparisID
end
GO
/****** Object:  StoredProcedure [dbo].[SKaydet]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SKaydet]
@MasaNo varchar(10),@Yiyecek varchar(30),@YiyecekAdet int, @Icecek varchar(30), @IcecekAdet int
as begin insert into Siparisler(MasaNo,Yiyecek,YiyecekAdet,Icecek,IcecekAdet)
values (@MasaNo,@Yiyecek,@YiyecekAdet,@Icecek,@IcecekAdet)
end
GO
/****** Object:  StoredProcedure [dbo].[SListele]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SListele]
as begin
select * from Siparisler
end
GO
/****** Object:  StoredProcedure [dbo].[SSil]    Script Date: 30.07.2023 19:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SSil]
@SiparisID int
as begin
delete from Siparisler where SiparisID = @SiparisID
end
GO
USE [master]
GO
ALTER DATABASE [TurhanRestoran] SET  READ_WRITE 
GO
