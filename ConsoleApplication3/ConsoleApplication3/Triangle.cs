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
        double perimeter;
        double area;

        public Triangle(Point pointfirst, Point pointsecond, Point pointthird)
        {
            One = new Edge(pointfirst, pointsecond);
            Two = new Edge(pointsecond, pointthird);
            Three = new Edge(pointfirst, pointthird);
            perimeter = GetPerimeter;
            area = GetArea;
        }

        public double GetPerimeter
        {
            get
            {
                perimeter = One.Lenght + Two.Lenght + Three.Lenght;
                //Console.WriteLine(One.Lenght + " + " + Two.Lenght  + " + " + Three.Lenght);
                Console.WriteLine("Периметр одного треугольника" + perimeter);
                return perimeter = One.Lenght + Two.Lenght + Three.Lenght;
              
            }
        }

        public double GetArea
        {
            get
            {
                double p = perimeter / 2;
                area = (p * (p - One.Lenght) * (p - Two.Lenght) * (p - Three.Lenght));
                Console.WriteLine("Площадь одного треугольника " + area);
                return area = (p * (p - One.Lenght) * (p - Two.Lenght) * (p - Three.Lenght));
            }
        }
        public bool Inseption()
        {
            return ((One.Lenght + Two.Lenght > Three.Lenght) && (One.Lenght + Three.Lenght > Two.Lenght) && (Two.Lenght + Three.Lenght > One.Lenght));
               
        }
        public bool Right()
        {
            return (Math.Pow(One.Lenght, 2) + (Math.Pow(Two.Lenght, 2)) == Math.Pow(Three.Lenght, 2)) ||
          (Math.Pow(One.Lenght, 2) + (Math.Pow(Three.Lenght, 2)) == Math.Pow(Two.Lenght, 2)) ||
            (Math.Pow(Two.Lenght, 2) + (Math.Pow(Three.Lenght, 2)) == Math.Pow(One.Lenght, 2));
            
        }
        public bool Isosceles()
        {
            return ((One.Lenght == Two.Lenght) || (Two.Lenght == Three.Lenght) || (One.Lenght == Three.Lenght));
        }
    }
}
