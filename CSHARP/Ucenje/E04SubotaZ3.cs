using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04SubotaZ3
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi broj: ");
            int pb= int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int db = int.Parse(Console.ReadLine());

            Console.WriteLine(pb<db ? pb : db<pb ? db : "Jednaki su");


            // DZ: isto napraviti za tri broja


            Console.Write("Unesi prvi broj: ");
             pb= int.Parse(Console.ReadLine());

            Console.Write("Unesi prvi broj: ");
             pb = int.Parse(Console.ReadLine());
            Console.Write("Unesi prvi broj: ");
             pb = int.Parse(Console.ReadLine());


        }


    }
}
