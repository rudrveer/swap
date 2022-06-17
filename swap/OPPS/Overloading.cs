using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class Overloading
    {
        int side=12;

        void Area(int r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area Of Circle =="+area);
        }
        void Area(int length,int bredth)
        {
            int area = length * bredth;
            Console.WriteLine("Area of Rectangle =="+area);
        }
        void Area(float breadth ,int height)
        {
            double Area = (breadth * height) / 2;
            Console.WriteLine("Area of Tringle=="+Area);
        }
        void Area()
        {
            int area = side * side;
            Console.WriteLine("Area of Square=="+area);
        }
        static void Main(string[] args)
        {
            Overloading b = new Overloading();
            // area of circle
            b.Area(10);
            // area of Rectangle
            b.Area(20, 25);
            // area of trinagle
            b.Area(4.5f, 12);
            // area of square 
            b.Area();
        }




    }
}
