using System;
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            /*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/
            Console.Write("Enter number: ");
            int bitNumberThree = 3;
            int number = int.Parse(Console.ReadLine());
            int theMask = 1 << bitNumberThree;
            int nAndMask = number & theMask;
            int whatIsTheBit = nAndMask >> bitNumberThree;
            Console.WriteLine("Bit #3 is: " + whatIsTheBit);
        }
    }
