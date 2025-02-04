using System;

internal class ciklicnamatrica
{
    static void Main()
    {
        do
        {
            int rows, cols, option;
            do
            {
                Console.Write("Unesite broj redova (1-20): ");
            } while (!int.TryParse(Console.ReadLine(), out rows) || rows < 1 || rows > 20);

            do
            {
                Console.Write("Unesite broj kolona (1-20): ");
            } while (!int.TryParse(Console.ReadLine(), out cols) || cols < 1 || cols > 20);

            do
            {
                Console.WriteLine("Odaberite opciju smjera kretanja:");
                Console.WriteLine("1. Dolje desno (kazaljka na satu)");
                Console.WriteLine("2. Dolje lijevo (kazaljka na satu)");
                Console.WriteLine("3. Gore lijevo (kazaljka na satu)");
                Console.WriteLine("4. Gore desno (kazaljka na satu)");
                Console.Write("Unesite broj opcije: ");
            } while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4);

            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix, option);
            PrintMatrix(matrix);

            Console.Write("Želite li generirati još jednu matricu? (DA/NE): ");
        } while (Console.ReadLine().Trim().ToUpper() == "DA");
    }

    static void FillMatrix(int[,] matrix, int option)
    {
        // Implementacija različitih smjerova kretanja
    }

    static void PrintMatrix(int[,] matrix)
    {
        int maxNum = matrix.GetLength(0) * matrix.GetLength(1);
        int width = maxNum.ToString().Length;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(width) + " ");
            }
            Console.WriteLine();
        }
    }
}
