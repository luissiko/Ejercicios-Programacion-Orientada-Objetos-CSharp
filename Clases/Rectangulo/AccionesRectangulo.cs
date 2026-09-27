using System;

namespace poo2parcialexamen.Clases.Rectangulo
{
    public static class AccionesRectangulo
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Rectangulo rect = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON RECTÁNGULOS ====");
                Console.WriteLine("1. Crear rectángulo por vértices");
                Console.WriteLine("2. Crear rectángulo por base y altura");
                Console.WriteLine("3. Calcular superficie");
                Console.WriteLine("4. Desplazar rectángulo");
                Console.WriteLine("5. Mostrar vértices");
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
                        rect = CrearPorVertices();
                        break;
                    case 2:
                        rect = CrearPorBaseAltura();
                        break;
                    case 3:
                        if (rect != null)
                        {
                            Console.WriteLine($"Superficie: {rect.Superficie()}");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear un rectángulo primero.");
                        }
                        break;
                    case 4:
                        if (rect != null)
                        {
                            Console.Write("Desplazar en X: ");
                            double dx = double.Parse(Console.ReadLine() ?? "0");
                            Console.Write("Desplazar en Y: ");
                            double dy = double.Parse(Console.ReadLine() ?? "0");
                            rect.Desplazar(dx, dy);
                            Console.WriteLine("Rectángulo desplazado.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear un rectángulo primero.");
                        }
                        break;
                    case 5:
                        if (rect != null)
                        {
                            rect.Print();
                        }
                        else
                        {
                            Console.WriteLine("Debe crear un rectángulo primero.");
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

        private static Rectangulo CrearPorVertices()
        {
            Console.WriteLine("Ingrese las coordenadas de los 4 vértices:");
            Punto[] puntos = new Punto[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"V{i + 1} - X: ");
                double x = double.Parse(Console.ReadLine() ?? "0");
                Console.Write($"V{i + 1} - Y: ");
                double y = double.Parse(Console.ReadLine() ?? "0");
                puntos[i] = new Punto(x, y);
            }
            return new Rectangulo(puntos[0], puntos[1], puntos[2], puntos[3]);
        }

        private static Rectangulo CrearPorBaseAltura()
        {
            Console.Write("Ingrese la base: ");
            double b = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese la altura: ");
            double h = double.Parse(Console.ReadLine() ?? "0");
            return new Rectangulo(b, h);
        }
    }
}
