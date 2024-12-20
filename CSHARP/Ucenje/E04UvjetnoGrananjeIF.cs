using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04UvjetnoGrananjeIF
    {

        public static void Izvedi()
        {

            //Console.WriteLine("E04");

            int broj = 7; // ovo je kao da sam ispisao poruku i da je korisnik unio broj 7

            // operator == provjerava jednakost, on je tipa bool

            bool uvjet = broj == 7;

            // if radi s bool tipom podataka

            if (uvjet)
            {
                Console.WriteLine("Broj ima vrijednost 7");
            }

            // u oravilu se if koristi ovako
            if (broj == 7)
            {
                Console.WriteLine("ponovno je jednako 7");
            }

            // if moze i bez {} i tada se odnosi samo na prvu liniju nakon if

            if (broj == 7)
                Console.WriteLine("I bez {} je jednako");
            //Console.WriteLine("I ovo bih da je uz uvjet jednakosti da je broj 7");


            if (broj == 7)
            {
                Console.WriteLine("I opet je 7 ali uz inače");

            }
            else
            {
                Console.WriteLine("Broj NIJE 7");
            }

            //maksimalni oblik if naredbe
            if (broj == 6)
            {
                Console.WriteLine("Sad je 6");
            }
            else if (broj == 7)
            {
                Console.WriteLine("Sad je 7");
            } // moze ici koliko god else if zelimo
            else // moze i nemora 
            {
                Console.WriteLine("Broj nije niti 6 ni 7");
            }

            // if koristi <, >, <=, >= i !=Razlicito

            //logicki operatori and or i not

            //and  & ili &&

            broj = 1;
            int temp = 2;
            if(broj!=1 & temp < 0) // provjeravati ce se oba uvjeta
            {
                Console.WriteLine("Hladno je");
            }


            if (broj != 1 && temp < 0) // ako prvi uvjet nije ispunjen ne provjerava se drugi
            {
                Console.WriteLine("Hladno je");
            }

            // or  | (AltGr + W) ||
             if(broj>0 | temp > 0) //provjerava oba uvjeta
            {
                Console.WriteLine("Toplo je");
            }

            if (broj > 0 || temp > 0) //Ako je prvi uvjet zadovoljen ne provjerava se drugi
            {
                Console.WriteLine("Toplo je");
            }

            //not !
            if(!(broj>1 || temp> 0))
            {
                Console.WriteLine("Ovo je komplicirani izraz");
            }
            // if se moze ugnjezdivati

            if (broj > 0)
            {
                if (temp == 0)
                {
                    Console.WriteLine("Ugnjezdeno");
                }


                //djelokrug varijable (scope)

                if(broj > 0)
                {
                    int t = 8; // ova varijbla zivi samo unutar ovog if-a
                }
                //Console.WriteLine(t); // varijabla t nije vidljiva izvan gore definiranog if-a

                string grad = "Osijek";

                if(grad== "Osijek")
                {
                    Console.WriteLine("Super");

                }
                else
                {
                    Console.WriteLine("Nije Super");
                }
                // u slucaju da if i else imaju istu akciju (Naredba, metoda) tada se moze koristiti 
                // inline if (? : operator)

                Console.WriteLine(grad== "Osijek" ? "Super" : "Nije Super");




            }
            
        }













    }
}
