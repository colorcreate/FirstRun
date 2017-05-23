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
                try
                {
                    // keluarkan pertanyaan
                    Console.WriteLine("Berapa lama Anda berolahraga");

                    // minta input dari user
                    input = Console.ReadLine();

                    // keluar bila user masukin "quit"
                    if (input.ToLower() == "quit") //QUit/quiT/quIt  --> quit
                    {
                        break;
                    }

                    // menambahkan inputnya
                    total += Int32.Parse(input);

                    if (Int32.Parse(input)<0)
                    {
                        Console.WriteLine("masukin di atas 0");
                        continue;
                    }


                    // mengeluarkan inputnya
                    Console.WriteLine("Selamat, Anda sudah " + total + " menit berolahraga");
                }

                catch(Exception)
                {
                    //jika input aneh
                                        
                    Console.WriteLine("masukkin yang bener");
                    continue;
                    
                }
                
                

            }
            

            


        }
    }
}
