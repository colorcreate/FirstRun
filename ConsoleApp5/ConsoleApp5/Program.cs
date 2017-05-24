using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> numbersBesarDariLima = new List<int>();

            //foreach (var angka in numbers)
            //{
            //    if (angka > 5)
            //    {
            //        numbersBesarDariLima.Add(angka);
            //    }
            //}


            //numbersBesarDariLima = from angka in numbers where angka > 5 select angka;  //Query syntax

            numbersBesarDariLima = numbers.Where(n => n > 5); //method syntax


            foreach (var number in numbersBesarDariLima)
                Console.WriteLine(number);
        }
    }
}
