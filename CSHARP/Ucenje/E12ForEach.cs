using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12ForEach
    {

        public static void Izvedi()
        {
            Console.WriteLine("E12");

            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();






            // svako slovo grada ispisi jedno ispod drugog

            for(int i =0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }



            Console.WriteLine("*********************");

           
            
            
            
            // u slucajevima kada idemo od pocetka do kraja (vecina puta)

            foreach(char znak in grad)
            {
                Console.WriteLine(znak);
            }

            Console.WriteLine("*****************");





           for (int i =0; i< grad.Length; i++)
            {
                Console.WriteLine(grad[^(i+1)]);
            }





        }
    }
}
