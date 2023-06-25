using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 3";

        Console.WriteLine("Program łączący zadanie 1 oraz 2, dodatkowo umożliwiający podanie wymiaru tablicy");
        Console.WriteLine();

        int wymiar = 0;
        while (wymiar <= 0)
        {
            Console.WriteLine("Podaj wymiar tablicy kwadratowej");
            int.TryParse(Console.ReadLine(), out wymiar);

            if (wymiar <= 0)
            {
                wymiar = 0;
                continue;
            }
        }

        int[,] tablica1 = new int[wymiar, wymiar];

        for (int i = 0; i < wymiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < wymiar; j++)
                {
                    tablica1[i, j] = i * wymiar + j + 1;
                }
            }
            else
            {
                for (int j = wymiar - 1; j >= 0; j--)
                {
                    tablica1[i, j] = (i + 1) * wymiar - j;
                }
            }
        }

        int[,] tablica2 = new int[wymiar, wymiar];
        int liczba = 1;
        int wierszPoczatek = 0, wierszKoniec = wymiar - 1;
        int kolumnaPoczatek = 0, kolumnaKoniec = wymiar - 1;

        while (liczba <= wymiar * wymiar)
        {
            for (int k = kolumnaPoczatek; k <= kolumnaKoniec; k++)
                tablica2[wierszPoczatek, k] = liczba++;

            wierszPoczatek++;

            for (int k = wierszPoczatek; k <= wierszKoniec; k++)
                tablica2[k, kolumnaKoniec] = liczba++;

            kolumnaKoniec--;

            for (int k = kolumnaKoniec; k >= kolumnaPoczatek; k--)
                tablica2[wierszKoniec, k] = liczba++;

            wierszKoniec--;

            for (int k = wierszKoniec; k >= wierszPoczatek; k--)
                tablica2[k, kolumnaPoczatek] = liczba++;

            kolumnaPoczatek++;
        }

        Console.WriteLine();
        Console.WriteLine("Tablica wypełniona według schematu z zadania 1:");
        Console.WriteLine();
        for (int i = 0; i < wymiar; i++)
        {
            for (int j = 0; j < wymiar; j++)
            {
                Console.Write("{0,4}", tablica1[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Tablica wypełniona według schematu z zadania 2:");
        Console.WriteLine();
        for (int k = 0; k < wymiar; k++)
        {
            for (int l = 0; l < wymiar; l++)
                Console.Write("{0,4}", tablica2[k, l]);

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}