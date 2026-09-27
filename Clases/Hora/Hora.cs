namespace poo2parcialexamen.Clases.Hora
{
    public class Hora
    {
        private int horas;
        private int minutos;
        private int segundos;

        public Hora()
        {
            horas = 0;
            minutos = 0;
            segundos = 0;
        }

        public Hora(int h, int m, int s)
        {
            horas = h;
            minutos = m;
            segundos = s;
            Valida();
        }

        public int GetHoras() => horas;
        public int GetMinutos() => minutos;
        public int GetSegundos() => segundos;

        public void SetHoras(int h)
        {
            horas = h;
            Valida();
        }

        public void SetMinutos(int m)
        {
            minutos = m;
            Valida();
        }

        public void SetSegundos(int s)
        {
            segundos = s;
            Valida();
        }

        public void Leer()
        {
            Console.Write("Horas: ");
            horas = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Minutos: ");
            minutos = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Segundos: ");
            segundos = int.Parse(Console.ReadLine() ?? "0");
            Valida();
        }

        private void Valida()
        {
            if (horas < 0 || horas > 23) horas = 0;
            if (minutos < 0 || minutos > 59) minutos = 0;
            if (segundos < 0 || segundos > 59) segundos = 0;
        }

        public void Print()
        {
            Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}");
        }

        public int ASegundos()
        {
            return horas * 3600 + minutos * 60 + segundos;
        }

        public void DeSegundos(int totalSegundos)
        {
            horas = totalSegundos / 3600;
            totalSegundos %= 3600;
            minutos = totalSegundos / 60;
            segundos = totalSegundos % 60;
            Valida();
        }

        public int SegundosDesde(Hora otra)
        {
            return Math.Abs(ASegundos() - otra.ASegundos());
        }

        public void Siguiente()
        {
            DeSegundos(ASegundos() + 1);
        }

        public void Anterior()
        {
            DeSegundos(ASegundos() - 1);
        }

        public Hora Copia()
        {
            return new Hora(horas, minutos, segundos);
        }

        public bool IgualQue(Hora otra)
        {
            return horas == otra.horas && minutos == otra.minutos && segundos == otra.segundos;
        }

        public bool MenorQue(Hora otra)
        {
            return ASegundos() < otra.ASegundos();
        }

        public bool MayorQue(Hora otra)
        {
            return ASegundos() > otra.ASegundos();
        }
    }
}
