using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Class13
    {
        FileStream fs;
        public Class13()
        {
            fs = new FileStream("StudentsList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            //fs = new FileStream(@"D:\day3\StudentsList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            //fs = new FileStream("D:/day3/StudentsList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            //fs = new FileStream("D:\\day3\\StudentsList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        }
        public void WriteToFile()
        {
            string str;
            Console.WriteLine("Enter a sentence");
            str = Console.ReadLine();

            StreamWriter sw = new StreamWriter(fs);

            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(str);
            sw.Flush();
            Console.WriteLine("Data is saved into the file");
        }
        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string result = sr.ReadToEnd();
            Console.WriteLine($"{result}");
        }
    }
}
