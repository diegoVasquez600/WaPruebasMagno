------------------- Proyecto Pronostico Stock -------------------

ALTER PROC PronosticoStock
@FechaInicial DATE,
@FechaFinal DATE,
@Referencia NVARCHAR(50),
@CodigoBodega NVARCHAR(50)
AS
DECLARE @Referenciav NVARCHAR(50), @Descripcion VARCHAR(max), @Stock_Inicial NVARCHAR(max) , @Stock FLOAT, @ADU FLOAT, @Transito FLOAT, @FechaActual DATE, @FechaAnterior DATE
DECLARE @PronosticoStock TABLE(Dia DATE, Referencia NVARCHAR(50), Descripcion VARCHAR(max), Stock_Inicial FLOAT, Stock FLOAT, ADU FLOAT, Transito FLOAT, IdRazon INT, CodigoBodega NVARCHAR(50))
SELECT @Referenciav = PB.Referencia, @Descripcion = Prod.Descripcion, @Stock_Inicial = PB.Stock, @Transito = ITA.CantTotalInsumo, @ADU = PB.ADU, @Stock = @Stock_Inicial - @ADU + @Transito FROM Vs_InventarioEnTransitoAcumulado_BETA ITA, Tbl_ProductoBodega PB
	INNER JOIN Tbl_Productos Prod ON PB.IdProducto = Prod.IdProducto
	INNER JOIN Tbl_Bodegas Bod ON PB.IdBodega = Bod.IdBodega
	WHERE PB.Referencia = @Referencia AND FechaEntrega = @FechaInicial AND Bod.Codigo = @CodigoBodega
	SET @FechaActual = @FechaInicial
	INSERT INTO @PronosticoStock VALUES(@FechaInicial, @Referenciav, @Descripcion, @Stock_Inicial, @Stock, @ADU, @Transito, NULL, @CodigoBodega)
	WHILE @FechaActual != @FechaFinal
	BEGIN
		SET @Stock = @Stock_Inicial
		SET @Stock_Inicial = @Stock - @ADU + @Transito
		SET @FechaAnterior = @FechaActual
		SET @FechaActual = DATEADD(DAY, 1, @FechaActual)
		INSERT INTO @PronosticoStock VALUES(@FechaActual, @Referenciav, @Descripcion, @Stock, @Stock_Inicial, @ADU, @Transito, 2, @CodigoBodega)
		IF @FechaAnterior != @FechaFinal
		BEGIN

			INSERT INTO HistRazon (Dia, Referencia, Descripcion, Stock_Inicial, Stock, ADU, Transito, IdRazon, CodigoBodega) SELECT Dia, Referencia, Descripcion, Stock_Inicial, Stock, ADU, Transito, IdRazon, CodigoBodega FROM @PronosticoStock WHERE Referencia = @Referencia AND CodigoBodega = @CodigoBodega AND Dia = @FechaActual AND Referencia NOT IN (SELECT Referencia FROM HistRazon WHERE Referencia = @Referencia AND Dia = @FechaActual AND CodigoBodega = @CodigoBodega)
		END
		CONTINUE  
	END  
	
SELECT Dia, Referencia, Descripcion, Stock_Inicial, Stock, ADU, Transito, rz.Razon, CodigoBodega FROM HistRazon hz
INNER JOIN Razones rz ON rz.IdRazon = hz.IdRazon
WHERE (Dia BETWEEN @FechaInicial AND @FechaFinal) AND CodigoBodega = @CodigoBodega
GO

CREATE TABLE HistRazon (IdHistRazon INT PRIMARY KEY IDENTITY(1,1), Dia DATE, Referencia NVARCHAR(50), Descripcion VARCHAR(50), Stock_Inicial FLOAT, Stock FLOAT, ADU FLOAT, Transito FLOAT, IdRazon INT, CodigoBodega NVARCHAR(50))

ALTER TABLE HistRazon 
ADD FOREIGN KEY (IdRazon)
REFERENCES Razones (IdRazon)

INSERT INTO Razones VALUES('Ninguno')

--------------- Prueba el PROC con esto -----------------------------

USE [WA_DEMO_MAGNO]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[GetHistRazones]
		@FechaInicial = "2021/03/17",
		@FechaFinal = "2021/04/03",
		@Referencia = N'1004002',
		@CodigoBodega = 'CN31'
SELECT	'Return Value' = @return_value

GO

USE [WA_DEMO_MAGNO]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[PronosticoStock]
		@FechaInicial = "2021/03/17",
		@FechaFinal = "2021/04/03",
		@Referencia = N'1004002',
		@CodigoBodega = 'CN31'

SELECT DATEDIFF (DAY, '2021/03/17', '2021/04/03')


ALTER PROC GetHistRazones
@FechaInicial DATE,
@FechaFinal DATE,
@Referencia NVARCHAR(50),
@CodigoBodega NVARCHAR(50)
AS
SELECT HR.Dia, HR.Referencia, HR.Descripcion, HR.Stock_Inicial, HR.Stock, HR.ADU, HR.Transito, RZ.Razon, HR.CodigoBodega FROM HistRazon HR
INNER JOIN Razones RZ ON HR.IdRazon = RZ.IdRazon
WHERE Referencia = @Referencia AND CodigoBodega = @CodigoBodega AND (Dia BETWEEN @FechaInicial AND @FechaFinal)
GO