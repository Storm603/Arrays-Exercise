using System;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            if (input.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int L = 0; L < i; L++)
                {
                    leftSum += input[L];
                }

                for (int R = i + 1; R < input.Length; R++)
                {
                    rightSum += input[R];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            if(leftSum != rightSum) Console.WriteLine("no");
        }
    }
}
