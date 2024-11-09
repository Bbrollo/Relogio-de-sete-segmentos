using System;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string time = Console.ReadLine();
        Console.WriteLine(ConvertTo7SegmentDisplay(time));
    }

    static string ConvertTo7SegmentDisplay(string time)
    {
        Dictionary<char, string[]> numRelogio = new Dictionary<char, string[]>();
        numRelogio.Add('0', new[] { " _ ", "| |", "|_|" });
        numRelogio.Add('1', new[] { "   ", "  |", "  |" });
        numRelogio.Add('2', new[] { " _ ", " _|", "|_ " });
        numRelogio.Add('3', new[] { " _ ", " _|", " _|" });
        numRelogio.Add('4', new[] { "   ", "|_|", "  |" });
        numRelogio.Add('5', new[] { " _ ", "|_ ", " _|" });
        numRelogio.Add('6', new[] { " _ ", "|_ ", "|_|" });
        numRelogio.Add('7', new[] { " _ ", "  |", "  |" });
        numRelogio.Add('8', new[] { " _ ", "|_|", "|_|" });
        numRelogio.Add('9', new[] { " _ ", "|_|", " _|" });
        numRelogio.Add(':', new[] { "   ", " . ", " . " });

        char[] caracteres = new char[5];
        for (int i = 0; i < time.Length; i++) //separa os caracteres de time nas posições do vetor
        {
            caracteres[i] = time[i];
        }

        string[,] matrizHora = new string[time.Length, 3];
        //atribui o relógio a uma matriz
        for (int i = 0; i<time.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizHora[i,j] = numRelogio[caracteres[i]][j]; 
            }
        }
        /*
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < time.Length; j++)
            {
                Console.Write(matrizHora[j, i]); // Exibe cada linha
            }
            Console.WriteLine();
        }*/

        string fusao = "";
        //funde os elementos da matriz
        for(int i = 0; i<3; i++)
        {
            for (int j = 0; j < time.Length; j++)
            {
                fusao = fusao + matrizHora[j, i];
            }
            fusao = fusao + "\n";
        }
        Console.WriteLine(fusao);

        return fusao;
    }
}

