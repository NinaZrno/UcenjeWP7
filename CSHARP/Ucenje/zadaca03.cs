using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    internal class zadaca03 {
    
    public static void Izvedi()
        {
            Console.Write("Unesi kolicinu vrijednosti u nizu: ");
            int n = int.Parse(Console.ReadLine());
            int[] niz = new int[n];

            Console.WriteLine("Unesi vrijednosti: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vrijednost {0}: ", i + 1);
                niz[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + niz[i];
            }

            Console.WriteLine("Zbroj svih vrijednosti je {0}", suma);




        }
   
    }

}