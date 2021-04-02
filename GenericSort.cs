using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSort
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }
  }

  public class GenericSort
  {
    static void Main(string[] args)
    {
      Person[] people = { new Person("Hal", 20),
		                      new Person("Susann", 31),
                          new Person("Dwight", 19),
                          new Person("Kassandra", 21),
                          new Person("Lawrence", 25),
                          new Person("Cindy", 22),
                          new Person("Cory", 27),
                          new Person("Mac", 19),
                          new Person("Romana", 27),
                          new Person("Doretha", 32),
                          new Person("Danna", 20),
                          new Person("Zara", 23),
                          new Person("Rosalyn", 26),
                          new Person("Risa", 24),
                          new Person("Benny", 28),
                          new Person("Juan", 33),
                          new Person("Natalie", 25)
                          };

      double[] numbers = { 645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25 };

      Console.WriteLine("--------------");
      Console.WriteLine("Unsorted List:");
      Console.WriteLine("--------------");
      
      foreach (Person p in people)
      {
        Console.WriteLine("{0}, {1}", p.Name, p.Age);
      }
      
      IEnumerable<Person> sortByName =
        from person in people
        orderby person.Name
        select person;
      
      Console.WriteLine("--------------");
      Console.WriteLine("Sorted by name:");
      Console.WriteLine("--------------");
      foreach (Person p in sortByName)
      {
        Console.WriteLine("{0}, {1}", p.Name, p.Age);
      }

      IEnumerable<Person> sortByAge =
        from person in people
        orderby person.Age descending, person.Name ascending
        select person;

      Console.WriteLine("--------------");
      Console.WriteLine("Sorted by age (then by name):");
      Console.WriteLine("--------------");
      foreach (Person p in sortByAge)
      {
        Console.WriteLine("{1}, {0}", p.Name, p.Age);
      }

      Console.WriteLine("--------------");
      Console.WriteLine("Unsorted Numbers:");
      Console.WriteLine("--------------");
      foreach (double n in numbers)
      {
        Console.WriteLine(n);
      }

      IEnumerable<double> sortNumbersAscending =
        from number in numbers
        orderby number
        select number;

      Console.WriteLine("--------------");
      Console.WriteLine("Sorted Numbers:");
      Console.WriteLine("--------------");
      foreach (double n in sortNumbersAscending)
      {
        Console.WriteLine(n);
      }
    }
  }
}
