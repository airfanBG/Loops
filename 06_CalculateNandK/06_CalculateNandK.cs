using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter \"n\"");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter \"k\"");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        if ((n > 0 && n <= 100) && (k > 0 && k <= 100))
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i<=k)
                {
                    factorialK *= i;
                }
               
            }
            Console.WriteLine("result: {0}", factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Not a valid number");
            
        }
        
    }
}
