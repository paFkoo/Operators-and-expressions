using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.
            Console.Write("Write the integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Write the index number: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine("Bit is = " + bit);
        }
    }
