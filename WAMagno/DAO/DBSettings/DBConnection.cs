using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DBSettings
{
    public class DBConnection
    {
        //private SqlConnection conection = new SqlConnection("Server=Localhost;Database=Neptuno;integrated security=True;");
        private SqlConnection conection = new SqlConnection("Server=54.200.234.56;Database=WA_DEMO_MAGNO;user id=practicasWA;password=WA12345");
        public SqlConnection AbrirConection()
        {
            if (conection.State == ConnectionState.Closed)
                conection.Open();
            return conection;
        }
        public SqlConnection CerrarConection()
        {
            if (conection.State == ConnectionState.Open)
                conection.Close();
            return conection;
        }

    }
}
