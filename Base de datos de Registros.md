# AMV_TEST_PARKINGs


USE [master]
GO
/****** Object:  Database [GestionAparcamientos]    Script Date: 15/11/2021 8:03:35 ******/
CREATE DATABASE [GestionAparcamientos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionAparcamientos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GestionAparcamientos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionAparcamientos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GestionAparcamientos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestionAparcamientos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionAparcamientos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionAparcamientos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionAparcamientos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionAparcamientos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestionAparcamientos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionAparcamientos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET RECOVERY FULL 
GO
ALTER DATABASE [GestionAparcamientos] SET  MULTI_USER 
GO
ALTER DATABASE [GestionAparcamientos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionAparcamientos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionAparcamientos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionAparcamientos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionAparcamientos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionAparcamientos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GestionAparcamientos', N'ON'
GO
ALTER DATABASE [GestionAparcamientos] SET QUERY_STORE = OFF
GO
USE [GestionAparcamientos]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 15/11/2021 8:03:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[idRegistro] [int] IDENTITY(1,1) NOT NULL,
	[idVehiculo] [int] NOT NULL,
	[entrada] [datetime] NOT NULL,
	[salida] [datetime] NULL,
	[duracion] [int] NULL,
	[coste] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 15/11/2021 8:03:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[Id_Tipo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_vehiculo] [nvarchar](50) NOT NULL,
	[Precio] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo]    Script Date: 15/11/2021 8:03:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo](
	[Id_vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [nvarchar](50) NOT NULL,
	[ID_Tipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Registro] ON 
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (2, 21, CAST(N'2021-11-13T18:49:21.000' AS DateTime), CAST(N'2021-11-13T19:20:52.000' AS DateTime), 32, 96.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (3, 22, CAST(N'2021-11-13T18:49:21.000' AS DateTime), CAST(N'2021-11-13T19:22:05.000' AS DateTime), 33, 33.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (7, 25, CAST(N'2021-11-13T19:22:05.000' AS DateTime), CAST(N'2021-11-13T19:44:05.000' AS DateTime), 22, 22.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (8, 26, CAST(N'2021-11-13T19:22:05.000' AS DateTime), CAST(N'2021-11-13T19:44:05.000' AS DateTime), 22, 66.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (10, 27, CAST(N'2021-11-14T00:16:16.000' AS DateTime), CAST(N'2021-11-14T11:40:55.000' AS DateTime), 685, 2055.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (11, 28, CAST(N'2021-11-15T01:12:12.000' AS DateTime), CAST(N'2021-11-15T03:12:12.000' AS DateTime), 120, 360.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (12, 29, CAST(N'2021-11-15T02:19:29.000' AS DateTime), CAST(N'2021-11-15T03:53:00.000' AS DateTime), 94, 564.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (13, 30, CAST(N'2021-11-15T06:08:45.000' AS DateTime), CAST(N'2021-11-15T06:35:19.000' AS DateTime), 27, 162.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (14, 31, CAST(N'2021-11-15T06:35:19.000' AS DateTime), CAST(N'2021-11-15T06:35:19.000' AS DateTime), 0, 0.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (15, 31, CAST(N'2021-11-15T06:35:19.000' AS DateTime), CAST(N'2021-11-15T06:57:37.000' AS DateTime), 22, 55.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (16, 31, CAST(N'2021-11-15T06:35:19.000' AS DateTime), CAST(N'2021-11-15T06:41:37.000' AS DateTime), 6, 15.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (17, 31, CAST(N'2021-11-15T06:35:19.000' AS DateTime), CAST(N'2021-11-15T06:57:37.000' AS DateTime), 22, 55.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (18, 32, CAST(N'2021-10-14T06:39:17.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (19, 32, CAST(N'2021-06-16T01:39:17.000' AS DateTime), CAST(N'2021-11-15T06:39:17.000' AS DateTime), 219180, 219180.0000)
GO
INSERT [dbo].[Registro] ([idRegistro], [idVehiculo], [entrada], [salida], [duracion], [coste]) VALUES (20, 33, CAST(N'2021-11-15T07:39:27.440' AS DateTime), CAST(N'2021-11-15T07:39:27.417' AS DateTime), 0, 0.0000)
GO
SET IDENTITY_INSERT [dbo].[Registro] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo] ON 
GO
INSERT [dbo].[Tipo] ([Id_Tipo], [Tipo_vehiculo], [Precio]) VALUES (1, N'Moto', 1.0000)
GO
INSERT [dbo].[Tipo] ([Id_Tipo], [Tipo_vehiculo], [Precio]) VALUES (2, N'Coche', 2.5000)
GO
INSERT [dbo].[Tipo] ([Id_Tipo], [Tipo_vehiculo], [Precio]) VALUES (3, N'Furgoneta', 3.0000)
GO
INSERT [dbo].[Tipo] ([Id_Tipo], [Tipo_vehiculo], [Precio]) VALUES (4, N'Camion', 6.0000)
GO
SET IDENTITY_INSERT [dbo].[Tipo] OFF
GO
SET IDENTITY_INSERT [dbo].[vehiculo] ON 
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (21, N'1111FFF', 1)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (22, N'2222AAAA', 1)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (23, N'3332AAAA', 3)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (24, N'4442AAAA', 4)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (25, N'1654ADQ', 1)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (26, N'4642SAF', 3)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (27, N'5464SDG', 3)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (28, N'4546DD', 3)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (29, N'5466SG', 4)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (30, N'5465SFS', 4)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (31, N'5466FDF', 2)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (32, N'4646FSF', 1)
GO
INSERT [dbo].[vehiculo] ([Id_vehiculo], [matricula], [ID_Tipo]) VALUES (33, N'5465GD', 3)
GO
SET IDENTITY_INSERT [dbo].[vehiculo] OFF
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_vehiculo1] FOREIGN KEY([idVehiculo])
REFERENCES [dbo].[vehiculo] ([Id_vehiculo])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_vehiculo1]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_Tipo] FOREIGN KEY([ID_Tipo])
REFERENCES [dbo].[Tipo] ([Id_Tipo])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_Tipo]
GO
/****** Object:  StoredProcedure [dbo].[DatosxDia]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DatosxDia]

@diaSeleccionado datetime
as
SELECT sum(coste) GananciasTotales,
		sum(duracion) DuracionTotal,
		COUNT(idRegistro) RegistrosTotales

		


		From Registro where CONVERT(DATE,Registro.salida) =                     @diaSeleccionado
GO
/****** Object:  StoredProcedure [dbo].[DiasRegistrados]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiasRegistrados]
		as 
		select CONVERT(DATE,r.salida) diaSalidas
		from Registro r
GO
/****** Object:  StoredProcedure [dbo].[EditarMatricula]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarMatricula]
@Id_vehiculo int,
@matricula nvarchar(50),
@ID_Tipo int
as
update vehiculo set matricula =@matricula , ID_Tipo =@ID_Tipo WHERE Id_vehiculo =@Id_vehiculo

GO
/****** Object:  StoredProcedure [dbo].[EditarRegistro]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarRegistro]
@id_registro int,
@fechaEntrada datetime,
@fechaSalida datetime
as
update Registro set salida=@fechaSalida,entrada=@fechaEntrada WHERE idRegistro=@id_registro
GO
/****** Object:  StoredProcedure [dbo].[InsertarMatricula]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarMatricula]
@matricula nvarchar(100),
@idTipo int
as
insert into vehiculo values (@matricula,@idTipo)
GO
/****** Object:  StoredProcedure [dbo].[InsertarRegistroEntrada]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarRegistroEntrada]
@id_vehiculo int,
@fechaEntrada datetime,
@fechaSalida datetime,
@duracion int,
@coste money
as
insert into Registro values (@id_vehiculo,@fechaEntrada,null,null,null)
GO
/****** Object:  StoredProcedure [dbo].[InsertarRegistroSalida]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarRegistroSalida]
@id_registro int,
@fechaSalida datetime,
@Duracion int,
@Coste money
as
update Registro set salida=@fechaSalida,duracion=@Duracion,coste=@Coste WHERE idRegistro=@id_registro
GO
/****** Object:  StoredProcedure [dbo].[InsetarMatricula]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsetarMatricula]

@matricula nvarchar (100),
@ID_Tipo int
as
insert into vehiculo values (@matricula,@ID_Tipo)
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuario]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarUsuario]
as
select idRegistro as ID,matricula as MATRICULA, Tipo_vehiculo AS VEHICULO,entrada AS HORA_ENTRADA, salida AS HORA_SALIDA, duracion AS DURACION, coste AS COSTE
from Registro
inner join vehiculo on Registro.idVehiculo=vehiculo.Id_vehiculo
inner join Tipo on vehiculo.ID_Tipo=Tipo.Id_Tipo
GO
/****** Object:  StoredProcedure [dbo].[RegistroCompleto]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistroCompleto]
as
select *
from Registro
inner join vehiculo on vehiculo.Id_vehiculo=Registro.idVehiculo
inner join Tipo on Tipo.ID_Tipo=vehiculo.Id_Tipo
GO
/****** Object:  StoredProcedure [dbo].[RegistroFecha]    Script Date: 15/11/2021 8:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RegistroFecha]

as
SELECT CONVERT(DATE,Registro.salida),
		coste GananciasDia,
		duracion DuracionDia,
		idRegistro RegistrosDia

		


		From Registro
GO
USE [master]
GO
ALTER DATABASE [GestionAparcamientos] SET  READ_WRITE 
GO

