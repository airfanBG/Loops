using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write a number \"n\"  1<n<100");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("Write a number \"k\"  1<n<100");
        int k = int.Parse(Console.ReadLine());
        int extraction = n-k;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger result = 1;
        if ((n < 1 || n > 100) && (k < 1 || k > 100))
        {
            Console.WriteLine("Not a valid number");
            return;
        }
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }

            }

            for (int j = 1; j <= extraction; j++)
            {

                result *= j;

            }


            Console.WriteLine("result: {0}", (factorialN / (factorialK * result)));
        }

    }


