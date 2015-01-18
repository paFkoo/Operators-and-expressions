using System;
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.
            Console.Write("Enter one side: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter another side: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The trapezoid's area is: " + ((a + b) / 2) * h);
        }
    }
