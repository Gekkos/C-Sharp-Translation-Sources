﻿namespace DigitsCountOfANumber
{
    using System;

    public class DigitsCountOfANumber
    {
        private static uint number = 4242;

        internal static void Main()
        {
            uint digits = 0;
            uint n = number;
            for (; n > 0; n /= 10, digits++)
            {
            }

            Console.WriteLine("Броят на цифрите на {0} е {1}", number, digits);
        }
    }
}
