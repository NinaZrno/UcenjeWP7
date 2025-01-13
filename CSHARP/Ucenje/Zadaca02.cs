using System;

public class Zadaca02
{

		public static void Izvedi()
	{

		Console.WriteLine("Unesi bilo koju vrijednost");
		float vrijednost= float.Parse(Console.ReadLine());

		if (vrijednost > 0)
		{
			Console.WriteLine("Broj {0} je pozitivan", vrijednost);

	}
        else if (vrijednost < 0)
            {
            Console.WriteLine("Broj {0} je negativan", vrijednost);
        }
        else
        {
            Console.WriteLine(" Broj {0} je nula!", vrijednost);
        }


    }
}
