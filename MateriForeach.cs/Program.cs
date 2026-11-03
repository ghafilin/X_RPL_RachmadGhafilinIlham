using System;
using System.Collections.Generic;

namespace TugasRPL
{
    class MateriForeach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU MATERI FOREACH LOOP ===");
            Console.WriteLine("1. Program 16: Membaca Nama Buah");
            Console.WriteLine("2. Program 17: Menjumlahkan Isi Array");
            Console.WriteLine("3. Program 18: Membaca Karakter Kata");
            Console.WriteLine("4. Program 19: Filter Angka > 50");
            Console.WriteLine("5. Program 20: Membaca List Boolean");
            Console.Write("Pilih nomor program (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n[HASIL PROGRAM]:");

            if (pilihan == 1)
            {
                string[] buah = { "Apel", "Jeruk", "Mangga" };
                foreach (string b in buah)
                {
                    Console.WriteLine("Buah: " + b);
                }
            }
            else if (pilihan == 2)
            {
                int[] deret = { 10, 20, 30 };
                int total = 0;
                foreach (int angka in deret)
                {
                    total = total + angka;
                }
                Console.WriteLine("Total penjumlahan isi array = " + total);
            }
            else if (pilihan == 3)
            {
                string kata = "RPL";
                foreach (char huruf in kata)
                {
                    Console.WriteLine("Huruf: " + huruf);
                }
            }
            else if (pilihan == 4)
            {
                int[] data = { 25, 60, 45, 80 };
                foreach (int nilai in data)
                {
                    if (nilai > 50)
                    {
                        Console.WriteLine("Lolos (>50): " + nilai);
                    }
                }
            }
            else if (pilihan == 5)
            {
                List<bool> status = new List<bool> { true, false, true };
                foreach (bool s in status)
                {
                    Console.WriteLine("Status: " + s);
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }

            Console.ReadLine();
        }
    }
}
