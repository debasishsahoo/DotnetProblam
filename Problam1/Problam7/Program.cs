using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam7
{

//    Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a parameter, a destructor that assigns the name to empty and overwrites the ToString () method.

//End the program by reading the people and executing the ToString() method on screen.
    internal class Program
    {
        public static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }

        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }

            ~Person()
            {
                Name = string.Empty;
            }
        }
    }
}
