using System;
using poo2parcialexamen.Clases.Complejo;
using poo2parcialexamen.Clases.Racional;
using poo2parcialexamen.Clases.Rectangulo;
using poo2parcialexamen.Clases.Linea;
using poo2parcialexamen.Clases.Cuenta;
using poo2parcialexamen.Clases.Cafetera;
using poo2parcialexamen.Clases.NIF;
using poo2parcialexamen.Clases.Fecha;
using poo2parcialexamen.Clases.Coche;
using poo2parcialexamen.Clases.Hora;
using poo2parcialexamen.Clases.Cancion;
using poo2parcialexamen.Clases.Empleado;
using poo2parcialexamen.Clases.Libro;
using poo2parcialexamen.Clases.ArrayInverso;
using poo2parcialexamen.Clases.ArrayEstadistica;
using poo2parcialexamen.Clases.Array234;
using poo2parcialexamen.Clases.CD;
using poo2parcialexamen.Clases.ListaLibro;

namespace poo2parcialexamen
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ PRINCIPAL ====");
                Console.WriteLine("1. Clase Complejo");
                Console.WriteLine("2. Clase Racional");
                Console.WriteLine("3. Clase Rectángulo");
                Console.WriteLine("4. Clase Línea");
                Console.WriteLine("5. Clase Cuenta");
                Console.WriteLine("6. Clase Cafetera");
                Console.WriteLine("7. Clase NIF");
                Console.WriteLine("8. Clase Fecha");
                Console.WriteLine("9. Clase Coche y componentes");
                Console.WriteLine("10. Clase Hora");
                Console.WriteLine("11. Clase Empleado");
                Console.WriteLine("12. Clase Canción");
                Console.WriteLine("13. Clase Libro");
                Console.WriteLine("14. Programa Array Inverso");
                Console.WriteLine("15. Programa Array Aleatorio Media/Desviación");
                Console.WriteLine("16. Clase Array234");
                Console.WriteLine("17. Clase CD");
                Console.WriteLine("18. Lista de Libros ordenada por título");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                string entrada = Console.ReadLine() ?? "0";
                if (!int.TryParse(entrada, out opcion))
                {
                    opcion = -1;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        AccionesComplejo.Ejecutar();
                        break;
                    case 2:
                        AccionesRacional.Ejecutar();
                        break;
                    case 3:
                        AccionesRectangulo.Ejecutar();
                        break;
                    case 4:
                        AccionesLinea.Ejecutar();
                        break;
                    case 5:
                        AccionesCuenta.Ejecutar();
                        break;
                    case 6:
                        AccionesCafetera.Ejecutar();
                        break;
                    case 7:
                        AccionesNIF.Ejecutar();
                        break;
                    case 8:
                        AccionesFecha.Ejecutar();
                        break;
                    case 9:
                        AccionesCoche.Ejecutar();
                        break;
                    case 10:
                        AccionesHora.Ejecutar();
                        break;
                    case 11:
                        AccionesEmpleado.Ejecutar();
                        break;
                    case 12:
                        AccionesCancion.Ejecutar();
                        break;
                    case 13:
                        AccionesLibro.Ejecutar();
                        break;
                    case 14:
                        AccionesArrayInverso.Ejecutar();
                        break;
                    case 15:
                        AccionesArrayEstadistica accionesArrayEstadistica = new AccionesArrayEstadistica();
                        accionesArrayEstadistica.Ejecutar();
                        break;
                    case 16:
                        AccionesArray234.Ejecutar();
                        break;
                    case 17:
                        AccionesCD.Ejecutar();
                        break;
                    case 18:
                        AccionesListaLibro.Ejecutar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (continuar && opcion != 0)
                {
                    Console.Write("\n¿Desea volver al menú? (S/N): ");
                    string respuesta = Console.ReadLine() ?? "S";
                    if (respuesta.ToUpper() != "S")
                    {
                        continuar = false;
                        Console.WriteLine("\nSaliendo...");
                    }
                }
            }
        }
    }
}
