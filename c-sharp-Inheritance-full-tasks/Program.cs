﻿using c_sharp_Inheritance_full_tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("_____________________________");
        Dog dog = new Dog();
        dog.MakeNoise();
        dog.Eat();
        Console.WriteLine("_____________________________");
        Cat cat = new Cat();
        cat.MakeNoise(); 
        cat.Eat();
        Console.WriteLine("_____________________________");
        Rectangle r = new Rectangle(2.4,3.5);
        Console.WriteLine("_____________________________");
        Circle c=new Circle(2.3);
        Console.WriteLine("_____________________________");
        Employee e = new Employee();
        Console.WriteLine($"The pay for Employee is {e.CalculatePay(6)}");
    }
}