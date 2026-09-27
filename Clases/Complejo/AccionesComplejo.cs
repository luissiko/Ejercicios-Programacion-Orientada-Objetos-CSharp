using System;

namespace poo2parcialexamen.Clases.Complejo
{
    public static class AccionesComplejo
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Complejo c1 = new Complejo();
            Complejo c2 = new Complejo();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON NÚMEROS COMPLEJOS ====");
                Console.WriteLine("1. Ingresar primer número complejo");
                Console.WriteLine("2. Ingresar segundo número complejo");
                Console.WriteLine("3. Sumar");
                Console.WriteLine("4. Restar");
                Console.WriteLine("5. Multiplicar");
                Console.WriteLine("6. Dividir");
                Console.WriteLine("7. Acumular (c1 + c2)");
                Console.WriteLine("8. Mostrar números complejos");
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
                        c1 = CapturarComplejo();
                        break;
                    case 2:
                        c2 = CapturarComplejo();
                        break;
                    case 3:
                        Console.WriteLine("Suma:");
                        c1.Sumar(c2).Print();
                        break;
                    case 4:
                        Console.WriteLine("Resta:");
                        c1.Restar(c2).Print();
                        break;
                    case 5:
                        Console.WriteLine("Multiplicación:");
                        c1.Multiplicar(c2).Print();
                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine("División:");
                            c1.Dividir(c2).Print();
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 7:
                        c1.Acumular(c2);
                        Console.WriteLine("Acumulación realizada. Resultado:");
                        c1.Print();
                        break;
                    case 8:
                        Console.WriteLine("Número complejo 1:");
                        c1.Print();
                        Console.WriteLine("Número complejo 2:");
                        c2.Print();
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

        private static Complejo CapturarComplejo()
        {
            Console.Write("Ingrese la parte real: ");
            double real = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese la parte imaginaria: ");
            double imaginario = double.Parse(Console.ReadLine() ?? "0");

            return new Complejo(real, imaginario);
        }
    }
}
