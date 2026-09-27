using System;

namespace poo2parcialexamen.Clases.ArrayEstadistica
{
    public class AccionesArrayEstadistica
    {
        public void Ejecutar()
        {
            ArrayEstadistica estadistica = new ArrayEstadistica();
            estadistica.Llenar();
            estadistica.Mostrar();
        }
    }
}
