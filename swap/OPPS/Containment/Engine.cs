using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Containment
{
    class Engine
    {
        string petrol;
        string disel;
        public string  Petrol
        {
            set { petrol = value; }
            get { return petrol; }
        }
        public string Disel
        {
            set { disel = value; }
            get { return disel; }
        }
       
    }
    class Cardetails
    {
        int price;
        int modelno;
        string name;
        Engine eig;

        public int Price
        {
            get;
            set;
        }
        public int Modelno
        {
            get;
            set;
        }
        public  string Name
        {
            get;
            set;
        }
        public Engine Eig
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Cardetails c1 = new Cardetails();
            c1.Price = 800000;
            c1.Modelno = 321;
            c1.Name = "Maruti Suzuki Swift";
            c1.Eig = new Engine();
            c1.Eig.Petrol = "petrol";
            c1.Eig.Disel = "disel";
            Console.WriteLine(c1.Name);
            Console.WriteLine(c1.Price);
            Console.WriteLine(c1.Modelno);
            Console.WriteLine(c1.Eig.Disel);
            Console.WriteLine(c1.Eig.Petrol);
        }

    }



}
