------------------- Proyecto Pronostico Stock -------------------

ALTER PROC PronosticoStock
@FechaInicial DATE,
@FechaFinal DATE,
@Referencia NVARCHAR(50),
@CodigoBodega NVARCHAR(50)
AS
DECLARE @Referenciav NVARCHAR(50), @Descripcion VARCHAR(max), @Stock_Inicial NVARCHAR(max) , @Stock FLOAT, @ADU FLOAT, @Transito FLOAT, @FechaActual DATE
DECLARE @PronosticoStock TABLE(Dia DATE, Referencia NVARCHAR(50), Descripcion VARCHAR(max), Stock_Inicial FLOAT, Stock FLOAT, ADU FLOAT, Transito FLOAT)
SELECT @Referenciav = PB.Referencia, @Descripcion = Prod.Descripcion, @Stock_Inicial = PB.Stock, @Transito = ITA.CantTotalInsumo, @ADU = PB.ADU, @Stock = @Stock_Inicial - @ADU + @Transito FROM Vs_InventarioEnTransitoAcumulado_BETA ITA, Tbl_ProductoBodega PB
	INNER JOIN Tbl_Productos Prod ON PB.IdProducto = Prod.IdProducto
	INNER JOIN Tbl_Bodegas Bod ON PB.IdBodega = Bod.IdBodega
	WHERE PB.Referencia = @Referencia AND FechaEntrega = @FechaInicial AND Bod.Codigo = @CodigoBodega
	SET @FechaActual = @FechaInicial
	INSERT INTO @PronosticoStock VALUES(@FechaInicial, @Referenciav, @Descripcion, @Stock_Inicial, @Stock, @ADU, @Transito)
	WHILE @FechaActual != @FechaFinal
	BEGIN
		SET @FechaActual = DATEADD(DAY, 1, @FechaActual)
		SET @Stock_Inicial = @Stock - @ADU + @Transito
		SET @Stock = @Stock_Inicial
		INSERT INTO @PronosticoStock VALUES(@FechaActual, @Referenciav, @Descripcion, @Stock_Inicial, @Stock, @ADU, @Transito)
			
		CONTINUE  
	END  
	
SELECT * from @PronosticoStock
GO

USE [WA_DEMO_MAGNO]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[PronosticoStock]
		@FechaInicial = "2021/03/17",
		@FechaFinal = "2021/03/30",
		@Referencia = N'1004002',
		@CodigoBodega = 'CN31'

SELECT	'Return Value' = @return_value

GO

-------------- Pruebas --------------

SELECT * FROM Vs_InventarioEnTransitoAcumulado_BETA Where IdProducto = 8031
SELECT * FROM Tbl_Productos WHERE Referencia = '1004002'
SELECT * FROM Tbl_Productos_2 WHERE IdProducto = 2569
SELECT * FROM Tbl_ProductoBodega WHERE Referencia = '1004002'
INSERT INTO Tbl_Productos (IdProducto) SELECT IdProducto FROM Tbl_Productos_2 WHERE IdProducto NOT IN (SELECT IdProducto FROM Tbl_Productos_2)
SELECT * FROM Tbl_ProductoBodega WHERE Referencia = '1000080' AND IdBodega = (SELECT IdBodega FROM Tbl_Bodegas WHERE Codigo = 'NN71')
SELECT * FROM Tbl_Bodegas WHERE IdBodega = 3350

SELECT PB.Referencia, Prod.Descripcion, Stock AS Stock_Inicial, PB.Stock - ADU + ITA.CantTotalInsumo AS Stock, ADU, ITA.CantTotalInsumo AS Transito FROM Vs_InventarioEnTransitoAcumulado_BETA ITA, Tbl_ProductoBodega PB
	INNER JOIN Tbl_Productos Prod ON PB.IdProducto = Prod.IdProducto
	WHERE PB.Referencia = '1004002' AND PB.IdBodega = (SELECT IdBodega FROM Tbl_Bodegas WHERE Codigo = 'CN31')



SELECT Top 1 PB.Referencia, Prod.Descripcion, Ant.Stock - Ant.ADU + ITA.CantTotalInsumo AS Stock_Inicial, PB.Stock - PB.ADU + ITA.CantTotalInsumo AS Stock, PB.ADU, ITA.CantTotalInsumo AS Transito FROM Vs_InventarioEnTransitoAcumulado_BETA ITA, Tbl_ProductoBodega PB
	INNER JOIN Tbl_ProductoBodega AS Ant ON PB.Stock = Ant.Stock
	INNER JOIN Tbl_Productos Prod ON PB.IdProducto = Prod.IdProducto
	WHERE PB.Referencia = '1004002' AND PB.IdBodega = (SELECT IdBodega FROM Tbl_Bodegas WHERE Codigo = 'CN31') AND FechaEntrega = '2021-03-17'
	

	DECLARE @Referenciav NVARCHAR(50), @Descripcion VARCHAR(max), @Stock_Inicial NVARCHAR(max) , @Stock FLOAT, @ADU FLOAT, @Transito FLOAT
	DECLARE @PronosticoStock TABLE(Dia DATE, Referencia NVARCHAR(50), Descripcion VARCHAR(max), Stock_Inicial FLOAT, Stock FLOAT, ADU FLOAT, Transito FLOAT)
	SELECT @Referenciav = PB.Referencia, @Descripcion = Prod.Descripcion, @Stock_Inicial = PB.Stock, @Transito = ITA.CantTotalInsumo, @Stock = @Stock_Inicial - @ADU + @Transito, @Transito = PB.ADU FROM Vs_InventarioEnTransitoAcumulado_BETA ITA, Tbl_ProductoBodega PB
	INNER JOIN Tbl_Productos Prod ON PB.IdProducto = Prod.IdProducto
	INNER JOIN Tbl_Bodegas Bod ON PB.IdBodega = Bod.IdBodega
	WHERE PB.Referencia = '1004002' AND FechaEntrega = '2021-03-17' AND Bod.Codigo = 'CN31'
	INSERT INTO @PronosticoStock VALUES()
	SELECT @Referenciav, @Descripcion, @ADU, @Stock_Inicial, @Stock
	
  

------ Rango de Fechas en Dias --------------	
SELECT DATEDIFF(DAY, '2000-04-30', '2021-04-05')

