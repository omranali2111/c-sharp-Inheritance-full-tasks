using c_sharp_Inheritance_full_tasks;

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
    }
}