using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam4
{
//    Complete the project named "Shapes" (january 8th), adding a class named "Square" to it.For each square, we will store its starting X and Y coordinates (the upper left corner, already stored as a "Location") and the length of its side.

//You will have to create:
//- A suitable constructor, to assign starting values to X, Y and the side. (2 points)
//- A Move method, to change X and Y coordinates. (1 point)
//- A Scale method, to change its side(for example, a scale factor of 2 would turn a side of 3 into 6). (1 point)
//- A method ToString, to return a string with its data(for example: "Corner (10,5), side 7". (1 point)
//- Redefine "GetPerimeter" and "GetArea", so that they return the correct values(2 points).

//- Another point corresponds to the attributes and the overall structure.

//- The remaining 2 points correspond to the test from "Main"
    class TestVehicles
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Drive();

            Sportscar mySportsCar = new Sportscar();
            mySportsCar.Drive();

            Van myVan = new Van();
            myVan.Drive();

            Minivan myMiniVan = new Minivan();
            myMiniVan.Drive();

            ExcursionVan myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();

            Console.ReadKey();
        }
    }
}
