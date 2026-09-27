namespace poo2parcialexamen.Clases.Cafetera
{
    public class Cafetera
    {
        private int capacidadMaxima;
        private int cantidadActual;

        public Cafetera()
        {
            capacidadMaxima = 1000;
            cantidadActual = 0;
        }

        public Cafetera(int capacidad)
        {
            capacidadMaxima = capacidad;
            cantidadActual = capacidad;
        }

        public Cafetera(int capacidad, int cantidad)
        {
            capacidadMaxima = capacidad;
            cantidadActual = cantidad > capacidad ? capacidad : cantidad;
        }

        public int GetCapacidadMaxima() => capacidadMaxima;
        public int GetCantidadActual() => cantidadActual;
        public void SetCapacidadMaxima(int capacidad) => capacidadMaxima = capacidad;
        public void SetCantidadActual(int cantidad) => cantidadActual = cantidad;

        public void LlenarCafetera()
        {
            cantidadActual = capacidadMaxima;
        }

        public void ServirTaza(int cantidad)
        {
            if (cantidadActual >= cantidad)
            {
                cantidadActual -= cantidad;
                Console.WriteLine($"Se sirvió una taza de {cantidad} c.c.");
            }
            else
            {
                Console.WriteLine($"No hay suficiente café. Solo se sirvieron {cantidadActual} c.c.");
                cantidadActual = 0;
            }
        }

        public void VaciarCafetera()
        {
            cantidadActual = 0;
        }

        public void AgregarCafe(int cantidad)
        {
            cantidadActual += cantidad;
            if (cantidadActual > capacidadMaxima)
            {
                cantidadActual = capacidadMaxima;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Capacidad máxima: {capacidadMaxima} c.c.");
            Console.WriteLine($"Cantidad actual: {cantidadActual} c.c.");
        }
    }
}
