using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Program
    {
        static Database db = new Database();
        static List<Futar> futarok = new List<Futar>();
        static void Main(string[] args)
        {
            futarok = db.getAllfutarok();
            feladat01();
            feladat02();
            //feladat03();
            Console.WriteLine("Program vége");
            Console.ReadLine();
        }

        //private static void feladat03()
        //{
        //    //Hányan dolgoznak az egyes részlegeken
        //    Console.WriteLine("3. feladat");
        //    foreach (var dolgozo in dolgozok.GroupBy(a => a.reszleg).Select(b => new { reszleg = b.Key, letszam = b.Count() }).OrderBy(x => x.letszam))
        //    {
        //        Console.WriteLine($"\t{dolgozo.reszleg} - {dolgozo.letszam} fő");
        //    }
        //}
        //
        private static void feladat02()
        {
            //A legkisebb értékben értékesítő futár nevét írja ki 
            Console.WriteLine("2. feladat");
            foreach (var f in futarok)
            {
                Console.WriteLine($"\t{f.fnev} - {f.ertek}");
            }
        }

        private static void feladat01()
        {
            //Írja ki a futárok adatait
            Console.WriteLine("1. feladat");
            foreach (var f in futarok)
            {
                Console.WriteLine($"\t{f.fazon}, {f.fnev}, {f.ftel}");
            }
        }
    }
}
