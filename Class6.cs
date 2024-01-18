using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class Class6 : Class4
    {
        int num2;

        public Class6(int num1, int num2) : base(num1)
        {
            this.num2 = num2;
            Console.WriteLine("Constructor of class2");
        }

        public void Display2()
        {
            base.Display();
            Console.WriteLine($"Num2 : {num2}");
        }
    }
}
