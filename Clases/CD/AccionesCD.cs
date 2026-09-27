using System;
using poo2parcialexamen.Clases.Cancion;

namespace poo2parcialexamen.Clases.CD
{
    public class AccionesCD
    {
        public static void MostrarSubmenu()
        {
            CD cd = new CD();
            int opcion;
            do
            {
                Console.WriteLine("\n==== SUBMENÚ CD ====");
                Console.WriteLine("1. Agregar canción");
                Console.WriteLine("2. Mostrar número de canciones");
                Console.WriteLine("3. Mostrar canción en posición");
                Console.WriteLine("4. Reemplazar canción");
                Console.WriteLine("5. Eliminar canción");
                Console.WriteLine("6. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine() ?? "6");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine() ?? "";
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine() ?? "";
                        cd.Agrega(new Cancion.Cancion(titulo, autor));
                        break;
                    case 2:
                        Console.WriteLine($"Número de canciones: {cd.NumeroCanciones()}");
                        break;
                    case 3:
                        Console.Write("Posición: ");
                        int pos = int.Parse(Console.ReadLine() ?? "0");
                        var cancion = cd.DameCancion(pos);
                        if (cancion != null)
                            Console.WriteLine($"Título: {cancion.Titulo}, Autor: {cancion.Autor}");
                        else
                            Console.WriteLine("Posición inválida.");
                        break;
                    case 4:
                        Console.Write("Posición: ");
                        int posCambio = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nuevo título: ");
                        string nuevoTitulo = Console.ReadLine() ?? "";
                        Console.Write("Nuevo autor: ");
                        string nuevoAutor = Console.ReadLine() ?? "";
                        cd.GrabaCancion(posCambio, new Cancion.Cancion(nuevoTitulo, nuevoAutor));
                        break;
                    case 5:
                        Console.Write("Posición a eliminar: ");
                        int posEliminar = int.Parse(Console.ReadLine() ?? "0");
                        cd.Elimina(posEliminar);
                        break;
                    case 6:
                        Console.WriteLine("Volviendo al menú principal...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 6);
        }

        public static void Ejecutar()
        {
            MostrarSubmenu();
        }
    }
}
