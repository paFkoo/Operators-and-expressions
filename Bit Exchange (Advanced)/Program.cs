using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/
            int num1, num2, p, q, k, loop;
            uint n, n1, bit;
            while (true)
            {
                Console.WriteLine("Input n:");
                if (uint.TryParse(Console.ReadLine(), out n))
                {
                    if (n >= 0)
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Input p:");
                if (int.TryParse(Console.ReadLine(), out p))
                {
                    if (p >= 0)
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Input q:");
                if (int.TryParse(Console.ReadLine(), out q))
                {
                    if (q >= 0)
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Input k:");
                if (int.TryParse(Console.ReadLine(), out k))
                {
                    if (k > 0)
                    {
                        break;
                    }
                }
                
            }
            Console.WriteLine(("Binary representation of initial n: ") + Convert.ToString(n, 2).PadLeft(32, '0'));
            if (p > q)
            {
                num1 = q;
                num2 = p;
            }
            else
            {
                num1 = p;
                num2 = q;
            }
            loop = num1;
            if (num2 - num1 < k || num1 + k > 32 || num2 + k > 32)
            {
                Console.WriteLine("Overlapping or out of range");
            }
            else
            {
                for (num1 = loop; num1 < (loop + k); num1++)
        {
                bit = (n >> num1) & 1;
                if (bit == 1)
                {
                    n1 = (bit << num1 + (num2 - num1)) | n; 
                    bit = (n >> num1 + (num2 - num1)) & 1;
                    if (bit == 1)
                    {
                        n1 = (bit << num1) | n1;
                    }
                    else
                    {
                        n1 = ~((bit + 1) << num1) & n1;
                    }
                }
                else
                {
                    n1 = ~((bit + 1) << num1 + (num2 - num1)) & n; 
                    bit = (n >> num1 + (num2 - num1)) & 1; 
                    if (bit == 1)
                    {
                        n1 = (bit << num1) | n1;
                    }
                    else
                    {
                        n1 = ~((bit + 1) << num1) & n1;
                    }
                }
                n = n1;
                num2 = num2 + 1;
        }
                Console.WriteLine(("Binary representation of n: ") + Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("The result is: {0}", n);
            }
        }
    }
