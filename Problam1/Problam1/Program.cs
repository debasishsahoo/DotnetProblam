using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam1
{
//    Create a new project, and include in it the class Person that you just created.

//Create a class "Student" and another class "Teacher", both descendants of "Person".

//The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class."

//The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". Also, it will have a private attribute "subject", a string.

//The class Person must have a method "SetAge (int n)" which will indicate the value of their age(eg, 20 years old).

//The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).

//You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
//Create a Person and make it say hello
//Create a student, set his age to 21, tell him to Greet and display his age
//Create a teacher, 30 years old, ask him to say hello and then explain.

     class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            bool debug = false;

            //Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();

  /*Create a student, set his age to 21, tell him to Greet and display his age*/
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

 /*Create a teacher, 30 years old, *ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)
                Console.ReadLine();

            Console.ReadKey();
        }
    }
}
