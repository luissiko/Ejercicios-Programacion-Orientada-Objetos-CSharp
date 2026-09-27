namespace poo2parcialexamen.Clases.Coche
{
    public class Rueda
    {
        private bool inflada;

        public Rueda()
        {
            inflada = false;
        }

        public void Inflar()
        {
            inflada = true;
            Console.WriteLine("Rueda inflada.");
        }

        public void Desinflar()
        {
            inflada = false;
            Console.WriteLine("Rueda desinflada.");
        }

        public bool Estado() => inflada;
    }
}
