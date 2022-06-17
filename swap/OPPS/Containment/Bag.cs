using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Containment
{
    class Bag
    {
        string colour;
        string brandname;
        int price;
        Pen P;
        Bag(string colour, string brandname, int price, Pen P)
        {
            this.colour = colour;
            this.brandname = brandname;
            this.price = price;
            this.P = P;
        }
        public void showBag()
        {
            Console.WriteLine(colour + "" + brandname + "" + price);

        }
        static void Main(string[] args)
        {
            Bag b1 = new Bag("blue", "Wildcraft", 1200, new Pen("lexi", "black", new Nib("metal")));
            b1.showBag();
        }
    }

    class Pen
    {
        string name;
        string colour;
        Nib N;
       public  Pen(string name, string colour, Nib N)
        {
            this.name = name;
            this.colour = colour;
            this.N = N;
        }
        public void showPen()
        {
            Console.WriteLine(name + "" + colour);
        }
    }
    class Nib
    {
        string type;
       public  Nib(string type)
        {
            this.type = type;

        }
        public void showNib()
        {
            Console.WriteLine(type);
        }
    }
}
