using System;
using System.Collections.Generic;

namespace Generics
{

    class Employee 
    {
        public string mName;
        public int mSalary;

        public Employee(string name, int salary)
        {
            mName = name;
            mSalary = salary;
        }

    }


    class Program
    {
       

        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>(10);
            empList.Add(new Employee("Arne de Klerk", 50000));
            empList.Add(new Employee("Liam Middleton", 65000));
            empList.Add(new Employee("Bob Saget", 10));

            empList.ForEach(TotalSalaries);

            Console.WriteLine("empList Capacity is: {0}", empList.Capacity);
            Console.WriteLine("empList Count is: {0}", empList.Count);

            Console.ReadLine();

        }

        static int total = 0;

        static void TotalSalaries(Employee e)
        {
            total += e.mSalary;
            
        }

    }


}
