using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    internal class zadaca05
    {


        public static void Izvedi()
        {

            Console.Write("Unesi broj b: ");
            int b= int.Parse(Console.ReadLine());

            if(b <= 0)
            {
                Console.WriteLine("Unesi broj veci od 0");
            }

            Console.WriteLine("Fibonaccijev niz: ");

            int prvibroj = 0, drugibroj = 1;
            {
                Console.Write(prvibroj + " ");
                int sljedecibroj = prvibroj + drugibroj;
                prvibroj = drugibroj;
                drugibroj = sljedecibroj;
            }

            
        }
    }

}