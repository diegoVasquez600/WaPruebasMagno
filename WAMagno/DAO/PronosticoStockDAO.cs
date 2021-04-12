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
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FechaInicial", FechaInicial);
            command.Parameters.AddWithValue("@FechaFinal", FechaFinal);
            command.Parameters.AddWithValue("@Referencia", Referencia);
            command.Parameters.AddWithValue("@CodigoBodega", CodigoBodega);
            Reader = command.ExecuteReader();
            table.Load(Reader);
            Reader.Close();
            connection.CerrarConection();
            return table;
        }
        public void ActualizarHistRazones(int IdHistRazon, string Razon)
        {
            command.Connection = connection.AbrirConection();
            command.CommandText = "ActualizarHistRazones";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdHistRazon", IdHistRazon);
            command.Parameters.AddWithValue("@Razon", Razon);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }


    }
}
