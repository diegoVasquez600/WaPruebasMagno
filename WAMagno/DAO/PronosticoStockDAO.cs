using DAO.DBSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class PronosticoStockDAO
    {
        private DBConnection connection;
        SqlDataReader Reader;
        private SqlCommand command;
        private DataTable table;
        public PronosticoStockDAO()
        {
            connection = new DBConnection();
            table = new DataTable();
            command = new SqlCommand();
        }
        public DataTable PronosticoStock(DateTime FechaInicial, DateTime FechaFinal, string Referencia, string CodigoBodega)
        {
            command.Connection = connection.AbrirConection();
            command.CommandText = "PronosticoStock";
            command.Parameters.AddWithValue("@FechaInicial", FechaInicial);
            command.Parameters.AddWithValue("@FechaFinal", FechaFinal);
            command.Parameters.AddWithValue("@Referencia", Referencia);
            command.Parameters.AddWithValue("@CodigoBodega", CodigoBodega);
            command.CommandType = CommandType.StoredProcedure;
            Reader = command.ExecuteReader();
            table.Load(Reader);
            Reader.Close();
            connection.CerrarConection();
            return table;
        }
    }
}
