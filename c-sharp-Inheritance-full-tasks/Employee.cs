using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_sharp_Inheritance_full_tasks
{
    /*
    Problem 3: Create a base class called Employee with the following properties:
    Name
    Salary
    Department
Create two derived classes called Manager and Secretary 
    that inherit from the Employee class. The Manager class
    should have a property for the number of employees they 
    manage, and the Secretary class should have a property for 
    the number of hours they work per week.
Create a method called CalculatePay() in the Employee class
    that calculates the pay for an employee.The Manager class 
    should override the CalculatePay() method to calculate the
    pay for a manager, and the Secretary class should override 
    the CalculatePay() method to calculate the pay for a secretary
Write a program that creates an instance of each derived class
    and calls the CalculatePay() method on each instance.
    */
    internal class Employee
    {
        public string Name;
        public double Salary;
        public string Department;
        public Employee() { }
        public Employee(string Name,double Salary,string Department) 
        { 
            this.Name = Name;
            this.Salary = Salary;
            this.Department = Department;
        }

        public virtual double CalculatePay(double NumberOfHours)
        {
            return NumberOfHours * 50;
        }
    }
}
