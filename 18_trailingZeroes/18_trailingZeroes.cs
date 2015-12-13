using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            long factorial = 1;
            int counter = 1;
            long result=0;
            while (counter<number)
            {
               factorial *= counter;
                counter++;
                result = (long)factorial / 10; 
                
            }
            
            Console.WriteLine(factorial);
            Console.WriteLine(result);
        }
    }

