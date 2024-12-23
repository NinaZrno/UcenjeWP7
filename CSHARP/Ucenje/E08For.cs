using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08For
    {
        public static void Izvedi()
        {

            // na osnovu dosadasnjeg znanja ispisite 10 puta jedno ispod drugog osijek
            // ovo nije dobra praksa (Best practice)
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("************");

            for (int i=0; i<10; i++) // i=i+1 i+=1 // paziti da ovdje nedode ;
            {
                Console.WriteLine("Osijek");
            }

            //kao i kod if ne moraju biti {} ali onda se petlja odnosi samo na prvu sljedecu liniju

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Ispisujem {0}. broj", i+1);

            }
            //zbroj prvih 100 brojeva


            int suma = 0;
            for (int i=1; i<=10; i++)
            {
                suma += i;
                //ako zelimo pratiti proces
               // Console.WriteLine("{0}+{1}={2}",suma-1, i, suma);  // ako zelimo taj proces vidjeti
                //ako zelimo samo rezultat onda poslije {}
            }
            Console.WriteLine(suma);

            //petlja moze ici i unazad

            for(int i=10; i>0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************");

            //petlja ne mora ici za korak 1
            for(int i=0; i < 10; i += 2)
            {
                Console.WriteLine(i);

            }

            int odKuda = 2, doKuda = 20, uvecanje = 3; //simulacija da je unio korisnik

            //ono cemu tezimo u kodu jest kod bez konstanti

            for(int i= odKuda; i<doKuda; i += uvecanje)
            {
                Console.WriteLine(i);

            }
            int[] niz = { 2, 3, 4, 5, 3, 2, 2 }; //duzina je 7

            Console.WriteLine(niz[3]);


            for(int i=0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);

            }

            //for petlja moze se gnjezditi



            int redaka = 8;
            int stupaca = 6;


            for (int i = 0; i < redaka; i++)  
            {
                for(int j= 0; j <stupaca; j++)
                {
                    Console.Write("{0,4} " , (i+1) * (j+1) );
                }
                Console.WriteLine();
            }

            // petlju se moze preskociti odnosno nastaviti

            for (int i= 0; i<10; i++)
            {
                if (i == 4)
                {
                    continue; //vraca na pocetak petlje
                }

                Console.WriteLine("Rezerviraj {0}. mjesto", i+1);

            }
            //petlja se moze nasilno prekinuti

            for(int i= 0; i < 10; i++) // prirodni kraj je i=10
            {
                if(i== 5)
                {
                    break; // nasilno prekidam
                }
                Console.WriteLine(i);
            }
            //korisnost break-a
            // prim broj, prime number, prosti broj
            // prosti brojevi: 2,3,5,7,11,17
            // zasto 4 nije prim broj? cjelobrojno je djeljiv s 2

            int brojZaProvjeru = 157;
            int brojacInteracija = 1;
            bool prim = true; // moja hipoteza je da taj broj je prim broj
                for (int i = 2; i< brojZaProvjeru; i++)
            {

                Console.WriteLine("{0}%{1}=={2} ({3})", brojZaProvjeru, i, brojZaProvjeru%i, brojacInteracija++);
                if (brojZaProvjeru % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            Console.WriteLine("{0} {1} prim broj", brojZaProvjeru, prim ? "JE" : "NIJE");


            //beskonacna petlja

            for(int i = 0; i> -1; i++) // ovo nije beskonacna petlja zbog brojevne kruznice
            {
                break;
            }

            for(; ; ) //ovo je sintaksa for beskonacne petlje
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} ", new Random().Next());
                Thread.Sleep(100);
                break;
            }


















        }



    }
}
