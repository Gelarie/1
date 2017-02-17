using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] trianglemass = Reader.Read("Data.txt");
            Console.WriteLine("Средний периметр треугольников " + Average.Perimeter(trianglemass));
            Console.WriteLine("Средняя площадь " + Average.Area(trianglemass));

        }
    }
}
