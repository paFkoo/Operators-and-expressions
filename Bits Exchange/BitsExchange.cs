using System;
    class BitsExchange
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            Console.Write("Enter the unsigned integer number n:");
            uint n;
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

                n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));

                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0') + "\nNew integer: " + (Convert.ToInt32(n)));
            }
        }
    }
