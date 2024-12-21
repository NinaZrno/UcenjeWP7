using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ2
    {
        public static void Izvedi()
        {
            Console.Write("Unesi broj godina: ");
            int godine= int.Parse(Console.ReadLine());

            if (godine >= 18)
            {
                Console.WriteLine("Korisnik je punoljetna osoba");

            }
            else
            {
                Console.WriteLine("Korisnik nije punoljetna osoba");
            }

            Console.WriteLine("Korisnik {0} punoljetna osoba ({1})", godine >=18 ? "je" : "nije", godine);






        }


    }
}
