using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square: IShape
    {
        float side;
        float area;
        public void CalculateArea()
        {
            area = side * side;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Area of square : {area}");
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter side");
            side = Convert.ToSingle(Console.ReadLine());
        }
    }
}
