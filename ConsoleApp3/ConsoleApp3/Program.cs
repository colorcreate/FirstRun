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

            //foreach (var a in nama)
            //    Console.WriteLine(a);


            HashSet<int> evenNumber = new HashSet<int>();
            evenNumber.Add(0);
            evenNumber.Add(2);
            evenNumber.Add(4);
            evenNumber.Add(6);
            evenNumber.Add(8);
            evenNumber.Add(10);


            //foreach (var number in evenNumber)
            //    Console.WriteLine(number);

            HashSet<String> namaHash = new HashSet<String>();

            namaHash.Add("kukuh");
            namaHash.Add("galih");
            namaHash.Add("daa");
            namaHash.Add("daa");
            namaHash.Add("kukuh");

            //foreach (var name in namaHash)
            //    Console.WriteLine(name);

            //for (int i = 0; i < namaHash.Count(); i++)
            //    Console.WriteLine(namaHash.ElementAt(i));

            namaHash.Remove("daa"); //menghilangkan "daa" dari namaHash

            ///
            HashSet<String> namaHash2 = new HashSet<String>();
            namaHash2.Add("ben");
            namaHash2.Add("nila");
            namaHash2.Add("YULIUS");
            namaHash2.Add("HANI");

            namaHash.UnionWith(namaHash2); //memasukkan semua unsur namaHash2 ke namaHash

            for (int i=0; i<namaHash.Count(); i++)
            {
                if (namaHash.ElementAt(i)=="nila")
                {
                    Console.WriteLine("ada datanya");
                }
            }



            Console.WriteLine("Panjang hashset: " + namaHash.Count());

        }
    }
}
