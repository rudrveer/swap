using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Character");
            char ah = Console.ReadLine()[0];

            switch (ah)
            {
              /* case 'A': Console.WriteLine("make everyone happy");
                    break;
                case 'B': Console.WriteLine("lot of love");
                    break;
                case 'C': Console.WriteLine("it is thired alphabet");
                    break;
                default: Console.WriteLine("it is no an aplhabet");
                    break;*/

                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("it is an wovel");
                    break;
                default: Console.WriteLine("it is a consonant");
                    break;


            }
            

                    

                   
               
            

            




        }
    }
}
