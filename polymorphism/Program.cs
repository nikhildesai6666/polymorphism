using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double basicsalary, hra, da, pf, netpaid;
        private static int count;
        public Employee(string name, double basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;
        }
        public virtual void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary) - pf;
        }
        public static string TotalCount()
        {
            return $"Total count is {count}";
        }
        public override string ToString()
        {
            return $"Employee details -->Id :{id} Name :{name} Salary {netpaid}";
        }
    }

    public class Manager : Employee
    {
        private double ta;
        public Manager(string name, double bs, double ta) : base(name, bs) 
        {
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ta) - pf;
        }
        public override string ToString()
        {
            return $"Manager details -->Id :{id} Name :{name} Salary {netpaid}";
        }
    }
    public class Precident : Employee
    {
        private double bonas;
        public Precident(string name, double bs,double bonus) : base(name,bs)
        {
            this.bonas = bonus;
        }
        public override void CalculateSalary()
        {
               hra = basicsalary * 0.40;
               da = basicsalary * 0.20;
               pf = basicsalary * 0.12;
               netpaid = (hra + da + basicsalary + bonas) - pf;
        }
        public override string ToString()
        {
            return $"Precident details ---> Id : {id} Name : {name} Salary : {netpaid}"; 

        }

        
    }
    public class SalesManager : Employee
    {
        private double insurance;
        public SalesManager(string name, double bs, double bonus) : base(name, bs)
        {
            this.insurance = insurance;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + insurance) - pf;
        }
        public override string ToString()
        {
            return $"Precident details ---> Id : {id} Name : {name} Salary : {netpaid}";

        }



    }
