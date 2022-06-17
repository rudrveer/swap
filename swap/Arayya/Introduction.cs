using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.Arayya
{
    class Introduction
    {
        static void Main(string[] args)
        {
            /* char[] ab = { 'a', 't', 'Y', 'r' };
             char[] c1 = new char[4];
             for (int i = 0; i <c1.Length; i++)
             {
                 c1[i] = Convert.ToChar(Console.ReadLine());
             }
             for(int i =0;i<c1.Length;i++)
             {
                 Console.WriteLine(c1[i]);
             }
            int[] cf = { 1, 2, 3, 4 };

            Console.WriteLine(cf[0]);
            int[] ram = new int[5];
            ram[0] = 11;
            ram[1] = 22;
            ram[2] = 13;
            ram[3] = 14;
            Console.Write(ram[1]);*/
            // arrya to display sum of even elements
            //   int sum = 0;
            //  int[] RR = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*  for(int i = 0; i < RR.Length; i++)
              {
                 if(RR[i]%2==0)
                  {
                      sum = sum + RR[i];
                  }
              }
              Console.WriteLine(sum); */
            //to display odd position
            /* for (int i = 0; i < RR.Length; i++)
             {
                 if (RR[i] % 2 != 0)
                 {
                     Console.WriteLine(RR[i]);
                 }

             }*/
            // to display sum of arrya elemnts
            int sum = 0;
            Console.WriteLine("Enter size of arry");
            int size = int.Parse(Console.ReadLine());
            int[] RR = new int [size];
            Console.WriteLine("Enter arrya elemnts ");
            for (int i = 0; i < RR.Length; i++)
            {
                RR[i] = int.Parse(Console.ReadLine());
            }  
            for(int i = 0; i < RR.Length; i++)
            {
                sum = sum + RR[i];
            }
            Console.WriteLine("sum of arrya elemnt is "+sum);
            sum = RR[RR.Length - 1] * (RR[RR.Length-1] + 1) / 2;
            Console.WriteLine(sum);
            for(int i = 0; i < RR.Length; i++)
            {
                Console.WriteLine(RR[i]*RR[i]);
            }
        }
    }
}
