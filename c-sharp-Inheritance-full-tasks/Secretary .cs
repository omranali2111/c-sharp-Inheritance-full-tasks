using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal class Secretary:Employee
    {
        int NumberOfHours;

        public Secretary(string Name,double Salary, string Department,int  NumberOfHours) : base(Name, Salary, Department)
        {
            this.NumberOfHours = NumberOfHours;
        }

        public virtual double CalculatePay(double NumberOfHours)
        {
            return NumberOfHours * 70;
        }
    }
}
