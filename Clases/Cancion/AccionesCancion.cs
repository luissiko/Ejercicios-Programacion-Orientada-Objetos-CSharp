using System;

namespace poo2parcialexamen.Clases.Cancion
{
    public static class AccionesCancion
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Cancion cancion = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== GESTIÓN DE CANCIÓN ====");
                Console.WriteLine("1. Crear canción vacía");
                Console.WriteLine("2. Crear canción con título y autor");
                Console.WriteLine("3. Mostrar información");
                Console.WriteLine("4. Modificar título");
                Console.WriteLine("5. Modificar autor");
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
                        cancion = new Cancion();
                        Console.WriteLine("Canción creada vacía.");
                        break;
                    case 2:
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine() ?? "";
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine() ?? "";
                        cancion = new Cancion(titulo, autor);
                        Console.WriteLine("Canción creada.");
                        break;
                    case 3:
                        if (cancion != null)
                        {
                            Console.WriteLine($"Título: {cancion.Titulo}");
                            Console.WriteLine($"Autor: {cancion.Autor}");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una canción primero.");
                        }
                        break;
                    case 4:
                        if (cancion != null)
                        {
                            Console.Write("Nuevo título: ");
                            cancion.Titulo = Console.ReadLine() ?? "";
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una canción primero.");
                        }
                        break;
                    case 5:
                        if (cancion != null)
                        {
                            Console.Write("Nuevo autor: ");
                            cancion.Autor = Console.ReadLine() ?? "";
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una canción primero.");
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
