﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class PronosticoStockDTO
    {
        private DataTable table;
        private PronosticoStockDAO objDAO;

        public PronosticoStockDTO()
        {
            objDAO = new PronosticoStockDAO();
        }

        public DataTable PronosticoStock(DateTime FechaInicial, DateTime FechaFinal, string Referencia, string CodigoBodega)
        {
            table = new DataTable();
            table = objDAO.PronosticoStock(FechaInicial, FechaFinal, Referencia, CodigoBodega);
            return table;
        } 
    }
}
