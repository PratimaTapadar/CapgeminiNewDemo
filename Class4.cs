using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        int num1;

        public Class4(int num1)
        {
            this.num1 = num1;
            Console.WriteLine("Constructor of class1");
        }

        public void Display()
        {
            Console.WriteLine($"Num1 : {num1}");
        }
    }
}
