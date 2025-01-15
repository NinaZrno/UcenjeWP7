using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z02
    {
        public static void Izvedi()
        {

            float b = 0;
            while (true)
            {

                Console.Write("Unesi decimalni broj: ");
                try
                {

                    b = float.Parse(Console.ReadLine());
                    break;

                }

                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }


            }




            string unos;
            while (true)
            {
                Console.Write("Unesi ime grada: ");
                    unos = Console.ReadLine();
                if (unos.Trim() == "")
                {
                    Console.WriteLine("Nisi unio ime grada");
                    continue;
                }
                try
                {
                    int.Parse(unos);
                    Console.WriteLine("Ne smijes unijeti broj");
                    continue; 
                }
                catch
                {

                }
                break; 
            }

        }
    }
}
