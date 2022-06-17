using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Display
    {
        static void Main(string[] args)
        {
            /*  for(int i = 16; i < 25; i++)
              {
                  Console.WriteLine(i);
              }*/

            /*  for(int i = 351; i < 400; i++)
              {
                  Console.WriteLine(i);
              }*/
            /*    for(int i= 15; i <= 30; i++)
               {
                   if (i % 2 != 0)
                   {
                       Console.WriteLine(i);
                   }
               }*/
            /* for(int i = 1; i <=99; i++)
                {
                    if (i % 5 == 0||i%10==0)
                    {
                        i++;
                    }
                    Console.WriteLine(i);
                  //  else
                    //{
                      //  Console.WriteLine(i*i);
                    //}

                }*/
            for(int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i+" "+(i*i));
                }
            }

            
            

            



        }
    }
}
