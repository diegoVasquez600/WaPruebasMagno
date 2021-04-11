using DAO.DBSettings;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class RazonesDAO
    {
        private DBConnection connection;
        SqlDataReader Reader;
        private SqlCommand command;
        private DataTable table;

        public RazonesDAO()
        {
            connection = new DBConnection();
            table = new DataTable();
            command = new SqlCommand();
        }

        public DataTable GetRazones()
        {
            command.Connection = connection.AbrirConection();
            command.CommandText = "GetRazones";
            command.CommandType = CommandType.StoredProcedure;
            Reader = command.ExecuteReader();
            table.Load(Reader);
            Reader.Close();
            connection.CerrarConection();
            return table;
        }

        public void InsertarRazon(string Razon)
        {
            command.Connection = connection.AbrirConection();
            command.CommandText = "InsertarRazones";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Razon", Razon);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

    }
}
