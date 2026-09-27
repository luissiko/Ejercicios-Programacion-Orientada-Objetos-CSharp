namespace poo2parcialexamen.Clases.Coche
{
    public class Motor
    {
        private bool encendido;

        public Motor()
        {
            encendido = false;
        }

        public void Arrancar()
        {
            encendido = true;
            Console.WriteLine("Motor encendido.");
        }

        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("Motor apagado.");
        }

        public bool Estado() => encendido;
    }
}
