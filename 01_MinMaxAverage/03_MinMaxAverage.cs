using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a count of numbers:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number:");
            array[i] = int.Parse(Console.ReadLine());
            
            sum += array[i];
        }
        int min = array[0];
        int max = array[0];
        for (int i = 0; i < n; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
            if (max < array[i])
            {
                max = array[i];
            }
        }
        Console.WriteLine("min= {0}", min);
        Console.WriteLine("max= {0}", max);
        Console.WriteLine("sum= {0}", sum);
        Console.WriteLine("average= {0:F2}", ((double)sum/n));

        }
    }
