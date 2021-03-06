﻿namespace MiddleFindKthElement2
{
    using System;

    public class MiddleFindKthElement2
    {
        private static readonly Random Rand = new Random();
        private static int[] array;

        public static void PrintArray(int[] numbers) /* Извежда масива на екрана */
        {
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static void Swap(ref int element1, ref int element2) /* Разменя стойностите на две променливи */
        {
            int temp = element1;
            element1 = element2;
            element2 = temp;
        }

        public static int FindKthElement(int left, int right, int k) /* Търсене по Хоор */
        {
            if (left == right)
            {
                return left;
            }

            int middle = Partition(left, right);
            int p = middle - left + 1;
            return k > p ? FindKthElement(left, middle, k) : FindKthElement(middle + 1, right, k - p);
        }

        internal static void Main()
        {
            int n = 10;
            int k = 4;
            array = new int[n];
            InitializeArray(array);
            PrintArray(array);
            FindKthElement(0, n - 1, k);
            PrintArray(array);
        }

        private static int Partition(int left, int right) /* Раделяне по Ломуто */
        {
            int i = left - 1;
            int x = array[right];
            for (int j = left; j <= right; j++)
            {
                if (array[j] <= x)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            /* Всички са <= x. Стесняване на областта с 1. */
            if (i == right)
            {
                i--;
            }

            return i;
        }

        private static void InitializeArray(int[] array) /* Запълва масива със случайни числа */
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Rand.Next() % ((2 * array.Length) + 1);
            }
        }
    }
}