using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal class Cat:Animal
    {
        public Cat() { }
        public override void MakeNoise()
        {
            Console.WriteLine("meow!");
        }

        public override void Eat()
        {

            Console.WriteLine("I eat Cat food");
        }


    }
}
