using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Series
    {
        static void Main(string[] args)
        {
            int i=1 ;int d ;
            while (i <= 10)
            {
                d = i * i + 1; 
                //d = i*i-1; i = 0;
                // d = i*i+(i*i*i);
                Console.WriteLine(d);
                i++;
            }
           
        }
    }
}
