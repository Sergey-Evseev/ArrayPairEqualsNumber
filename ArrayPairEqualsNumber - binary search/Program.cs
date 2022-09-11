//3.1. Бинарный поиск в упорядоченном массиве - лучшее решение

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
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = sum - arr[i]; //временная переменная для поиска пары для текущего значения цикла
                //число которое мы ищем будет лежать справа от текущего, иначе мы бы нашли его ранее
                int l = i + 1; //левая граница поиска равна индексу следующего элемента
                int r = arr.Length - 1; //правая граница будет последний элемент массива
                while (l <= r)//в цикле, пока наша граница поиска содержит хотя бы один элемент 
                {
                    int mid = l + (r - l) / 2; //найдем ИНДЕКС эл-та середины границы поиска 
                    // - участка от числа справа от текущего до последнего элемента
                    if (arr[mid] == temp) { //если элемент в середине равен искомому (разнице заданного с текущим)
                        Console.WriteLine("\nPair with a given sum: " + sum + " is: (" + arr[i] + ", " + temp + ")");
                        flag = true; //меняем flag на true 
                    }
                    if (temp < arr[mid]) { //если число что ищем меньше числу в середине
                                           //значит arr[mid] и все индексы больше него нам не подходят
                        r = mid - 1; //соответственно мы изменяем правую границу на mid-1 (-1 потому что arr[mid] мы уже проверили)
                    }
                    else {//если число больше элемента в середине 
                        l = mid + 1; // изменяем левую границу поиска (+1 потому что arr[mid] мы уже проверили)
                    }
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
            int[] A3 = { 2, 4, 5, 2, -10 }; int x3 = 8;
            int[] A4 = { -2, -1, 1, 2 };    int x4 = 0;

            printResults(A1, x1);
            printResults(A2, x2);
            printResults(A3, x3);
            printResults(A4, x4);
        }
    }
}