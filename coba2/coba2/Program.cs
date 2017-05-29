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
            ///////////////////////////////////////////inisiasi data////////////////////////////////////////
            //inisiasi
            int[,] numbers = new int[6, 6];

            //matriks baris 0
            numbers[0, 0] = 1000;
            numbers[0, 1] = 3;
            numbers[0, 2] = 2;
            numbers[0, 3] = 3;
            numbers[0, 4] = 6;
            numbers[0, 5] = 2;

            //matrisk baris 1
            numbers[1, 0] = 3;
            numbers[1, 1] = 1000;
            numbers[1, 2] = 1;
            numbers[1, 3] = 1000;
            numbers[1, 4] = 2;
            numbers[1, 5] = 1000;

            //matriks baris 2
            numbers[2, 0] = 2;
            numbers[2, 1] = 1;
            numbers[2, 2] = 1000;
            numbers[2, 3] = 1;
            numbers[2, 4] = 1000;
            numbers[2, 5] = 1000;

            //matriks baris 3
            numbers[3, 0] = 3;
            numbers[3, 1] = 1000;
            numbers[3, 2] = 1;
            numbers[3, 3] = 1000;
            numbers[3, 4] = 1;
            numbers[3, 5] = 1;

            //matriks baris 4
            numbers[4, 0] = 6;
            numbers[4, 1] = 2;
            numbers[4, 2] = 1000;
            numbers[4, 3] = 1;
            numbers[4, 4] = 1000;
            numbers[4, 5] = 1000;

            //matriks baris 5
            numbers[5, 0] = 2;
            numbers[5, 1] = 1000;
            numbers[5, 2] = 1000;
            numbers[5, 3] = 1;
            numbers[5, 4] = 1000;
            numbers[5, 5] = 1000;

            ////penyamaan entri matriks kolom dan baris
            //for (var i = 0; i < 5; i++)
            //{
            //    for (var j = i; j < 5; j++)
            //    {
            //        numbers[j, i] = numbers[i, j];
            //    }
            //}


            /////////////////////////////////////////////////djikstra/////////////////////////////
            //djikstra dari start ke final
            //string morseCode = _textToMorse[character];
            Console.WriteLine(" ");
            Console.WriteLine("DJIKSTRA");
            Console.WriteLine(" ");
            Console.WriteLine("Tulis nama dua kota yang ingin anda ketahui jaraknya");
            Console.WriteLine("---Bandung, Jakarta, Bogor, Depok, Tanggerang, Bekasi---");
            Console.WriteLine(" ");

            while (true)
            {
                Console.WriteLine("ketik mulai");
                string mulay = Console.ReadLine();
                mulay = mulay.ToLower();

                
                if(mulay=="mulai")
                {
                    try
                    {
                        Console.WriteLine("Kota 1");
                        string kota1 = Console.ReadLine();
                        kota1 = kota1.ToLower();
                        //while (kota1 != "bandung" && kota1 != "jakarta" && kota1 != "bogor" && kota1 != "depok" && kota1 != "tanggerang" && kota1 != "bekasi")
                        //{
                        //    Console.WriteLine("masukkan Kota 1 (bandung, jakarta, bogor, depok, tanggerang atau bekasi");
                        //    kota1 = Console.ReadLine();
                        //    kota1 = kota1.ToLower();
                        //}

                        Console.WriteLine(" ");
                        Console.WriteLine("Kota 2");
                        string kota2 = Console.ReadLine();
                        kota2 = kota2.ToLower();
                        //while (kota2 != "bandung" && kota2 != "jakarta" && kota2 != "bogor" && kota2 != "depok" && kota2 != "tanggerang" && kota2 != "bekasi")
                        //{
                        //    Console.WriteLine("masukkan Kota 2 (bandung, jakarta, bogor, depok, tanggerang atau bekasi");
                        //    kota2 = Console.ReadLine();
                        //    kota2 = kota2.ToLower();
                        //}
                        Console.WriteLine(" ");



                        int start = kota[kota1];
                        int final = kota[kota2];



                        if (start > final)
                        {
                            var middle = start;
                            start = final;
                            final = middle;
                        }

                        //inisiasi jarak dan cek
                        List<int> jarak = new List<int>(); //jarak adalah panjang terpendek
                        List<int> cek = new List<int>(); //cek adalah indeks yang masih di pakai

                        ////lisfOflist
                        //var listOfList = new List<List<List<int>>>();

                        //for (var i=0; i<6; i++)
                        //{
                        //    listOfList.Add(new List<List<int>>());
                        //    listOfList[i].Add(new List<int>());
                        //    listOfList[i][0].Add(start);
                        //}


                        //jarak dan cek mula-mula
                        for (var i = 0; i < 6; i++)
                        {
                            cek.Add(i);
                            jarak.Add(numbers[start, i]);
                            //listOfList[i][0].Add(i);
                        }



                        //indeks dari jarak dan cek yang sudah dipakai dihilangkan
                        cek.RemoveAt(start);
                        jarak.RemoveAt(start);


                        //car nilai minimal dari jarak sekaligus indeks yang diperoleh di catat
                        var min = jarak[0];
                        var indeks = 0;
                        for (var i = 0; i < jarak.Count(); i++)
                        {
                            min = (jarak[i] <= min) ? jarak[i] : min;
                        }
                        for (var i = 0; i < jarak.Count(); i++)
                        {
                            indeks = (jarak[i] == min) ? i : indeks;
                        }


                        //looping sampai ketemu hasil akhir
                        while (cek[indeks] != final)
                        {
                            for (var i = 0; i < cek.Count(); i++)
                            {
                                //if (jarak[i]> jarak[indeks] + numbers[cek[indeks], cek[i]])
                                //{
                                //    jarak[i] = jarak[indeks] + numbers[cek[indeks], cek[i]];

                                //}
                                //if (jarak [i] == jarak[indeks] + numbers[cek[indeks], cek[i]])
                                //{
                                //    var banyak = listOfList[cek[indeks]].Count();
                                //    for (var j=0; j<listOfList[cek[indeks]].Count(); j++ )
                                //    {
                                //        listOfList[cek[indeks]][j].Add(i);
                                //        listOfList[i].Add(new List<int>());
                                //        listOfList[i][banyak + j-1] = listOfList[cek[indeks]][j];
                                //    }

                                //    //listOfList[i].Add(listOfList[cek[indeks]][j]);
                                //}
                                if (jarak[i] >= jarak[indeks] + numbers[cek[indeks], cek[i]])
                                {
                                    jarak[i] = jarak[indeks] + numbers[cek[indeks], cek[i]];
                                    //for (var j = 0; j < listOfList[cek[indeks]].Count(); j++)
                                    //{
                                    //    listOfList[cek[indeks]][j].Add(i);                            
                                    //}
                                    //listOfList[i] = listOfList[cek[indeks]];
                                }
                            }
                            cek.RemoveAt(indeks);
                            jarak.RemoveAt(indeks);
                            min = jarak[0];
                            indeks = 0;
                            for (var i = 0; i < jarak.Count(); i++)
                            {
                                min = (jarak[i] <= min) ? jarak[i] : min;
                            }
                            for (var i = 0; i < jarak.Count(); i++)
                            {
                                indeks = (jarak[i] == min) ? i : indeks;
                            }
                        }

                        Console.WriteLine("jarak antara " + kota1 + " dan " + kota2 + " adalah " + jarak[indeks]); //hasil 

                        //for (var i=0; i<6; i++)
                        //{
                        //    for (var j=0; j<2; j++)
                        //    {
                        //        Console.WriteLine(listOfList[i][0][j]);
                        //    }
                        //}


                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("masukkin yang bener!");
                        continue;
                    }

                    }

                else if (mulay=="sudah")
                {
                    break;                        
                }

               
                
            }


        }

        private static Dictionary<string, int> kota = new Dictionary<string, int>()
                {
                    {"bandung",0},
                    {"jakarta",1},
                    {"bogor",2},                    
                    {"depok",3},
                    {"tanggerang",4},
                    {"bekasi",5},
                    
                };
    }
}
