using System;

namespace poo2parcialexamen.Clases.Racional
{
    public static class AccionesRacional
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Racional r1 = new Racional();
            Racional r2 = new Racional();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON NÚMEROS RACIONALES ====");
                Console.WriteLine("1. Ingresar primer fracción");
                Console.WriteLine("2. Ingresar segunda fracción");
                Console.WriteLine("3. Sumar");
                Console.WriteLine("4. Restar");
                Console.WriteLine("5. Multiplicar");
                Console.WriteLine("6. Dividir");
                Console.WriteLine("7. Comparar (Mayor, Menor, Igual)");
                Console.WriteLine("8. Copiar fracción 1");
                Console.WriteLine("9. Mostrar fracciones");
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
                        r1.Leer();
                        break;
                    case 2:
                        r2.Leer();
                        break;
                    case 3:
                        Console.WriteLine("Suma:");
                        r1.Sumar(r2).Print();
                        break;
                    case 4:
                        Console.WriteLine("Resta:");
                        r1.Restar(r2).Print();
                        break;
                    case 5:
                        Console.WriteLine("Multiplicación:");
                        r1.Multiplicar(r2).Print();
                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine("División:");
                            r1.Dividir(r2).Print();
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 7:
                        if (r1.IgualQue(r2))
                            Console.WriteLine("Las fracciones son iguales.");
                        else if (r1.MayorQue(r2))
                            Console.WriteLine("La primera fracción es mayor.");
                        else
                            Console.WriteLine("La primera fracción es menor.");
                        break;
                    case 8:
                        Racional copia = r1.Copia();
                        Console.Write("Copia de la primera fracción: ");
                        copia.Print();
                        break;
                    case 9:
                        Console.WriteLine("Fracción 1:");
                        r1.Print();
                        Console.WriteLine("Fracción 2:");
                        r2.Print();
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
