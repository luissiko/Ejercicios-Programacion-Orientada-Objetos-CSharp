using System;

namespace poo2parcialexamen.Clases.ArrayInverso
{
    public static class AccionesArrayInverso
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            ArrayInverso array = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== ARRAY INVERSO ====");
                Console.WriteLine("1. Ingresar números");
                Console.WriteLine("2. Mostrar en orden inverso");
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
                        array = new ArrayInverso();
                        array.LeerNumeros();
                        break;
                    case 2:
                        if (array != null)
                            array.MostrarInverso();
                        else
                            Console.WriteLine("Debe ingresar los números primero.");
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
