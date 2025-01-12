using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Zadaca06
    {

        public static void Izvedi()
        {
            Console.Write("Unesite string: ");
            string unos = Console.ReadLine();

            string preokrenut = "";
            for (int i = unos.Length - 1; i >= 0; i--)
            {
                preokrenut += unos[i];
            }

            Console.WriteLine("Preokrenuti string: {preokrenut}");

        }
    }
}