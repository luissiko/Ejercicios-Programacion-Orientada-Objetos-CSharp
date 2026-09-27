using System;

namespace poo2parcialexamen.Clases.Fecha
{
    public class Fecha
    {
        private int _dia;
        private int _mes;
        private int _anio;

        public Fecha()
        {
            _dia = 1;
            _mes = 1;
            _anio = 1900;
        }

        public Fecha(int dia, int mes, int anio)
        {
            _dia = dia;
            _mes = mes;
            _anio = anio;
            Valida();
        }

        public int Dia { get => _dia; set { _dia = value; Valida(); } }
        public int Mes { get => _mes; set { _mes = value; Valida(); } }
        public int Anio { get => _anio; set { _anio = value; Valida(); } }

        public void Leer()
        {
            Console.Write("Ingrese día (1-31): ");
            _dia = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Ingrese mes (1-12): ");
            _mes = int.Parse(Console.ReadLine() ?? "1");

            Console.Write("Ingrese año (1900-2050): ");
            _anio = int.Parse(Console.ReadLine() ?? "1900");

            Valida();
        }

        private void Valida()
        {
            if (_anio < 1900 || _anio > 2050) _anio = 1900;
            if (_mes < 1 || _mes > 12) _mes = 1;
            if (_dia < 1 || _dia > DiasMes(_mes)) _dia = 1;
        }

        public bool Bisiesto()
        {
            return (_anio % 4 == 0 && _anio % 100 != 0) || (_anio % 400 == 0);
        }

        public int DiasMes(int mes)
        {
            return mes switch
            {
                2 => Bisiesto() ? 29 : 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };
        }

        public string Corta()
        {
            return $"{_dia:D2}-{_mes:D2}-{_anio}";
        }

        public string Larga()
        {
            return $"{_dia:D2} de {NombreMes()} de {_anio}";
        }

        private string NombreMes()
        {
            return _mes switch
            {
                1 => "enero",
                2 => "febrero",
                3 => "marzo",
                4 => "abril",
                5 => "mayo",
                6 => "junio",
                7 => "julio",
                8 => "agosto",
                9 => "septiembre",
                10 => "octubre",
                11 => "noviembre",
                12 => "diciembre",
                _ => "desconocido"
            };
        }

        public long DiasTranscurridos()
        {
            DateTime inicio = new DateTime(1900, 1, 1);
            DateTime actual = new DateTime(_anio, _mes, _dia);
            return (long)(actual - inicio).TotalDays;
        }

        public void Siguiente()
        {
            DateTime fecha = new DateTime(_anio, _mes, _dia).AddDays(1);
            _dia = fecha.Day;
            _mes = fecha.Month;
            _anio = fecha.Year;
        }

        public void Anterior()
        {
            DateTime fecha = new DateTime(_anio, _mes, _dia).AddDays(-1);
            _dia = fecha.Day;
            _mes = fecha.Month;
            _anio = fecha.Year;
        }

        public Fecha Copia()
        {
            return new Fecha(_dia, _mes, _anio);
        }

        public bool IgualQue(Fecha f)
        {
            return _dia == f.Dia && _mes == f.Mes && _anio == f.Anio;
        }

        public bool MenorQue(Fecha f)
        {
            DateTime actual = new DateTime(_anio, _mes, _dia);
            DateTime otra = new DateTime(f.Anio, f.Mes, f.Dia);
            return actual < otra;
        }

        public bool MayorQue(Fecha f)
        {
            DateTime actual = new DateTime(_anio, _mes, _dia);
            DateTime otra = new DateTime(f.Anio, f.Mes, f.Dia);
            return actual > otra;
        }
    }
}
