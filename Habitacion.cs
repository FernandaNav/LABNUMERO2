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
        public int NumeroHabitacion { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponibilidad { get; set; } 
        public string NombreCliente { get; set; }

        public Habitacion(double precioPorNoche, bool disponibilidad, string nombreCliente)
        {
            NumeroHabitacion = 0;
            PrecioPorNoche = precioPorNoche;
            Disponibilidad = disponibilidad;
            NombreCliente = nombreCliente;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Número de Habitación: {NumeroHabitacion}");
            Console.WriteLine($"Precio por noche: Q");
            Console.WriteLine($"Disponibilidad: ");
            Console.WriteLine($"Nombre de Cliente : {NombreCliente}");
        }
        public bool CambiarDisponibilidad(bool disponibilidad)
        {
            if(disponibilidad = true)
            {
                Console.WriteLine("La habitación está disponible.");
                Console.WriteLine("Presine ENTER para cambiar disponibilidad");
                Console.ReadKey(); Console.Clear(); disponibilidad = false;
                Console.WriteLine("La habitación ya no está disponible");
                AsignarCliente();
            }else if (disponibilidad = false)
            {
                Console.WriteLine("La habitación no está disponible.");
                Console.WriteLine("Presine ENTER para cambiar disponibilidad");
                Console.ReadKey(); Console.Clear(); disponibilidad = true;
                Console.WriteLine("La habitación ya no está disponible");
                Liberar();
            }
            return disponibilidad;
        }

        public string AsignarCliente()
        {
            Console.Write("Agrega el nombre del cliente: ");
            NombreCliente = Console.ReadLine();
            return NombreCliente;
        }

        public string Liberar()
        {
            NombreCliente = "";
            return NombreCliente;
        }
    }
}
