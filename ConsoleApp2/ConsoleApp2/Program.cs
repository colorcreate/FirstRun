using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nama = new List<string>();

            nama.Add("kukuh");
            nama.Add("erwan");
            nama.Add("galih");

            foreach (var a in nama)
                Console.WriteLine(a);Console.ReadLine();

            nama.Sort();

            foreach(var a in nama)
                Console.WriteLine(a); Console.ReadLine();

        }
    }
}
