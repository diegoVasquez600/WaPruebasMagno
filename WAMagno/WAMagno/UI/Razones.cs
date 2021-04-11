using DTO;
using System;
using System.Windows.Forms;

namespace WAMagno.UI
{
    public partial class Razones : Form
    {
        public Razones()
        {
            InitializeComponent();
            FillRazones();
        }

        #region Methods

        private void FillRazones()
        {
            RazonesDTO objDTO = new RazonesDTO();
            gridRazones.DataSource = objDTO.GetRazones();
        }

        #endregion

        #region Events

        private void buttonGuardarRazon_Click(object sender, EventArgs e)
        {
            try
            {
                RazonesDTO objDTO = new RazonesDTO();
                objDTO.InsertarRazones(txtRazon.Text);
                MessageBox.Show("Razon Insertada Correctamente", "Completado");
                txtRazon.Text = string.Empty;
                FillRazones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        #endregion
    }
}
