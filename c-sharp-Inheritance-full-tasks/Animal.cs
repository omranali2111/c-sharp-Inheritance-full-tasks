using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Inheritance_full_tasks
{
    internal abstract class Animal
    {
        /*
        Problem 1: Create a base class called Animal with the following methods:
        MakeNoise()
        Eat()
        Create a derived class called Dog that inherits from the 
        Animal class and overrides the MakeNoise() method to print 
        "Woof!" and the Eat() method to print "I eat dog food.
        Create a derived class called Cat that inherits from the 
        Animal class and overrides the MakeNoise() method to
        print "Meow!" and the Eat() method to print "I eat cat food.
        Write a program that creates an instance of each derived 
        class and calls the MakeNoise() and Eat() methods on each instance.
        */

        public Animal() { }

        public abstract void MakeNoise();


        public abstract void Eat();

    }
}
