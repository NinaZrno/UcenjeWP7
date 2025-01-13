using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10WhilePetlja
    {
        public static void Izvedi()
        {

           // Console.WriteLine("E10");

            // while radi sa bool

            // beskonacna petlja
            while (true)
            {
                Console.WriteLine("Ispis iz beskonacne petlje nakon cega je break");
                break;
            }


            int i = 0;
            while (i++ < 10) // i++ kreni od nule
            {
                Console.WriteLine(i);
            }


            // continue radi na isti nacin

            int j = 10;
            while ( i>= 10 && j++ < 10) // moze jos i || te !
            {
                Console.WriteLine(i*j);
            }

            // U for i while se ne mora uci

            int odBroja = 10;
            int dobroja = 0;
             for ( int x= odBroja; x< dobroja; x++)
            {
                Console.WriteLine(x);
            }

            bool uvjet = false;

            while (uvjet)
            {
                Console.WriteLine("Nece se ispisati");
            }


        }
    }
}
