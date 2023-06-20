using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal class Rectangle : Shape
    {
        double Width;
        double Height;

        public Rectangle() { }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;

            Console.WriteLine($"the Area of rectangle is:{GetArea()}");
            Console.WriteLine($"the Area of Perimeter is:{GetPerimeter()}");
        }

        public override double GetArea()
        {
            return (Width * Height);
        }

        public override double GetPerimeter()
        {
            return (Height + Width)*2;
        }


    }
}
