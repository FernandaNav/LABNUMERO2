using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNUMERO2
{
    public class Mensajes
    {
        public void MensajeError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error de formato. Intenta de nuevo...");
            Console.ResetColor();
        }
        public void MensajeContinuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Pulsa cualquier tecla para continuar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }
    }
}
