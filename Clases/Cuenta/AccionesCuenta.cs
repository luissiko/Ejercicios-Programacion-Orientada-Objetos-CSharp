using System;

namespace poo2parcialexamen.Clases.Cuenta
{
    public static class AccionesCuenta
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Cuenta cuenta = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== OPERACIONES CON CUENTA BANCARIA ====");
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Actualizar saldo (interés diario)");
                Console.WriteLine("3. Ingresar dinero");
                Console.WriteLine("4. Retirar dinero");
                Console.WriteLine("5. Mostrar datos de la cuenta");
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
                        cuenta = CrearCuenta();
                        break;
                    case 2:
                        if (cuenta != null)
                        {
                            cuenta.ActualizarSaldo();
                            Console.WriteLine("Saldo actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cuenta primero.");
                        }
                        break;
                    case 3:
                        if (cuenta != null)
                        {
                            Console.Write("Cantidad a ingresar: ");
                            double ingreso = double.Parse(Console.ReadLine() ?? "0");
                            cuenta.Ingresar(ingreso);
                            Console.WriteLine("Ingreso realizado.");
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cuenta primero.");
                        }
                        break;
                    case 4:
                        if (cuenta != null)
                        {
                            Console.Write("Cantidad a retirar: ");
                            double retiro = double.Parse(Console.ReadLine() ?? "0");
                            cuenta.Retirar(retiro);
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cuenta primero.");
                        }
                        break;
                    case 5:
                        if (cuenta != null)
                        {
                            cuenta.MostrarDatos();
                        }
                        else
                        {
                            Console.WriteLine("Debe crear una cuenta primero.");
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

        private static Cuenta CrearCuenta()
        {
            Console.Write("Ingrese DNI del cliente: ");
            long dni = long.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese interés anual (%): ");
            double interes = double.Parse(Console.ReadLine() ?? "0");

            return new Cuenta(dni, saldo, interes);
        }
    }
}
