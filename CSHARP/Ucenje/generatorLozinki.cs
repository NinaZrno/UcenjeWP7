using System;
using System.Text;

class generatorLozinki

{
    static void Main()
    {
        do
        {
            Console.Write("Unesite dužinu lozinke: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Uključiti velika slova? (DA/NE): ");
            bool includeUpper = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Uključiti mala slova? (DA/NE): ");
            bool includeLower = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Uključiti brojeve? (DA/NE): ");
            bool includeNumbers = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Uključiti interpunkcijske znakove? (DA/NE): ");
            bool includeSymbols = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Lozinka počinje brojem? (DA/NE): ");
            bool startWithNumber = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Lozinka počinje interpunkcijskim znakom? (DA/NE): ");
            bool startWithSymbol = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Lozinka završava brojem? (DA/NE): ");
            bool endWithNumber = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Lozinka završava interpunkcijskim znakom? (DA/NE): ");
            bool endWithSymbol = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Lozinka nema ponavljajuće znakove? (DA/NE): ");
            bool noRepeats = Console.ReadLine().Trim().ToUpper() == "DA";

            Console.Write("Koliko lozinki generirati? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(GeneratePassword(length, includeUpper, includeLower, includeNumbers, 
                includeSymbols, startWithNumber, startWithSymbol, endWithNumber, endWithSymbol, noRepeats));
            }

            Console.Write("Želite li generirati još jednu seriju lozinki? (DA/NE): ");
        } while (Console.ReadLine().Trim().ToUpper() == "DA");
    }





    static string GeneratePassword(int length, bool includeUpper, bool includeLower, bool includeNumbers,
    bool includeSymbols, bool startWithNumber, bool startWithSymbol, bool endWithNumber, bool endWithSymbol, bool noRepeats)
    
    {
        const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lower = "abcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        const string symbols = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/";

        StringBuilder password = new StringBuilder();
        Random random = new Random();
        string charPool = "";

        if (includeUpper) charPool += upper;
        if (includeLower) charPool += lower;
        if (includeNumbers) charPool += numbers;
        if (includeSymbols) charPool += symbols;

        if (startWithNumber) password.Append(numbers[random.Next(numbers.Length)]);
        else if (startWithSymbol) password.Append(symbols[random.Next(symbols.Length)]);

        while (password.Length < length - (endWithNumber || endWithSymbol ? 1 : 0))
        {
            char nextChar = charPool[random.Next(charPool.Length)];
            if (noRepeats && password.ToString().Contains(nextChar)) continue;
            password.Append(nextChar);
        }

        if (endWithNumber) password.Append(numbers[random.Next(numbers.Length)]);
        else if (endWithSymbol) password.Append(symbols[random.Next(symbols.Length)]);

        return password.ToString();
    }
}
