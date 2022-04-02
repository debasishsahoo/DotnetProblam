using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam10
{
    //2.Create the classes required to store data regarding different types of Courses.All courses have name, duration and course fee. Some courses are part time where you have to store the timing for course.Some courses are onsite where you have to store the company name and the no.of candidates for the course. For onsite course we charge 10% more on the course fee.For part-time course, we offer 10% discount.
    //Provide constructors and the following methods.

    //Print()
    //GetTotalFee()
    abstract class Course
    {
        protected string name;
        protected int duration;
        protected int coursefee;

        public Course(string name, int duration, int coursefee)
        {
            this.name = name;
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(duration);
            Console.WriteLine(coursefee);
        }

        public abstract int GetTotalFee();
    }

    class ParttimeCourse : Course
    {
        private string timings;

        public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name, duration, coursefee)
        {
            this.timings = timings;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 0.90); // 10% discount 
        }

    }

    class OnsiteCourse : Course
    {
        private string company;
        private int nostud;

        public OnsiteCourse(string name, int duration, int coursefee, string company, int nostud)
            : base(name, duration, coursefee)
        {
            this.company = company;
            this.nostud = nostud;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(nostud);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);  // 10% more
        }

    }

    class TestCourse
    {

        public static void Main()
        {
            Course c = new OnsiteCourse("ASP.NET", 30, 5000, "ABC Tech", 10);
            c.Print();
            Console.WriteLine(c.GetTotalFee());

            c = new ParttimeCourse("C#", 30, 3000, "7-8pm");
            c.Print();
            Console.WriteLine(c.GetTotalFee());
        }


    }
}
