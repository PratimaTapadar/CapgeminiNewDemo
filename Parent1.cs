using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class Parent1
    {
        protected int num;
        protected string name;

        public Parent1()
        {
            Console.WriteLine("Default constructor of Parent");
            num = 10;
            name = "sa";
        }

        protected void Function1()
        {
            Console.WriteLine("Function1 of Parent");
        }
    }
}
