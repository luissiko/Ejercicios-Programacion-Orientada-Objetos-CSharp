using System;
using poo2parcialexamen.Clases.Cancion;

namespace poo2parcialexamen.Clases.CD
{
    public class CD
    {
        private Cancion.Cancion[] canciones;
        private int contador;

        public CD()
        {
            canciones = new Cancion.Cancion[100]; // puedes ajustar el tamaño si deseas
            contador = 0;
        }

        public int NumeroCanciones()
        {
            return contador;
        }

        public Cancion.Cancion DameCancion(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
                return canciones[posicion];
            else
                return null!;
        }

        public void GrabaCancion(int posicion, Cancion.Cancion nuevaCancion)
        {
            if (posicion >= 0 && posicion < contador)
                canciones[posicion] = nuevaCancion;
        }

        public void Agrega(Cancion.Cancion nuevaCancion)
        {
            if (contador < canciones.Length)
            {
                canciones[contador] = nuevaCancion;
                contador++;
            }
            else
            {
                Console.WriteLine("El CD está lleno.");
            }
        }

        public void Elimina(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
            {
                for (int i = posicion; i < contador - 1; i++)
                {
                    canciones[i] = canciones[i + 1];
                }
                canciones[contador - 1] = null!;
                contador--;
            }
        }
    }
}
