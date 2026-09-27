using System;

namespace poo2parcialexamen.Clases.Coche
{
    public static class AccionesCoche
    {
        public static void Ejecutar()
        {
            MostrarSubmenu();
        }

        private static void MostrarSubmenu()
        {
            Motor motor = new Motor();
            Rueda rueda = new Rueda();
            Puerta puerta = new Puerta();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== COMPONENTES DEL COCHE ====");
                Console.WriteLine("1. Arrancar motor");
                Console.WriteLine("2. Apagar motor");
                Console.WriteLine("3. Inflar rueda");
                Console.WriteLine("4. Desinflar rueda");
                Console.WriteLine("5. Abrir puerta");
                Console.WriteLine("6. Cerrar puerta");
                Console.WriteLine("7. Abrir ventana");
                Console.WriteLine("8. Cerrar ventana");
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
                        motor.Arrancar();
                        break;
                    case 2:
                        motor.Apagar();
                        break;
                    case 3:
                        rueda.Inflar();
                        break;
                    case 4:
                        rueda.Desinflar();
                        break;
                    case 5:
                        puerta.Abrir();
                        break;
                    case 6:
                        puerta.Cerrar();
                        break;
                    case 7:
                        puerta.GetVentana().Abrir();
                        break;
                    case 8:
                        puerta.GetVentana().Cerrar();
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
