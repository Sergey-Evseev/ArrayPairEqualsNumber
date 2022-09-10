//2. Перебор массива с хэшсетом

using System;

namespace ArrayPairEqualsNumber
{
    class Program
    {
        static bool chkPair(int[] A, int x)
        {
            int size = A.Length;
            for (int i = 0; i < (size - 1); i++)
            {
                for (int j = (i + 1); j < size; j++)
                {
                    if (A[i] + A[j] == x)
                    {
                        Console.WriteLine("\nPair with a given sum: " + x + " is (" + A[i] + ", " + A[j] + ")");
                        return true;
                    }
                }
            }
            return false;
        }

        static void printResults(int[] arr, int key)
        {
            Console.WriteLine("For array:");            
            foreach (var item in arr) {
                Console.Write(item + " ");
            }
            if (chkPair(arr, key))
            {
                Console.WriteLine("Valid pair exists\n");
            }
            else
            {
                Console.WriteLine("\nNo valid pair exists for " + key + "\n");
            }
        }

        static void Main(string[] args)
        {
            int[] A1 = { -1, 2, 5, 8 }; int x1 = 7;
            int[] A2 = { -3, -1, 0, 2, 6 }; int x2 = 6;
            int[] A3 = { 2, 4, 5 }; int x3 = 8;
            int[] A4 = { -2, -1, 1, 2 }; int x4 = 0;

            printResults(A1, x1);
            printResults(A2, x2);
            printResults(A3, x3);
            printResults(A4, x4);
        }
    }
}