using System;
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7

            Console.Write("Enter number: ");
            int thirdDigit = int.Parse(Console.ReadLine());

            thirdDigit /= 100;

            bool realSeven = (thirdDigit % 10) == 7;

            Console.WriteLine("The third digit is 7 ----> " + realSeven);
        }
    }
