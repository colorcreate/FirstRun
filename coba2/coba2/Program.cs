using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfList = new List<List<List<int>>>();
            listOfList.Add(new List<List<int>>());
            listOfList.Add(new List<List<int>>());
            listOfList.Add(new List<List<int>>());
            listOfList.Add(new List<List<int>>());
            listOfList.Add(new List<List<int>>());
            listOfList.Add(new List<List<int>>());

            listOfList[0].Add(new List<int>());
            listOfList[0].Add(new List<int>());
            listOfList[0].Add(new List<int>());

            listOfList[0][0].Add(42);
            listOfList[0][0].Add(41);
            listOfList[0][1].Add(40);
            listOfList[0][1].Add(39);
            listOfList[0][2].Add(38);






            Console.WriteLine(listOfList[0][1][1]);
            Console.ReadLine();
        }
    }
}
