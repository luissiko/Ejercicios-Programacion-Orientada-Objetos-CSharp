using System;

namespace poo2parcialexamen.Clases.Cafetera
{
    public static class AccionesCafetera
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Cafetera cafetera = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON CAFETERA ====");
                Console.WriteLine("1. Crear cafetera (predeterminada)");
                Console.WriteLine("2. Crear cafetera con capacidad máxima");
                Console.WriteLine("3. Crear cafetera con capacidad y cantidad");
                Console.WriteLine("4. Llenar cafetera");
                Console.WriteLine("5. Servir taza");
                Console.WriteLine("6. Vaciar cafetera");
                Console.WriteLine("7. Agregar café");
                Console.WriteLine("8. Mostrar datos");
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
                        cafetera = new Cafetera();
                        Console.WriteLine("Cafetera creada por defecto.");
                        break;
                    case 2:
                        Console.Write("Ingrese capacidad máxima: ");
                        int cap = int.Parse(Console.ReadLine() ?? "1000");
                        cafetera = new Cafetera(cap);
                        Console.WriteLine("Cafetera creada con capacidad máxima.");
                        break;
                    case 3:
                        Console.Write("Ingrese capacidad máxima: ");
                        int capacidad = int.Parse(Console.ReadLine() ?? "1000");
                        Console.Write("Ingrese cantidad actual: ");
                        int cantidad = int.Parse(Console.ReadLine() ?? "0");
                        cafetera = new Cafetera(capacidad, cantidad);
                        Console.WriteLine("Cafetera creada con capacidad y cantidad.");
                        break;
                    case 4:
                        if (cafetera != null)
                        {
                            cafetera.LlenarCafetera();
                            Console.WriteLine("Cafetera llena.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cafetera primero.");
                        }
                        break;
                    case 5:
                        if (cafetera != null)
                        {
                            Console.Write("Ingrese cantidad a servir: ");
                            int taza = int.Parse(Console.ReadLine() ?? "0");
                            cafetera.ServirTaza(taza);
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cafetera primero.");
                        }
                        break;
                    case 6:
                        if (cafetera != null)
                        {
                            cafetera.VaciarCafetera();
                            Console.WriteLine("Cafetera vaciada.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cafetera primero.");
                        }
                        break;
                    case 7:
                        if (cafetera != null)
                        {
                            Console.Write("Ingrese cantidad de café a agregar: ");
                            int agregar = int.Parse(Console.ReadLine() ?? "0");
                            cafetera.AgregarCafe(agregar);
                            Console.WriteLine("Café agregado.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cafetera primero.");
                        }
                        break;
                    case 8:
                        if (cafetera != null)
                        {
                            cafetera.MostrarDatos();
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cafetera primero.");
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
