using System;

    class Program
    {
        static void Main()
        {
            int[] array = new int [3];
            Random r = new Random();
            int randomNumber = 0;
            int randomNumbers = 0;
            for (int i = 0; i < 3; i++)
            {
             randomNumber=r.Next(0,3+1);
             array[i] = randomNumber;
               
            }
            
            foreach (var item in array)
	            {
                    Console.WriteLine(item);
                   
	            }
                
          
    }
}
