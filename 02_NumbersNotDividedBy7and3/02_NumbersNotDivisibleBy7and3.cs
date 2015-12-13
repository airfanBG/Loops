using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (n>=counter)
            {
                if (counter%3!=0&& counter%7!=0)
                {
                    Console.Write("Nnumbers not devisible at 3 and 7 are: {0}",counter);
                    
                }
                counter++;
            }
            Console.WriteLine();
            
        }
    }

