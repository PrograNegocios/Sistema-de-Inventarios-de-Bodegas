USE [master]
GO

/****** Object:  Database [inventario de bodega UNICAH]    Script Date: 07/05/2016 23:56:37 ******/
CREATE DATABASE [inventario de bodega UNICAH] ON  PRIMARY 
( NAME = N'Inventario de Bodegas UNICAH', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\inventario de bodega UNICAH.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Inventario de Bodegas UNICAH_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\inventario de bodega UNICAH.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [inventario de bodega UNICAH] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inventario de bodega UNICAH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET ARITHABORT OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET  DISABLE_BROKER 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET  READ_WRITE 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET  MULTI_USER 
GO

ALTER DATABASE [inventario de bodega UNICAH] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [inventario de bodega UNICAH] SET DB_CHAINING OFF 
GO

