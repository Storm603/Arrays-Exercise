using System;
using System.Linq;

namespace _05._Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string bestArr = String.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    bestArr += array[i].ToString() + " ";
                    break;
                }

                if (array[i] > array[i + 1])
                {
                    bestArr += array[i].ToString() + " ";
                }
            }
            Console.WriteLine(bestArr);
        }
    }
}
