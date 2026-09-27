namespace poo2parcialexamen.Clases.Coche
{
    public class Puerta
    {
        private bool abierta;
        private Ventana ventana;

        public Puerta()
        {
            abierta = false;
            ventana = new Ventana();
        }

        public void Abrir()
        {
            abierta = true;
            Console.WriteLine("Puerta abierta.");
        }

        public void Cerrar()
        {
            abierta = false;
            Console.WriteLine("Puerta cerrada.");
        }

        public Ventana GetVentana() => ventana;
        public bool Estado() => abierta;
    }
}
