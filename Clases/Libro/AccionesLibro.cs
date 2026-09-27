using System;

namespace poo2parcialexamen.Clases.Libro
{
    public static class AccionesLibro
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Libro libro = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== GESTIÓN DE LIBRO ====");
                Console.WriteLine("1. Crear libro");
                Console.WriteLine("2. Mostrar información del libro");
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
                        libro = new Libro();
                        libro.Leer();
                        Console.WriteLine("Libro creado.");
                        break;
                    case 2:
                        if (libro != null)
                            libro.Mostrar();
                        else
                            Console.WriteLine("Debe crear un libro primero.");
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
