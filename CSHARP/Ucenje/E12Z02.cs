using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z02
    {

        public static void Izvedi()
        {
            // korisnik unosi dvije rijeci
            // program ispisuje unesene  rijeci redoslijedom druga pa prva rijec unazad u istoj liniji

            Console.WriteLine("Unesi prvu rijec: ");
            string prvaRijec= Console.ReadLine();

            Console.WriteLine("Unesi drugu rijec: ");
            string drugaRijec = Console.ReadLine();
            string unazad = "";
            drugaRijec = drugaRijec + "" + prvaRijec;
            for (int i = drugaRijec.Length - 1; i >= 0; i--)
            {
                unazad += drugaRijec[i];
            }
            Console.WriteLine("{0}");
           




        }

    }
}
