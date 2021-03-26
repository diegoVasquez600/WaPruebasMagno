------------------------- Ejercicio General 1 -------------------------------------

SELECT Productos.IdProducto, Productos.Referencia, Bodegas.Codigo FROM Tbl_ProductoBodega PB
INNER JOIN Tbl_Productos Productos ON PB.IdProducto  = Productos.IdProducto
INNER JOIN Tbl_Bodegas Bodegas ON PB.IdBodega = Bodegas.IdBodega WHERE TamBufferDDMRP > 0

------------------------- Ejercicio General 2 -------------------------------------

SELECT * FROM Tbl_Productos WHERE IdProducto NOT IN (SELECT IdProducto FROM Tbl_ProductoBodega)

------------------------- Ejercicio General 3 -------------------------------------

/* Nota:  Cree Tbl_Productos_3 ya que la Tbl_Productos_2 y estaba en la Base de Datos */

-------- Crear Tabla Tbl_Productos_3 --------
CREATE TABLE Tbl_Productos_3
(
	IdProducto int NOT NULL,
	Referencia nvarchar(50) NULL,
	ReferenciaAux nvarchar(100) NULL,
	Descripcion nvarchar(200) NULL,
	EsInsumo bit NULL,
	EsProducto bit NULL,
	UnidadMedida nvarchar(50) NULL,
	CostoPromedio numeric(18, 2) NULL,
	CostoUltimo numeric(18, 2) NULL,
	PrecioPromedio numeric(18, 2) NULL,
	PrecioUltimo numeric(18, 2) NULL,
	Estado bit NULL,
	IdBodegaEntrada int NULL,
	IdBodegaSalida int NULL,
	FechaActualizacion datetime NULL,
	FechaCreacion datetime NULL,
	IdFamilia int NULL,
	IdLinea int NULL,
	IdPlanta int NULL,
	IdSupLinea int NULL,
	Iva numeric(18, 0) NULL,
	CodigoBarras nvarchar(100) NULL,
	EsServicio bit NULL,
	IdClienteDefecto int NULL,
	Buffer numeric(18, 2) NULL,
	IdAsesor int NULL,
	IdDisenador int NULL,
	ObservacionesCliente text NULL,
	CampoAd1 nvarchar(400) NULL,
	CampoAd2 nvarchar(400) NULL,
	CampoAd3 numeric(18, 10) NULL,
	IdProveedorDefecto int NULL,
	CampoAd4 nvarchar(400) NULL,
	CampoAd5 nvarchar(400) NULL,
	Peso numeric(18, 10) NULL,
	Volumen numeric(18, 10) NULL,
	Color nvarchar(50) NULL,
	IdEtiqueta int NULL,
	EsMaestro bit NULL,
	NivelBOM int NULL,
	CampoAd7 nvarchar(50) NULL,
	CampoAd8 nvarchar(50) NULL,
	CampoAd9 nvarchar(50) NULL,
	CampoAd10 nvarchar(50) NULL,
	CampoAd11 nvarchar(50) NULL,
	CampoAd12 nvarchar(50) NULL,
	CampoAd13 nvarchar(50) NULL,
	IdProductoMaxNivelBOM int NULL,
	CampoAd_Num1 numeric(18, 4) NULL
);

-------- Ingresar Top 10 de los registros de Tbl_Productos --------

INSERT INTO Tbl_Productos_3 SELECT TOP 10 * FROM Tbl_Productos

-------- Eliminar los 10 Prouctos desde Tbl_Productos --------

DELETE TOP (10) FROM Tbl_Productos WHERE IdProducto = (SELECT IdProducto FROM Tbl_Productos_3)

------------------------- Ejercicio General 4 -------------------------------------

SELECT * FROM Tbl_HistorialStockMP WHERE (Fecha BETWEEN '2021-01-01' AND '2021-03-27') AND Salidas > 10.0