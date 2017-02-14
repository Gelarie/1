using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Edge
    {
        Point First;
        Point Second;
        double lenght;

        public Edge(Point pointfirst, Point pointsecond) //Конструктор 
        {
            First = pointfirst;
            Second = pointsecond;
            CaculateEdgeLenght();
        }
        public double CaculateEdgeLenght() //Метод 
        {
            return lenght = Math.Sqrt(Math.Pow((Second.X - First.X), 2) + Math.Pow((Second.Y - First.Y), 2));
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
        }
    }
}
