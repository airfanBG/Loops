using System;

    class Program
    {
        static void Main()
        {
           string binary = Console.ReadLine();
           int length =binary.Length;
            long convToDecimal=0;
            long degree = binary.Length-1;
            for (int i = 0; i < binary.Length; i++)
            {
                char ch = binary[i];
                length = Convert.ToInt32(ch.ToString());
                convToDecimal+= length*(long)Math.Pow(2,degree);
                degree--;
            }
            Console.WriteLine(convToDecimal);
        }
    }

