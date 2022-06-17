using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Containment
{
    class Car
    {
        int modelno;
        string name;
        double price;
        string engine;
        public int Modelno
        {
            set { modelno = value; }
            get { return modelno; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Engine
        {
            set { engine = value; }
            get { return engine; }
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Engine = "Petrol";
            c.Modelno = 111;
            c.Name = "Mercedes";
            c.Price = 12345000;
            Console.WriteLine(c.Price+c.Modelno+c.Engine+c.Name);
        }
    }
}
