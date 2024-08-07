using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNUMERO2
{
    public class Deluxe: Habitacion
    {
        public string ServiciosExtras {  get; set; }
        public Deluxe(double precioPorNoche, bool disponibilidad, string nombreCliente, string serviciosExtras)
            : base(precioPorNoche, disponibilidad, nombreCliente)
        {
            ServiciosExtras = serviciosExtras;
        }

    }
}
