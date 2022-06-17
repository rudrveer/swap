using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class For_Loop_for_patern
    {
        static void Main(string[] args)
        {
            /* for (int i = 1; i <= 4; i++)
             {

                 for (int j = 4; j >= i; j--)
                 {
                     Console.Write(j + " ");

                 }
                 Console.WriteLine();
             }/*
           //third one 
           /*for(int i= 1; i <= 4; i++)
             {

                 for(int j = i; j <= 4; j++)
                 {
                     Console.Write(j+" ");
                 }
                 Console.WriteLine();
             }*/
            /* for(int i = 4; i >=1; i--)
               {
                   for(int j = 1; j <= i; j++)
                   {
                       Console.Write(j+"");
                   }
                   Console.WriteLine();
               }*/
            //1001 type patern
            /* for (int i = 1; i <= 4; i++)
               {
                   for(int j = 1; j <= i; j++)
                   {
                       if (j % 2 == 0)
                           Console.Write("0");
                       else
                       {
                           Console.Write("1");
                       }

                   }
                   Console.WriteLine();
               }*/
            /*int c = 64;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write((char)(c + j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }*/
            int z=7;
            for(int i = 1; i <= 6; i++)
            {
                for(int j =6; j>=i; j--)
                {                    
                        Console.Write(" ");
                }
                for(int k = 1; k <= z; k++)
                {
                    Console.Write("*");
                }
                z -= 2;

                Console.WriteLine("");
            }

                //for(int i=1; i<=5; i++)
              //{
               // for(int j =1; j <=i; j++)
                //{
                  //  Console.Write(" ");
                //}
               // for(int j =1; j <=i ; j++)
                //{
                  //  Console.Write(j);
                //}
                //Console.WriteLine();
              
               //}




           



        }                 
            
                
    
    }
}
