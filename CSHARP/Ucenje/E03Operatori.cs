using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Operatori
    {

        public static void Izvedi()
        {

            //Console.WriteLine("E03");

            int i, j;

            i = 2; j = 3;

            i += j;



            Console.WriteLine(i/j);


            Console.WriteLine(i/(float)j);

            Console.WriteLine(5 % 2 );

            i = 1;
            // razliciti nacini za uvecanje varijable za broj 1
            i = i + 1;
            i += 1;
            i++;
            ++i;
            Console.WriteLine("**************");
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(++i); // 3 prvo se uveca pa se koristi

            Console.WriteLine("------------");
            int x = 1, y = 0;

            x = x + --y;
            y += ++x;
            Console.WriteLine(++x - y--);





        }

           




    }




}
