using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
   
    internal class Child : Parent1
    {
        int num2;

        public Child()
        {
            num2 = 30;
            Console.WriteLine("Constructor of Child");
        }

        public void Function2()
        {
            base.Function1();
            Console.WriteLine($"Num : {num} Name : {name} Num2 : {num2}");
            Console.WriteLine("Function2 of Child");
        }
    }
}
