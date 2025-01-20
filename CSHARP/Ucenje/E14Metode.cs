using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Metode
    {
        // cilj rada s metodama : write once, use everywhere
     // static oznacava da se metoda moze pozvati na klasi
        public static void Izvedi()
        {

            Console.WriteLine("E14");
            // metode se sastoje od dva dijela:
            // 1. Tijelo metode
            // 2. Poziv metode

            // iz staticne metode na klasi moze samo pozvati drugu staticnu metodu, posljedicno sve nade metoda danas ce biti

            // poziv metode
            Tip1();

            Tip2(5);

            Tip2(3, "Osijek");

            Console.WriteLine(Tip3());

            //svi prosti brojevi od 1 do 100
            for (int i= 1; i<100; i++)
            {
                if (Tip4(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }



        // prvo se pise tijelo metode
        /// <summary>
        /// Metoda tipa 1: ne vraca vrijednost ne prima vrijednost
        ///  ne vraca vrijednost- void
        ///  ne prima vrijednost- u zagradama nakon naziva metode nema parametra
        ///  mora trenutno biti static
        ///  ne pise public ili nesto drugo: radi se o nacinu pristupa 
        ///  bez navodenja: vidljivo samo u ovoj klasi
        ///   </summary>
        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode Tip 1");
        }

        //2. ne vraca vrijednost , prima parametre
        // int i je parametar
        /// <summary>
        /// Metoda koja ispisuje broj i njegovo uvecanje za 10
        /// </summary>
        /// <param name="i"></param>

        private static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}", i);
            Console.WriteLine("Uvecan za 10 on iznosi {0}", i+10);
        }

        // potpis metode: naziv metode + lista parametara koje prima
        protected static void Tip2(int i, string s) // method overloading
        {
            Console.WriteLine(s);
            Console.WriteLine("Primio sam {0}", i);
        }




        //3. vraca vrijednost, ne prima parametre
        public static string Tip3()
        {
            // ako nije void metoda mora vratiti (return) onaj tip za koji je deklarirana
            return "Web programiranje";

        }

        //4. najjzanimljivija , vraca vrijednost, prima parametre
        /// <summary>
        /// za dani broj odlucuje da li je prim ili ne
        /// </summary>
        /// <param name="broj"></param> broj koji se analizira
        /// <returns></returns> true ako je prim, false ako nije 

        public static bool Tip4(int broj)
        {
           
            for(int i=2; i< broj; i++)
            {
                if(broj% i == 0)
                {
                    // short circuiting
                    // prekidam i petlju i metodu i vraca false
                    return false;
                }
            }

            return true; 
        }

        public static int UcitajBroj(string poruka)
        {
            
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli broj");
                    
                }
            }
                
            //return 0; // samo da ne bude greska,kasnije obrisati

        }

        public static int UcitajBroj(string poruka, int min, int max)
        {
            int i = 0;
            for(; ; )
            {
                Console.Write(poruka + " :" +
                    "");
                try
                {
                    i= int.Parse(Console.ReadLine()) ;
                    if (i<min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} i {1}", min , max );
                        continue;
                    }
                    return i;
                }
                catch 
                {
                    Console.WriteLine("Nisi unio broj!!");
                    
                }
            }



            //return 0;
        }

        public static string UcitajString(string poruka, string greska)
        {
            string s;
            do
            {
                Console.WriteLine(poruka + ":");
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine(greska);
                    continue;
                }
                return s;
            } while (true);



            //return "";
        }












    }
}
