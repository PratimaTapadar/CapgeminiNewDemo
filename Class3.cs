using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class Class3 : Interface3, Interface4
    {
        void Interface3.Display()
        {
            Console.WriteLine("Interface 3 display");
        }

        void Interface4.Display()
        {
            Console.WriteLine("Interface 4 display");
        }
    }
}
