namespace poo2parcialexamen.Clases.ArrayInverso
{
    public class ArrayInverso
    {
        private int[] numeros;

        public ArrayInverso()
        {
            numeros = new int[10];
        }

        public void LeerNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        public void MostrarInverso()
        {
            Console.WriteLine("\nNúmeros en orden inverso:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
