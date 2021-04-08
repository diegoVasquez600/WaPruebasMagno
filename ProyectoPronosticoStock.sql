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
		SET @Stock = @Stock_Inicial
		SET @Stock_Inicial = @Stock - @ADU + @Transito
		INSERT INTO @PronosticoStock VALUES(@FechaActual, @Referenciav, @Descripcion, @Stock, @Stock_Inicial, @ADU, @Transito)
		CONTINUE  
	END  
	
SELECT * from @PronosticoStock
GO

--------------- Prueba el PROC con esto -----------------------------

USE [WA_DEMO_MAGNO]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[PronosticoStock]
		@FechaInicial = "2021/03/17",
		@FechaFinal = "2021/04/03",
		@Referencia = N'1004002',
		@CodigoBodega = 'CN31'

SELECT	'Return Value' = @return_value

GO
