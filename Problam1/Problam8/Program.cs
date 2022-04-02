using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam8
{
//    Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. There will be two people of the Student type and one person of the Teacher type.

//To do this, create a Person class that has a Name property of type string, a constructor that receives the name as a parameter and overrides the ToString() method.

//Then create two more classes that inherit from the Person class, they will be called Student and Teacher.The Student class has a Study method that writes by console that the student is studying.The Teacher class will have an Explain method that writes to the console that the teacher is explaining.Remember to also create two constructors on the child classes that call the parent constructor of the Person class.

//End the program by reading the people(the teacher and the students) and execute the Explain and Study methods.
    internal class Program
    {
        public static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }

        public class Person
        {
            protected string Name { get; set; }

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

        public class Teacher : Person
        {
            public Teacher(string name) : base(name)
            {
                Name = name;
            }

            public void Explain()
            {
                Console.WriteLine("Explain");
            }
        }

        public class Student : Person
        {
            public Student(string name) : base(name)
            {
                Name = name;
            }

            public void Study()
            {
                Console.WriteLine("Study");
            }
        }
    }
}
