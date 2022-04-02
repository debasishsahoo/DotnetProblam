using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam3
{
    class ColoredCircle : Circle
    {
        protected int color;
        public ColoredCircle()
        {

        }
        public ColoredCircle(double dX, double dY, double dRadius, int color)
        {
            this.dX = dX;
            this.dY = dY;
            this.dRadius = dRadius;
            this.color = color;
        }

        public void Move()
        {

        }

        public void Scale()
        {

        }

        public string ToString()
        {
            return "";
        }

        public int GetColor()
        {
            return 0;
        }

        public void SetColor(int newColor)
        {
            color = newColor;
        }

        public override double Area()
        {
            return 0;
        }
        public override double Perimeter()
        {
            return 0;
        }
    }
}
