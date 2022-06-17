using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Fibonacii
    {
        static void Main(string[] args)
        {
            int a = 0;
            int sum;
            int b = 1;

            Console.WriteLine(a);

            for (int i = 0; i <= 10; i++)
            {
                sum = a + b;
                Console.WriteLine(sum);
                a = b;
                b = sum;

            }
        }
    }
}
