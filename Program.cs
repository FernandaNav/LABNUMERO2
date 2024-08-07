class program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------");
            Console.WriteLine("     BIENVENIDO");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------");
            Console.ResetColor(); Console.WriteLine();
            Console.WriteLine("Opción 1: Agregar Habitación");
            Console.WriteLine("Opción 2: Eliminar Habitación");
            Console.WriteLine("Opción 3: Mostrar Habitación");
            Console.WriteLine("Opción 4: Liberar Habitación");
            Console.WriteLine("Opción 5: Salir");
            Console.WriteLine();
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {

            }
        } while (opcion != 5);
    }
}