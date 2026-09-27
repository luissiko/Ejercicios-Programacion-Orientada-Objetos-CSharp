namespace poo2parcialexamen.Clases.Racional
{
    public class Racional
    {
        private int numerador;
        private int denominador;

        // Constructor por defecto
        public Racional()
        {
            numerador = 0;
            denominador = 1;
        }

        // Constructor parametrizado
        public Racional(int num, int den)
        {
            numerador = num;
            denominador = den != 0 ? den : 1;
        }

        // Accedentes
        public int GetNumerador() => numerador;
        public int GetDenominador() => denominador;

        // Mutadores
        public void SetNumerador(int num) => numerador = num;
        public void SetDenominador(int den) => denominador = den != 0 ? den : 1;

        // Leer fracción
        public void Leer()
        {
            Console.Write("Ingrese el numerador: ");
            numerador = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese el denominador (≠ 0): ");
            int den = int.Parse(Console.ReadLine() ?? "1");
            denominador = den != 0 ? den : 1;
        }

        // Operaciones
        public Racional Sumar(Racional r)
        {
            int num = numerador * r.denominador + r.numerador * denominador;
            int den = denominador * r.denominador;
            return new Racional(num, den);
        }

        public Racional Restar(Racional r)
        {
            int num = numerador * r.denominador - r.numerador * denominador;
            int den = denominador * r.denominador;
            return new Racional(num, den);
        }

        public Racional Multiplicar(Racional r)
        {
            int num = numerador * r.numerador;
            int den = denominador * r.denominador;
            return new Racional(num, den);
        }

        public Racional Dividir(Racional r)
        {
            if (r.numerador == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");

            int num = numerador * r.denominador;
            int den = denominador * r.numerador;
            return new Racional(num, den);
        }

        public Racional Copia()
        {
            return new Racional(numerador, denominador);
        }

        public bool IgualQue(Racional r)
        {
            return numerador * r.denominador == r.numerador * denominador;
        }

        public bool MayorQue(Racional r)
        {
            return numerador * r.denominador > r.numerador * denominador;
        }

        public bool MenorQue(Racional r)
        {
            return numerador * r.denominador < r.numerador * denominador;
        }

        public void Print()
        {
            Console.WriteLine($"{numerador}/{denominador}");
        }
    }
}
