using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal class Manager:Employee
    {
        int NumberOfEmployees;
        public Manager() { }
        public Manager(string Name, double Salary, string Department, int NumberOfEmployees):base( Name,  Salary,  Department) 
        {
            this.NumberOfEmployees = NumberOfEmployees;
        }
        public override double CalculatePay(double NumberOfHours)
        {
            return NumberOfHours * 100;
        }
    }
}
