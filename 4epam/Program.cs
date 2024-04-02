namespace _4epam
//3 завдання
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            int[] Array_summa = new int[width];

            for (int i = 0; i < width; i++)
            {
                int summa = 0;
                for (int j = 0; j < length; j++)
                {
                    summa += array[i, j];
                }
                Array_summa[i] = summa;
            }

            int maxsumma = Array_summa[0];
            int maxline = 1;
            for (int i = 0; i < length; i++)
            {
                if (maxsumma < Array_summa[i])
                {
                    maxsumma = Array_summa[i];
                    maxline = i + 1;
                }
            }
            
            Console.WriteLine("Макс лiнiя " + maxline);
            Console.WriteLine("Макс сума " + maxsumma);
        }
    }
}