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

            Console.WriteLine(nama.IndexOf("kukuh"));

            nama.Insert(1, "wahyu");

            foreach (var a in nama)
                Console.WriteLine(a); Console.ReadLine();
        }
    }
}
