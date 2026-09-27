using System;

namespace poo2parcialexamen.Clases.Linea
{
    public static class AccionesLinea
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Linea linea = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON LÍNEAS ====");
                Console.WriteLine("1. Crear línea");
                Console.WriteLine("2. Mover derecha");
                Console.WriteLine("3. Mover izquierda");
                Console.WriteLine("4. Mover arriba");
                Console.WriteLine("5. Mover abajo");
                Console.WriteLine("6. Mostrar línea");
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
                        linea = CrearLinea();
                        break;
                    case 2:
                        if (linea != null)
                            MoverLinea(linea, "derecha");
                        else
                            Console.WriteLine("Debe crear una línea primero.");
                        break;
                    case 3:
                        if (linea != null)
                            MoverLinea(linea, "izquierda");
                        else
                            Console.WriteLine("Debe crear una línea primero.");
                        break;
                    case 4:
                        if (linea != null)
                            MoverLinea(linea, "arriba");
                        else
                            Console.WriteLine("Debe crear una línea primero.");
                        break;
                    case 5:
                        if (linea != null)
                            MoverLinea(linea, "abajo");
                        else
                            Console.WriteLine("Debe crear una línea primero.");
                        break;
                    case 6:
                        if (linea != null)
                            linea.Print();
                        else
                            Console.WriteLine("Debe crear una línea primero.");
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

        private static Linea CrearLinea()
        {
            Console.WriteLine("Ingrese las coordenadas del punto A:");
            double x1 = double.Parse(Console.ReadLine() ?? "0");
            double y1 = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Ingrese las coordenadas del punto B:");
            double x2 = double.Parse(Console.ReadLine() ?? "0");
            double y2 = double.Parse(Console.ReadLine() ?? "0");

            return new Linea(new Punto(x1, y1), new Punto(x2, y2));
        }

        private static void MoverLinea(Linea l, string direccion)
        {
            Console.Write($"Ingrese la distancia a mover hacia {direccion}: ");
            double d = double.Parse(Console.ReadLine() ?? "0");

            switch (direccion)
            {
                case "derecha":
                    l.MueveDerecha(d);
                    break;
                case "izquierda":
                    l.MueveIzquierda(d);
                    break;
                case "arriba":
                    l.MueveArriba(d);
                    break;
                case "abajo":
                    l.MueveAbajo(d);
                    break;
            }
            Console.WriteLine($"Línea movida hacia {direccion}.");
        }
    }
}
