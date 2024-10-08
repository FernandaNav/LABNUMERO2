﻿using LABNUMERO2;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
    static void Main(string[] args)
    {
        int opcion = 0, opcionHabitacion = 0;
        bool disponibilidad = false, validarPrecio = false; string nombreCliente = ""; double precioPorNoche = 1;
        Mensajes mensajes = new Mensajes();
        List<Habitacion> listaHabitaciones = new List<Habitacion>();
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
            Console.WriteLine("Opción 5: Asignar Habitación");
            Console.WriteLine("Opción 6: Salir");
            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ingresa el no. de opción: "); Console.ResetColor();
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        bool accionCompletada = false;
                        do
                        {
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
                            Console.WriteLine("5. Ninguna");
                            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Ingresa el no. de opción: "); Console.ResetColor();
                            try
                            {
                                opcionHabitacion = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
                                if (opcionHabitacion == 5)
                                    Console.Clear();
                                if (opcionHabitacion == 1 || opcionHabitacion == 2 || opcionHabitacion == 3 || opcionHabitacion == 4)
                                {
                                    Console.WriteLine("---------------------------------");
                                    do
                                    {
                                        Console.Write("Ingresa el precio por noche: Q");
                                        try
                                        {
                                            precioPorNoche = Convert.ToDouble(Console.ReadLine());
                                            if (precioPorNoche <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El precio no puede ser menor o igual a 0.");
                                            }
                                            else
                                            {
                                                validarPrecio = true;
                                            }
                                        }
                                        catch (FormatException)
                                        {
                                            mensajes.MensajeError();
                                        }
                                    } while (validarPrecio == false);
                                    Console.Write("¿Está disponible? (Si/No): ");
                                    string disponible = Console.ReadLine();
                                    if (disponible.ToLower() == "si")
                                    {
                                        disponibilidad = true;
                                    }
                                    if (disponibilidad == false)
                                    {
                                        Console.Write("Ingresa el nombre del cliente: ");
                                        nombreCliente = Console.ReadLine();
                                    }
                                    switch (opcionHabitacion)
                                    {
                                        case 1:
                                            int numeroDeCamas = 0;
                                            bool validaNumero1 = false;
                                            do
                                            {
                                                Console.Write("Ingresa el número de camas: ");
                                                try
                                                {
                                                    numeroDeCamas = Convert.ToInt32(Console.ReadLine());
                                                    if (numeroDeCamas <= 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El numero de camas no puede ser menor o igual a 0.");
                                                    }
                                                    else
                                                    {
                                                        validaNumero1 = true;
                                                        HabitacionSimple nuevaHabitacionSimple = new HabitacionSimple(precioPorNoche, disponibilidad, nombreCliente, numeroDeCamas);
                                                        listaHabitaciones.Add(nuevaHabitacionSimple);
                                                        accionCompletada = true;
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    mensajes.MensajeError();
                                                }
                                            } while (validaNumero1 == false);
                                            break;
                                        case 2:
                                            bool vistaAlMar = false;
                                            Console.Write("¿La habitación tiene vista al mar (SI/NO)?: ");
                                            string siNo = Console.ReadLine();
                                            if (siNo.ToLower() == "si")
                                            {
                                                vistaAlMar = true;
                                            }
                                            HabitacionDoble nuevaHabitacionDoble = new HabitacionDoble(precioPorNoche, disponibilidad, nombreCliente, vistaAlMar);
                                            listaHabitaciones.Add(nuevaHabitacionDoble);
                                            accionCompletada = true;
                                            break;
                                        case 3:
                                            int numeroHabitaciones = 0;
                                            bool validarNumero2 = false, jacuzzi = false;
                                            do
                                            {
                                                Console.ResetColor(); Console.Write("Ingresa el número de habitaciones: ");
                                                try
                                                {
                                                    numeroHabitaciones = Convert.ToInt32(Console.ReadLine());
                                                    if (numeroHabitaciones <= 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El numero de habitaciones no puede ser menor o igual a 0.");
                                                    }
                                                    else
                                                    {
                                                        validarNumero2 = true;
                                                        Console.Write("¿La habitación tiene jacuzzi (SI/NO)?: ");
                                                        string siONo = Console.ReadLine();
                                                        if (siONo.ToLower() == "si")
                                                            jacuzzi = true;
                                                        Suite nuevaSuite = new Suite(precioPorNoche, disponibilidad, nombreCliente, numeroHabitaciones, jacuzzi);
                                                        listaHabitaciones.Add(nuevaSuite);
                                                        accionCompletada = true;
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    mensajes.MensajeError();
                                                }
                                            } while (validarNumero2 == false);
                                            break;
                                        case 4:
                                            Console.Write("Ingresa el servicio extra: ");
                                            string extraServicio = Console.ReadLine();
                                            Deluxe nuevaDeluxe = new Deluxe(precioPorNoche, disponibilidad, nombreCliente,extraServicio);
                                            listaHabitaciones.Add(nuevaDeluxe);
                                            accionCompletada = true;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Esta opcion no existe. Intenta de nuevo...");
                                            break;
                                    }
                                }
                            }
                            catch (FormatException)
                            {
                                mensajes.MensajeError();
                            }
                        } while (accionCompletada==false);
                        mensajes.MensajeContinuar();
                        break;
                    case 2:
                        Console.Clear(); bool habitacionEncontrada=false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     ELIMINAR HABITACIÓN");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        Console.Write("Ingresa el número de habitación que quieres eliminar: ");
                        string numHabitacion = Console.ReadLine();
                        int numero = Convert.ToInt32(numHabitacion);
                        for (int i = 0; i < listaHabitaciones.Count; i++)
                        {
                            if (listaHabitaciones[i].NumeroHabitacion == numero)
                            {
                                habitacionEncontrada = true;
                                listaHabitaciones.RemoveAt(i);
                                break;
                            }
                        }
                        if (!habitacionEncontrada)
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Esta habitación no existe.");
                        mensajes.MensajeContinuar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     MOSTRAR HABITACIÓN");
                        Console.WriteLine("----------------------------");
                        foreach(var habitacion in listaHabitaciones)
                        {
                            habitacion.MostrarInformacion();
                            Console.WriteLine();
                        }
                        mensajes.MensajeContinuar();
                        break;
                    case 4:
                        Console.Clear(); bool habitacionExistente = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     LIBERAR HABITACION");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        Console.Write("Ingresa el número de habitación que quieres liberar: ");
                        string numHabitacion2 = Console.ReadLine();
                        int numero2 = Convert.ToInt32(numHabitacion2);
                        foreach(var habitacion in listaHabitaciones)
                        {
                            if (numero2 == habitacion.NumeroHabitacion)
                            {
                                habitacionExistente = true;
                                habitacion.CambiarDisponibilidad(true);
                                break;
                            }
                        }
                        if (!habitacionExistente)
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Esta habitación no existe.");
                        mensajes.MensajeContinuar();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("     ASIGNAR HABITACION");
                        Console.WriteLine("----------------------------");
                        Console.ResetColor(); Console.WriteLine();
                        Console.Write("Ingresa el número de habitación que quieres asignar: ");
                        string numHabitacion3 = Console.ReadLine();
                        int numero3 = Convert.ToInt32(numHabitacion3);
                        foreach (var habitacion in listaHabitaciones)
                        {
                            if (numero3 == habitacion.NumeroHabitacion)
                            {
                                if (habitacion.Disponibilidad == true)
                                {
                                    Console.Write("Agrega el nombre del cliente: ");
                                    string nombre = Console.ReadLine();
                                    habitacion.AsignarHabitacion(nombre);
                                }
                                else
                                {
                                    Console.WriteLine("Esta habitación ya está asignada.");
                                }
                                break;
                            }
                        }
                        mensajes.MensajeContinuar();
                        break;
                    case 6:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("     Ten un buen día :)");
                        Console.WriteLine("-----------------------------");
                        Console.ResetColor(); 
                        break;
                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Esta opcion no existe. Intenta de nuevo...");
                        mensajes.MensajeContinuar();
                        break;
                }
            }
            catch (FormatException)
            {
                mensajes.MensajeError();
                mensajes.MensajeContinuar();
            }
        } while (opcion != 6);
    }
}