using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total = 0;

            // looping
            while (true)
            {
                // keluarkan pertanyaan
                Console.WriteLine("Berapa lama Anda berolahraga");

                // minta input dari user
                input = Console.ReadLine();

                // menambahkan inputnya
                total += Int32.Parse(input);

                // keluar bila user masukin "quit"
                if (input == "quit")
                {
                    break;
                }

                // mengeluarkan inputnya
                Console.WriteLine("Selamat, Anda sudah " + input + " menit berolahraga");

            }
            

            


        }
    }
}
