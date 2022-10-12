using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Class1
    {
        static void Main(string[]args)
        {
            Employee e1 = new Employee("Nikhil", 60000);
            e1.CalculateSalary();
            Console.WriteLine(e1);

            Manager m1 = new Manager("Nikhil", 60000, 1500);
            m1.CalculateSalary();
            Console.WriteLine(m1);

            Precident p1 = new Precident("Nikhil", 60000, 4521);
            p1.CalculateSalary();
            Console.WriteLine(p1);

            SalesManager s1 = new SalesManager("Nikhil", 60000, 8976);
            s1.CalculateSalary();
            Console.WriteLine(s1);
            
            


        }
    }
}
