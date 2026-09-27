using System;

namespace poo2parcialexamen.Clases.NIF
{
    public static class AccionesNIF
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            NIF nif = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON NIF ====");
                Console.WriteLine("1. Crear NIF predeterminado");
                Console.WriteLine("2. Crear NIF con DNI");
                Console.WriteLine("3. Leer NIF");
                Console.WriteLine("4. Mostrar NIF");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                string entrada = Console.ReadLine() ?? "0";
                int opcion;
                if (!int.TryParse(entrada, out opcion))
                {
                    opcion = -1;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        nif = new NIF();
                        Console.WriteLine("NIF creado por defecto.");
                        break;
                    case 2:
                        Console.Write("Ingrese el número de DNI: ");
                        long dni = long.Parse(Console.ReadLine() ?? "0");
                        nif = new NIF(dni);
                        Console.WriteLine("NIF creado.");
                        break;
                    case 3:
                        nif = new NIF();
                        nif.Leer();
                        break;
                    case 4:
                        if (nif != null)
                        {
                            nif.Mostrar();
                        }
                        else
                        {
                            Console.WriteLine("Debe crear un NIF primero.");
                        }
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
