using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal class Dog:Animal
    {
       public Dog() { }
        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eat()
        {

            Console.WriteLine("I eat dog food");
        }
    }
}
