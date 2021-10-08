using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokBekerese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kedves Felhasználó! Adj meg egy 50-nél kisebb számot!");
            string input = Console.ReadLine();
            int szam; // ez most csak egy deklaráció.
            
            bool sikerult_e = int.TryParse(input, out szam);
            // Az int.TryParse azt csinálja, hogy MEGPRÓBÁLJA beolvasni az inputot
            // - ha sikerül, akkor a sikerult_e igaz lesz, és a KORÁBBAN DEKLARÁLT szam változóba betölti az eredményt.
            // - ha nem sikerül, akkor a sikerult_e hamis lesz, és a szam valtozó ugyanolyan, mint korábban

            if (sikerult_e)
            {
                if (szam >= 50)
                {
                    Console.WriteLine("Ez a szám nem jó, mert nem kisebb, mint 50! Próbáld újra.");
                }
                else
                {
                    Console.WriteLine("Ez a szám kétszerese: ");
                    Console.WriteLine(2 * szam);
                }
            }
            else
            {
                Console.WriteLine("Jaj, bocsánat! Nem mondtam, de csak számjeleket fogadok el!");
            }



            /// Animáció következik

            int i = 0;
            while (i<=200)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            for (int j = 0; j <= 300; j++) // j++ helyére ezeket is lehetett volna írni: j+=1, j=j+1
            {
                Console.WriteLine(j);
            }


            Console.WriteLine("Köszönjük, hogy minket választott!");
        }
    }
}
