using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNUMERO2
{
    public class Habitacion
    {
        public static int contador = 0;
        public int NumeroHabitacion { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponibilidad { get; set; } 
        public string NombreCliente { get; set; }

        public Habitacion(double precioPorNoche, bool disponibilidad, string nombreCliente)
        {
            NumeroHabitacion = contador++;
            PrecioPorNoche = precioPorNoche;
            Disponibilidad = disponibilidad;
            NombreCliente = nombreCliente;
        }

        public virtual void MostrarInformacion()
        {
            Console.ResetColor(); Console.WriteLine($"Número de Habitación: {NumeroHabitacion}");
            Console.WriteLine($"Precio por noche: Q{PrecioPorNoche}");
            Console.WriteLine($"Disponibilidad: {Disponibilidad}");
            Console.WriteLine($"Nombre de Cliente: {NombreCliente}");
        }
        public void CambiarDisponibilidad(bool disponible)
        {
            if (Disponibilidad == disponible)
            {
                Console.WriteLine("La habitación ya está en el estado deseado.");
            }
            else
            {
                Disponibilidad = disponible;
                if (Disponibilidad)
                {
                    Liberar();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("La habitación ahora está disponible.");
                }
                else
                {
                    AsignarCliente();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("La habitación ha sido asignada.");
                }
                Console.ResetColor();
            }
        }

        public string AsignarCliente()
        {
            Console.Write("Agrega el nombre del cliente: ");
            NombreCliente = Console.ReadLine();
            return NombreCliente;
        }

        public string AsignarHabitacion(string nombreCliente)
        {
            NombreCliente = nombreCliente;
            Disponibilidad = false;
            return NombreCliente;
        }

        public string Liberar()
        {
            NombreCliente = "";
            return NombreCliente;
        }
    }
}
