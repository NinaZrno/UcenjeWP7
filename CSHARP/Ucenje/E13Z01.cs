using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z01
    {
        public static void Izvedi()
        {

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

            Console.WriteLine("************");

            int broj = 0;
            string unos;
            for (; ; )
            {
                Console.Write("Unesi parni broj: ");
                unos = Console.ReadLine();
                if (unos.Trim() == "")
                {
                    Console.WriteLine("Molim unesite PARNI broj");
                    continue;
                }


                try
                {

                    broj = int.Parse(unos);
                    // siguran si da je broj unesen ali ne znas koji
                    if (broj % 2 == 1)
                    {
                        Console.WriteLine("Nisi unio odgovarajuci broj( 2,4,6,8...)");
                        continue;
                    }
                    break;
                }
                catch
                {
                    // unos 12O

                    Console.WriteLine("Nisi unio parni broj.");

                }

                Console.WriteLine("***********************");



                int visina = 0;
                string unesi;
                int Visina;
                for (; ; )
                {
                pocetak: // ovo se label/ labela
                    Console.Write("Unesi svoju visinu: ");
                    unesi = Console.ReadLine();
                    if (unesi.Trim() == "")
                    {
                        Console.WriteLine("Molim unesite visinut");
                        continue;
                    }


                    try
                    {

                        visina = int.Parse(unesi);
                        // siguran si da je broj unesen ali ne znas koji
                        if (visina < 110 || visina > 220)
                        {
                            Console.WriteLine("Nisi unio odgovarajucu visinu( 110-220)");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        // unos 12O
                        foreach (char znak in unesi)
                        {
                            Visina = znak;
                            if (Visina < 48 || Visina > 57)
                            {
                                Console.WriteLine("Uneseni znak {0} nije broj, on je dio abecede ...{1}, {2}, {3}...",
                                    znak, (char)(Visina - 1), znak, (char)(Visina + 1));
                                goto pocetak;

                            }
                        }


                        Console.WriteLine("Nisi unio broj.");

                    }




                }
            }
        }
    }
}
