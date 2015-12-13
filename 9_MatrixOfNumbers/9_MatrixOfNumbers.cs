using System;
class Program
{
    static void Main()
    {
        int n = 4;
        int count = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <2*n; j++)
            {
                if (count<=n)
                {
                    Console.Write("{0}", j);
                    count++;  
                }
                    
               
            }
            Console.WriteLine();
            count = 1;
        }
    }
}

                       
    

