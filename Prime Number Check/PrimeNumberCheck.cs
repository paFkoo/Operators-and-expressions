using System;
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
 //Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
            Console.Write("Enter number: ");
            int isItPrime = int.Parse(Console.ReadLine());

            bool mayBePrime = false;

            if (isItPrime > 1 && isItPrime < 101)
            {
                if (isItPrime == 2 || isItPrime == 3 || isItPrime == 5 || isItPrime == 7)
                {
                    mayBePrime = true;
                }
                else if (isItPrime % 2 != 0 && isItPrime % 3 != 0 && isItPrime % 5 != 0 && isItPrime % 7 != 0)
                {
                    mayBePrime = true;
                }
            }
            Console.WriteLine("Prime -  " + mayBePrime);
        }
    }
