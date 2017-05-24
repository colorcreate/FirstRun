using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nama = new List<String>();
            nama.Add("kukuh");
            nama.Add("kukuh");
            nama.Add("erwan");
            nama.Add("galih");
            nama.Add("wahyu");

            foreach (var a in nama)
                Console.WriteLine(a);


            HashSet<int> evenNumber = new HashSet<int>();
            evenNumber.Add(0);
            evenNumber.Add(2);
            evenNumber.Add(4);
            evenNumber.Add(6);
            evenNumber.Add(8);
            evenNumber.Add(10);


            foreach (var number in evenNumber)
                Console.WriteLine(number);
        }
    }
}
