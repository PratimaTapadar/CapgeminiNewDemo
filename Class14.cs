using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Class14
    {
        FileStream fss;
        string s;
        public Class14()
        {
            GetDetails();
            fss = new FileStream($"C:\\Users\\ptapadar\\Desktop\\.NET\\day8\\ConsoleApp1\\{s}.cs", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter the file name:");
            s = Console.ReadLine();
        }
        
        public void DisplayDetails()
        {
            StreamReader sr = new StreamReader(fss);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string result = sr.ReadToEnd();
            Console.WriteLine($"{result}");
        }
    }
}
