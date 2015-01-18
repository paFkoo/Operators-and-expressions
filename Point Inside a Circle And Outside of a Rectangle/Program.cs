using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
             * and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= (r * r);
            bool outsideRect = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
            bool check = inCircle && outsideRect;
            Console.WriteLine("Inside the circle & outside of rectangle --> " + check );
        }
    }
