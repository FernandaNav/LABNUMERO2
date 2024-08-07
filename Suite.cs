using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNUMERO2
{
    public class Suite: Habitacion
    {
        public int NumeroDeHabitaciones {  get; set; }
        public bool TieneJacuzzi { get; set; }
        public Suite(double precioPorNoche, bool disponibilidad, string nombreCliente, int numeroDeHabitaciones, bool tieneJacuzzi)
            : base(precioPorNoche, disponibilidad, nombreCliente)
        {
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }
    }
}
