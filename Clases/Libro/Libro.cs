using System;
using poo2parcialexamen.Clases.Fecha;

namespace poo2parcialexamen.Clases.Libro
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre}";
        }
    }

    public class Libro
    {
        private string titulo;
        private Persona autor;
        private string isbn;
        private int paginas;
        private int edicion;
        private string editorial;
        private string ciudad;
        private string pais;
        private Fecha.Fecha fechaEdicion;

        public Libro()
        {
            titulo = "";
            autor = new Persona("", "");
            isbn = "";
            paginas = 0;
            edicion = 0;
            editorial = "";
            ciudad = "";
            pais = "";
            fechaEdicion = new Fecha.Fecha();
        }

        public void Leer()
        {
            Console.Write("Título: ");
            titulo = Console.ReadLine() ?? "";
            Console.Write("Autor - Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            Console.Write("Autor - Apellido: ");
            string apellido = Console.ReadLine() ?? "";
            autor = new Persona(nombre, apellido);
            Console.Write("ISBN: ");
            isbn = Console.ReadLine() ?? "";
            Console.Write("Páginas: ");
            paginas = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Edición: ");
            edicion = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Editorial: ");
            editorial = Console.ReadLine() ?? "";
            Console.Write("Ciudad: ");
            ciudad = Console.ReadLine() ?? "";
            Console.Write("País: ");
            pais = Console.ReadLine() ?? "";
            Console.WriteLine("Fecha de edición:");
            fechaEdicion.Leer();
        }

        public void Mostrar()
        {
            Console.WriteLine($"\nTítulo: {titulo}");
            Console.WriteLine($"{edicion}a. edición");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"{editorial}, {ciudad} ({pais}), {fechaEdicion.Larga()}");
            Console.WriteLine($"{paginas} páginas\n");
        }
    }
}
