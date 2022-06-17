using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Kaprekar_no
    {
        static void Main(string[] args)
        {
            int temp;
            int num;
            Console.WriteLine("enter the num");
            num = int.Parse(Console.ReadLine());
            temp = num;
            int sq = num * num;
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int division = sq / power;
            int remainder = sq % power;
            int sum = division + remainder;
            if (sum == temp)
            {
                Console.WriteLine("Kaprekar No");
            }
            else
            {
                Console.WriteLine("Not kaprekar");
            }
            
        }
    }
}
