using System;

// Define a class called Person
class Person
{
    // Declare two properties: name and age
    public string name;
    public int age;

    // Define a constructor that takes two parameters
    public Person(string name, int age)
    {
        // Assign the parameters to the properties
        this.name = name;
        this.age = age;
    }

    // Define a method called Greet that prints a greeting message
    public void Greet()
    {
        Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create two objects of the Person class
        Person alice = new Person("Alice", 25);
        Person bob = new Person("Bob", 30);

        // Call the Greet method on each object
        alice.Greet();
        bob.Greet();
    }
}
