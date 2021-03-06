﻿namespace Majorant7
{
    using System;

    public class Majorant7
    {
        internal static void Main()
        {
            char majority;
            char[] array = { 'A', 'A', 'A', 'C', 'C', 'B', 'B', 'C', 'C', 'C', 'B', 'C', 'C', };
            if (FindMajority(array, 0, array.Length - 1, out majority))
            {
                Console.WriteLine("Мажорант: {0}", majority);
            }
            else
            {
                Console.WriteLine("Няма мажорант.");
            }
        }

        private static int Count<T>(T[] array, int left, int right, T candidate)
        {
            int counter = 0;
            for (; left <= right; left++)
            {
                if (array[left].Equals(candidate))
                {
                    counter++;
                }
            }

            return counter;
        }

        private static bool FindMajority<T>(T[] array, int left, int right, out T majority)
        {
            majority = default(T);
            if (left == right)
            {
                majority = array[left];
                return true;
            }

            int middle = (left + right) / 2;
            if (FindMajority(array, left, middle, out majority))
            {
                if (Count(array, left, right, majority) > (right - left + 1) / 2)
                {
                    return true;
                }
            }

            if (FindMajority(array, middle + 1, right, out majority))
            {
                if (Count(array, left, right, majority) > (right - left + 1) / 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}