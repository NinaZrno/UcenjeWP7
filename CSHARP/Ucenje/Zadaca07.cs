using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Zadaca07
    {
        public static void Izvedi()
        {
            int brojSamoglasnika = 0;
            foreach (char znak in unos)
            {
                if (znak == 'a' || znak == 'e' || znak == 'i' || znak == 'o' || znak == 'u')
                {
                    brojSamoglasnika++;
                }
            }
        }
    }
}