using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WAMagno.UI
{
    public partial class PronosticoStock : Form
    {

        #region Fields

        PronosticoStockDTO objDTO;
        DataTable data;

        #endregion

        #region Constructors

        public PronosticoStock()
        {
            InitializeComponent();
            objDTO = new PronosticoStockDTO();
            data = new DataTable();
        } 

        #endregion


        #region Events

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FillPronosticoStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        } 

        #endregion


        #region Methods

        private void FillPronosticoStock()
        {

        } 

        #endregion


    }
}
