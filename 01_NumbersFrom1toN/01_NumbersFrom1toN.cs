using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            while (n>=counter)
            {
                Console.Write("{0} ",counter);
                counter++;
                
            }
            Console.WriteLine();
        }
    }

