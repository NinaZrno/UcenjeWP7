using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z02
    {
        /// <summary>
        /// Osoba unosi broj godina
        /// program ispisuje da li je punoljetna ili ne
        /// </summary>
        public static void Izvedi()
        {
            int godine= (E14Metode.UcitajBroj("Unesi broj svojih godina  ", 1, 150));
            if (godine < 18)
            {
                Console.WriteLine("Maloljetna osoba");
            }
            else
            {
                Console.WriteLine("Punoljetna osoba");
            }


            // one liner

            Console.WriteLine((E14Metode.UcitajBroj("Unesi broj svojih godina  ", 1, 150)<18? " Maloljetna" : "Punoljetna ")+ "osoba");

        }


    }
}
