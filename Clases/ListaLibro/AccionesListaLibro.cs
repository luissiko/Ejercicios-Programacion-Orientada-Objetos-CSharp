using System;

namespace poo2parcialexamen.Clases.ListaLibro
{
    public static class AccionesListaLibro
    {
        public static void Ejecutar()
        {
            LibroList lista = new LibroList();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== GESTIÓN DE LISTA DE LIBROS ====");
                Console.WriteLine("1. Insertar libro");
                Console.WriteLine("2. Mostrar libros");
                Console.WriteLine("3. Eliminar libro por posición");
                Console.WriteLine("4. Obtener libro por posición");
                Console.WriteLine("5. Buscar libro por título");
                Console.WriteLine("6. Mostrar número de libros");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("\nSeleccione una opción: ");

                string entrada = Console.ReadLine() ?? "0";
                int opcion;
                if (!int.TryParse(entrada, out opcion)) opcion = -1;

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el título del libro: ");
                        string titulo = Console.ReadLine() ?? "";
                        lista.InsertarLibro(titulo);
                        Console.WriteLine("Libro insertado y lista ordenada.");
                        break;
                    case 2:
                        lista.MostrarLibros();
                        break;
                    case 3:
                        Console.Write("Ingrese la posición a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int posEliminar))
                        {
                            lista.EliminarLibro(posEliminar);
                            Console.WriteLine("Libro eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("Posición inválida.");
                        }
                        break;
                    case 4:
                        Console.Write("Ingrese la posición a consultar: ");
                        if (int.TryParse(Console.ReadLine(), out int posConsulta))
                        {
                            Console.WriteLine(lista.ObtenerLibro(posConsulta));
                        }
                        else
                        {
                            Console.WriteLine("Posición inválida.");
                        }
                        break;
                    case 5:
                        Console.Write("Ingrese parte del título a buscar: ");
                        string buscar = Console.ReadLine() ?? "";
                        int posicion = lista.BuscarLibro(buscar);
                        if (posicion != -1)
                            Console.WriteLine($"Libro encontrado en la posición {posicion}: {lista.ObtenerLibro(posicion)}");
                        else
                            Console.WriteLine("Libro no encontrado.");
                        break;
                    case 6:
                        Console.WriteLine($"Número de libros: {lista.NumeroLibros()}");
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
