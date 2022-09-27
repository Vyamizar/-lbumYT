 
# Hola, soy jonathan villamizar  👋  
                
## 🚀 About Me  
Soy ingeniero de sistema titulado 
    
## 🔗 Links   
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/jonathan-sebastian-villamizar-rodriguez-b418a1178/)
    
## 🛠 Skills  
.NET Framework, c#, SQLServer, Oracle 11g, Angular, JsvaScript ...  
    
## base de datos (Tabla) 
USE [Videos]
GO

/****** Object:  Table [dbo].[VideosYT]    Script Date: 03-09-2022 18:41:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VideosYT](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[imagen] [varchar](100) NULL,
	[descripcion] [varchar](2000) NULL,
	[titulo] [varchar](200) NULL,
	[url] [varchar](500) NULL
) ON [PRIMARY]
GO   
## base de datos (SP1) 
USE [Videos]
GO
/****** Object:  StoredProcedure [dbo].[inserta_url]    Script Date: 03-09-2022 18:47:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[inserta_url]
	-- Add the parameters for the stored procedure here
	@url varchar(500),
	@imagen varchar(100),
	@descripcion varchar(2000),
	@titulo varchar(200)



AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into VideosYT (imagen,descripcion,titulo,url)values(@imagen,@descripcion,@titulo,@url);
END
## base de datos (SP1) 
USE [Videos]
GO
/****** Object:  StoredProcedure [dbo].[tablaVideos]    Script Date: 03-09-2022 18:48:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[tablaVideos]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from VideosYT
END
## imagens de la funcion 
![image](https://user-images.githubusercontent.com/88111708/188289886-ae80d30b-5987-402e-a05a-72cda450205e.png)
![image](https://user-images.githubusercontent.com/88111708/188289929-479cb39d-5dd3-43d4-80e3-d34c4d442a71.png)
![image](https://user-images.githubusercontent.com/88111708/188293084-30de5487-6cd7-42e7-bdf1-0087ec4da952.png)
![image](https://user-images.githubusercontent.com/88111708/188293091-2d4367be-de40-4390-80ae-0d9aacc94ba6.png)
![image](https://user-images.githubusercontent.com/88111708/188293109-2803c804-b854-43c4-b9f0-440dd92504b2.png)


## consumo de la PI de youtube V3
![image](https://user-images.githubusercontent.com/88111708/188289951-97cf3e90-9b6a-44a3-bbc3-24f3bd51954e.png)
![image](https://user-images.githubusercontent.com/88111708/188289972-909b5c12-d846-468e-a1a0-ce0b5ada6717.png)






