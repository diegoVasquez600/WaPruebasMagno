using DevExpress.XtraGrid.Views.Grid;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WAMagno.UI
{
    public partial class PronosticoStock : Form
    {

        #region Fields

        PronosticoStockDTO objDTO;
        DataTable data;
        List<Models.Razones> rzList;
        RazonesDTO razonesDTO;
        #endregion


        #region Constructors

        public PronosticoStock()
        {
            InitializeComponent();
            data = new DataTable();
            rzList = new List<Models.Razones>();
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

        private void ListRazones_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Cambio seleccion");
        }

        private void buttonRazon_Click(object sender, EventArgs e)
        {
            Razones historialRazones = new Razones();
            historialRazones.ShowDialog();
        }

        private void gridViewPronostico_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;

            if (e.RowHandle >= 0)
            {
                string el_stock = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Stock_Inicial"]);
                if (el_stock == "0,00" || el_stock.Trim() == "")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Red);
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        #endregion


        #region Methods

        private void FillPronosticoStock()
        {
            objDTO = new PronosticoStockDTO();
            razonesDTO = new RazonesDTO();
            gridPronostico.DataSource = objDTO.PronosticoStock(DateTime.Parse(fechaInicial.Text), DateTime.Parse(fechaFinal.Text), txtReferencia.Text, txtCodigoBodega.Text);
            FillCombo();
            
        }


        private void FillCombo()
        {
            listRazones.Items.Clear();
            listRazones.SelectedValueChanged += ListRazones_SelectedValueChanged;
            var razon = razonesDTO.GetRazones();
            for (int i = 0; i < razon.Rows.Count; i++)
            {
                Models.Razones rz = new Models.Razones
                {
                    IdRazon = Convert.ToInt32(razon.Rows[i]["IdRazon"]),
                    Razon = razon.Rows[i]["Razon"].ToString()
                };
                listRazones.Items.Add(rz.Razon);
            }
        }


        #endregion


    }
}
