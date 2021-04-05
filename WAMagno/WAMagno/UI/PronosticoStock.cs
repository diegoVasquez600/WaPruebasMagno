using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WAMagno.UI
{
    public partial class PronosticoStock : Form
    {
        PronosticoStockDTO objDTO;
        DataTable data;
        public PronosticoStock()
        {
            InitializeComponent();
            objDTO = new PronosticoStockDTO();
            data = new DataTable();
        }

        private void FillPronosticoStock()
        {
            data = objDTO.PronosticoStock(Convert.ToDateTime("2020/01/10"), Convert.ToDateTime("2021/01/01"),
                "1027464", "CN29");
            lblRef.Text = fechaInicial.Text;
            //IEnumerable<Pronostico> pronosticoStock = new List<Pronostico>();
            //pronosticoStock = (from DataRow dr in data.Rows select new Pronostico()
            //{
            //    Dia = Convert.ToDateTime(dr["Dia"].ToString()),
            //    Stock = float.Parse(dr["Stock"].ToString()),
            //    Stock_Inical = float.Parse(dr["Stock_Inicial"].ToString()),
            //    ADU = float.Parse(dr["ADU"].ToString()),
            //    Codigo = dr["Codigo"].ToString(),
            //    Referencia = dr["Referencia"].ToString(),
            //    Descripcion = dr["Descripcion"].ToString(),
            //    CantTotalInsumo = float.Parse(dr["CantTotalInsumo"].ToString())
            //}).ToList();
            gridPronostico.DataSource = data;

        }

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
    }
}
