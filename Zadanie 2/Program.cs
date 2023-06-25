using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Program wypełniający tabelę 10x10 kolejnymi liczbami naturalnymi we wzór spirali");
        Console.WriteLine();

        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int wierszPoczatek = 0, wierszKoniec = 9;
        int kolumnaPoczatek = 0, kolumnaKoniec = 9;

        while (liczba <= 100)
        {
            for (int i = kolumnaPoczatek; i <= kolumnaKoniec; i++)
                tablica[wierszPoczatek, i] = liczba++;

            wierszPoczatek++;

            for (int i = wierszPoczatek; i <= wierszKoniec; i++)
                tablica[i, kolumnaKoniec] = liczba++;

            kolumnaKoniec--;

            for (int i = kolumnaKoniec; i >= kolumnaPoczatek; i--)
                tablica[wierszKoniec, i] = liczba++;

            wierszKoniec--;

            for (int i = wierszKoniec; i >= wierszPoczatek; i--)
                tablica[i, kolumnaPoczatek] = liczba++;

            kolumnaPoczatek++;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                Console.Write("{0,4}", tablica[i, j]);

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}