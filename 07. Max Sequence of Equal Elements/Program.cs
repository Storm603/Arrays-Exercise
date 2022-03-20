using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string sequence = String.Empty;
            string bestSequence = String.Empty;
            int nextNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    if (arr[i] == arr[i - 1])
                    {
                        sequence += arr[i].ToString() + " ";
                        if (sequence.Length > bestSequence.Length)
                        {
                            bestSequence = sequence;
                            sequence = String.Empty;
                            nextNumber = 0;
                        }
                    }
                    break;
                }
                
                if (arr[i] == arr[i + 1])
                {
                    nextNumber = arr[i + 1];

                    sequence += arr[i].ToString() + " ";
                    continue;
                }

                if (arr[i] == nextNumber)
                {
                    sequence += arr[i].ToString() + " ";
                }

                if (arr[i] != arr[i + 1])
                {
                    if (sequence.Length > bestSequence.Length)
                    {
                        bestSequence = sequence;
                    }
                    sequence = String.Empty;
                }
            }
            Console.WriteLine(bestSequence);
        }
    }
}
