using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a Boolean expression that checks for given integer if 
            it can be divided (without remainder) by 7 and 5 at the same time.*/
            Console.Write("Enter number to be divided: ");
            int number = int.Parse(Console.ReadLine());
            bool wtfMath = ((number % 7 == 0) && (number % 5 == 0));
            Console.WriteLine("The number is divisible by both 7 and 5 --> {0}" , wtfMath);
            /*or we can do it like this:
            int number = int.Parse(Console.ReadLine());
            bool a = false;
            bool b = true;
            {
                if (number / 7 == 0 && number / 5 == 0)
                Console.WriteLine(a);
            
                else
            
                Console.WriteLine(b);
            }
             */
        }
    }
