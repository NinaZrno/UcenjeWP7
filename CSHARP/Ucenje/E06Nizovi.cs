using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06Nizovi
    {

        public static void Izvedi()
        {
            // motivacija: treba pohraniti prosjecne temp u 12 mjeseci

            // krivi pristup
            int sijecanj, veljaca, ozujak, /*...*/ prosinac; // ne raditi 12 varijabli

            int[] temp = new int[12]; // glavni problem nizova je sto u trenutku kreiranja moras znati koliko elemenata

            // niz ima index i vrijednost 
            temp[0] = -1; //sijecanj
            temp[1] = 1; // veljaca
            //...
            temp[11] = 4; //prosinac


            Console.WriteLine(temp[0]);
            Console.WriteLine(temp);
            // ispisivanje svih elemenata niza
            Console.WriteLine(string.Join(",", temp));

            // dvodimenzionalni niz - tablica
            int[,] tablica =
            {

                {1,2,3 },
                {4,5,6 },
                {5,6,7 }

            };

            //ispisite broj 6
            Console.WriteLine(tablica[1,2]);

            //trodimenzionalni niz - kocka
            int[,,] kocka = new int[10, 10, 10];
            kocka[5, 5, 5] = 27;
              
                Console.WriteLine(kocka[5,5,5]);


            //cetverodimenzionalni niz- tesaarect
            //multiverse
            int[,,,,,,,] multiverse;

            // zasto nam je bitan jednodimenzionalni niz
            string grad = "Osijek";
            //ispisi slovo j
            // string je niz znakova

            Console.WriteLine(grad[3]);

            char znak = 'A';

            //Ispisi zadnji znak
            Console.WriteLine(grad[grad.Length-1]);

        }
    }
}
