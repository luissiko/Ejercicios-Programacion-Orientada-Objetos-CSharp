using System;

namespace poo2parcialexamen.Clases.Fecha
{
    public static class AccionesFecha
    {
        public static void Ejecutar()
        {
            var fecha = new Fecha();
            Console.WriteLine("Fecha por defecto: " + fecha.Corta());
            fecha.Leer();
            Console.WriteLine("Fecha ingresada: " + fecha.Corta());

            var copia = fecha.Copia();
            Console.WriteLine("Copia de la fecha: " + copia.Corta());

            fecha.Siguiente();
            Console.WriteLine("Día siguiente: " + fecha.Corta());

            fecha.Anterior();
            fecha.Anterior();
            Console.WriteLine("Día anterior: " + fecha.Corta());
        }
    }
}
