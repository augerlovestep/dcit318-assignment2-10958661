// See https://aka.ms/new-console-template for more information


using inheritance;

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
    }
}