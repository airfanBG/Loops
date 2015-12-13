using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            long number = long.Parse(Console.ReadLine());
            long divisor = 2;
            long result=1;
            long quotient = 1;
            string binary = string.Empty;
            while (quotient!=0)
            {
                result = number % divisor;
                quotient = number / divisor;
                binary += result.ToString();
                number = quotient;
            }
            char[] value = binary.ToCharArray();
            Array.Reverse(value);
            for (int i = 0; i < value.Length; i++)
            {
                Console.Write("{0}", value[i]);  
            }
            Console.WriteLine();
        }
    }

