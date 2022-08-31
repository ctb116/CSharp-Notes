using System;

class Program
{
  static void Main()
  {
    // STRINGS
    Console.WriteLine("Hello World");

    string name = "Peggy"; 
    Console.WriteLine("Hello, " + name);
    // can use "var" for variables but we choose not to for now.
    // because we are enforcing strongly typed language

    // Just like with JS, C# has built in methods for every datatype

    name.ToUpper();
    Console.WriteLine(name);

    int age = 45;
    age.ToString();
    Console.WriteLine("This is the age " + age);

    Console.ReadLine();

    var userAge = Console.ReadLine();
    
    Console.WriteLine("What is your age?");
    int userInputAge = Int32.Parse(Console.ReadLine());
    int newAge = userInputAge + 10;
    Console.WriteLine("I added 10 years to your age: " + newAge);

    //demo C# datatypes
  }
}