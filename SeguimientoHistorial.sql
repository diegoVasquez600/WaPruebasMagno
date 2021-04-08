ALTER PROC SeguimientoHistorial
@FechaInicial DATE,
@FechaFinal DATE
AS
    DECLARE @FechaActual DATE 
    DECLARE @SeguimientoHistorial TABLE (IdProducto INT, IdBodega INT, Referencia NVARCHAR(50), Descripcion VARCHAR(max))
    SELECT Top 10 hs.Fecha, hs.IdProducto, hs.IdBodega, prod.Referencia, prod.Descripcion FROM Tbl_HistorialStockMP hs
    INNER JOIN Tbl_Productos prod ON hs.IdProducto = prod.IdProducto WHERE (Fecha BETWEEN @FechaInicial AND @FechaFinal)
    SET @FechaActual = @FechaInicial
    WHILE @FechaActual != @FechaFinal
    BEGIN
		SET @FechaActual = DATEADD(MONTH, 1, @FechaActual)
		PRINT(@FechaActual)
		CONTINUE  
	END  
GO

EXEC SeguimientoHistorial
@FechaInicial = "2021/03/17",
@FechaFinal = "2021/04/03"