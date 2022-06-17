using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Table
    {
        static void Main(string[] args)
        {
            
            
                int num1, num2;
                int c = 0;
            int e;
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            bool isprime = true;

                for (int i = 2; i < num1; i++)
                {
                if (num1 % i == 0)
                    isprime = false;
                }
            Console.WriteLine("First no is prime");
                for (int j = 2; j < num2; j++)
                {
                if (num2 % j == 0)
                    isprime = false;

                        
                }
            Console.WriteLine("second no is prime");
                e = Math.Abs(num2 - num1);

                if (isprime=true && e == 2)
                {
                    Console.WriteLine("no are twin prime");
                }
                else
                {
                    Console.WriteLine("no are not twin prime");
                }








                /* for (int i = 1; i <=5; i++)

                 {
                     Console.WriteLine("table of 1 to 5");

                     for (int j = 1; j <= 5; j++)
                     {
                         Console.WriteLine(i * j);
                     }

                 }*/

            }
    }
}
