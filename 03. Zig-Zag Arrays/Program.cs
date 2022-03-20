using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int range = int.Parse(Console.ReadLine());
            int[] arrOne = new int[range];
            int[] arrTwo = new int[range];

            for (int i = 0; i < arrOne.Length; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i] = input[0];
                    arrTwo[i] = input[1];
                }
                else if (i % 2 == 1)
                {
                    arrOne[i] = input[1];
                    arrTwo[i] = input[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
