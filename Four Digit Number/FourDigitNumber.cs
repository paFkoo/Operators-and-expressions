using System;
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
     /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
             * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
               Prints on the console the number in reversed order: dcba (in our example 1102).
               Puts the last digit in the first position: dabc (in our example 1201).
               Exchanges the second and the third digits: acbd (in our example 2101).*/
            Console.Write("Enter 4 digit number: ");

            int fourDigitNumber = int.Parse(Console.ReadLine());

            int firstDigit = fourDigitNumber % 10;

            int secondDigit = (fourDigitNumber / 10) % 10;

            int thirdDigit = (fourDigitNumber / 100) % 10;

            int fourthDigit = (fourDigitNumber / 1000) % 10;

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);

            Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);

            Console.WriteLine("{0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);

            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }