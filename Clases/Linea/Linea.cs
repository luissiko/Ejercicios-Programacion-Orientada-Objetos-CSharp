namespace poo2parcialexamen.Clases.Linea
{
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        public void Desplazar(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
    }

    public class Linea
    {
        private Punto _puntoA;
        private Punto _puntoB;

        public Linea()
        {
            _puntoA = new Punto(0, 0);
            _puntoB = new Punto(0, 0);
        }

        public Linea(Punto a, Punto b)
        {
            _puntoA = a;
            _puntoB = b;
        }

        public Punto GetPuntoA() => _puntoA;
        public Punto GetPuntoB() => _puntoB;

        public void SetPuntoA(Punto p) => _puntoA = p;
        public void SetPuntoB(Punto p) => _puntoB = p;

        public void MueveDerecha(double d)
        {
            _puntoA.Desplazar(d, 0);
            _puntoB.Desplazar(d, 0);
        }

        public void MueveIzquierda(double d)
        {
            _puntoA.Desplazar(-d, 0);
            _puntoB.Desplazar(-d, 0);
        }

        public void MueveArriba(double d)
        {
            _puntoA.Desplazar(0, d);
            _puntoB.Desplazar(0, d);
        }

        public void MueveAbajo(double d)
        {
            _puntoA.Desplazar(0, -d);
            _puntoB.Desplazar(0, -d);
        }

        public void Print()
        {
            Console.WriteLine($"[({_puntoA.X},{_puntoA.Y}),({_puntoB.X},{_puntoB.Y})]");
        }
    }
}
