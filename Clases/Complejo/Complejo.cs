namespace poo2parcialexamen.Clases.Complejo
{
    public class Complejo
    {
        private double real;
        private double imaginario;

        public Complejo()
        {
            real = 0;
            imaginario = 0;
        }

        public Complejo(double r, double i)
        {
            real = r;
            imaginario = i;
        }

        public double GetReal() => real;
        public double GetImaginario() => imaginario;
        public void SetReal(double r) => real = r;
        public void SetImaginario(double i) => imaginario = i;

        public Complejo Sumar(Complejo c)
        {
            return new Complejo(real + c.real, imaginario + c.imaginario);
        }

        public Complejo Restar(Complejo c)
        {
            return new Complejo(real - c.real, imaginario - c.imaginario);
        }

        public Complejo Multiplicar(Complejo c)
        {
            double r = real * c.real - imaginario * c.imaginario;
            double i = real * c.imaginario + imaginario * c.real;
            return new Complejo(r, i);
        }

        public Complejo Dividir(Complejo c)
        {
            double divisor = c.real * c.real + c.imaginario * c.imaginario;
            if (divisor == 0)
                throw new DivideByZeroException("No se puede dividir entre 0.");

            double r = (real * c.real + imaginario * c.imaginario) / divisor;
            double i = (imaginario * c.real - real * c.imaginario) / divisor;
            return new Complejo(r, i);
        }

        public void Acumular(Complejo c)
        {
            real += c.real;
            imaginario += c.imaginario;
        }

        public void Print()
        {
            Console.WriteLine($"{real} + {imaginario}i");
        }
    }
}
