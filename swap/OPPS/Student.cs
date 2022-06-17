using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS
{
    class Student
    {
        public int id;
        public string name;
        public int m1, m2, m3;
        int per;

        public void AcceptDetail(int sid,string sname,int sub1,int sub2,int sub3)
        {
            id = sid;
            name = sname;
            m1 = sub1;
            m2 = sub2;
            m3 = sub3;
        }
        public void Calculate()
        {
            per = (m1 + m2 + m3) / 3;
        }
        void Display()
        {
            
            Console.WriteLine(id +"    "+name+"    "+m1+"  "+m2+"   "+m3+"   "+per);
        }
        static void Main(string[] args)
        {
            Student rudra = new Student();
            rudra.AcceptDetail(12, "Rudraveer", 65, 66, 70);
            rudra.Calculate();
            rudra.Display();

        }









    }
}
