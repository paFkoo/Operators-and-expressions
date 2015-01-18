using System;
    class PointInACircle
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            double r = 2;

            bool isItInTheCircle = (x * x + y * y) <= (r * r);

            Console.WriteLine("Is it in the circle ---> " + isItInTheCircle);
        }
    }
