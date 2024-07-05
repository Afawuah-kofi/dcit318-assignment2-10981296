// See https://aka.ms/new-console-template for more information
using System;

// Define the IMovable interface
interface IMovable
{
    void Move();
}

// Car class implementing IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class implementing IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interfaces Example");

        // Create instances of Car and Bicycle
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        // Call Move() method on each instance
        Console.WriteLine("Moving the car:");
        car.Move();

        Console.WriteLine("\nMoving the bicycle:");
        bicycle.Move();
    }
}
