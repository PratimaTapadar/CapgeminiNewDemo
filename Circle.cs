using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle : IShape
    {
        float radius;
        const float pie = 3.14f;
        float area;
        public void CalculateArea()
        {
            area = pie * radius * radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Area of a circle is {area}");
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter radius");
            radius = Convert.ToSingle(Console.ReadLine());
        }
    }
}
