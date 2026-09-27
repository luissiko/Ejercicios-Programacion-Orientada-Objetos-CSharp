namespace poo2parcialexamen.Clases.Rectangulo
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
    }

    public class Rectangulo
    {
        private Punto[] vertices;

        // Constructor con cuatro vértices
        public Rectangulo(Punto p1, Punto p2, Punto p3, Punto p4)
        {
            vertices = new Punto[] { p1, p2, p3, p4 };
        }

        // Constructor con base y altura desde (0,0)
        public Rectangulo(double baseR, double altura)
        {
            vertices = new Punto[]
            {
                new Punto(0, 0),
                new Punto(baseR, 0),
                new Punto(baseR, altura),
                new Punto(0, altura)
            };
        }

        public double Superficie()
        {
            double baseR = vertices[1].X - vertices[0].X;
            double altura = vertices[3].Y - vertices[0].Y;
            return Math.Abs(baseR * altura);
        }

        public void Desplazar(double dx, double dy)
        {
            foreach (var v in vertices)
            {
                v.X += dx;
                v.Y += dy;
            }
        }

        public void Print()
        {
            Console.WriteLine("Vértices del rectángulo:");
            for (int i = 0; i < vertices.Length; i++)
            {
                Console.WriteLine($"V{i + 1}: ({vertices[i].X}, {vertices[i].Y})");
            }
        }
    }
}
