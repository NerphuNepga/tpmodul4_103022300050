// See https://aka.ms/new-console-template for more information
using System;

public class KodePos
{
    public int GetKodePos(string input)
    {
        string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        for (int i = 0; i < kelurahan.Length; i++)
        {
            if (kelurahan[i] == input)
            {
                return kodePos[i];
            }
        }
        return -1;
    }
}

public class Program
{
    public static void Main()
    {
        KodePos kodePos = new KodePos();
        Console.Write("Masukkan nama kelurahan: ");
        string input = Console.ReadLine();
        int kode = kodePos.GetKodePos(input);

        if (kode != -1)
        {
            Console.WriteLine("Kode pos dari kelurahan " + input + " adalah : " + kode);
        }
        else
        {
            Console.WriteLine("Kode Pos tidak ditemukan!");
        }
    }
}