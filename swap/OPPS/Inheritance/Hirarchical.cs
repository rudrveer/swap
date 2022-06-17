using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Inheritance
{
  class Mobile
    {
        int price;
        string name;
        public void display()
        {
            Console.WriteLine("this is mobile");
        }
        
    }
    class Samsung : Mobile
    {
        int price = 20000;
        string name = "Samsung";

    }
    class Moto : Mobile
    {
        int price = 12000;
    }
    class Redmi : Mobile
    {
        int price = 20000;
        string name = "redmi";
    }
    class Apple : Mobile
    {
        int price = 60000;
        string name = "apple";
    }
    class Hirar
    {
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.display();
            Apple a = new Apple();
            a.display();
        }
    }


}







