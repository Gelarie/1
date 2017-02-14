using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Triangle
    {
        Edge One;
        Edge Two;
        Edge Three;

        public Triangle(Point pointfirst, Point pointsecond, Point pointthird)
        {
            One = new Edge (pointfirst, pointsecond);
            Two = new Edge (pointsecond, pointthird);
            Three = new Edge (pointfirst, pointthird);
            GetPerimeter();
            GetArea();
        }

        public double GetPerimeter()
        {

        }

        public double GetArea()
        {

        }
    }
}
