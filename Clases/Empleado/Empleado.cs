namespace poo2parcialexamen.Clases.Empleado
{
    public class Empleado
    {
        private long nif;
        private double sueldoBase;
        private double pagoHoraExtra;
        private int horasExtra;
        private double irpf;
        private bool casado;
        private int hijos;

        public Empleado()
        {
            nif = 0;
            sueldoBase = 0;
            pagoHoraExtra = 0;
            horasExtra = 0;
            irpf = 0;
            casado = false;
            hijos = 0;
        }

        public Empleado(long nif)
        {
            this.nif = nif;
        }

        // Accedentes y mutadores
        public long GetNif() => nif;
        public void SetNif(long value) => nif = value;

        public double GetSueldoBase() => sueldoBase;
        public void SetSueldoBase(double value) => sueldoBase = value;

        public double GetPagoHoraExtra() => pagoHoraExtra;
        public void SetPagoHoraExtra(double value) => pagoHoraExtra = value;

        public int GetHorasExtra() => horasExtra;
        public void SetHorasExtra(int value) => horasExtra = value;

        public double GetIrpf() => irpf;
        public void SetIrpf(double value) => irpf = value;

        public bool GetCasado() => casado;
        public void SetCasado(bool value) => casado = value;

        public int GetHijos() => hijos;
        public void SetHijos(int value) => hijos = value;

        public Empleado Copia()
        {
            return (Empleado)this.MemberwiseClone();
        }

        public double ComplementoHorasExtra()
        {
            return pagoHoraExtra * horasExtra;
        }

        public double SueldoBruto()
        {
            return sueldoBase + ComplementoHorasExtra();
        }

        public double Retencion()
        {
            double porcentaje = irpf;
            if (casado) porcentaje -= 2;
            porcentaje -= hijos;
            if (porcentaje < 0) porcentaje = 0;
            return SueldoBruto() * porcentaje / 100;
        }

        public double SueldoNeto()
        {
            return SueldoBruto() - Retencion();
        }

        public void Println()
        {
            Console.WriteLine($"NIF: {nif}");
        }

        public void PrintAll()
        {
            Console.WriteLine($"NIF: {nif}");
            Console.WriteLine($"Sueldo Base: {sueldoBase}");
            Console.WriteLine($"Pago Hora Extra: {pagoHoraExtra}");
            Console.WriteLine($"Horas Extra: {horasExtra}");
            Console.WriteLine($"Casado: {(casado ? "Sí" : "No")}");
            Console.WriteLine($"Número de Hijos: {hijos}");
            Console.WriteLine($"IRPF: {irpf}%");
            Console.WriteLine($"Complemento Horas Extra: {ComplementoHorasExtra()}");
            Console.WriteLine($"Sueldo Bruto: {SueldoBruto()}");
            Console.WriteLine($"Retención IRPF: {Retencion()}");
            Console.WriteLine($"Sueldo Neto: {SueldoNeto()}");
        }
    }
}
