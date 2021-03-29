------------------- Proyecto Pronostico Stock -------------------

CREATE PROC PronosticoStock
@FechaInicial DATE,
@FechaFinal DATE,
@Referencia NVARCHAR(50),
@CodigoBodega VARCHAR(50)
AS
  SELECT FechaEntrega AS Dia, PB.Stock - ADU + CantTotalInsumo AS Stock, PB.Stock AS Stock_Inicial, PB.ADU, Bodega.Codigo, PB.Referencia, Producto.Descripcion, CantTotalInsumo FROM Vs_InventarioEnTransitoAcumulado_BETA, Tbl_ProductoBodega PB
  INNER JOIN Tbl_Bodegas Bodega on PB.IdBodega = (SELECT IdBodega FROM Tbl_Bodegas WHERE Codigo = @CodigoBodega)
  INNER JOIN Tbl_Productos Producto ON PB.IdProducto = (SELECT IdProducto FROM Tbl_Productos WHERE Referencia = @Referencia) WHERE (FechaEntrega BETWEEN @FechaInicial AND @FechaFinal)
GO