using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class Overloadingsum
    {
        void Calculate(int x,int y)
        {
            Console.WriteLine("addition of two no is == "+(x+y));
        }
        void Calculate(float p,int  q)
        {
            Console.WriteLine(" Multiplication of two no == "+(p*q));
        }
       void Calculate(int  a, float b)
        {
            Console.WriteLine("subtraction of two no is =="+(a-b));
        }
        void Calculate(float a,float b)
        {
            Console.WriteLine("Division Of two no is ==" + (a / b));

        }
        static void Main(string[] args)
        {
            Overloadingsum s1 = new Overloadingsum();
            s1.Calculate(10,22);//sum
            s1.Calculate(5.5f, 23);//multiplication
            s1.Calculate(22, 12.5f);//substraction
            s1.Calculate(12.5f, 2.5f);// division



        }







    }
}
