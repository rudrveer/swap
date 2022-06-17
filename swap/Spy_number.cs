using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Spy_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());

            int product = 1;
            int sum = 0;
            
            while (num > 0)

            {
                int r = num % 10;
                sum = sum + r;

                product = sum * r;

                num = num / 10;
                            }

            Console.WriteLine(sum);

            Console.WriteLine(product);
            if (sum == product)
            {
                Console.WriteLine("it is a spy no");
            }
            else
            {
                Console.WriteLine("it is not a spy no");
            }
           


        }
    }
}
