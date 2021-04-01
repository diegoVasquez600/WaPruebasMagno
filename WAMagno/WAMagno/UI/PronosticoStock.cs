using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace WAMagno.UI
{
    public partial class PronosticoStock : Form
    {
        PronosticoStockDTO objDTO;
        public PronosticoStock()
        {
            InitializeComponent();
            objDTO = new PronosticoStockDTO();
        }

        private void FillPronosticoStock()
        {
            gridPronostico.DataSource = objDTO.PronosticoStock(Convert.ToDateTime(fechaInicial.Text), Convert.ToDateTime(fechaFinal.Text), txtReferencia.Text, txtCodigoBodega.Text);
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
