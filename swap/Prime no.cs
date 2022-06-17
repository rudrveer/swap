using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Prime_no
    {
        static void Main(string[] args)
        {// diasarium no
           /* Console.WriteLine("entre the number");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            double sum = 0;int r;
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            num = temp;
            while (num != 0)
            {
                r = num % 10;
                sum = sum + Math.Pow(r, count);
                count--;
                num = num / 10;

            }
            Console.WriteLine(sum);
            if (sum == temp)
            {
                Console.WriteLine(" It is a Diasarium");
            }
            else
                Console.WriteLine("it is not Diasarium");*/

            //primr no 
            int  sum = 0;
            int count;
            for (int i = 1; i <= 10; i++)
            {
                count = 0;
                for (int j = 2; j <= i /2 ; j++)
                {
                    if (i% j == 0)
                    {
                        count++;
                        break;
                    }
                }  
                if (count == 0 && i !=1)
                    {
                        sum = sum + i;
                    }
                        
                               
            }
            Console.WriteLine("sum of Prime no between 1 to 10 is equal="+sum);

        }
    }
}
