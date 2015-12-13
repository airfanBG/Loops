using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer in the range (1 < n < 100):");
            int n = int.Parse(Console.ReadLine());
            if (n == 1 || n >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            BigInteger factorial2N = 1;
            BigInteger factorial=1;
            BigInteger factorial1 = 1;

            for (int i = 1; i <= n*2; i++)
            {
                
                factorial2N *= i;

                if (i <= n)
                {
                    factorial *= i;
                }
            }
                for (int j = 1; j <= n+1; j++)
                {
                    factorial1 *= j;
                }
            
            
            Console.WriteLine(factorial2N/(factorial1*factorial));
        }
    }
