---------------- Crear Funcion para conocer el mobre del mes en Español


CREATE FUNCTION MesesEnEspanol
(
	@Fecha AS DATE
)
RETURNS VARCHAR(20)
AS
BEGIN
DECLARE @NumMes AS INT;
DECLARE @NombreMes as VARCHAR(50)
	SELECT @NumMes= MONTH(@Fecha)

	SELECT @NombreMes = CASE 
				WHEN @NumMes = 1 THEN 'Enero'
				WHEN @NumMes = 2 THEN 'Febrero'
				WHEN @NumMes = 3 THEN 'Marzo' 
				WHEN @NumMes = 4 THEN 'Abril'
				WHEN @NumMes = 5 THEN 'Mayo'
				WHEN @NumMes = 6 THEN 'Junio'
				WHEN @NumMes = 7 THEN 'Julio'
				WHEN @NumMes = 8 THEN 'Agosto'
				WHEN @NumMes = 9 THEN 'Septiembre'
				WHEN @NumMes = 10 THEN 'Octubre'
				WHEN @NumMes = 11 THEN 'Noviembre'
				WHEN @NumMes = 12 THEN 'Noviembre'

				END 

	-- Return the result of the function
	RETURN @NombreMes

END
GO




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
		 ------ SET @FechaActual = DATEADD(MONTH, 1, @FechaActual) ------
		CONTINUE  
	END  
GO



EXEC SeguimientoHistorial
@FechaInicial = "2021/03/17",
@FechaFinal = "2021/04/30"

GO




DECLARE @Cad as NVARCHAR(max)
DECLARE @params as NVARCHAR(max)
DECLARE @comodin1 as VARCHAR(20)
DECLARE  @comodin2 as VARCHAR(20)
set @comodin1='mesYear>'
set @comodin2='</'


SELECT @params= replace(replace(replace(res,'<mesYear>',''),'</mesYear>',''),'<esYear>','')  FROM (SELECT  STUFF(
 (
SELECT * FROM (
SELECT distinct
   ',' + QUOTENAME(LTRIM(mesYear)) as [mesYear]
 FROM
   (SELECT       dbo.MesesEnEspanol()(Fecha)+convert(VARCHAR(5),year(Fecha)) as mesYear
FROM            Tbl_HistorialStockMP
WHERE fecha between '20200129' and '20200201'
GROUP BY IdProducto, Fecha, IdBodega, Referencia
   ) AS T
) AS Q

   ORDER BY
 Q.mesYear
 FOR XML PATH('')
 ), 1, 1, '') as res) as qq;

 SELECT @params= REPLACE(SUBSTRING(@params,2,len(@params)),'esYear>,','')
 SELECT @params
SELECT  @cad = N'

 SELECT * FROM (SELECT MesesEnEspanol(Fecha) + CONVERT(VARCHAR(5), YEAR(Fecha)) AS mesYear, IdBodega, Referencia, IdProducto, SUM(CostoUnitario) AS suma
FROM            Tbl_HistorialStockMP
WHERE fecha between ''20200129'' and ''20200201''
GROUP BY IdProducto, Fecha, IdBodega, Referencia
) as q
pivot 
(
sum(suma)
for[mesYear] in ('+@params+N')
)as p;';


EXEC sp_executesql  @Cad



