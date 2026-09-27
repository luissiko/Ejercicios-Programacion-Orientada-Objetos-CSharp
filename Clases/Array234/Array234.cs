namespace poo2parcialexamen.Clases.Array234
{
    public class Array234
    {
        private double[,,] _array;

        public Array234()
        {
            _array = new double[2, 3, 4];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 4; k++)
                        _array[i, j, k] = rnd.NextDouble();
        }

        public void MaxMin()
        {
            double max = _array[0, 0, 0];
            double min = _array[0, 0, 0];
            (int, int, int) maxIndex = (0, 0, 0);
            (int, int, int) minIndex = (0, 0, 0);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (_array[i, j, k] > max)
                        {
                            max = _array[i, j, k];
                            maxIndex = (i, j, k);
                        }
                        if (_array[i, j, k] < min)
                        {
                            min = _array[i, j, k];
                            minIndex = (i, j, k);
                        }
                    }
                }
            }

            Console.WriteLine($"Valor Máximo: {max:F3} en índice ({maxIndex.Item1},{maxIndex.Item2},{maxIndex.Item3})");
            Console.WriteLine($"Valor Mínimo: {min:F3} en índice ({minIndex.Item1},{minIndex.Item2},{minIndex.Item3})");
        }
    }
}
