using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ1
    {

        public static void Izvedi()
        {
            //za ucitani cijeli broj izmedu 10 i 99 ispisi jedinicnu vrijednost
            // 56 -> 6
            // 82 -> 2

            Console.Write("Unesi cijeli broj izmedu 10 i 99: ");
           
            int broj = int.Parse(Console.ReadLine());
           
            Console.WriteLine(broj % 10);

            Console.Write("Ponovi unos: ");

            Console.WriteLine(Console.ReadLine()[1]);

            // sada ispisati prvu znamenku

            Console.WriteLine(broj / 10);









        }



    }
}
