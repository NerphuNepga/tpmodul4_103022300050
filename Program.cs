// See https://aka.ms/new-console-template for more information
using System;
using tpmodul4_103022300050;

public class Program
{
    public static void Main()
    {
        /*KodePos kodePos = new KodePos();
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
        }*/

        DoorMachine door = new DoorMachine();
        string[] status = { "Terkunci", "Terbuka", "Masuk" };

        while (door.GetState() != State.Masuk)
        {
            Console.Write("Masukkan Command: ");
            string command = Console.ReadLine();

            switch (door.GetState())
            {
                case State.Terkunci:
                    if (command == "Terbuka")
                    {
                        door.Terbuka();
                    }
                    else
                    {
                        Console.WriteLine("Pintu tetap terkunci.");
                    }
                    break;

                case State.Terbuka:
                    if (command == "Terkunci")
                    {
                        door.Terkunci();
                    }
                    else if (command == "Masuk")
                    {
                        door.Masuk();
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terbuka.");
                    }
                    break;
            }
        }
    }
}