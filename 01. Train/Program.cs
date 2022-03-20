using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            int range = int.Parse(Console.ReadLine());
            int[] arr = new int[range];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }
            Console.WriteLine();
            Console.Write(sum);
        }
    }
}
