// See https://aka.ms/new-console-template for more information
using System;
using tpmodul4_103022300050;

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