using System;
namespace Deliverable_4;
class Program
{
    static void Main(string[] args)
    {

      

        //Declaring arrays
        int[] fibonacci = new int[25];
        int[] even = new int[25];
        int[] odd = new int[25];

        
        // Initialize fibonacci series
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 0; i < 25; i++)
        {
            even[i] = 2 * i;
            odd[i] = 2 * i + 1;

            if (i >= 2)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
        }
        

        Console.WriteLine("The first" + " " + 25 + " " +
"Fibonacci numbers are: ");

       

        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
          
        }

    }
}

