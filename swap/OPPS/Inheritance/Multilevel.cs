using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Inheritance
{
  /*  class Car
    {
        int Price;
        string name;
        string colour;
        public void display()
        {
            Console.WriteLine("this is big car");
        }
    }
    class Maruti:Car
    {
        public int price = 300000;
       public  string colour = "white";
    }
    class Suzuki:Maruti
    {
        string name = "suzuki swift";
        public void show()
        {
            Console.WriteLine(name+""+price+""+colour);
        }

    }*/
  class Person
    {
        public string name = "Rudra";

    }
    class Employee : Person
    {
        public int id = 103;
        public string department = "accounts";

    }
    class Manager : Employee
    {
        public int salary = 60000;
        public void Show()
        {
            Console.WriteLine(id+""+department+""+salary);
        }
    }
    class Multilevel
    {
        static void Main(string[] args)
        {
            // Suzuki s1 = new Suzuki();
            //s1.show();
            //s1.display();
            Manager m = new Manager();
            m.Show();


        }
       
        
    }
}
