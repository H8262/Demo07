using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter integers = new System.IO.StreamWriter("integers.txt");
            System.IO.StreamWriter doubles = new System.IO.StreamWriter("doubles.txt");
            string text = null;
            int number;
            double number1;
            
            do
            {
                Console.WriteLine("Give number: ");             
                try
                {
                    text = Console.ReadLine();
                    bool integer = int.TryParse(text, out number);
                    bool tuplat = double.TryParse(text, out number1);

                    if (integer)
                    {
                        integers.WriteLine(text);
                    }
                    else if (tuplat)
                    {
                        doubles.WriteLine(text);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }
            } while (text.Length != 0);
            integers.Close();
            doubles.Close();

            string values = System.IO.File.ReadAllText("integers.txt");
            string values1 = System.IO.File.ReadAllText("doubles.txt");

            Console.WriteLine("Integers: " + values);
            Console.WriteLine("Doubles: " + values1);       
        }
    }
}
