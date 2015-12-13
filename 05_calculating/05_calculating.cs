using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter \"n\":");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"x\":");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            double pow = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                pow = Math.Pow(x, i);
                sum += (factorial / pow);
            }
            
            Console.WriteLine("S= {0:F5}",sum);
        }
    }

