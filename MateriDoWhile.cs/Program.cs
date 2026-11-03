using System;

namespace TugasRPL
{
    class MateriDoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU MATERI DO-WHILE LOOP ===");
            Console.WriteLine("1. Program 11: Do-While Minimal 1 Kali");
            Console.WriteLine("2. Program 12: Hitung 1 Sampai 4");
            Console.WriteLine("3. Program 13: Validasi Password");
            Console.WriteLine("4. Program 14: Mundur Kelipatan 10");
            Console.WriteLine("5. Program 15: Konfirmasi Ulang (y/n)");
            Console.Write("Pilih nomor program (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n[HASIL PROGRAM]:");

            if (pilihan == 1)
            {
                int i = 10;
                do
                {
                    Console.WriteLine("Ini tetap jalan sekali meskipun i = " + i);
                } while (i < 5);
            }
            else if (pilihan == 2)
            {
                int i = 1;
                do
                {
                    Console.WriteLine("Angka: " + i);
                    i++;
                } while (i <= 4);
            }
            else if (pilihan == 3)
            {
                string password;
                do
                {
                    Console.Write("Masukkan password (petunjuk: rpl): ");
                    password = Console.ReadLine();
                } while (password != "rpl");
                Console.WriteLine("Password Benar!");
            }
            else if (pilihan == 4)
            {
                int i = 50;
                do
                {
                    Console.WriteLine("Mundur: " + i);
                    i -= 10;
                } while (i >= 10);
            }
            else if (pilihan == 5)
            {
                string ulang;
                do
                {
                    Console.Write("Apakah ingin mengulang tes ini? (y/n): ");
                    ulang = Console.ReadLine();
                } while (ulang == "y" || ulang == "Y");
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }

            Console.ReadLine();
        }
    }
}