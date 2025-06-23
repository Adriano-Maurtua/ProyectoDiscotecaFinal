using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscotecaFinal
{
    public class Promocion
    {
        public int NroPromocion { get; set; }
        public string Nombre { get; set; }
        public string Porcentaje { get; set; }
        public string FechaVencimiento { get; set; }

        public override string ToString()
        {
            return $"{NroPromocion}|{Nombre}|{Porcentaje}|{FechaVencimiento}";
        }
    }
}
