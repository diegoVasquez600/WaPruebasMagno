using DAO;
using System;
using System.Data;

namespace DTO
{
    public class PronosticoStockDTO
    {
        #region Fields
        private DataTable table;
        private PronosticoStockDAO objDAO;
        #endregion

        #region Methods

        public DataTable PronosticoStock(DateTime FechaInicial, DateTime FechaFinal, string Referencia, string CodigoBodega)
        {
            objDAO = new PronosticoStockDAO();
            table = new DataTable();
            table = objDAO.PronosticoStock(FechaInicial, FechaFinal, Referencia, CodigoBodega);
            return table;
        }

        public void ActualizarHistRazon(string IdHistRazon, string Razon)
        {
            objDAO = new PronosticoStockDAO();
            objDAO.ActualizarHistRazones(int.Parse(IdHistRazon), Razon);
        }

        #endregion
    }
}
