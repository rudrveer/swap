using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Practice
    {

        static void Main(string[] args)
        {//plus pattern
          /*  for (int i = 1; i <= 5; i++)
           {
               for (int j = 1; j <= 5; j++)
             {
                if (i == 3 || j == 3)
                     Console.Write("*");
                  else
                     Console.Write(" ");
              }

                Console.WriteLine();

            }*/

            // 

            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                }
            }



        }
    }
    class Manage
    {
        static void Main(string[] args)
        {

            
            int sum=0;
            int fact= 1;

            for(int i = 1; i <=5; i++)
            {
                fact= fact * i;


                sum = sum + fact;


            }

            Console.WriteLine(sum);



        }
        
    }
}  
