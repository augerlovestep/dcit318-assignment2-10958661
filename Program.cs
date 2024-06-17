// See https://aka.ms/new-console-template for more information


using abstraction;
using inheritance;
using interface_demo;

public class Program
{

    public static void Main(string[] args)
    {
        Animal animal = new Animal();   
        Dog dog = new Dog();    
        Cat cat = new Cat();

        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Circle newCircle = new Circle(6.5);
        Rectangle newRectange = new Rectangle(3, 5);

        Console.WriteLine(newCircle.GetArea());
        Console.WriteLine(newRectange.GetArea());

        Car newCar = new Car();
        Bicycle bicycle = new Bicycle();

        newCar.Move();
        bicycle.Move();

    }
}