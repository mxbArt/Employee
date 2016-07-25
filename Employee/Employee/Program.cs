using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("XXX", 2100));
            list.Add(new Employee("Andrew", 1002));
            list.Add(new Employee("Bravo", 200));
            foreach (Employee emp in list)
            {
                emp.Write();
            }
            list.Sort();
            Console.WriteLine("After sorting by salary");
            foreach (Employee emp in list)
            {
                emp.Write();
            }
            EpmComparer empComp= new EpmComparer();
            list.Sort(empComp);
            Console.WriteLine("After sorting by name:");
            foreach (Employee emp in list)
            {
                emp.Write();
            }
        }
    }
}
