using System;

namespace poo2parcialexamen.Clases.ArrayEstadistica
{
    public class ArrayEstadistica
    {
        private double[] _numeros;
        private int _n;

        public ArrayEstadistica()
        {
            _n = 30;
            _numeros = new double[_n];
        }

        public void Llenar()
        {
            Random rnd = new Random();
            for (int i = 0; i < _n; i++)
            {
                _numeros[i] = rnd.NextDouble();
            }
        }

        public double Media()
        {
            double suma = 0;
            foreach (double num in _numeros)
            {
                suma += num;
            }
            return suma / _n;
        }

        public double DesviacionEstandar()
        {
            double media = Media();
            double sumaCuadrados = 0;
            foreach (double num in _numeros)
            {
                sumaCuadrados += Math.Pow(num - media, 2);
            }
            return Math.Sqrt(sumaCuadrados / (_n - 1));
        }

        public void Mostrar()
        {
            Console.WriteLine("\nNúmeros generados:");
            foreach (double num in _numeros)
            {
                Console.Write($"{num:F4} ");
            }
            Console.WriteLine($"\n\nMedia: {Media():F4}");
            Console.WriteLine($"Desviación estándar: {DesviacionEstandar():F4}\n");
        }
    }
}
