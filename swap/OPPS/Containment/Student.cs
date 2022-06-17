using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Containment
{
    class Student
    {
       private int id;
        string name;
        float percentage;
        

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public float Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
       class Encapsulation
        {
            static void Main(string[] args)
            {

                Student s = new Student();
                s.Id = 1002;
                s.Name = "Allu Arjun";
                Console.WriteLine("Name is :" + s.Name);
                Console.WriteLine("studnet id is :" + s.Id);
                s.Percentage = int.Parse(Console.ReadLine());

                if (s.Percentage >= 35)
                {
                    Console.WriteLine("Placed");
                }
                else
                {
                    Console.WriteLine("not Placed");
                }

            }
        }
        




    }
}
