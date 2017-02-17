using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Triangle
    {
        //public readonly Point First;
      //  public readonly Point Second;
        public readonly Edge One;
        public readonly Edge Two;
        public readonly Edge Three;
        double perimeter;
        double area;

        public Triangle(Point pointfirst, Point pointsecond, Point pointthird)
        {
            One = new Edge(pointfirst, pointsecond);
            Two = new Edge(pointsecond, pointthird);
            Three = new Edge(pointfirst, pointthird);
            perimeter = GetPerimeter;
            area = GetArea;
            Console.WriteLine("Координаты: X (" + pointfirst.X + " " + pointfirst.Y + ") Y (" + pointsecond.X + " " + pointsecond.Y + ") Z (" + pointthird.X + " " + pointthird.Y + ")");
        }

        public double GetPerimeter
        {
            get
            {
                //perimeter = One.Lenght + Two.Lenght + Three.Lenght;
                //Console.WriteLine("Периметр одного треугольника" + perimeter);
                return  One.Lenght + Two.Lenght + Three.Lenght;
                
              
            }
        }

        public double GetArea
        {
            get
            {
                double p = perimeter / 2;
               // area = (p * (p - One.Lenght) * (p - Two.Lenght) * (p - Three.Lenght));
              //  Console.WriteLine("Площадь одного треугольника " + area);
                return (p * (p - One.Lenght) * (p - Two.Lenght) * (p - Three.Lenght));
            }
        }
        public bool Inseption() // в конструктор
        {
            return ((One.Lenght + Two.Lenght > Three.Lenght) && (One.Lenght + Three.Lenght > Two.Lenght) && (Two.Lenght + Three.Lenght > One.Lenght));
               
        }
        public bool Right
        {
            get
            {
                return (Math.Pow(One.Lenght, 2) + (Math.Pow(Two.Lenght, 2)) == Math.Pow(Three.Lenght, 2)) ||
                (Math.Pow(One.Lenght, 2) + (Math.Pow(Three.Lenght, 2)) == Math.Pow(Two.Lenght, 2)) ||
                (Math.Pow(Two.Lenght, 2) + (Math.Pow(Three.Lenght, 2)) == Math.Pow(One.Lenght, 2));
            }
        }
        public bool Isosceles
        {
            get
            {
                return ((One.Lenght == Two.Lenght) || (Two.Lenght == Three.Lenght) || (One.Lenght == Three.Lenght));
            }
        }
    }
}
