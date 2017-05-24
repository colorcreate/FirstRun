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
                new Bird { Name = "Merpati", Color = "white", Sightings = 1 }
            };

            bird.Add(new Bird { Name = "kakaktua", Color = "Black", Sightings = 2 });
        
            

            //foreach (var burung in bird)
            //{
            //    Console.WriteLine(burung.Name + " " + burung.Color + " " + burung.Sightings);
            //}

          

            var output = from burung in bird where burung.Sightings > 1 select burung.Name;

            foreach (var burung in output)
            {
                Console.WriteLine(burung);
            }

            var output2 = bird.Where(burung => burung.Sightings > 1);

            foreach (var burung in output2)
            {
                Console.WriteLine(burung.Name);
            }
        }
    }
}
