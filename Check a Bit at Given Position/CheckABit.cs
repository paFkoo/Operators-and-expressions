using System;
    class CheckABit
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a position: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            bool real = true;
                {
                    if (bit == 1)
                        Console.WriteLine(real);
                    else
                        Console.WriteLine(!real);
                }
        }
    }
