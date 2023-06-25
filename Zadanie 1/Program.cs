using System;

class Program
{
    static void Main()
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Program wypełniający tabelę 10x10 kolejnymi liczbami naturalnymi we wzór węża");
        Console.WriteLine();

        int[,] tablica = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = i * 10 + j + 1;
                }
            }
            else
            {
                for (int j = 9; j >= 0; j--)
                {
                    tablica[i, j] = (i + 1) * 10 - j;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0,4}", tablica[i, j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}