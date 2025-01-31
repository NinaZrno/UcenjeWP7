using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GSALE
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("E19");

            // problem nizova? moramo znati velicinu niza prije nego sta ga kreiram
            // tom problemu u c sharp doskace se s koristenjem liste List
            // List koristi sintaksu parametiziranja, moramo shvatit sto su Gweneric klase (generici)

            List<int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(7);

            var sb = new Random();

            for (int i = 0; i < 20; i++)
            {
                brojevi.Add(sb.Next(1, 100));         
            }

            // trenutno u listi ima 22 broja


            Console.WriteLine(brojevi[6]);

            Console.WriteLine("********************************");

            foreach (var broj in brojevi)
            {
                Console.WriteLine(broj);
            }

            //brojevi.Add("a"); // nece raditi jer lista je na int

            List<string> imena = new List<string>();
            imena.Add("Ivan");
            imena.Add("Marko");


            Console.WriteLine(imena[1]);

            List<Smjer> smjerovi = new List<Smjer>();
            smjerovi.Add(new Smjer { Sifra = 1, Naziv = "Web programiranje" });
            smjerovi.Add(new () { Sifra = 2, Naziv = "Serviser" });



            var o = new Obrada<Smjer>();

            o.PredmetObrade = smjerovi[0];

            o.Posao();

            var op = new Obrada<Polaznik>();
            
            op.PredmetObrade = new Polaznik { Sifra = 7, Ime = "Ivan", Prezime = "Mrav" };

            op.Posao();

            //var os = new Obrada<string>(); // string ne nasljeduje entitet

            Console.WriteLine("**************************************");
            
            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            Console.WriteLine("***************************************");
            smjerovi.Sort();

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            op.Job();




            Console.WriteLine(Zbroj(3,4));
            Console.WriteLine(Zbroj(1,1));

            // Lambda izrazi
            var Zbroji = (int a, int b) => a + b;

            Console.WriteLine(Zbroji(3,4));

            var Algoritam = (int a, int b) =>
            {
                if (a > b)
                {
                    return a;
                }
                return b;
            };


            var br = 6;
            if (br % 2 == 0)
            {
                Console.WriteLine("Paran");
            }
            else
            {
                Console.WriteLine("Neparan");
            }


            var Paran = (int i) => i % 2 == 0;

            Console.WriteLine(Paran(6) ? "Paran" : "Neparan");

            //ekstenzije


            Console.WriteLine(smjerovi.FirstOrDefault());

            smjerovi[0].Ispis();

            var jedanSmjer = smjerovi[0];
            
            jedanSmjer.Ispis();

            var jedanPolaznik = op.PredmetObrade;

            jedanPolaznik.Ispis();

            op.Odradi();
            jedanSmjer.Odradi();



            // o osnovnim OOP principima

        }

        public int Zbroj (int a, int b)
        {
            return a + b;
        }

    }

}
