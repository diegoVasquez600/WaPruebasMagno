------------------------- Ejercicio de Reconocimiento 1 ------------------------------------

SELECT IdProducto FROM Tbl_Productos WHERE IdProducto NOT IN (SELECT IdProducto FROM Tbl_ProductoBodega)

------------------------- Ejercicio de Reconocimiento 2 ------------------------------------

INSERT INTO Tbl_ProductoBodega (IdProducto) SELECT IdProducto FROM Tbl_Productos WHERE IdProducto NOT IN (SELECT IdProducto FROM Tbl_ProductoBodega)

------------------------- Ejercicio de Reconocimiento 3 -------------------------------------

SELECT Referencia FROM Tbl_BodegasTrasladosProductos WHERE Cantidad > (SELECT Stock FROM Tbl_ProductoBodega)

------------------------- Ejercicio de Reconocimiento 4 -------------------------------------

SELECT E.IdProducto, COUNT(E.IdProducto) AS CantSalidas
FROM Tbl_ProductoBodega AS E LEFT OUTER JOIN 
Tbl_BodegasTrasladosProductos AS HT ON HT.IdProducto = E.IdProducto 
WHERE (HT.FechaEnvio BETWEEN '2021-01-01' AND '2021-03-27')
GROUP BY E.IdProducto

