using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write b");
            int b = int.Parse(Console.ReadLine());

            int remainder = 0;
            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
                
                
            }
            Console.WriteLine(a);
        }
    }

