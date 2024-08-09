using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNUMERO2
{
    public class HabitacionSimple: Habitacion
    {
        public int NumeroDeCamas { get; set; }
        public HabitacionSimple(double precioPorNoche, bool disponibilidad, string nombreCliente, int numeroDeCamas)
            : base(precioPorNoche, disponibilidad, nombreCliente)
        {
            NumeroDeCamas = numeroDeCamas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); //esto es para mostrar los atributos que vienen desde la super clase
            Console.WriteLine($"Número de camas: {NumeroDeCamas}");
        }
    }
}
