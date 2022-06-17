using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class StaticDemo
    {
        static StaticDemo()
        {
            Console.WriteLine("you are doing Good");
        }
         StaticDemo()
        {
            Console.WriteLine(" are you well");
        }
        StaticDemo(int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticDemo s1 = new StaticDemo(9);
            StaticDemo s2 = new StaticDemo();


        }
    }
}
