using System;
class OddOrEvenInteger
{
    static void Main(string[] args)
    {
        //Write an expression that checks if given integer is odd or even.
        Console.Write("Enter a number: ");
        int oddOrEven = int.Parse(Console.ReadLine());
        {
            if (oddOrEven % 2 == 0)
                Console.WriteLine("This number is even");

            else

                Console.WriteLine("This number is odd");
        }
    }
}