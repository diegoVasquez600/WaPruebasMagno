using System;

namespace WAMagno.Models
{
    public class Pronostico
    {
        public DateTime Dia { get; set; }
        public float Stock { get; set; }
        public float Stock_Inical { get; set; }
        public float ADU { get; set; }
        public string Codigo { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public float CantTotalInsumo { get; set; }
        public int Razon { get; set; }

    }

}
