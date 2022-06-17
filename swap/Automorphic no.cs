using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Automorphic_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the nmber");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            num = temp;
            int square = num * num;
            int power = 1;
            for(int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int end = square % power;
            if (end == num)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not automorphic");
            }







        }
    }
}
