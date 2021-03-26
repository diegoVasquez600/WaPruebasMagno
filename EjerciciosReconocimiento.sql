------------------------- Ejercicio de Reconocimiento 1 ------------------------------------

SELECT IdProducto FROM Tbl_Productos WHERE IdProducto NOT IN (SELECT IdProducto FROM Tbl_ProductoBodega)

------------------------- Ejercicio de Reconocimiento 2 ------------------------------------

INSERT INTO Tbl_ProductoBodega (IdProducto) SELECT IdProducto FROM Tbl_Productos WHERE IdProducto NOT IN (SELECT IdProducto FROM Tbl_ProductoBodega)

------------------------- Ejercicio de Reconocimiento 3 -------------------------------------

SELECT ProductoTransladosBodega.Referencia, ProductoTransladosBodega.IdProducto, PB.Stock, ProductoTransladosBodega.Cantidad FROM Tbl_BodegasTrasladosProductos AS ProductoTransladosBodega LEFT OUTER JOIN 
Tbl_ProductoBodega AS PB ON PB.IdProducto = ProductoTransladosBodega.IdProducto 
WHERE (ProductoTransladosBodega.Cantidad > PB.Stock)

------------------------- Ejercicio de Reconocimiento 4 -------------------------------------

SELECT ProductoBodega.IdProducto, COUNT(ProductoBodega.IdProducto) AS CantSalidas
FROM Tbl_ProductoBodega AS ProductoBodega LEFT OUTER JOIN 
Tbl_BodegasTrasladosProductos AS HT ON HT.IdProducto = ProductoBodega.IdProducto 
WHERE (HT.FechaEnvio BETWEEN '2021-01-01' AND '2021-03-27')
GROUP BY ProductoBodega.IdProducto HAVING COUNT(ProductoBodega.IdProducto) > 3

