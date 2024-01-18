using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Class7 : Class6
    {
        int num3;

        public Class7(int num1, int num2, int num3) : base(num1, num2)
        {
            this.num3 = num3;
            Console.WriteLine("Constructor of class3");
        }

        public void Display3()
        {
            base.Display2();
            Console.WriteLine($"Num3 : {num3}");
        }
    }
}
