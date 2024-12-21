using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ4
    {
        public static void Izvedi() 
        { 
       


            Console.Write("Unesi broj od 1 do 7: ");
            {
                int broj = int.Parse(Console.ReadLine());


                switch (broj)
                {
                    case 1:
                        Console.WriteLine("Ponedjeljak-Korisnik ide na trening");
                        break;
                    case 2:
                        Console.WriteLine("Utorak-Korisnik uci programiranje");
                        break;
                    case 3:
                        Console.WriteLine("Srijeda-Korisnik ide na trening");
                        break;
                    case 4:
                        Console.WriteLine("Cetvrtak-Korisnik uci programiranje");
                        break;
                    case 5:
                        Console.WriteLine("Petak-Korisnik ide u kino");
                        break;
                    case 6:
                        Console.WriteLine("Subota-Korisnik se odmara");
                        break;
                    case 7:
                        Console.WriteLine("Nedjelja-Korisnik se odmara");
                        break;
                    default:
                        Console.WriteLine("Nije dobar dan");
                        break;
                }






                }











        }
      
            


    }
}
