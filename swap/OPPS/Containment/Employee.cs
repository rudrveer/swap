using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.OPPS.Containment
{
    class Employee
    {
        int id;
        string name;
        double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        static void Main(string[] args)
        {

            Employee e = new Employee();

            e.Salary = 124000;
            e.Name = "Rudraveer";
            e.Id = 103;
            Console.WriteLine(" Name is :"+e.Name);
            Console.WriteLine("Salary is :"+e.Salary);
            Console.WriteLine("Id is :"+e.Id);
















        }

       
    }
}
