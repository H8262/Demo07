using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt");
            outputFile.WriteLine(Console.ReadLine());
            outputFile.Close();
            string text = System.IO.File.ReadAllText("test.txt");
            System.Console.WriteLine("File contains: " + text);
        }
    }
}
