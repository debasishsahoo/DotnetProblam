using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam9
{

    //1. Create a class to store details of student like rollno, name, course joined and fee paid so far.Assume courses are C# and ASP.NET with course fees being 2000 and 3000.

    //Provide the a constructor to take rollno, name and course.
    //Provide the following methods:

    //Payment(amount)
    //Print()
    //DueAmount property
    //TotalFee property

    //Add a static member to store Service Tax, which is set to 12.3%. Also allow a property through which we can set and get service tax.

    //Modify TotalFee and DueAmount properties to consider service tax.


    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
        private static double servicetax = 12.3;

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "c#" ? 2000 : 3000;
                // service tax
                total = total + total * servicetax / 100;
                return (int)total;
            }
        }

        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
    }

    class UseStudent
    {

        public static void Main()
        {

            Student s = new Student(1, "ABC", "c#");
            s.Payment(1000);
            s.Print();
            Console.WriteLine(s.DueAmount);


        }
    }
}
