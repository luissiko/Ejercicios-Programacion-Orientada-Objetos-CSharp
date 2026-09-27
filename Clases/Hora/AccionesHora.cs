using System;

namespace poo2parcialexamen.Clases.Hora
{
    public static class AccionesHora
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Hora hora = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON HORA ====");
                Console.WriteLine("1. Crear hora predeterminada");
                Console.WriteLine("2. Crear hora parametrizada");
                Console.WriteLine("3. Leer hora");
                Console.WriteLine("4. Mostrar hora");
                Console.WriteLine("5. Mostrar segundos desde medianoche");
                Console.WriteLine("6. Establecer hora desde segundos");
                Console.WriteLine("7. Siguiente segundo");
                Console.WriteLine("8. Segundo anterior");
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
                        hora = new Hora();
                        Console.WriteLine("Hora creada por defecto.");
                        break;
                    case 2:
                        Console.Write("Horas: ");
                        int h = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Minutos: ");
                        int m = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Segundos: ");
                        int s = int.Parse(Console.ReadLine() ?? "0");
                        hora = new Hora(h, m, s);
                        Console.WriteLine("Hora creada.");
                        break;
                    case 3:
                        hora = new Hora();
                        hora.Leer();
                        break;
                    case 4:
                        if (hora != null)
                            hora.Print();
                        else
                            Console.WriteLine("Debe crear una hora primero.");
                        break;
                    case 5:
                        if (hora != null)
                            Console.WriteLine($"Segundos desde medianoche: {hora.ASegundos()}");
                        else
                            Console.WriteLine("Debe crear una hora primero.");
                        break;
                    case 6:
                        if (hora != null)
                        {
                            Console.Write("Ingrese segundos: ");
                            int seg = int.Parse(Console.ReadLine() ?? "0");
                            hora.DeSegundos(seg);
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una hora primero.");
                        }
                        break;
                    case 7:
                        if (hora != null)
                        {
                            hora.Siguiente();
                            Console.WriteLine("Hora incrementada un segundo.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una hora primero.");
                        }
                        break;
                    case 8:
                        if (hora != null)
                        {
                            hora.Anterior();
                            Console.WriteLine("Hora decrementada un segundo.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una hora primero.");
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
