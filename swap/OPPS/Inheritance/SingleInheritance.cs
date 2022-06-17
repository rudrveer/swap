using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Inheritance
{


   /* class Father
    {
        string name;
        int age;
        public void display()
        {
            Console.WriteLine("father is happy");
        }
    }
    class Son:Father
    {
        public void show()
        {
            int age = 14;
            string name = "rajesh";
            Console.WriteLine(age+" "+name);
        }
    } */

    class Animal
    {
        int eye;
        public void show()
        {
            Console.WriteLine(" Animal has Large Eyes");
        }
    }
    class Elephant:Animal
    {
        int eye = 2;
        public void display()
        {
            Console.WriteLine("Animal has "+eye+"eyes");
        }

    }

    class SingleInheritance
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant();
            e.show();
            e.display();
            
            

        }
    }
}
