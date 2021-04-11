using DAO;
using System.Data;

namespace DTO
{
    public class RazonesDTO
    {
        #region Fields
        private DataTable table;
        private RazonesDAO objDAO;
        #endregion


        #region Methods

        public DataTable GetRazones()
        {
            objDAO = new RazonesDAO();
            table = new DataTable();
            table = objDAO.GetRazones();
            return table;
        }

        public void InsertarRazones(string Razon)
        {
            objDAO = new RazonesDAO();
            objDAO.InsertarRazon(Razon);
        }

        #endregion

    }
}
