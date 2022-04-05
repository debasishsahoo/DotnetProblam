using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    //Create a class to store day, month and year. Ensure objects of this class are comparable.
    class Date : IComparable
    {
        private int day, month, year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int CompareTo(Date other)
        {
            if (this.year - other.year != 0)
                return this.year - other.year;

            if (this.month - other.month != 0)
                return this.month - other.month;

            return this.day - other.day;
        }

        
    }

    class TestDate
    {

        public static void Main()
        {
            Date d1 = new Date(10, 2, 2011);
            Date d2 = new Date(20, 1, 2011);

            Console.WriteLine(d1.CompareTo(d2));
        }
    }
}
