using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNUMERO2
{
    public class HabitacionDoble: Habitacion
    {
        public bool VistaAlMar {  get; set; }
        public HabitacionDoble(double precioPorNoche, bool disponibilidad, string nombreCliente, bool vistaAlMar)
            : base(precioPorNoche, disponibilidad, nombreCliente)
        {
            VistaAlMar = vistaAlMar;
        }
    }
}
