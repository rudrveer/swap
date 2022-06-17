using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class While
    {
        static void Main(string[] args)
        {

            int i = 0;
            int sum = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
             

                }
                else
                {
                    sum = i * i;
                    Console.WriteLine(sum);
                }
                i++;

            }

          
        }
       
    }
}
