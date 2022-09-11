//2. Перебор массива с созданием хэшсета

using System;
using System.Collections.Generic;

namespace ArrayPairEqualsNumber
{
    class Program
    {
        static bool chkPair(int[] arr, int sum)
        {
            HashSet<int> set = new HashSet<int>();                       
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = sum - arr[i];
                if (set.Contains(temp))
                {
                    Console.WriteLine("\nPair with given sum: " + sum + " is (" + arr[i] + ", " + temp + ")");
                    return true;
                }
                else set.Add(arr[i]);
                
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
            int[] A1 = { -1, 2, 5, 8, 15}; int x1 = 7;
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