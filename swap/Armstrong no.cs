using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Armstrong_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;int product=num;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r * r * r;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (sum == product)
            {
                Console.WriteLine("No is armstrong no");
            }
            else
            {
                Console.WriteLine("No is not armstrong no");
            }
            
        }
    }
}
