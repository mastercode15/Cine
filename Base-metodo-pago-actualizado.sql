USE [cine]
GO
/****** Object:  Table [dbo].[Asiento]    Script Date: 11/2/2020 2:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asiento](
	[ID_asiento] [int] NOT NULL,
	[Disp_asiento] [bit] NOT NULL,
	[FK_ID_sala] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_asiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Boleto]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleto](
	[ID_boleto] [int] NOT NULL,
	[Costo_boleto] [numeric](3, 2) NOT NULL,
	[FK_ID_compra] [int] NOT NULL,
	[FK_ID_funcion] [int] NOT NULL,
	[FK_ID_sala] [int] NOT NULL,
	[FK_ID_Asiento] [int] NOT NULL,
	[FK_ID_peli] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_boleto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[ID_compra] [int] NOT NULL,
	[Total_boletos] [int] NOT NULL,
	[Valor_total] [numeric](3, 2) NOT NULL,
	[FK_ID_usuario] [int] NOT NULL,
	[FK_ID_met_pago] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funciones](
	[ID_funcion] [int] NOT NULL,
	[Fecha_funcion] [date] NOT NULL,
	[Hora_funcion] [time](7) NOT NULL,
	[Idioma_funcion] [varchar](25) NULL,
	[FK_ID_peli] [int] NOT NULL,
	[FK_ID_sala] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodo_pago]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_pago](
	[ID_met_pago] [int] NOT NULL,
	[Nom_met_pago] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_met_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodo_pago_compra]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_pago_compra](
	[ID_met_pago_compra] [int] IDENTITY(1,1) NOT NULL,
	[Nom_met_pago_compra] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_met_pago_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[ID_peli] [int] NOT NULL,
	[Nom_peli] [varchar](35) NOT NULL,
	[Dur_peli] [int] NOT NULL,
	[Anio_peli] [int] NOT NULL,
	[Sip_peli] [text] NULL,
	[Clasif_peli] [varchar](25) NOT NULL,
	[Gen_peli] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_peli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[ID_sala] [int] NOT NULL,
	[Num_asien_sala] [int] NOT NULL,
	[Tipo_de_sala] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/2/2020 2:25:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_usuario] [int] NOT NULL,
	[Nom_usuario] [varchar](35) NOT NULL,
	[Correo_usuario] [varchar](40) NOT NULL,
	[FK_ID_met_pago] [int] NOT NULL,
	[pwd_usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asiento]  WITH CHECK ADD FOREIGN KEY([FK_ID_sala])
REFERENCES [dbo].[Sala] ([ID_sala])
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD FOREIGN KEY([FK_ID_Asiento])
REFERENCES [dbo].[Asiento] ([ID_asiento])
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD FOREIGN KEY([FK_ID_compra])
REFERENCES [dbo].[Compras] ([ID_compra])
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD FOREIGN KEY([FK_ID_funcion])
REFERENCES [dbo].[Funciones] ([ID_funcion])
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD FOREIGN KEY([FK_ID_peli])
REFERENCES [dbo].[Peliculas] ([ID_peli])
GO
ALTER TABLE [dbo].[Boleto]  WITH CHECK ADD FOREIGN KEY([FK_ID_sala])
REFERENCES [dbo].[Sala] ([ID_sala])
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([FK_ID_met_pago])
REFERENCES [dbo].[Metodo_pago_compra] ([ID_met_pago_compra])
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([FK_ID_usuario])
REFERENCES [dbo].[Usuario] ([ID_usuario])
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD FOREIGN KEY([FK_ID_peli])
REFERENCES [dbo].[Peliculas] ([ID_peli])
GO
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD FOREIGN KEY([FK_ID_sala])
REFERENCES [dbo].[Sala] ([ID_sala])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([FK_ID_met_pago])
REFERENCES [dbo].[Metodo_pago] ([ID_met_pago])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([FK_ID_met_pago])
REFERENCES [dbo].[Metodo_pago] ([ID_met_pago])
GO
