﻿using LABNUMERO2;

class program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        List<Habitacion> listaHabitaciones = new List<Habitacion>();
        Habitacion nuevaHabitacion = new Habitacion(0, true, "");
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------");
            Console.WriteLine("         BIENVENIDO");
            Console.WriteLine("------------------------------");
            Console.ResetColor(); Console.WriteLine();
            Console.WriteLine("Opción 1: Agregar Habitación");
            Console.WriteLine("Opción 2: Eliminar Habitación");
            Console.WriteLine("Opción 3: Mostrar Habitación");
            Console.WriteLine("Opción 4: Liberar Habitación");
            Console.WriteLine("Opción 5: Salir");
            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ingresa el no. de opción: "); Console.ResetColor();
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     AGREGAR HABITACION");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        Console.WriteLine("¿Qué tipo de habitación desea agregar?");
                        Console.WriteLine("1. Habitación Simple");
                        Console.WriteLine("2. Habitación Doble");
                        Console.WriteLine("3. Suite");
                        Console.WriteLine("4. Habitación Deluxe");
                        nuevaHabitacion.MensajeContinuar();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     ELIMINAR HABITACIÓN");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        nuevaHabitacion.MensajeContinuar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     MOSTRAR HABITACIÓN");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        nuevaHabitacion.MensajeContinuar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     LIBERAR HABITACION");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        nuevaHabitacion.MensajeContinuar();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     Ten un buen día.");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        nuevaHabitacion.MensajeContinuar();
                        break;
                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Esta opcion no existe. Intenta de nuevo...");
                        nuevaHabitacion.MensajeContinuar();
                        break;
                }
            }
            catch (FormatException)
            {
                nuevaHabitacion.MensajeError();
                nuevaHabitacion.MensajeContinuar();
            }
        } while (opcion != 5);
    }
}