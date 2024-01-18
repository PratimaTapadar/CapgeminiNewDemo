using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
    internal class Class12 : Class11
    {
        //shadowing
        public new void Display()
        {
            Console.WriteLine("Shadowing functions");
        }
    }
}
