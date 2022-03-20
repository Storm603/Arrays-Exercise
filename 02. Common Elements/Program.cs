using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arrTwo.Length; i++)
            {
                for (int j = 0; j < arrOne.Length; j++)
                {
                    if (arrOne[j] == arrTwo[i])
                    {
                        Console.Write(arrTwo[i] + " ");
                    }
                }
            }
        }
    }
}
