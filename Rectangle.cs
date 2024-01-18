using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : IShape
    {
        float l, b, area;
        public void GetDetails()
        {
            Console.WriteLine("Enter Length");
            l = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            b = Convert.ToSingle(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Area of Rectangel {area}");
        }

        public void CalculateArea()
        {
            area = l * b;
        }
    }
}
