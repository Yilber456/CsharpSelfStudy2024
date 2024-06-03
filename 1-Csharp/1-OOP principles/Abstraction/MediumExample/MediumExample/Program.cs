using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double area = circle.GetArea();
            Console.WriteLine(area);

            Rectangle rectangle = new Rectangle(5,3);
             area = rectangle.GetArea();
            Console.WriteLine(area);
            var perimeter = rectangle.GetPerimeter();
            Console.WriteLine(perimeter);
        }
    }
}
