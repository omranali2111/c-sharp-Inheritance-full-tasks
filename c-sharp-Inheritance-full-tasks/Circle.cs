using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal class Circle:Shape
    {
        double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;

            Console.WriteLine($"the Area of circle is:{GetArea()}");
            Console.WriteLine($"the Perimeter of circle is:{GetPerimeter()}");
        }

        public override double GetArea()
        {
            return (Math.PI * Radius * Radius);
        }

        public override double GetPerimeter()
        {
            return (2* Math.PI* Radius);
        }
    }
}
