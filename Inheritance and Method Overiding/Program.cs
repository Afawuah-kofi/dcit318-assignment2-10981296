// See https://aka.ms/new-console-template for more information
using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance and Method Overriding Example");

        // Creating instances of each class
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        // Calling MakeSound() on each instance
        Console.WriteLine("Generic Animal sound:");
        genericAnimal.MakeSound();

        Console.WriteLine("\nDog sound:");
        dog.MakeSound();

        Console.WriteLine("\nCat sound:");
        cat.MakeSound();
    }
}
