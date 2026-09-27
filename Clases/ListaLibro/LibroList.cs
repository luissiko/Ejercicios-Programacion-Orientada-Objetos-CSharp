using System;
using System.Collections.Generic;

namespace poo2parcialexamen.Clases.ListaLibro
{
    public class LibroList
    {
        private List<string> _libros;

        public LibroList()
        {
            _libros = new List<string>();
        }

        public int NumeroLibros()
        {
            return _libros.Count;
        }

        public void InsertarLibro(string titulo)
        {
            _libros.Add(titulo);
            _libros.Sort(StringComparer.OrdinalIgnoreCase); // Ordena ignorando mayúsculas
        }

        public void EliminarLibro(int posicion)
        {
            if (posicion >= 0 && posicion < _libros.Count)
            {
                _libros.RemoveAt(posicion);
            }
        }

        public string ObtenerLibro(int posicion)
        {
            if (posicion >= 0 && posicion < _libros.Count)
            {
                return _libros[posicion];
            }
            return "Posición inválida.";
        }

        public int BuscarLibro(string titulo)
        {
            return _libros.FindIndex(l => l.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public void MostrarLibros()
        {
            if (_libros.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            for (int i = 0; i < _libros.Count; i++)
            {
                Console.WriteLine($"{i}: {_libros[i]}");
            }
        }
    }
}
