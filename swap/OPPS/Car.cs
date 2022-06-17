using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class Car
    {
        public int modelno;
        public string carname;
       public string carcolour;
        public long prize;
        public void Input1()
        {           
            modelno = 113;
            carname = "BMW";
            carcolour = " blue";
            prize = 2000000;
        }
        public void Input2()
        {
            modelno = 114;
            carname = "scorpio";
            carcolour = " White";
            prize = 1800000;
        }
        public void Input3()
        {
            modelno = 115;
            carname = "Maruti Suzuki";
            carcolour = " Black";
            prize = 1800000;

        }



          /*  modelno = int.Parse(Console.ReadLine());
            carname = Convert.ToString(Console.ReadLine());
            carcolour = Convert.ToString(Console.ReadLine());
            prize = long.Parse(Console.ReadLine());*/
        public void Display()
        {
            Console.WriteLine(modelno +"  "+carname+" "+carcolour+" "+prize);
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            Car c3 = new Car();

            c1.Input1();
            c1.Display();
            c2.Input2();
            c2.Display();
            c3.Input3();
            c3.Display();




        }

    }
}
