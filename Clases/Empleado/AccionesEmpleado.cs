using System;

namespace poo2parcialexamen.Clases.Empleado
{
    public static class AccionesEmpleado
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Empleado empleado = null;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== GESTIÓN DE EMPLEADO ====");
                Console.WriteLine("1. Crear empleado");
                Console.WriteLine("2. Ingresar datos");
                Console.WriteLine("3. Mostrar datos básicos");
                Console.WriteLine("4. Mostrar todos los datos");
                Console.WriteLine("5. Calcular sueldo bruto");
                Console.WriteLine("6. Calcular retención IRPF");
                Console.WriteLine("7. Calcular sueldo neto");
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
                        Console.Write("Ingrese NIF: ");
                        long nif = long.Parse(Console.ReadLine() ?? "0");
                        empleado = new Empleado(nif);
                        Console.WriteLine("Empleado creado.");
                        break;
                    case 2:
                        if (empleado != null)
                        {
                            Console.Write("Sueldo base: ");
                            empleado.SetSueldoBase(double.Parse(Console.ReadLine() ?? "0"));
                            Console.Write("Pago por hora extra: ");
                            empleado.SetPagoHoraExtra(double.Parse(Console.ReadLine() ?? "0"));
                            Console.Write("Horas extra: ");
                            empleado.SetHorasExtra(int.Parse(Console.ReadLine() ?? "0"));
                            Console.Write("Tipo IRPF (%): ");
                            empleado.SetIrpf(double.Parse(Console.ReadLine() ?? "0"));
                            Console.Write("¿Casado? (s/n): ");
                            empleado.SetCasado(Console.ReadLine()?.ToLower() == "s");
                            Console.Write("Número de hijos: ");
                            empleado.SetHijos(int.Parse(Console.ReadLine() ?? "0"));
                        }
                        else
                        {
                            Console.WriteLine("Debe crear un empleado primero.");
                        }
                        break;
                    case 3:
                        if (empleado != null)
                            empleado.Println();
                        else
                            Console.WriteLine("Debe crear un empleado primero.");
                        break;
                    case 4:
                        if (empleado != null)
                            empleado.PrintAll();
                        else
                            Console.WriteLine("Debe crear un empleado primero.");
                        break;
                    case 5:
                        if (empleado != null)
                            Console.WriteLine($"Sueldo Bruto: {empleado.SueldoBruto()}");
                        else
                            Console.WriteLine("Debe crear un empleado primero.");
                        break;
                    case 6:
                        if (empleado != null)
                            Console.WriteLine($"Retención IRPF: {empleado.Retencion()}");
                        else
                            Console.WriteLine("Debe crear un empleado primero.");
                        break;
                    case 7:
                        if (empleado != null)
                            Console.WriteLine($"Sueldo Neto: {empleado.SueldoNeto()}");
                        else
                            Console.WriteLine("Debe crear un empleado primero.");
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
