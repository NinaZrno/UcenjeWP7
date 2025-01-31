using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GSALE
{
    public class Obrada<T> : ISucelje where T : Entitet
    {
        public T? PredmetObrade { get; set; }

        public void OdradiPosao()
        {
            Posao();
        }

        public void Posao()
        {
            Console.WriteLine(PredmetObrade?.Sifra);
        }


        // ova metoda je depricated
        [Obsolete("Koristi metodu Job()")] // atribute stavljaju iznad metode i oni su uputa za 3rd party alatima
        public void Job()
        {
            Console.WriteLine("Stara Metoda");
        }

    }
}
