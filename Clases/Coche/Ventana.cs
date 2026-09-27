namespace poo2parcialexamen.Clases.Coche
{
    public class Ventana
    {
        private bool abierta;

        public Ventana()
        {
            abierta = false;
        }

        public void Abrir()
        {
            abierta = true;
            Console.WriteLine("Ventana abierta.");
        }

        public void Cerrar()
        {
            abierta = false;
            Console.WriteLine("Ventana cerrada.");
        }

        public bool Estado() => abierta;
    }
}
