using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    /*
    Problem 2: Create a base class called Shape with the following methods:
GetArea()
GetPerimeter()
Create two derived classes called Circle and Rectangle that inherit
    from the Shape class. The Circle class should override the GetArea() 
    method to calculate the area of a circle, and the Rectangle class should 
    override the GetArea() method to calculate the area of a rectangle.The 
    Circle class should also override the GetPerimeter() method to calculate 
    the perimeter of a circle, and the Rectangle class should override the 
    GetPerimeter() method to calculate the perimeter of a rectangle.
Write a program that creates an instance of each derived class and calls
    the GetArea() and GetPerimeter() methods on each instance.
    */
    internal abstract class Shape
    {
        public Shape() { }

        public abstract double GetArea();
        public abstract double GetPerimeter();


    }
}
