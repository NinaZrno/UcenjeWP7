using System;

public class ZadaPP
{

		public static void Izvedi()
	{

		Console.Write("Unesi prvu vrijednost, duljina a ");
		
            float a = float.Parse(Console.ReadLine());

        

        Console.Write("Unesi drugu vrijednost, sirina b");
		
            float b = float.Parse(Console.ReadLine());



		float p = a * b;



		Console.WriteLine("Povrsina pravokutnika je {0}", p );
    }




	}

