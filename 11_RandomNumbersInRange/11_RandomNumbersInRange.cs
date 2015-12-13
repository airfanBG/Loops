using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write \"n\"");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write \"min\"");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Write \"max\"");
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();
            if (min>max)
            {
                Console.WriteLine("Invalid number, try again");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",rand.Next(min, max+1));
            }
            





            //// ... Create new Random object.
            //Random r = new Random();
            //// ... Get three random numbers.
            ////     Always 5, 6, 7, 8 or 9.
            //Console.WriteLine(r.Next(1,10));
            //Console.WriteLine(r.Next(5, 10));
            //Console.WriteLine(r.Next(5, 10));
        }
    }

