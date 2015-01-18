using System;
    class Rectangles
    {
        static void Main(string[] args)
        {//Write an expression that calculates rectangle’s perimeter and area by given width and height.
            Console.Write("Enter the rectangle's width and height: ");
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int perimeter = ((sideA + sideB) + (sideA + sideB));
            int area = sideA * sideB;
            Console.WriteLine("The perimeter of the rectangle is - {0}" ,  perimeter);
            Console.WriteLine("The area of the rectangle is - {0}" , area);
        }
    }

