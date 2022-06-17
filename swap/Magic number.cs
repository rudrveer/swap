using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Magic_number
    {
        static void Main(string[] args)
        {
            int Magicnumber = 55;
           
          
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                if( Magicnumber==num)
                Console.WriteLine("it is a Magic Number");
               
                else
                {
                    Console.WriteLine("it is not magic number");
                }
                break;
            }
        }
    }
}
