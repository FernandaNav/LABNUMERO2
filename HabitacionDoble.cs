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
        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); //esto es para mostrar los atributos que vienen desde la super clase
            Console.WriteLine($"¿Tiene vista al mar? (true/si;false/no): {VistaAlMar}");
        }
    }
}
