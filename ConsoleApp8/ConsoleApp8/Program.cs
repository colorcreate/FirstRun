using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<String> nama = new List<string> { "aaa", "bbb", "ccc" };

            List<Bird> bird = new List<Bird>()
            {
                new Bird { Name = "Beo", Color = "red", Sightings = 1 },
                new Bird { Name = "Merpati", Color = "white", Sightings = 1 },
                new Bird { Name = "kakaktua", Color = "black", Sightings = 2 },
                new Bird { Name = "kukabura", Color = "white", Sightings = 3 },
            };

            //foreach (var burung in bird)
            //    Console.WriteLine(burung.Name);
            ////burung yang sightings>1 diurutkan berdasarkan warna descending menggunakan query syntax
            //var output = from burung in bird where burung.Sightings > 1 orderby burung.Color descending select burung;
            //foreach (var burung in output)
            //    Console.WriteLine("Hasilnya: " + burung.Name + " punya warna " + burung.Color);

            ////burung yang sightings>1 diurutkan berdasarkan warna descending menggunakan method syntax
            //var output2 = bird.Where(burung => burung.Sightings > 1).OrderByDescending(burung => burung.Color);  
            //foreach(var burung in output2)
            //    Console.WriteLine("Hasilnya: " + burung.Name + " punya warna " + burung.Color);

            //burung diurutkan berdasarkan warna dilanjutkan berdasarkan nama menggunakan method syntax
            var output3 = bird.OrderBy(burung => burung.Color).ThenBy(burung => burung.Name);
            foreach (var burung in output3)
                Console.WriteLine("Hasilnya: " + burung.Name + " punya warna " + burung.Color);

            //cek apakah ada burung di bird yang bernama "Beo" (boolean)
            Console.WriteLine(bird.Any(burung => burung.Name == "Beo"));

            //cek apakah object sparrow di bird (boolean)
            var sparrow = new Bird { Name = "sparrow", Color = "black", Sightings = 4 };
            Console.WriteLine(bird.Contains(sparrow));

            //cek apakah semua burung bernama "Beo" (boolean)
            Console.WriteLine(bird.All(burung => burung.Name == "Beo"));

            //
            Console.WriteLine(bird.First(burung => burung.Color == "white").Name);

            //di urutin berdasarkan sighting, skip 1, diambil 2 dari atas
            Console.WriteLine(".................................");
            var output4 = bird.OrderBy(burung => burung.Sightings).Skip(1).Take(2);
            foreach (var burung in output4)
                Console.WriteLine(burung.Name + " " + burung.Sightings);

            //diurutin mundur berdasarkan sightings, ambil yang sightings>1
            Console.WriteLine(".................................");
            var output5 = bird.OrderByDescending(burung => burung.Sightings).TakeWhile(burung => burung.Sightings > 1);
            foreach (var burung in output5)
                Console.WriteLine(burung.Name + " " + burung.Sightings);


        }
    }
}