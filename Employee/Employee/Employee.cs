using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee : IComparable<Employee>
    {
        private string _name;
        private decimal _salary;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!value.Equals(""))
                {
                    _name = value;
                }
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Salary is out of range. Salary must be more then 0");
                }
            }
        }

        private Employee() { }

        public Employee(string newName, decimal newSalary)
        {
            _name = newName;
            if (newSalary > 0)
            {
                _salary = newSalary;
            }
        }

        public void Write()
        {
            Console.WriteLine("Name: " + _name + ", Salary: " + _salary);
        }

        public int CompareTo(Employee compareEmp)
        {
            if (compareEmp == null)
            {
                return 1;
            }
            return _salary.CompareTo(compareEmp._salary); 
        }
    }

    class EpmComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Name == null && y.Name == null) return 0;
            else if (x.Name == null) return -1;
            else if (y.Name == null) return 1;
            else return x.Name.CompareTo(y.Name);
        }
    }
}
