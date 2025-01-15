using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13TryCatch
    {
        public static void Izvedi()
        {
            Console.WriteLine("E13");

            int b = 0;
            while (true)
            {

                Console.Write("Unesi broj: ");
                try
                {

                    b = int.Parse(Console.ReadLine());
                    break;  

                }

                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }


            }
            Console.WriteLine(b);




            Console.WriteLine("****************");


            //unesi godine izmedu 1 i 110

            int godine = 0;
            string unos;
            int brojZnak;
            for(; ; )
            {
                pocetak: // ovo se label/ labela
                Console.Write("Unesi svoje godine: ");
                unos= Console.ReadLine();
                if (unos.Trim() == "")
                {
                    Console.WriteLine("Molim unesite vrijednost");
                    continue;
                }
            

                try
                {
                
                    godine= int.Parse(unos);
                    // siguran si da je broj unesen ali ne znas koji
                    if(godine <1 || godine > 110)
                    {
                        Console.WriteLine("Nisi unio odgovarajuci broj( 1-110)");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    // unos 12O
                    foreach( char znak in unos)
                    {
                        brojZnak= znak;
                        if(brojZnak < 48 || brojZnak > 57)
                        {
                            Console.WriteLine("Uneseni znak {0} nije broj, on je dio abecede ...{1}, {2}, {3}...",
                                znak, (char)(brojZnak-1), znak, (char)(brojZnak+1));
                            goto pocetak; 

                        }
                    }


                    Console.WriteLine("Nisi unio broj.");
                    
                }
            }
        




        }
    }
}