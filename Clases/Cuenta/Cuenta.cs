namespace poo2parcialexamen.Clases.Cuenta
{
    public class Cuenta
    {
        private static long contadorCuentas = 100001;
        private long numeroCuenta;
        private long dni;
        private double saldo;
        private double interesAnual;

        public Cuenta()
        {
            numeroCuenta = contadorCuentas++;
            dni = 0;
            saldo = 0;
            interesAnual = 0;
        }

        public Cuenta(long dni, double saldo, double interes)
        {
            numeroCuenta = contadorCuentas++;
            this.dni = dni;
            this.saldo = saldo;
            interesAnual = interes;
        }

        public long GetNumeroCuenta() => numeroCuenta;
        public long GetDni() => dni;
        public double GetSaldo() => saldo;
        public double GetInteresAnual() => interesAnual;

        public void SetDni(long dni) => this.dni = dni;
        public void SetSaldo(double saldo) => this.saldo = saldo;
        public void SetInteresAnual(double interes) => interesAnual = interes;

        public void ActualizarSaldo()
        {
            double interesDiario = interesAnual / 365;
            saldo += saldo * (interesDiario / 100);
        }

        public void Ingresar(double cantidad)
        {
            saldo += cantidad;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para retirar.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Número de cuenta: {numeroCuenta}");
            Console.WriteLine($"DNI: {dni}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Interés anual: {interesAnual}%");
        }
    }
}
