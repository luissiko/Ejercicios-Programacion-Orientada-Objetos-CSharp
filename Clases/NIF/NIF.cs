namespace poo2parcialexamen.Clases.NIF
{
    public class NIF
    {
        private long numeroDni;
        private char letra;

        public NIF()
        {
            numeroDni = 0;
            letra = ' ';
        }

        public NIF(long dni)
        {
            numeroDni = dni;
            letra = CalcularLetra(dni);
        }

        public long GetNumeroDni() => numeroDni;
        public char GetLetra() => letra;

        public void SetNumeroDni(long dni)
        {
            numeroDni = dni;
            letra = CalcularLetra(dni);
        }

        public void Leer()
        {
            Console.Write("Ingrese el número de DNI: ");
            long dni = long.Parse(Console.ReadLine() ?? "0");
            SetNumeroDni(dni);
        }

        public void Mostrar()
        {
            Console.WriteLine($"{numeroDni.ToString("D8")}-{letra}");
        }

        private char CalcularLetra(long dni)
        {
            string tabla = "TRWAGMYFPDXBNJZSQVHLCKE";
            int indice = (int)(dni % 23);
            return tabla[indice];
        }
    }
}
