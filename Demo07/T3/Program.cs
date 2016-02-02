using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            TV program = new TV();

            TV program1 = new TV { Name = "Teletapit", Channel = "Kakkonen", Start = "3:00", End = "20:00", Description = "Uudestaan" };
            TV program2 = new TV { Name = "Salapoliisiohjelma", Channel = "Perkele", Start = "1:00", End = "1:15", Description = "Paras ikinä" };
            TV program3 = new TV { Name = "Tosi-Tv", Channel = "Muijienitkukanava", Start = "6:66", End = "Ajan rakenne muuttunut", Description = "Ihana David" };

            program.AddTv(program1);
            program.AddTv(program2);
            program.AddTv(program3);

            System.IO.StreamWriter tvPrograms = new System.IO.StreamWriter("programs.txt");
           
            tvPrograms.WriteLine(program1.ToString());
            tvPrograms.WriteLine(program2.ToString());
            tvPrograms.WriteLine(program3.ToString());
            tvPrograms.Close();
            string text = System.IO.File.ReadAllText("programs.txt");
            System.Console.WriteLine("Programs: " + text);          
        }
    }
}
