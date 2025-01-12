using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Zadaca09
    {
        public static void Izvedi()
        {

            for (int i = 0; i < niz.Length - 1; i++)
            {
                for (int j = 0; j < niz.Length - i - 1; j++)
                {
                    if (niz[j] > niz[j + 1])
                    {
                        // Zamjena elemenata
                        int temp = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j + 1] = temp;
                    }
                }
            }
        }
    }
}