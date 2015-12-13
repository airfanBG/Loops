using System;

    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int num=0;
            long hex=0;

            long degree = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                char ch = number[i];
                switch (ch.ToString())
                {
                    case "A": num = 10;
                        break;
                    case "B": num = 11;
                        break;
                    case "C": num= 12;
                        break;
                    case "D": num = 13;
                        break;
                    case "E": num = 14;
                        break;
                    case "F": num = 15;
                        break;


                    default: num= Convert.ToInt32(ch.ToString());
                        break;
                }
                hex += num * (long)Math.Pow(16, degree);
                degree--;
            }
            Console.WriteLine(hex);
        }
    }

