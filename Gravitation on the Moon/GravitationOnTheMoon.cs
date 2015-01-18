using System;
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            /*The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/
            Console.Write("Enter your weight: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the moon is: " + weightOnEarth * 0.17);
        }
    }
