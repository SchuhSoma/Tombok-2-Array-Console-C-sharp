using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok2
{
    class Program
    {
        static int[] Szamok= new int[10];
        static void Main(string[] args)
        {
            TombFeltoltes();
            Console.WriteLine("\n-----------------------\n");
            TombKiiratas();
            Console.WriteLine("\n-----------------------\n");
            MinimumKivalasztas();
            Console.WriteLine("\n-----------------------\n");
            MaximumErtekKereses();
            Console.WriteLine("\n-----------------------\n");
            TombertekeinekAtlaga();
            Console.WriteLine("\n-----------------------\n");
            TombelemeinekRendezese(); 
            Console.WriteLine("\n-----------------------\n");
            Console.ReadKey();
        }

        private static void TombelemeinekRendezese()
        {
            Console.WriteLine("6.Feladat: tömb eleminek rendezése paranccsal");
            Array.Sort(Szamok);
            Array.Reverse(Szamok);//számok sorrendjének megfordítása
            for (int i = 0; i < Szamok.Length; i++)
            {
                Console.WriteLine("\t{0:00}. elem -> {1}", i + 1, Szamok[i]);
            }
        }

        private static void TombertekeinekAtlaga()
        {
            Console.WriteLine("5.Feladat: Összegzési tétel, átlagolás tétele");
            double Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                Osszeg += Szamok[i];
                Atlag = Osszeg / Szamok.Length;
            }
            Console.WriteLine("\tA tömb elemeinek összege: {0}", Osszeg);
            Console.WriteLine("\tA tömb elemeinek átlaga: {0:0.00}", Atlag);
        }

        private static void MaximumErtekKereses()
        {
            Console.WriteLine("4.Feladat: Maximum érték keresés");
            int Maximum = int.MinValue;
            int MaxHelye = 0;
            //Console.WriteLine(Maximum);
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]>Maximum)
                {
                    Maximum = Szamok[i];
                    MaxHelye = i + 1;
                }
            }
            Console.WriteLine("a Számok tömb legnagyobb értéke: {0}", Maximum);
            Console.WriteLine("A maximumot a tömb enyiedik helyén tároltam le: {0}", MaxHelye);
        }

        private static void MinimumKivalasztas()
        {
            Console.WriteLine("3.Feladat: Legkisebb elem (érték) kiválasztása");
            int Minimum = int.MaxValue;// az int számok körében a lehető legnagyobb érték
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]<Minimum)
                {
                    Minimum = Szamok[i];
                }
            }
            Console.WriteLine("A tömb legkisebb értéke: {0}", Minimum);

        }

        private static void TombKiiratas()
        {
            Console.WriteLine("2.Feladat: Tömb kiíratása");
            for (int i = 0; i < Szamok.Length; i++)
            {
                Console.WriteLine("{0:00}. elem -> {1}", i + 1, Szamok[i]);
            }
        }

        private static void TombFeltoltes()
        {
            Console.WriteLine("1.Feladat: Tömb (egész szám tömb) feltöltése");
            Szamok = new int[10] {10,15,13,14,20,19,36,1,-7,-11};
        }
    }
}
