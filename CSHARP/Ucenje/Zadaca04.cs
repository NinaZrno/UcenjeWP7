using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje {

    internal class zadaca04 
{
    
    public static void Izvedi()
        {

            Console.Write("Unesi broj ocjena: ");
            
                int a = int.Parse(Console.ReadLine());

            int a = 0; //a=Broj ocjena

            int b = 0; //b=zbroj ocjena
           
            // pojedinacne ocjene

            for (int i=1; i<=a; i++)
            {
                Console.Write("Unesi ocjenu broj {i}: ");
                int c = int.Parse(Console.ReadLine()); // c= ocjena
                b += c;
            }


            //prosjek

            double d = (double)b / a; // d= prosjek

            Console.WriteLine("Prosjek ocjena je: {0}", d);

        }
    
    
    
    }

}