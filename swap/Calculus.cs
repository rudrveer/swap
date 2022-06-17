using System;
using System.Collections.Generic;
using System.Text;

namespace swap
{
    class Calculus
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num 2 ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter symbol");
            //char ch = Convert.ToChar(Console.ReadLine());
            char ch = Console.ReadLine()[0];
            
            switch (ch)
            {
                case'+': Console.WriteLine(num1+num2);
                    break;
                case '-': Console.WriteLine(num1-num2);
                    break;
                case '*': Console.WriteLine(num1*num2);
                    break;
                case '/': Console.WriteLine(num1/num2);
                    break;
                default: Console.WriteLine("invalid operation");
                    break;
            }

        }
    }
}
