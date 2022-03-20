using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int tempIndex = 0;

            for (int j = 0; j < rotations; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        tempIndex = arr[arr.Length - 1];
                        arr[arr.Length - 1] = arr[0];
                    }

                    if (i == arr.Length - 1 - 1)
                    {
                        arr[arr.Length - 1 - 1] = tempIndex;
                        break;
                    }
                    arr[0 + i] = arr[1 + i];
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
