using System;
    class Program
    {
        static void Main(string[] args)
        {/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the
          * position p from the binary representation of n while preserving all other bits in n.*/
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter a bit value ( 0 or 1): ");
            int v = int.Parse(Console.ReadLine());
            int mask = 1 << p;        
            if (v == 0)
            {
                mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }
            else if (v == 1)
            {
                mask = 1 << p;
                int resultOne = n | mask;
                Console.WriteLine(resultOne);
            }
        }
    }
