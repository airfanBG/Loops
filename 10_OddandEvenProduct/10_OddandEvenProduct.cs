using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write integers with space between them");
            string[] inputArray = Console.ReadLine().Split();
            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                
                
                if (i%2==0)
                {
                    productOdd *= Convert.ToInt32(inputArray[i]); 
                }
                else 
                {
                    productEven *= Convert.ToInt32(inputArray[i]); 
                }
            }
                if (productEven==productOdd)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("product = {0}", productOdd);
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("odd_product = {0}", productOdd);
                    Console.WriteLine("even_product = {0}", productEven);
                }
                
            }
        }
    
