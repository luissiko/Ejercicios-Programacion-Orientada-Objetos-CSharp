using System;

namespace poo2parcialexamen.Clases.Cancion
{
    public class Cancion
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Cancion()
        {
            Titulo = "";
            Autor = "";
        }

        public Cancion(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public void Leer()
        {
            Console.Write("Ingrese título: ");
            Titulo = Console.ReadLine() ?? "";
            Console.Write("Ingrese autor: ");
            Autor = Console.ReadLine() ?? "";
        }

        public void Mostrar()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}");
        }
    }
}
