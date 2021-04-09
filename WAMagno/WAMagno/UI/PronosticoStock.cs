using DevExpress.XtraGrid.Views.Grid;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WAMagno.Models;

namespace WAMagno.UI
{
    public partial class PronosticoStock : Form
    {

        #region Fields

        PronosticoStockDTO objDTO;
        DataTable data;
        List<Razones> rz;
        #endregion

        #region Constructors

        public PronosticoStock()
        {
            InitializeComponent();
            objDTO = new PronosticoStockDTO();
            data = new DataTable();
            rz = new List<Razones>();
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
            rz.Add(
            new Razones() { IdRazon = 2, Razon = "Ninguno" }
            );
            rz.Add(new Razones()
            {
                IdRazon = 1,
                Razon = "Razon 1"
            });
            rz.Add(new Razones()
            {
                IdRazon = 3,
                Razon = "Razon 2"
            });

            gridPronostico.DataSource = objDTO.PronosticoStock(DateTime.Parse(fechaInicial.Text), DateTime.Parse(fechaFinal.Text), txtReferencia.Text, txtCodigoBodega.Text);
            //listRazones.Items.Add(rz);
            histRazonesDataSetBindingSource.Add("Ninguno");
            histRazonesDataSetBindingSource.Add("Razon 1");
            histRazonesDataSetBindingSource.Add("Razon 2");
            
            
        }


        #endregion

        private void buttonRazon_Click(object sender, EventArgs e)
        {
            HistorialRazones historialRazones = new HistorialRazones();
            historialRazones.ShowDialog();
        }

        private void gridViewPronostico_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            
            if (e.RowHandle >= 0)
            {
                string el_stock = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Stock"]);
                if (el_stock == "0,00" || el_stock.Trim() == "")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Red);
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }
    }
}
