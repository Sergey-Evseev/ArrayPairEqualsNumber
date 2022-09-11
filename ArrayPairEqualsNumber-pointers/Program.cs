//4. Поиск с помощью сдвига указателей

using System;
using System.Collections.Generic;

namespace ArrayPairEqualsNumber
{
    class Program
    {
        static bool chkPair(int[] arr, int sum)
        {
            HashSet<int> set = new HashSet<int>();
            bool flag = false;
           
            //создаем две переменные, которыые указывают на индексы первого элемента массива и последнего
            int l = 0, r = arr.Length - 1; 

            while (l < r)//в цикле, пока наши граница поиска не сошлись
            {
                int pairSum = arr[l] + arr[r]; //посчитаем сумму этих чисел
                if (pairSum == sum) //если пара чисел в сумме равна искомому                    
                { //то выводим эти элементы
                    Console.WriteLine("\nPair with a given sum: " + sum + " is: (" + arr[l] + ", " + arr[r] + ")");
                    flag = true; //меняем flag на true 
                }
                if (pairSum < sum) //если сумма меньше, чем число,
                {
                    l++; //то двигаем l-левый индекс на единицу вправо 
                }
                else //если же сумма больше числа
                {
                    r--; //то двигаем правый индекс на единицу влево
                }
            }            
            return flag; //если ничего не нашли оставляем флаг false и возвращаем его
        }

        static void printResults(int[] arr, int key)
        {
            Console.WriteLine("For array:");
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
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
            int[] A1 = { -1, 2, 5, 8, 15 }; int x1 = 7;
            int[] A2 = { -3, -1, 0, 2, 6 }; int x2 = 6;
            int[] A3 = { -10, 4, 5, 2 }; int x3 = 8;
            int[] A4 = { -2, -1, 1, 2 }; int x4 = 0;

            printResults(A1, x1);
            printResults(A2, x2);
            printResults(A3, x3);
            printResults(A4, x4);
        }
    }
}